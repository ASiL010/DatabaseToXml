using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Gülsistem_V8;
using Microsoft.EntityFrameworkCore;
using Gülsistem_V8.xml;
using DatabaseToXml.Models;

namespace Gülsistem_V8.xml
{
    public partial class Form1 : Form
    {

        #region SQLvaribles
        private readonly string connectionString = "Data Source=DESKTOP-69S6Q42\\SQLEXPRESS;Initial Catalog=db_gulSistem;Integrated Security=True";
        private SqlConnection baglanti = new SqlConnection();
        private SqlCommand komut = new SqlCommand();
        SqlDataReader rdr;
        SqlDataAdapter adapter;
        private DataSet ds;
        #endregion
        static SemaphoreSlim sem = new SemaphoreSlim(1, 1);
        Thread SatışSipariş;
        public static string savingPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\LOGO_XML_FILES";
        string? SeçilenSiparişNumarası="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SatışSipariş = new Thread(SatıŞSiparisiKaydetBaslaTread);
            
            
            
            Control.CheckForIllegalCrossThreadCalls = false;
            if (!Directory.Exists(savingPath))
            {
                System.IO.Directory.CreateDirectory(savingPath);

            }
        }
        private void KaydetBasla_Clk(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (SatışSipariş.ThreadState == System.Threading.ThreadState.Unstarted)
                SatışSipariş.Start();
            if (sem.CurrentCount == 0) sem.Release();

        }
 
