using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UpdateSite : Form
    {
        public int siteId;
        public string oldName;

        private void loadDataSite(int siteId)
        {
            SiteDAO siteDAO = new SiteDAO();
            Site site = (Site)siteDAO.getSiteById(siteId);
            labelSite.Text = site.name;
        }
        public UpdateSite(List<String> siteInfo)
        {
            InitializeComponent();
            siteId = int.Parse(siteInfo[0]);
            loadDataSite(siteId);
            oldName = siteInfo[1];
        }

        private void saveUpdateSite_Click(object sender, EventArgs e)
        {
            String name = txt_site_update.Text;
            name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            Site site = new Site
            {
                id = siteId,
                name = name,
            };

            SiteDAO siteDAO = new SiteDAO();

            DialogResult dialogResult = MessageBox.Show(
                "ATTENTION : \n\n" +
                "En modifiant ce site, vous allez modifier les employé(e)s qui y sont rattaché(e)s\n" +
                "Voulez-vous  vraiment renommer le site " + oldName + " en " + site.name + "?",
                "MODIFICATION D'UN SITE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int result = siteDAO.updateSite(site);

            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                return;
            }
            this.Close();
        }
    }
}
