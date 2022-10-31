using System;
using System.Data;
using System.Data.SqlClient;
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
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1 = new Thread(KaydetBaslaTread);
        }
        string savingPath = Directory.GetCurrentDirectory();
        private void KaydetBasla_Clk(object sender, EventArgs e)
        {

            if (t1.ThreadState == System.Threading.ThreadState.Unstarted)
                t1.Start();
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

        private void KaydetBaslaTread()
        {
            while (true)
            {
                sem.Wait();
                try
                {
                    string[] orderNumbers = stringArrayDoldur("SELECT Distinct items_orderNumber  FROM [db_gulSistem].[dbo].[tbl_siparis]");
                    for (int k = 0; k < orderNumbers.Length; k++)
                    {//eşi olmayan veri sayısı
                        string sorgu = "SELECT  Distinct items_orderNumber  FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k];
                       //her orderın içindeki veriler
                        string[] NUMBER = stringArrayDoldur(sorgu);
                        for (int i = 0; i < NUMBER.Length; i++)//numberLength genelde 1 olur
                        {
                            #region AllNeededVaribles
                            string[] NUMBER1 = stringArrayDoldur(sorgu);
                            string[] DOC_TRACK_NR = stringArrayDoldur(sorgu);
                            string[] DATE = stringArrayDoldur(sorgu);
                            string[] TIME = stringArrayDoldur(sorgu);
                            string[] DOC_NUMBER = stringArrayDoldur(sorgu);
                            string[] AUXIL_CODE = stringArrayDoldur(sorgu);
                            string[] ARP_CODE = stringArrayDoldur(sorgu);
                            string[] RC_RATE = stringArrayDoldur(sorgu);
                            string[] NOTES1 = stringArrayDoldur(sorgu);
                            string[] NOTES2 = stringArrayDoldur(sorgu);
                            string[] NOTES3 = stringArrayDoldur(sorgu);
                            string[] NOTES5 = stringArrayDoldur(sorgu);
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
                            string[] RESERVE_DATE = stringArrayDoldur(sorgu);
                            string[] RESERVE_AMOUNT = stringArrayDoldur(sorgu);
                            string[] CUST_ORD_NO = stringArrayDoldur(sorgu);
                            string[] DOC_TRACKING_NR = stringArrayDoldur(sorgu);
                            #endregion

                            string[] amount = stringArrayDoldur("SELECT  items_totalPrice_amount FROM [db_gulSistem].[dbo].[tbl_siparis] where items_orderNumber=" + orderNumbers[k]);
                            //her orderın içindeki çoklu olabilen değer
                            XElement[] a = new XElement[amount.Length];
                            for (int j = 0; j < a.Length; j++)
                            {
                                a[j] = new XElement("TRANSACTION");
                                a[j].Add(new XElement("TYPE", "A"),
                                     new XElement("MASTER_CODE", "A"),
                                     new XElement("QUANTITY", "A"),
                                     new XElement("PRICE", amount[j]),
                                     new XElement("TOTAL", "A"),
                                     new XElement("VAT_RATE", "A"),
                                     new XElement("UNIT_CODE", "A"),
                                     new XElement("UNIT_CONV2", "A"),
                                     new XElement("ORDER_RESERVE", "A"),
                                     new XElement("DUE_DATE", "A"),
                                     new XElement("CURR_PRICE", "A"),
                                     new XElement("PC_PRICE", "A"),
                                     new XElement("RC_XRATE", "A"),
                                     new XElement("TOTAL_NET", "A"),
                                     new XElement("RESERVE_DATE", "A"),
                                     new XElement("RESERVE_AMOUNT", "A")
                                     );
                            }

                            XElement transactions = new XElement("TRANSACTIONS");
                            transactions.Add(a);

                            XDocument doc = new XDocument(
                           new XElement("SALES_ORDERS",
                           new XElement("ORDER_SLIP",
                                 new XElement("NUMBER", NUMBER[i]),
                                 new XElement("DOC_TRACK_NR", DOC_TRACK_NR[i]),
                                 new XElement("DATE", DATE[i]),
                                 new XElement("TIME", TIME[i]),
                                 new XElement("DOC_NUMBER", DOC_NUMBER[i]),
                                 new XElement("AUXIL_CODE", AUXIL_CODE[i]),
                                 new XElement("ARP_CODE", ARP_CODE[i]),
                                 new XElement("RC_RATE", RC_RATE[i]),
                                 new XElement("NOTES1", NOTES1[i]),
                                 new XElement("NOTES2", NOTES2[i]),
                                 new XElement("NOTES3", NOTES3[i]),
                                 new XElement("NOTES5", NOTES5[i]),
                                 new XElement("ORDER_STATUS", ORDER_STATUS[i]),
                                 new XElement("CREATED_BY", CREATED_BY[i]),
                                 new XElement("DATE_CREATED", DATE_CREATED[i]),
                                 new XElement("HOUR_CREATED", HOUR_CREATED[i]),
                                 new XElement("MIN_CREATED", MIN_CREATED[i]),
                                 new XElement("SEC_CREATED", SEC_CREATED[i]),
                                 new XElement("MODIFIED_BY", MODIFIED_BY[i]),
                                 new XElement("CURRSEL_TOTAL", CURRSEL_TOTAL[i]),
                                transactions
                                ,//Transactions Altı
                               new XElement("CUST_ORD_NO", CUST_ORD_NO[i]),
                               new XElement("DOC_TRACKING_NR", DOC_TRACKING_NR[i])
                            )
                           //orderslipin altı

                           )
                   //salesorderın altı
                   );
                            doc.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");

                            doc.Save(savingPath + "\\" + ARP_CODE[i] + ".xml");
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