        private void KaydetmeYeri_Clk(object sender, EventArgs e)
        {

            FolderBrowserDialog Folder = new FolderBrowserDialog();
            DialogResult result = Folder.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(Folder.SelectedPath))
            {
                savingPath = Folder.SelectedPath;
                KaydetBasla.Enabled = true;
                XmlMergeButton.Enabled = true;
            }
          
        }
       

        public long SaatFonksiyonu(string HH,string MM,string SS)
        {
            int a = Convert.ToInt32(HH) * 65536 * 256;
            int b = Convert.ToInt32(MM) * 65536;
            int c = Convert.ToInt32(SS) * 256;
            string rtrn = (a + b + c).ToString();
            return long.Parse(rtrn);
        }

        private void XmlMerger_Clk(object sender, EventArgs e)
        {
            XmlMerger a=new XmlMerger();
            string birleştirmeİsmi = null;
            a.MergeMyXmls(birleştirmeİsmi);
        }

        private void SelectedOrderNumber_TextChanged(object sender, EventArgs e)
        {
            
                if (System.Text.RegularExpressions.Regex.IsMatch(SelectedOrderNumber.Text, "[^0-9]"))
                {
                    MessageBox.Show("Lütfen Sadece Sayı Girişi Yapınız.");
                SelectedOrderNumber.Text = Regex.Replace(SelectedOrderNumber.Text, "[^0-9]", "");
                //SelectedOrderNumber.Text=SelectedOrderNumber.Text.Remove(SelectedOrderNumber.Text.Length-1);
                }
                else
                {
                    SeçilenSiparişNumarası = SelectedOrderNumber.Text;

                }
        }
  
        public string ReverseDate(string text)
        {
            char[] newText=new char[8];
            newText[0] = text[7];
            newText[1] = text[6];
            newText[2] = text[5];
            newText[3] = text[4];
            newText[4] = text[2];
            newText[5] = text[3];
            newText[6] = text[0];
            newText[7] = text[1];

            return new string(newText);
        }
        public bool DateBetweenPickers(string kontroledilecek)
        {
            string newDate=DateFixes(kontroledilecek.Split(' ')[0]);
            string datepicker = DateFixes(BüyükDate.Value.ToString().Split(' ')[0]);
            string littedatePicker= DateFixes(KüçükDate.Value.ToString().Split(' ')[0]);
        //    MessageBox.Show(newDate.Replace(".", "") + "\n"+datepicker);
            int MiddleDate = Convert.ToInt32(ReverseDate(newDate.Replace(".", "")));
            int RightDate = Convert.ToInt32(ReverseDate(datepicker.Replace(".", "")));
            int Left = Convert.ToInt32(ReverseDate(littedatePicker.Replace(".", "")));
            if (MiddleDate <= RightDate && MiddleDate >= Left)
            {
                //MessageBox.Show(Left+ "\n" + MiddleDate+ "\n" + RightDate+"\n");
                return true;
            }
            else
            {
                //MessageBox.Show(Left + "\n" + MiddleDate + "\n" + RightDate + "\n");

                return false;
            }
         
        }
        public string DateFixes(string toBeFİX)
        {
            string ForFix="";
            if (toBeFİX.Length == 9)
            {
                ForFix = "0" + toBeFİX;
            }
            else 
            ForFix = toBeFİX;
            
            return ForFix;
        }
        public XDocument CombineDocuments(XDocument combine, XDocument AddToDocument)
        {
            XElement element, element2;

            element = combine.Elements().FirstOrDefault();
            element2 = AddToDocument.Elements().FirstOrDefault();

            element.Add(element2.Nodes());
            return combine;
        }
            private void SatıŞSiparisiKaydetBaslaTread()
            {
            
            while (true)
            {
                sem.Wait();
                try
                {
                    KaydetBasla.Enabled = false;
                    SecilenIleKaydet_btn.Enabled = false;
                    db_gulSistemContext db = new db_gulSistemContext();
                    var siparis = db.TblSiparis;
                    
                    var query = (new string[] { "a"}).ToList();
                    XDocument CariCombined = new XDocument(new XElement("AR_APS"));
                    XDocument SatısCombined = new XDocument(new XElement("SALES_ORDERS"));
                    XDocument MaterialCombined = new XDocument(new XElement("ITEMS"));
                    CariCombined.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                    SatısCombined.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                    MaterialCombined.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");


                    string[] orderNumbers = new string[0];
                    if (Pnl_secilenSiparis.Visible)
                    {
                        // query = db.Database.SqlQuery<string>("Select Distinct (items_orderNumber) from [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber = @c", new SqlParameter("@c",SeçilenSiparişNumarası)).ToList();
                         query = db.TblSiparis.Where(c => c.ItemsOrderNumber == SeçilenSiparişNumarası).Select(a=>a.ItemsOrderNumber).Distinct().ToList();
                    }
                    else
                    {
                        // query = db.Database.SqlQuery<string>("Select Distinct (items_orderNumber) from [db_gulSistem].[dbo].[tbl_siparis] where  xmlYapildi = 0 and items_orderDate >= @a and items_orderDate < @b ", new SqlParameter("@a", KüçükDate.Value.Date), new SqlParameter("@b", BüyükDate.Value.AddDays(1).Date)).ToList();
                        query=  db.TblSiparis.Where(c => c.Xml == false &&db.TblPaketTemps.Any(sp=>sp.SiparisNo==c.ItemsOrderNumber) && c.ItemsOrderDate >= KüçükDate.Value.Date && c.ItemsOrderDate < BüyükDate.Value.AddDays(1).Date).Select(a=>a.ItemsOrderNumber).Distinct().ToList();
                    }


                    //    MessageBox.Show(KüçükDate.Value.Date.ToString());
                    foreach (var item in query)
                    {
                       
                        var need = siparis.Select(c => c).Where(k => k.ItemsOrderNumber == item).ToList();
                        var V = need[0];
                        //  MessageBox.Show(V.items_orderDate.ToString());

                        #region Cari Hesaplar

                        #region AllNeededVaribles

                        string[] CODE = db.TblMusterilers.Where(c => c.Uniqid == V.ItemsInvoiceAddressAddressId).Select(a => a.Logoid).ToArray();
                        string[] TITLE = db.TblMusterilers.Where(c => c.Uniqid == V.ItemsInvoiceAddressAddressId).Select(a => a.Mad).ToArray();


                        string ADDRESS1 = V.ItemsInvoiceAddressAddress;
                            string DISTRICT = V.ItemsInvoiceAddressDistrict;
                            string TOWN = V.ItemsInvoiceAddressTown;
                            string CITY = V.ItemsInvoiceAddressCity;
                            string TAX_OFFICE = V.ItemsInvoiceTaxOffice;
                            string NAME = V.ItemsCustomerName;
                            #endregion


                            if (V.ItemsInvoiceTaxNumber == "")
                            {

                            for (int z = 0; z < CODE.Length; z++)//verinin olup olmadığını da kontrol ediyor
                                {


                                    XDocument CarilerDocument = new XDocument(
                                        new XElement("AR_APS",
                                        new XElement("AR_AP",
                                             new XElement("ACCOUNT_TYPE", 3),
                                          new XElement("CODE", CODE[0]),
                                          new XElement("TITLE", TITLE[0]),
                                          new XElement("ADDRESS1", ADDRESS1),
                                          new XElement("DISTRICT", DISTRICT),
                                          new XElement("TOWN_CODE", "TR"),
                                          new XElement("TOWN", TOWN),
                                          new XElement("CITY_CODE", "TR"),
                                          new XElement("CITY", CITY),
                                          new XElement("COUNTRY_CODE", "TR"),
                                          new XElement("COUNTRY", "TÜRKİYE"),
                                           //postaKodu
                                           new XElement("E_MAIL", V.ItemsInvoiceAddressEmail),
                                            new XElement("CORRESP_LANG", "1"),
                                            new XElement("CREDIT_TYPE", "1"),
                                            new XElement("RISKFACT_CHQ", "1"),
                                            new XElement("RISKFACT_PROMNT", "1"),
                                            new XElement("AUTO_PAID_BANK", "0"),
                                            new XElement("CL_ORD_FREQ", "1"),
                                            new XElement("LOGOID", "0"),
                                            new XElement("CELL_PHONE", "0"),
                                            new XElement("INVOICE_PRNT_CNT", "1"),
                                            new XElement("PURCHBRWS", "1"),
                                            new XElement("SALESBRWS", "1"),
                                            new XElement("IMPBRWS", "1"),
                                            new XElement("EXPBRWS", "1"),
                                            new XElement("FINBRWS", "1"),
                                            new XElement("COLLATRLRISK_TYPE", "1"),
                                            new XElement("PERSCOMPANY", "1"),
                                            new XElement("EARCHIVE_SEND_MODE", 1),
                                            new XElement("INSTEAD_OF_DISPATCH", 1),
                                            new XElement("INVOICE_PRNT_CNT", 1),
                                          new XElement("TCKNO", V.ItemsInvoiceTurkishIdentityNumber),
                                            new XElement("POST_LABEL", CODE[0]),
                                             new XElement("SENDER_LABEL", CODE[0]),
                                          new XElement("EARCHIVE_SEND_MODE", 1),
                                          new XElement("PROFILE_ID", 2),
                                           new XElement("ACCEPT_EINV", 1),
                                          new XElement("NAME", NAME.Split(' ').Take(NAME.Split(' ').Length - 1)),
                                          new XElement("SURNAME", NAME.Split(' ').Last())
                                    //,
                                    //   new XElement("SURNAME", SURNAME[z])

                                    )//AR_AP end 
                                     //AR_APSSSS end
                                    ));//documant end

                                    CarilerDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                    System.IO.Directory.CreateDirectory(savingPath + "\\Cariler");
                                    CarilerDocument.Save(savingPath + "\\Cariler\\" + CODE[0] + ".xml");

                                    CombineDocuments(CariCombined, CarilerDocument);
                                }
                            }
                            else
                            {
                                //ŞİRKET Firma HESAPLARI BURAYA 

                                for (int z = 0; z < CODE.Length; z++)//verinin olup olmadığını da kontrol ediyor
                                {
                                    XDocument CarilerDocument = new XDocument(
                                       new XElement("AR_APS",
                                         new XElement("AR_AP",
                                             new XElement("ACCOUNT_TYPE", "3"),
                                             new XElement("CODE", CODE[0]),
                                             new XElement("TITLE", TITLE[0]),
                                             new XElement("ADDRESS1", ADDRESS1),
                                             //new XElement("TOWN_CODE", "TR"),
                                             
                                             new XElement("TOWN", TOWN),
                                             //new XElement("CITY_CODE", "TR"),
                                             new XElement("CITY", CITY),
                                             new XElement("COUNTRY_CODE", "TR"),
                                             new XElement("COUNTRY", "Türkiye"),
                                             //postakodu
                                             new XElement("TAX_ID", V.ItemsInvoiceTaxNumber),
                                             new XElement("TAX_OFFICE", TAX_OFFICE),
                                             //new XElement("CORRESP_LANG", 1),
                                             new XElement("AUTO_PAID_BANK", 0),
                                             new XElement("CL_ORD_FREQ", 1),
                                             new XElement("CELL_PHONE", 0),
                                             new XElement("INVOICE_PRNT_CNT", 1),
                                              //< ORGLOGOID ></ ORGLOGOID >
                                             new XElement("PURCHBRWS", 1),
                                             new XElement("SALESBRWS", 1),
                                             new XElement("IMPBRWS", 1),
                                             new XElement("EXPBRWS", 1),
                                             new XElement("FINBRWS", 1),
                                             new XElement("COLLATRLRISK_TYPE", 1),
                                             new XElement("RISK_TYPE1", 1),
                                             new XElement("RISK_TYPE2", 1),
                                             new XElement("RISK_TYPE3", 1),
                                             new XElement("ACCEPT_EINV", 1),
                                             new XElement("PROFILE_ID", 2),
                                             new XElement("EARCHIVE_SEND_MODE", 1),
                                             new XElement("POST_LABEL", CODE[0]),
                                             new XElement("SENDER_LABEL", CODE[0]),
                                             new XElement("INSTEAD_OF_DISPATCH", "1"),
                                             //?? CLNTC_2022.12.08_20.05.16 ya göre ekstra eklenenler
											 //bazı carilerde var bunda yoktu
                                             new XElement("DISTRICT", DISTRICT),
                                             new XElement("E_MAIL", V.ItemsInvoiceAddressEmail),
                                             new XElement("LOGOID", "0"),
                                             new XElement("EARCHIVE_SEND_MODE", "1"),
                                             new XElement("CONTACT", NAME.Split(' ').Take(NAME.Split(' ').Length - 1)),
                                             new XElement("CONTACT2", NAME.Split(' ').Last())
                                             //??   
                                                
                                             )//AR_AP end 
                                         )  //AR_APSSSS end
                                       );//documant end


                                    CarilerDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                    System.IO.Directory.CreateDirectory(savingPath + "\\Cariler");
                                    CarilerDocument.Save(savingPath + "\\Cariler\\" + CODE[z] + ".xml");

                                    CombineDocuments(CariCombined, CarilerDocument);
                                }
                                #endregion
                            }
                        db_gulSistemContext db1 = new db_gulSistemContext();
                        //her orderın içindeki çoklu olabilen değer VE DEĞERLER
                        string[] Totalamount = db1.TblSiparis.Where(c => c.ItemsOrderNumber == item).Select(a => a.ItemsTotalPriceAmount).ToArray();
                        string[] unitPrice = db1.TblSiparis.Where(c => c.ItemsOrderNumber == item).Select(a => a.ItemsUnitPriceAmount).ToArray();
                        string[] vatRate = db1.TblSiparis.Where(c => c.ItemsOrderNumber == item).Select(a => a.ItemsVatRate).ToArray();
                        string[] quantity = db1.TblSiparis.Where(c => c.ItemsOrderNumber == item).Select(a => a.ItemsQuantity).ToArray();
                        string[] dueDate = db1.TblSiparis.Where(c => c.ItemsOrderNumber == item).Select(a => a.ItemsDueDate).ToArray();
                        string[] RESERVE_DATE = db1.TblSiparis.Where(c => c.ItemsOrderNumber == item).Select(a => a.ItemsLastStatusUpdateDate).ToArray();
                        string[] SKUasMasterCode = db1.TblSiparis.Where(c => c.ItemsOrderNumber == item).Select(a => a.ItemsSku).ToArray();
                        string[] MASTER_DEF = db1.TblPaketTemps.Where(c => c.SiparisNo == item).Select(a => a.UrunAd).ToArray();
                            
                        
                        
                        
                         
                            XElement[] a = new XElement[Totalamount.Length];

                            var pakettemp = db.TblPaketTemps;
                            var packet = pakettemp.Select(b => b).Where(c => c.SiparisNo == V.ItemsOrderNumber).ToList();


                           
                                for (int j = 0; j < a.Length; j++)
                                {

                                    #region MaterialKaydet_DOC
                                    string ürünadı = "Tanımsız";
                                    try
                                    {
                                        ürünadı = MASTER_DEF[0].Split('|')[j];//her ürün ismi yazılmamış buradaki j sıkıntı çıkartıyor 

                                        //-----------------------------
                                        XElement ünitler = new XElement("UNITS");


                                        ünitler.Add(new XElement(new XElement("UNIT",
                                                 new XElement("UNIT_CODE", "ADET"),
                                                 new XElement("USEF_MTRLCLASS", 1),//kırtasiyedeki logodaki ürün kodu
                                                 new XElement("USEF_PURCHCLAS", 1),//ürün adı
                                                 new XElement("USEF_SALESCLAS", 1),
                                                 new XElement("CONV_FACT1", 1),
                                                 new XElement("CONV_FACT2", 1)))
                                                 );
                                        XDocument MaterialDocument = new XDocument(new XElement("ITEMS",
                                                  new XElement("ITEM",
                                               new XElement("CARD_TYPE", 1),
                                               new XElement("CODE", SKUasMasterCode[j]),
                                               new XElement("NAME", ürünadı),
                                               new XElement("USEF_PURCHASING", 1),
                                               new XElement("USEF_SALES", 1),
                                               new XElement("USEF_MM", 1),
                                               new XElement("VAT", vatRate[j]),
                                               new XElement("AUTOINCSL", 1),
                                               new XElement("LOTS_DIVISIBLE", 1),
                                               new XElement("UNITSET_CODE", "ADET"),
                                              ünitler,
                                             new XElement("MULTI_ADD_TAX", 0),
                                             new XElement("PACKET", 11),
                                             new XElement("SELVAT", vatRate[j]),
                                             new XElement("RETURNVAT", vatRate[j]),
                                             new XElement("SELPRVAT", vatRate[j]),
                                              new XElement("RETURNPRVAT", vatRate[j])
                                          )
                                                  )
                                         );
                                        MaterialDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                              
                                System.IO.Directory.CreateDirectory(savingPath + "\\Materials");
                                        MaterialDocument.Save(savingPath + "\\Materials\\" + SKUasMasterCode[j] + ".xml");

                                        CombineDocuments(MaterialCombined, MaterialDocument);
                                    }

                                    catch (Exception EX)
                                    {
                                    }
                                    

                                    //-----------------------------

                                    #endregion
                                    #region ÇokluTransactionKısmı
                                    string duedateFİX = DateFixes(dueDate[j].Split(' ')[0]);
                                    string reservedateFix = DateFixes(RESERVE_DATE[j].Split(' ')[0]);
                                    a[j] = new XElement("TRANSACTION");

                                    a[j].Add(new XElement("TYPE", "0"),
                                         new XElement("MASTER_CODE", SKUasMasterCode[j]),//kırtasiyedeki logodaki ürün kodu
                                                                                         // new XElement("MASTER_DEF", ürünadı),//ürün adı
                                         new XElement("QUANTITY", quantity[j]),
                                         new XElement("PRICE", unitPrice[j].Replace(',', '.')),
                                         //new XElement("TOTAL", Totalamount[j]),
                                         new XElement("VAT_RATE", vatRate[j]),
                                         new XElement("UNIT_CODE", "ADET"),//adet
                                         new XElement("UNIT_CONV1", 1),//birim kodu tl için 1
                                         new XElement("UNIT_CONV2", 1),//çevrim katsayısı
                                         new XElement("ORDER_RESERVE", 1),
                                         new XElement("DUE_DATE", duedateFİX),
                                         new XElement("CURR_PRICE", 1),//tl için 1
                                                                       // new XElement("PC_PRICE", "A"),
                                                                       //new XElement("RC_XRATE", "A"),
                                                                       //new XElement("TOTAL_NET", "A"),
                                         new XElement("RESERVE_DATE", reservedateFix),
                                         new XElement("RESERVE_AMOUNT", 1),
                                           new XElement("RC_XRATE", 1)
                                         );
                                    #endregion

                                    #region SatişSiparişi_DOC
                                }
                            
                                string orderDATEFİX = DateFixes(V.ItemsOrderDate.ToString().Split(' ')[0]);
                   

                        string[] saatDizisi = V.ItemsOrderDate.ToString().Split(' ')[1].Split(':');
                                XElement transactions = new XElement("TRANSACTIONS");
                                transactions.Add(a);

                                XDocument SatışlarDocument = new XDocument(
                                    new XElement("SALES_ORDERS",
                                      new XElement("ORDER_SLIP",
                                     // new XElement("NUMBER", NUMBER[i]),
                                     new XElement("DOC_TRACK_NR", V.ItemsOrderNumber),//@AYNI1
                                     new XElement("DATE", orderDATEFİX),
                                     new XElement("TIME", SaatFonksiyonu(saatDizisi[0], saatDizisi[1], saatDizisi[2])),
                                     new XElement("DOC_NUMBER", V.ItemsOrderNumber),
                                     new XElement("AUXIL_CODE", "HB Öder"),
                                     new XElement("ARP_CODE", CODE),
                                     new XElement("RC_RATE", "1"),
                                     new XElement("NOTES1", V.ItemsInvoiceAddressName),
                                     new XElement("NOTES2", V.ItemsInvoiceAddressDistrict),
                                     new XElement("NOTES3", V.ItemsInvoiceAddressTown),
                                     new XElement("NOTES5", V.ItemsInvoiceAddressCity),
                                     new XElement("ORDER_STATUS", "4"),
                                     new XElement("CURRSEL_TOTAL", "2"),
                                    transactions
                                    ,//Transactions Altı
                                   new XElement("CUST_ORD_NO", V.ItemsOrderNumber),//@AYNI1
                                   new XElement("DOC_TRACKING_NR", V.ItemsOrderNumber)//@AYNI1
                                )
                       //orderslipin altı
                       )

                       //salesorderın altı
                       );
                                SatışlarDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                System.IO.Directory.CreateDirectory(savingPath + "\\SatışSipariş");
                                SatışlarDocument.Save(savingPath + "\\SatışSipariş\\" + V.ItemsOrderNumber + ".xml");

                                CombineDocuments(SatısCombined, SatışlarDocument);
                        #endregion


                       // db.Database.ExecuteSqlCommand("Update tbl_siparis SET xmlYapildi = 1 where items_orderNumber = '" + V.ItemsOrderNumber + "'");
                        using (var q = new db_gulSistemContext())
                        {
                            q.Database.ExecuteSqlRaw("Update tbl_siparis SET xml = 1 where items_orderNumber = '" + V.ItemsOrderNumber + "'");
                        }


                        progressBar1.Maximum = query.Count();
                            progressBar1.Value++;
                        }
                        if (SatısCombined.Elements().Nodes().Count() > 1)
                        {
                            SatısCombined.Save(savingPath + "\\" + DateTime.Now.ToString().Replace(".", "-").Replace(":", ".") + " Satışlar.xml");

                        }
                        if (CariCombined.Elements().Nodes().Count() > 1)
                        {
                            CariCombined.Save(savingPath + "\\" + DateTime.Now.ToString().Replace(".", "-").Replace(":", ".") + " Cariler.xml");

                        }
                        if (MaterialCombined.Elements().Nodes().Count() > 1)
                        {
                            MaterialCombined.Save(savingPath + "\\" + DateTime.Now.ToString().Replace(".", "-").Replace(":", ".") + " Materyaller.xml");

                        }

                }
                
                finally
                {

                    MessageBox.Show("işlemler tamamlandı");
                    progressBar1.Value = 0;
                    KaydetBasla.Enabled = true;
                    SecilenIleKaydet_btn.Enabled = true;
                }
            }
        }

        private void OncekineDon_Click(object sender, EventArgs e)
        {
            Pnl_secilenSiparis.Visible =false;
        }

        private void SecilenPanelineGit_Click(object sender, EventArgs e)
        {
            Pnl_secilenSiparis.Visible = true;
        }

        private void SecilenIleKaydet_btn_Click(object sender, EventArgs e)
        {
            if (SatışSipariş.ThreadState == System.Threading.ThreadState.Unstarted)
                SatışSipariş.Start();
            if (sem.CurrentCount == 0) sem.Release();

        }
    }
 

}

