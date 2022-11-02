using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
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
        Thread SatışSipariş, CariHesap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SatışSipariş = new Thread(SatıŞSiparisiKaydetBaslaTread);
            CariHesap = new Thread(CariHesapKaydetBaslaTread);
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
                            string[] NUMBER1 = stringArrayDoldur(sorgu);
                            string[] DOC_TRACK_NR = stringArrayDoldur(sorgu);
                            string[] DATE = stringArrayDoldur("SELECT  items_orderDate FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                            string[] TIME = stringArrayDoldur(sorgu);
                            string[] DOC_NUMBER = stringArrayDoldur(sorgu);
                            string[] AUXIL_CODE = stringArrayDoldur(sorgu);
                            string[] ARP_CODE = stringArrayDoldur(sorgu);
                            string[] RC_RATE = stringArrayDoldur(sorgu);
                            string[] NOTES1 = stringArrayDoldur("SELECT items_invoice_address_name FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                            string[] NOTES2 = stringArrayDoldur("SELECT items_invoice_address_district FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                            string[] NOTES3 = stringArrayDoldur("SELECT items_invoice_address_town FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                            string[] NOTES5 = stringArrayDoldur("SELECT items_invoice_address_city FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k] + "order by items_orderNumber asc");
                            string[] ORDER_STATUS = stringArrayDoldur(sorgu);
                            string[] CREATED_BY = stringArrayDoldur(sorgu);
                            string[] DATE_CREATED = stringArrayDoldur(sorgu);
                            string[] HOUR_CREATED = stringArrayDoldur(sorgu);
                            string[] MIN_CREATED = stringArrayDoldur(sorgu);
                            string[] SEC_CREATED = stringArrayDoldur(sorgu);
                            string[] MODIFIED_BY = stringArrayDoldur(sorgu);
                            string[] CURRSEL_TOTAL = stringArrayDoldur(sorgu);
                            string[] TYPE = stringArrayDoldur(sorgu);
                            string[] MASTER_CODE = stringArrayDoldur(sorgu);
                            string[] QUANTITY = stringArrayDoldur(sorgu);
                            string[] PRICE = stringArrayDoldur(sorgu);
                            string[] TOTAL = stringArrayDoldur(sorgu);
                            string[] VAT_RATE = stringArrayDoldur(sorgu);
                            string[] UNIT_CODE = stringArrayDoldur(sorgu);
                            string[] UNIT_CONV2 = stringArrayDoldur(sorgu);
                            string[] ORDER_RESERVE = stringArrayDoldur(sorgu);
                            string[] DUE_DATE = stringArrayDoldur(sorgu);
                            string[] CURR_PRICE = stringArrayDoldur(sorgu);
                            string[] PC_PRICE = stringArrayDoldur(sorgu);
                            string[] RC_XRATE = stringArrayDoldur(sorgu);
                            string[] TOTAL_NET = stringArrayDoldur(sorgu);
                            string[] RESERVE_AMOUNT = stringArrayDoldur(sorgu);
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

                            #endregion

                            //her orderın içindeki çoklu olabilen değer
                            XElement[] a = new XElement[Totalamount.Length];
                            for (int j = 0; j < a.Length; j++)
                            {
                                string[] MASTER_DEFfromSKU;
                                MASTER_DEFfromSKU = stringArrayDoldur("SELECT Distinct ProductName FROM [DataFromExel].[dbo].[PerformansS] where Sku='" + SKUasMasterCode[j] + "'");
                                 string ürünadı = null;
                                if (MASTER_DEFfromSKU.Length>0)
                                {
                                  ürünadı = MASTER_DEFfromSKU[0];
                                }
                                else
                                {
                                    try
                                    {

                                         ürünadı = MASTER_DEF[j].Split('|')[j];
                                    }
                                    catch (Exception)
                                    {

                                          ürünadı = "Tanımsız";   
                                    }
                                }
                                
                               
                                a[j] = new XElement("TRANSACTION");

                                a[j].Add(new XElement("TYPE", "0"),
                                     new XElement("MASTER_CODE", SKUasMasterCode[j]),//kırtasiyedeki logodaki ürün kodu
                                     new XElement("MASTER_DEF", ürünadı),//ürün adı
                                     new XElement("QUANTITY", quantity[j]),
                                     new XElement("PRICE", unitPrice[j]),
                                     new XElement("TOTAL", Totalamount[j]),
                                     new XElement("VAT_RATE", vatRate[j]),
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
                            }

                            XElement transactions = new XElement("TRANSACTIONS");
                            transactions.Add(a);

                        //    DateTimeOffset dateTimeOffset = new DateTimeOffset();
                          //  DateTimeOffset.TryParseExact(DATE[i], @"HH\:mm\:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeOffset);

                            XDocument doc = new XDocument(
                           new XElement("SALES_ORDERS",
                           new XElement("ORDER_SLIP",
                                 // new XElement("NUMBER", NUMBER[i]),
                                 new XElement("DOC_TRACK_NR", DOC_TRACK_NR[i]),//@AYNI1
                                 new XElement("DATE", DATE[i].Split(' ')[0]),
                                 new XElement("TIME", DATE[i].Split(' ')[1]),
                                 new XElement("DOC_NUMBER", DOC_NUMBER[i]),
                                 new XElement("AUXIL_CODE", "HB Öder"),
                                 new XElement("ARP_CODE", ARP_CODE[i]),
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

                            doc.Save(savingPath + "\\" + NOTES1[i] + ".xml");

                        }
                    }
                }

                finally
                {

                }
            }
        }

    }


}

