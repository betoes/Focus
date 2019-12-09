using SysCredito.model.dao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SysCredito.user_control
{
    /// <summary>
    /// Lógica de interacción para GUIDocumentos.xaml
    /// </summary>
    public partial class GUIDocumentos : System.Windows.Controls.UserControl
    {
        public GUIDocumentos()
        {
            InitializeComponent();
            txtComprobanteDom.IsEnabled = false;
            txtIne.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Pdf Files|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            txtIne.Text = filePath;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Pdf Files|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            txtComprobanteDom.Text = filePath;

        }

        public void guardarDocumentos(int idCliente)
        {
            
            if (txtComprobanteDom.Text == "" || txtIne.Text == "")
            {
                System.Windows.MessageBox.Show("Escoja los archivos correspondientes");
            } else if (txtNombreCD.Text == "" || txtNombreIne.Text == "")
            {
                System.Windows.MessageBox.Show("Escoja los archivos correspondientes");
            } else
            {
                bool resultadoIne = DocumentosDAO.saveDocuments(txtIne.Text, txtNombreIne.Text,idCliente);
                bool resultadoCD = DocumentosDAO.saveDocuments(txtComprobanteDom.Text, txtNombreCD.Text,idCliente);

                if(resultadoCD && resultadoIne)
                {
                    System.Windows.MessageBox.Show("Se guardaron los documentos");
                }
            }


        }
    }
}
