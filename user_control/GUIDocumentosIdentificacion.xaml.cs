using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SysCredito.user_control
{
    


    public partial class GUIDocumentosIdentificacion : UserControl
    {
        public GUIDocumentosIdentificacion()
        {
            InitializeComponent();
        }

        private void BtnFileOpen_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            var result = fileDialog.ShowDialog();
            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    var file = fileDialog.FileName;
                    TxtFile.Text = file;
                    TxtFile.ToolTip = file;
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    TxtFile.Text = null;
                    TxtFile.ToolTip = null;
                    break;
            }
        }
    }
}
