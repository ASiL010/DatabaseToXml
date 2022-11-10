using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DatabaseToXml
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
      public static string savingPath = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SatışSipariş = new Thread(SatıŞSiparisiKaydetBaslaTread);
           
        }
        private void KaydetBasla_Clk(object sender, EventArgs e)
        {

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
            }
            KaydetBasla.Enabled = true;
            XmlMergeButton.Enabled = true;
        }
        public string[] stringArrayDoldur(string Sorgunuz)
        {
            baglanti = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(Sorgunuz, baglanti);
            ds = new DataSet();
            baglanti.Open();
            adapter.Fill(ds, Sorgunuz);
            string[] ReturnValue = new string[ds.Tables[0].Rows.Count];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ReturnValue[i] = ds.Tables[0].Rows[i][0].ToString();
            }
            baglanti.Close();
            return ReturnValue;
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
            a.MergeMyXmls();
        }

        private void author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ASiL010");
            author.LinkVisited = true;
        }

        private void SatıŞSiparisiKaydetBaslaTread()
        {
            while (true)
            {
                sem.Wait();
                try
                {
                   
                        string[] orderNumbers = stringArrayDoldur("SELECT Distinct items_orderNumber  FROM [db_gulSistem].[dbo].[tbl_siparis]");
                        for (int k = 0; k < orderNumbers.Length; k++)
                        {//eşi olmayan veri sayısı 56
                            string sorgu = "SELECT  Distinct items_orderNumber  FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k];
                            //her orderın içindeki veriler
                            string[] NUMBER = stringArrayDoldur(sorgu);
                            for (int i = 0; i < NUMBER.Length; i++)//numberLength genelde 1 olur
                            {
                                #region AllNeededVaribles
                                string[] DOC_TRACK_NR = stringArrayDoldur(sorgu);
                                string[] DATE = stringArrayDoldur("SELECT  items_orderDate FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] DOC_NUMBER = stringArrayDoldur(sorgu);
                                string[] NOTES1 = stringArrayDoldur("SELECT items_invoice_address_name FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] NOTES2 = stringArrayDoldur("SELECT items_invoice_address_district FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] NOTES3 = stringArrayDoldur("SELECT items_invoice_address_town FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] NOTES5 = stringArrayDoldur("SELECT items_invoice_address_city FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] CUST_ORD_NO = stringArrayDoldur(sorgu);
                                string[] DOC_TRACKING_NR = stringArrayDoldur(sorgu);


                                string[] Totalamount = stringArrayDoldur("SELECT  items_totalPrice_amount FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] unitPrice = stringArrayDoldur("SELECT  items_unitPrice_amount FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] vatRate = stringArrayDoldur("SELECT  items_vatRate FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] quantity = stringArrayDoldur("SELECT  items_quantity FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] dueDate = stringArrayDoldur("SELECT  items_dueDate FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] RESERVE_DATE = stringArrayDoldur("SELECT  items_lastStatusUpdateDate FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] SKUasMasterCode = stringArrayDoldur("SELECT  items_sku FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] MASTER_DEF = stringArrayDoldur("SELECT  UrunAd FROM [db_gulSistem].[dbo].[tbl_paketTemp] where siparisNo=" + orderNumbers[k] + "order by siparisNo asc");

                                #region dateFixes
                                string duedateFİX = "";
                                if (dueDate[i].Split(' ')[0].Length == 9)
                                {
                                    duedateFİX = "0" + dueDate[i].Split(' ')[0];
                                }
                                string DATEFİX = "";
                                if (DATE[i].Split(' ')[0].Length == 9)
                                {
                                    DATEFİX = "0" + DATE[i].Split(' ')[0];
                                }
                                string reservedateFix = "";
                                if (RESERVE_DATE[i].Split(' ')[0].Length == 9)
                                {
                                    reservedateFix = "0" + RESERVE_DATE[i].Split(' ')[0];
                                }
                                #endregion


                                #endregion
                                #region Cari Hesaplar

                                #region AllNeededVaribles
                                string[] TAX_ID = stringArrayDoldur("SELECT [items_invoice_taxNumber] FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                                string[] E_MAILID = stringArrayDoldur("SELECT distinct [items_invoice_address_addressId] FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k]);
                                string[] E_MAILFatura = stringArrayDoldur("SELECT distinct items_invoice_address_email FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k]);
                                string[] CODE = stringArrayDoldur("Select [logoid] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]='" + E_MAILID[i] + "'");
                                string[] TITLE = stringArrayDoldur("Select [Mad] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]='" + E_MAILID[i] + "'");
                                string[] ADDRESS1 = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAILID[i] + "'");
                                string[] DISTRICT = stringArrayDoldur("Select [items_invoice_address_district] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAILID[i] + "'");
                                string[] TOWN = stringArrayDoldur("Select [items_invoice_address_town] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAILID[i] + "'");
                                string[] CITY = stringArrayDoldur("Select [items_invoice_address_city] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAILID[i] + "'");
                                // string[] TAX_ID = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]=" + E_MAIL[i]);
                                string[] TAX_OFFICE = stringArrayDoldur("Select items_invoice_taxOffice FROM tbl_siparis where [items_invoice_address_addressId] ='" + E_MAILID[i] + "'");

                                //  string[] CONTACT = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                                //string[] CONTACT2 = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                                string[] NAME = stringArrayDoldur("Select [items_customerName] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAILID[i] + "'");
                                // string[] SURNAME = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]=" + E_MAIL[i]);
                                //string[] POST_LABEL = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                                //string[] SENDER_LABEL = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                                //string[] EARC_EMAIL_ADDRESS1 = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                                //string[] KVKK_BEGIN_DATE = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                                #endregion


                                if (TAX_ID[i] == "")
                                {



                                    for (int z = 0; z < CODE.Length; z++)
                                    {



                                        XDocument CarilerDocument = new XDocument(
                                            new XElement("AR_APS",
                                            new XElement("AR_AP",
                                                 new XElement("ACCOUNT_TYPE", 3),
                                              new XElement("CODE", CODE[z]),
                                              new XElement("TITLE", TITLE[z]),
                                              new XElement("ADDRESS1", ADDRESS1[z]),
                                              new XElement("DISTRICT", DISTRICT[z]),
                                              new XElement("TOWN_CODE", "TR"),
                                              new XElement("TOWN", TOWN[z]),
                                              new XElement("CITY_CODE", "TR"),
                                              new XElement("CITY", CITY[z]),
                                              new XElement("COUNTRY_CODE", "TR"),
                                              new XElement("COUNTRY", "TÜRKİYE"),
                                               //postaKodu
                                               new XElement("E_MAIL", E_MAILFatura[i]),
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
new XElement("PERSCOMPANY","1"),
new XElement("EARCHIVE_SEND_MODE", 1),
new XElement("INSTEAD_OF_DISPATCH",1),
new XElement("INVOICE_PRNT_CNT", 1),
                                              new XElement("TCKNO", 11111111111),
                                              new XElement("EARCHIVE_SEND_MODE", 1),
                                              new XElement("PROFILE_ID", 2),
                                               new XElement("ACCEPT_EINV", 1),
                                              new XElement("NAME", NAME[z].Split(' ').Take(NAME[z].Split(' ').Length - 1)),
                                              new XElement("SURNAME", NAME[z].Split(' ').Last())
                                        //,
                                        //   new XElement("SURNAME", SURNAME[z])

                                        )//AR_AP end 
                                         //AR_APSSSS end
                                        ));//documant end

                                        CarilerDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                        System.IO.Directory.CreateDirectory(savingPath + "\\Cariler");
                                        CarilerDocument.Save(savingPath + "\\Cariler\\" + CODE[z] + ".xml");
                                    }
                                }
                                else
                                {
                                    //ŞİRKET Firma HESAPLARI BURAYA 



                                    for (int z = 0; z < CODE.Length; z++)
                                    {
                                        XDocument CarilerDocument = new XDocument(
                                           new XElement("AR_APS",
                                             new XElement("AR_AP",
                                                 new XElement("ACCOUNT_TYPE","3"),
                                                 new XElement("CODE", CODE[z]),
                                                 new XElement("TITLE", TITLE[z]),
                                                 new XElement("ADDRESS1", ADDRESS1[z]),
                                                 new XElement("TOWN_CODE", "TR"),
                                                 new XElement("DISTRICT", DISTRICT[z]),
                                                 new XElement("TOWN", TOWN[z]),
                                                 new XElement("CITY_CODE", "TR"),
                                                 new XElement("CITY", CITY[z]),
                                                 new XElement("COUNTRY_CODE", "TR"),
                                                 new XElement("COUNTRY", "TÜRKİYE"),
                                                 //postakodu
                                                 new XElement("TAX_ID", TAX_ID[z]),
                                                 new XElement("TAX_OFFICE", TAX_OFFICE[z]),
                                                 new XElement("CORRESP_LANG", 1),
                                                 new XElement("AUTO_PAID_BANK", 0),
                                                 new XElement("CL_ORD_FREQ", 1),
                                                 new XElement("LOGOID","0"),
                                                 new XElement("E_MAIL", E_MAILFatura[z]),
                                                 new XElement("EARCHIVE_SEND_MODE", 1),
                                                 new XElement("PROFILE_ID", 2),
                                                 new XElement("EARCHIVE_SEND_MODE","1"),
                                                 new XElement("INSTEAD_OF_DISPATCH","1"),
                                                 new XElement("INVOICE_PRNT_CNT", 1),
                                                 new XElement("CONTACT", NAME[z].Split(' ').Take(NAME[z].Split(' ').Length - 1)),
                                                 new XElement("CONTACT2", NAME[z].Split(' ').Last())
                                           //[NAME[z].Split(' ').Length - 1]
                                           //,
                                           //     new XElement("POST_LABEL", POST_LABEL[z]),
                                           //    new XElement("SENDER_LABEL", SENDER_LABEL[z])
                                           //new XElement("EARC_EMAIL_ADDRESS1", EARC_EMAIL_ADDRESS1[i])
                                           )//AR_AP end 
                                           )  //AR_APSSSS end
                                           );//documant end


                                        CarilerDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                        System.IO.Directory.CreateDirectory(savingPath + "\\Cariler");
                                        CarilerDocument.Save(savingPath + "\\Cariler\\" + CODE[z] + ".xml");
                                    }
                                    #endregion
                                }
                                //her orderın içindeki çoklu olabilen değer                                
                                XElement[] a = new XElement[Totalamount.Length];
                                for (int j = 0; j < a.Length; j++)
                                {
                                    #region MaterialKaydet_DOC
                                    string ürünadı = "Tanımsız";
                                    try
                                    {
                                        ürünadı = MASTER_DEF[0].Split('|')[j];

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
                                    }
                                    catch (Exception EX)
                                    {
                                        if (MASTER_DEF.Length > 0)
                                        {
                                            ürünadı = MASTER_DEF[0];
                                            MessageBox.Show(EX.Message);
                                        }
                                    }


                                    //-----------------------------

                                    #endregion
                                    #region ÇokluTransactionKısmı
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
                                         new XElement("RESERVE_AMOUNT", 1)
                                         );
                                    #endregion
                                }
                                #region SatişSiparişi_DOC


                                string[] saatDizisi = DATE[i].Split(' ')[1].Split(':');
                                XElement transactions = new XElement("TRANSACTIONS");
                                transactions.Add(a);

                                XDocument SatışlarDocument = new XDocument(
                                    new XElement("SALES_ORDERS",
                                      new XElement("ORDER_SLIP",
                                     // new XElement("NUMBER", NUMBER[i]),
                                     new XElement("DOC_TRACK_NR", DOC_TRACK_NR[i]),//@AYNI1
                                     new XElement("DATE", DATEFİX),
                                     new XElement("TIME", SaatFonksiyonu(saatDizisi[0], saatDizisi[1], saatDizisi[2])),
                                     new XElement("DOC_NUMBER", DOC_NUMBER[i]),
                                     new XElement("AUXIL_CODE", "HB Öder"),
                                     new XElement("ARP_CODE", CODE),
                                     new XElement("RC_RATE", "1"),
                                     new XElement("NOTES1", NOTES1[i]),
                                     new XElement("NOTES2", NOTES2[i]),
                                     new XElement("NOTES3", NOTES3[i]),
                                     new XElement("NOTES5", NOTES5[i]),
                                     new XElement("ORDER_STATUS", "4"),
                                     new XElement("CURRSEL_TOTAL", "2"),
                                    transactions
                                    ,//Transactions Altı
                                   new XElement("CUST_ORD_NO", CUST_ORD_NO[i]),//@AYNI1
                                   new XElement("DOC_TRACKING_NR", DOC_TRACKING_NR[i])//@AYNI1
                                )
                       //orderslipin altı
                       )

                       //salesorderın altı
                       );
                                SatışlarDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                System.IO.Directory.CreateDirectory(savingPath + "\\SatışSipariş");
                                SatışlarDocument.Save(savingPath + "\\SatışSipariş\\" + DOC_TRACK_NR[i] + ".xml");


                                #endregion
                            }
                        }



                    
                }
                finally
                {

                    MessageBox.Show("işlemler tamamlandı");
                }
            }
        }


    }


}

