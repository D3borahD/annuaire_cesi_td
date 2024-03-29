﻿//using MySqlX.XDevAPI.Common;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class UpdateSite : Form
    {
        public int siteId;
        public string oldName;

        // load data of soite
        private async void loadDataSite(int siteId)
        {
            var siteName = await siteDAO.getSiteById(siteId);
            String siteN = siteName.name;

            labelSite.Text = $"{siteN}";
        }
        public UpdateSite(List<String> siteInfo)
        {
            InitializeComponent();
            siteId = int.Parse(siteInfo[0]);
            loadDataSite(siteId);
            oldName = siteInfo[1];
        }

        // button to save changes 
        private async void saveUpdateSite_Click(object sender, EventArgs e)
        {
            // format name with low case and first letter capital
            String name = txt_site_update.Text;
            name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            Site site = new Site
            {
                id = siteId,
                name = name,
            };

            siteDAO siteDAO = new siteDAO();

            DialogResult dialogResult = MessageBox.Show(
                "ATTENTION : \n\n" +
                "En modifiant ce site, vous allez modifier les employé(e)s qui y sont rattaché(e)s\n" +
                "Voulez-vous  vraiment renommer le site " + oldName + " en " + site.name + "?",
                "MODIFICATION D'UN SITE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                await siteDAO.updateSite(site.id, site);
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
