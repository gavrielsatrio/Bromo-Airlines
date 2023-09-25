using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bromo_Airlines.HelperAndExtension;
using Bromo_Airlines.AdminForms;

namespace Bromo_Airlines
{
    public partial class AdminMainForm : CoreForm
    {
        private bool isNavBarShown = true;
        private Dictionary<PictureBox, Label> sideNavItemList = new Dictionary<PictureBox, Label>();

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            picBoxMasterBandara.BindClick(lblMasterBandara, masterBandara_Click);
            picBoxMasterMaskapai.BindClick(lblMasterMaskapai, masterMaskapai_Click);
            picBoxMasterJadwalPenerbangan.BindClick(lblMasterJadwalPenerbangan, masterJadwalPenerbangan_Click);
            picBoxMasterKodePromo.BindClick(lblMasterKodePromo, masterKodePromo_Click);
            pictureBox1.BindClick(lblUbahStatusPenerbangan, ubahStatusPenerbangan_Click);

            sideNavItemList.Add(picBoxMasterBandara, lblMasterBandara);
            sideNavItemList.Add(picBoxMasterMaskapai, lblMasterMaskapai);
            sideNavItemList.Add(picBoxMasterJadwalPenerbangan, lblMasterJadwalPenerbangan);
            sideNavItemList.Add(picBoxMasterKodePromo, lblMasterKodePromo);
            sideNavItemList.Add(pictureBox1, lblUbahStatusPenerbangan);

            picBoxLogout.BindClick(lblLogout, logout_Click);

            ChangeContent(new MasterBandaraForm(), picBoxMasterBandara, "map");
        }

        private void masterBandara_Click(object sender, EventArgs e)
        {
            ChangeContent(new MasterBandaraForm(), picBoxMasterBandara, "map");
        }

        private void masterMaskapai_Click(object sender, EventArgs e)
        {
            ChangeContent(new MasterMaskapaiForm(), picBoxMasterMaskapai, "plane-take-off");
        }

        private void masterJadwalPenerbangan_Click(object sender, EventArgs e)
        {
            ChangeContent(new MasterJadwalPenerbanganForm(), picBoxMasterJadwalPenerbangan, "calendar");
        }

        private void masterKodePromo_Click(object sender, EventArgs e)
        {
            ChangeContent(new MasterKodePromoForm(), picBoxMasterKodePromo, "purchase-tag-alt");
        }

        private void ubahStatusPenerbangan_Click(object sender, EventArgs e)
        {
            ChangeContent(new UbahStatusPenerbanganForm(), pictureBox1, "notepad");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void UnselectAllSideNav()
        {
            picBoxMasterBandara.ImageLocation = Application.StartupPath + "/Images/Icons/map-unselected-72.png";
            picBoxMasterMaskapai.ImageLocation = Application.StartupPath + "/Images/Icons/plane-take-off-unselected-72.png";
            picBoxMasterJadwalPenerbangan.ImageLocation = Application.StartupPath + "/Images/Icons/calendar-unselected-72.png";
            picBoxMasterKodePromo.ImageLocation = Application.StartupPath + "/Images/Icons/purchase-tag-alt-unselected-72.png";
            pictureBox1.ImageLocation = Application.StartupPath + "/Images/Icons/notepad-unselected-72.png";

            foreach (var item in sideNavItemList.Values)
            {
                item.ForeColor = Color.FromArgb(160, 160, 160);
            }
        }

        private void SelectSideNav(PictureBox picBox, string iconName)
        {
            picBox.ImageLocation = Application.StartupPath + $"/Images/Icons/{iconName}-selected-72.png";

            var lbl = sideNavItemList[picBox];
            lbl.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void ChangeContent(UserControl userControl, PictureBox picBox, string iconName)
        {
            UnselectAllSideNav();
            panelContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            SelectSideNav(picBox, iconName);

            // Cheat Form
            //var a = new LoginForm()
            //{
            //    TopLevel = false,
            //    AutoScroll = true,
            //    Dock = DockStyle.Fill,
            //    FormBorderStyle = FormBorderStyle.None
            //};
            //panelContent.Controls.Add(a);
            //a.Show();

            panelContent.Controls.Add(userControl);
        }

        private void btnToggleNav_Click(object sender, EventArgs e)
        {
            isNavBarShown = !isNavBarShown;

            if(isNavBarShown)
            {
                panelSideNav.Width = 220;
            }
            else
            {
                panelSideNav.Width = 50;
            }

            lblDashboardContent.Visible = !isNavBarShown;
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
