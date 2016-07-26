using GrapeCity.Win.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpaddressPluspakSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gcPostal1_ValueChanged(object sender, EventArgs e)
        {
            this.gcPostalBarCode1.ZipCode = this.gcPostal1.Value;

            // GcPostalに入力された郵便番号から住所が取得できる場合はtextBox2を補完する
            if (gcPostal1.Addresses != null && gcPostal1.Addresses.Count() > 0)
            {
                var address = gcPostal1.Addresses[0];
                this.textBox2.Text = address.Prefecture + address.City + address.Town;
            }
        }
    }
}
