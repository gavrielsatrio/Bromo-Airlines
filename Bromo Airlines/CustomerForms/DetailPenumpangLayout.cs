using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines.CustomerForms
{
    public partial class DetailPenumpangLayout : UserControl
    {
        public int nomorPenumpang = 1;
        public DetailPenumpangLayout()
        {
            InitializeComponent();
        }

        private void DetailPenumpangLayout_Load(object sender, EventArgs e)
        {
            lblNomorPenumpang.Text = $"Penumpang #{nomorPenumpang.ToString()}";
            comboTitel.Text = comboTitel.Items[0].ToString();
        }

        public string GetTitel()
        {
            return comboTitel.Text;
        }

        public string GetNamaLengkap()
        {
            return txtNamaLengkap.Text;
        }
    }
}
