using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatabaseToXml
{
    internal class XmlMerger
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        XDocument xmlDocument, xmlDocument2;
        XElement element, element2;
        private void InitializeOpenFileDialog()
        {
            openFileDialog.Filter =
                "Xml Dosyaları (*.xml)|*.xml"; 
                //+"All files (*.*)|*.*";

            // Allow the user to select multiple images.
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Birleştirelecek Xml Dosyalarını Seçiniz";
        }

        public  void MergeMyXmls()
        {
            InitializeOpenFileDialog();
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                int i = 0;
                foreach (String file in openFileDialog.FileNames)
                {
                    try
                    {
                        if (i==0)
                        {
                             xmlDocument = XDocument.Load(file);
                             element = xmlDocument.Elements().FirstOrDefault();
                            i++;
                        }
                        else
                        {
                             xmlDocument2 = XDocument.Load(file);
                             element2 = xmlDocument2.Elements().FirstOrDefault();

                            element.Add(element2.Nodes());
                        }
                    
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                xmlDocument.Declaration = new XDeclaration("1.0", "ISO-8859-9", "");
                xmlDocument.Save(Form1.savingPath + "\\" + "Birleştirilenler" + ".xml");
            }
        }
    }
}
