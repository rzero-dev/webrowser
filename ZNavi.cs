using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZNavi
{
    public partial class ZNavi : Form
    {
        public ZNavi()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            nav.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            nav.GoForward();
        }

        private void pbxRecargar_Click(object sender, EventArgs e)
        {
            nav.Refresh();
        }

        private void pbxDetener_Click(object sender, EventArgs e)
        {
            nav.Stop();
        }

        private void pbxInicio_Click(object sender, EventArgs e)
        {
            nav.Navigate("www.google.com");
        }

        private void pbxIr_Click(object sender, EventArgs e)
        {
            nav.Navigate(tbxUrl.Text);
        }

        private void tbxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) nav.Navigate(tbxUrl.Text);
        }

        private void nav_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tbxUrl.Text = nav.Url.ToString();
        }

        private void ZNavi_Load(object sender, EventArgs e)
        {
            nav.Navigate("www.google.com");
        }
    }
}
