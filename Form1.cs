using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
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
        Thread SatışSipariş, CariHesap,ÜRÜNLER;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SatışSipariş = new Thread(SatıŞSiparisiKaydetBaslaTread);
            CariHesap = new Thread(CariHesapKaydetBaslaTread);
            ÜRÜNLER = new Thread(ÜrünKaydetBaslaTread);
        }
        string savingPath = Directory.GetCurrentDirectory();
        private void KaydetBasla_Clk(object sender, EventArgs e)
        {

            if (SatışSipariş.ThreadState == System.Threading.ThreadState.Unstarted)
                SatışSipariş.Start();
            if (sem.CurrentCount == 0) sem.Release();


        }

        private void CariKaydetBTN_Clk(object sender, EventArgs e)
        {
            if (CariHesap.ThreadState == System.Threading.ThreadState.Unstarted)
                CariHesap.Start();
            if (sem.CurrentCount == 0) sem.Release();

        }
        private void UrunKaydet_Clk(object sender, EventArgs e)
        {
            if (ÜRÜNLER.ThreadState == System.Threading.ThreadState.Unstarted)
                ÜRÜNLER.Start();
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

        }
        private void CariHesapKaydetBaslaTread()
        {
            while (true)
            {
                sem.Wait();
                try
                {
                    #region ŞahısŞirket

                   
                    if (SirketSahıs.Checked == true)
                    {


                        string sorgu = "SELECT  Distinct items_orderNumber  FROM [db_gulSistem].[dbo].[tbl_siparis]";
                        #region AllNeededVaribles
                        string[] CODE = stringArrayDoldur(sorgu);
                        string[] TITLE = stringArrayDoldur(sorgu);
                        string[] ADDRESS1 = stringArrayDoldur(sorgu);
                        string[] TOWN = stringArrayDoldur(sorgu);
                        string[] CITY = stringArrayDoldur(sorgu);
                        string[] NAME = stringArrayDoldur(sorgu);
                        string[] SURNAME = stringArrayDoldur(sorgu);
                        string[] KVKK_BEGIN_DATE = stringArrayDoldur(sorgu);
                        #endregion
                        for (int i = 0; i < CODE.Length; i++)
                        {



                            XDocument doc = new XDocument(
                           new XElement("AR_APS",
                           new XElement("AR_AP",
                                 new XElement("ACCOUNT_TYPE", 3),
                                 new XElement("CODE", "AA990" + CODE[i]),
                                 new XElement("TITLE", TITLE[i]),
                                 new XElement("ADDRESS1", ADDRESS1[i]),
                                 new XElement("TOWN_CODE", "TR"),
                                 new XElement("TOWN", TOWN[i]),
                                 new XElement("CITY_CODE", "TR"),
                                 new XElement("CITY", CITY[i]),
                                 new XElement("COUNTRY_CODE", "TR"),
                                 new XElement("COUNTRY", "TÜRKİYE"),
                                 new XElement("PERSCOMPANY", 1),
                                 new XElement("TCKNO", 11111111111),
                                 new XElement("EARCHIVE_SEND_MODE", 1),
                                 new XElement("PROFILE_ID", 2),
                                 new XElement("NAME", NAME[i]),
                                 new XElement("SURNAME", SURNAME[i])

                           )//AR_AP end 
                           )//AR_APSSSS end
                           );//documant end


                            doc.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");

                            doc.Save(savingPath + "\\" + CODE[i] + ".xml");
                        }
                    }
                    #endregion
                    #region FİRMA

                
                    else if (SirketSahıs.Checked == false)
                    {
                        //ŞİRKET HESAPLARI BURAYA GELECEK

                        string sorgu = "SELECT  Distinct items_orderNumber  FROM [db_gulSistem].[dbo].[tbl_siparis]";

                        #region AllNeededVaribles
                        string[] CODE = stringArrayDoldur(sorgu);
                        string[] TITLE = stringArrayDoldur(sorgu);
                        string[] ADDRESS1 = stringArrayDoldur(sorgu);
                        string[] DISTRICT = stringArrayDoldur(sorgu);
                        string[] TOWN = stringArrayDoldur(sorgu);
                        string[] CITY = stringArrayDoldur(sorgu);
                        string[] TAX_ID = stringArrayDoldur(sorgu);
                        string[] TAX_OFFICE = stringArrayDoldur(sorgu);
                        string[] E_MAIL = stringArrayDoldur(sorgu);
                        string[] CONTACT = stringArrayDoldur(sorgu);
                        string[] CONTACT2 = stringArrayDoldur(sorgu);
                        string[] NAME = stringArrayDoldur(sorgu);
                        string[] SURNAME = stringArrayDoldur(sorgu);
                        string[] POST_LABEL = stringArrayDoldur(sorgu);
                        string[] SENDER_LABEL = stringArrayDoldur(sorgu);
                        string[] EARC_EMAIL_ADDRESS1 = stringArrayDoldur(sorgu);
                        #endregion
                        for (int i = 0; i < CODE.Length; i++)
                        {



                            XDocument doc = new XDocument(
                           new XElement("AR_APS",
                           new XElement("AR_AP",
                                 new XElement("ACCOUNT_TYPE", 3),
                                 new XElement("CODE", "AA990" + CODE[i]),
                                 new XElement("TITLE", TITLE[i]),
                                 new XElement("ADDRESS1", ADDRESS1[i]),
                                 new XElement("TOWN_CODE", "TR"),
                                 new XElement("DISTRICT", DISTRICT[i]),
                                 new XElement("TOWN", TOWN[i]),
                                 new XElement("CITY_CODE", "TR"),
                                 new XElement("CITY", CITY[i]),
                                 new XElement("COUNTRY_CODE", "TR"),
                                 new XElement("COUNTRY", "TÜRKİYE"),
                                 new XElement("TAX_ID", TAX_ID[i]),
                                 new XElement("TAX_OFFICE", TAX_OFFICE[i]),
                                 new XElement("E_MAIL", E_MAIL[i]),
                                 new XElement("EARCHIVE_SEND_MODE", 1),
                                 new XElement("PROFILE_ID", 2),
                                 new XElement("CONTACT", CONTACT[i]),
                                 new XElement("CONTACT2", CONTACT2[i]),
                                 new XElement("NAME", NAME[i]),
                                 new XElement("SURNAME", SURNAME[i]),
                                 new XElement("POST_LABEL", POST_LABEL[i]),
                                 new XElement("SENDER_LABEL", SENDER_LABEL[i]),
                                 new XElement("EARC_EMAIL_ADDRESS1", EARC_EMAIL_ADDRESS1[i])
                           )//AR_AP end 
                           )//AR_APSSSS end
                           );//documant end


                            doc.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");

                            doc.Save(savingPath + "\\" + CODE[i] + ".xml");
                        }
                        #endregion
                    }
                }

                finally
                {

                }
            }
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
                if (ds.Tables[0].Rows[i][0].ToString()==null)
                {
                    ReturnValue[i] = "";
                }else
                ReturnValue[i] = ds.Tables[0].Rows[i][0].ToString();
            }
            baglanti.Close();
            return ReturnValue;
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


                            string[] TAX_ID = stringArrayDoldur("SELECT [items_invoice_taxNumber] FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");

                            #endregion
                            #region ŞahısŞirket
                            
                            #region AllNeededVaribles
                            string[] E_MAIL = stringArrayDoldur("SELECT distinct [items_invoice_address_addressId] FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k]);
                            string[] CODE = stringArrayDoldur("Select [logoid] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]='" + E_MAIL[i] + "'");
                            string[] TITLE = stringArrayDoldur("Select [Mad] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]='" + E_MAIL[i] + "'");
                            string[] ADDRESS1 = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] DISTRICT = stringArrayDoldur("Select [items_invoice_address_district] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] TOWN = stringArrayDoldur("Select [items_invoice_address_town] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] CITY = stringArrayDoldur("Select [items_invoice_address_city] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                           // string[] TAX_ID = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]=" + E_MAIL[i]);
                            string[] TAX_OFFICE = stringArrayDoldur("Select items_invoice_taxOffice FROM tbl_siparis where [items_invoice_address_addressId] ='" + E_MAIL[i] + "'");

                            string[] CONTACT = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] CONTACT2 = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] NAME = stringArrayDoldur("Select [items_customerName] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                           // string[] SURNAME = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_musteriler] where [uniqid]=" + E_MAIL[i]);
                            string[] POST_LABEL = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] SENDER_LABEL = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] EARC_EMAIL_ADDRESS1 = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            string[] KVKK_BEGIN_DATE = stringArrayDoldur("Select [items_invoice_address_address] FROM [db_gulSistem].[dbo].[tbl_siparis] where [items_invoice_address_addressId]='" + E_MAIL[i] + "'");
                            #endregion


                            if (TAX_ID[i] == "")
                            {


                             
                                for (int z = 0; z < CODE.Length; z++)
                                {



                                    XDocument doc = new XDocument(
                                   new XElement("AR_APS",
                                   new XElement("AR_AP",
                                         new XElement("ACCOUNT_TYPE", 3),
                                         new XElement("CODE", CODE[z]),
                                         new XElement("TITLE", TITLE[z]),
                                         new XElement("ADDRESS1", ADDRESS1[z]),
                                         new XElement("TOWN_CODE", "TR"),
                                         new XElement("TOWN", TOWN[z]),
                                         new XElement("CITY_CODE", "TR"),
                                         new XElement("CITY", CITY[z]),
                                         new XElement("COUNTRY_CODE", "TR"),
                                         new XElement("COUNTRY", "TÜRKİYE"),
                                          new XElement("E_MAIL", E_MAIL[i]),
                                         new XElement("PERSCOMPANY", 1),
                                         new XElement("TCKNO", 11111111111),
                                         new XElement("EARCHIVE_SEND_MODE", 1),
                                         new XElement("PROFILE_ID", 2),
                                         new XElement("NAME", NAME[z].Split(' ').Take(NAME[z].Split(' ').Length - 1)),
                                         new XElement("SURNAME", NAME[z].Split(' ').Last())
                                   //,
                                   //   new XElement("SURNAME", SURNAME[z])

                                   )//AR_AP end 
                                   )//AR_APSSSS end
                                   );//documant end


                                    doc.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                    System.IO.Directory.CreateDirectory(savingPath + "\\Cari");
                                    doc.Save(savingPath + "\\Cari\\" + CODE[i] + ".xml");
                                }
                            }
                            #endregion
                            #region FİRMA


                            else
                            {
                                //ŞİRKET HESAPLARI BURAYA 



                                for (int z = 0; z < CODE.Length; z++)
                                {
                                    XDocument doc1 = new XDocument(
                                   new XElement("AR_APS",
                                   new XElement("AR_AP",
                                         new XElement("ACCOUNT_TYPE", 3),
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
                                         new XElement("TAX_ID", TAX_ID[z]),
                                         new XElement("TAX_OFFICE", TAX_OFFICE[z]),
                                         new XElement("E_MAIL", E_MAIL[z]),
                                         new XElement("EARCHIVE_SEND_MODE", 1),
                                         new XElement("PROFILE_ID", 2),
                                         new XElement("CONTACT", NAME[z].Split(' ').Take(NAME[z].Split(' ').Length - 1)),
                                         new XElement("CONTACT2", NAME[z].Split(' ').Last())
                                            //[NAME[z].Split(' ').Length - 1]
                                                                                    //,
                                                                                    //     new XElement("POST_LABEL", POST_LABEL[z]),
                                                                                    //    new XElement("SENDER_LABEL", SENDER_LABEL[z])
                                                                                    //new XElement("EARC_EMAIL_ADDRESS1", EARC_EMAIL_ADDRESS1[i])
                                   )//AR_AP end 
                                   )//AR_APSSSS end
                                   );//documant end


                                    doc1.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                    System.IO.Directory.CreateDirectory(savingPath + "\\Cari");

                                    doc1.Save(savingPath + "\\Cari\\" + CODE[i] + ".xml");
                                }
                                #endregion



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


                                        ünitler.Add(new XElement(new XElement("UNIT", new XElement("UNIT_CODE", "ADET"),
                                                 new XElement("USEF_MTRLCLASS", 1),//kırtasiyedeki logodaki ürün kodu
                                                 new XElement("USEF_PURCHCLAS", 1),//ürün adı
                                                 new XElement("USEF_SALESCLAS", 1),
                                                 new XElement("CONV_FACT1", 1),
                                                 new XElement("CONV_FACT2", 1)))
                                                 );


                                        XDocument doc1 = new XDocument(
                                       new XElement("ITEMS",
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
                                        doc1.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                        System.IO.Directory.CreateDirectory(savingPath + "\\Materials");

                                        doc1.Save(savingPath + "\\Materials\\" + SKUasMasterCode[j] + ".xml");

                                    }
                                    catch (Exception)
                                    {
                                        if (MASTER_DEF.Length > 0)
                                        {
                                            ürünadı = MASTER_DEF[0];
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
                                         new XElement("UNIT_CODE", 1),//birim kodu tl için 1
                                         new XElement("UNIT_CONV2", 1),//çevrim katsayısı
                                         new XElement("ORDER_RESERVE", 1),
                                         new XElement("DUE_DATE", dueDate[j].Split(' ')[0]),
                                         new XElement("CURR_PRICE", 1),//tl için 1
                                                                       // new XElement("PC_PRICE", "A"),
                                                                       //new XElement("RC_XRATE", "A"),
                                                                       //new XElement("TOTAL_NET", "A"),
                                         new XElement("RESERVE_DATE", RESERVE_DATE[j].Split(' ')[0]),
                                         new XElement("RESERVE_AMOUNT", 1)
                                         );
                                    #endregion
                                }
                                #region SatişSiparişi_DOC

                                XElement transactions = new XElement("TRANSACTIONS");
                                transactions.Add(a);
                                XDocument doc = new XDocument(
                               new XElement("SALES_ORDERS",
                               new XElement("ORDER_SLIP",
                                     // new XElement("NUMBER", NUMBER[i]),
                                     new XElement("DOC_TRACK_NR", DOC_TRACK_NR[i]),//@AYNI1
                                     new XElement("DATE", DateTime.Parse(DATE[i].Split(' ')[0])),
                                     new XElement("TIME", DATE[i].Split(' ')[1]),
                                     new XElement("DOC_NUMBER", DOC_NUMBER[i]),
                                     new XElement("AUXIL_CODE", "HB Öder"),
                                     new XElement("ARP_CODE", 625),
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
                                doc.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                                System.IO.Directory.CreateDirectory(savingPath + "\\SatışSipariş");
                                doc.Save(savingPath + "\\SatışSipariş\\" + NOTES1[i] + ".xml");


                                #endregion



                            }
                        }
                    }
                }

                finally
                {

                }
            }
        }

        private void ÜrünKaydetBaslaTread()
        {
            while (true)
            {
                sem.Wait();
                try
                {
                    string[] SKUasMasterCode = stringArrayDoldur("SELECT  items_sku FROM [db_gulSistem].[dbo].[tbl_siparis] ");
                
                    string[] MASTER_DEF = stringArrayDoldur("SELECT  UrunAd FROM [db_gulSistem].[dbo].[tbl_paketTemp] ");


                    
                    
                    
                    string[] ürünadı;
                    string[] SKU;
                    for (int i = 0; i < MASTER_DEF.Length; i++)
                    {
                        ürünadı = MASTER_DEF[i].Split('|');
                        SKU = SKUasMasterCode[i].Split('|');
                        string[] vatRate = stringArrayDoldur("SELECT  items_vatRate FROM [db_gulSistem].[dbo].[tbl_siparis] where items_sku= '"+SKU[0]+"'");
                                            //her orderın içindeki çoklu olabilen değer
                                            XElement ünitler = new XElement("UNITS");


                                            ünitler.Add(new XElement(new XElement("UNIT", new XElement("UNIT_CODE", "ADET"),
                                                     new XElement("USEF_MTRLCLASS", 1),//kırtasiyedeki logodaki ürün kodu
                                                     new XElement("USEF_PURCHCLAS", 1),//ürün adı
                                                     new XElement("USEF_SALESCLAS", 1),
                                                     new XElement("CONV_FACT1", 1),
                                                     new XElement("CONV_FACT2", 1)))
                                                     );


                                            XDocument doc = new XDocument(
                                           new XElement("ITEMS",
                                           new XElement("ITEM",
                                                 new XElement("CARD_TYPE", 1),
                                                 new XElement("CODE", SKU[0]),
                                                 new XElement("NAME", ürünadı[0]),
                                                 new XElement("USEF_PURCHASING", 1),
                                                 new XElement("USEF_SALES", 1),
                                                 new XElement("USEF_MM", 1),
                                                 new XElement("VAT", vatRate[0]),
                                                 new XElement("AUTOINCSL", 1),
                                                 new XElement("LOTS_DIVISIBLE", 1),
                                                 new XElement("UNITSET_CODE", "ADET"),
                                                ünitler,
                                               new XElement("MULTI_ADD_TAX", 0),
                                               new XElement("PACKET", 11),
                                               new XElement("SELVAT", vatRate[0]),
                                               new XElement("RETURNVAT", vatRate[0]),
                                               new XElement("SELPRVAT", vatRate[0]),
                                                       new XElement("RETURNPRVAT", vatRate[0])
                                            )

                                           )
                                   );
                                            doc.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");

                                            doc.Save(savingPath + "\\" + ürünadı + ".xml");



                                            

                    }
                }
                finally
                {

                }
            }
        }

    }


}

