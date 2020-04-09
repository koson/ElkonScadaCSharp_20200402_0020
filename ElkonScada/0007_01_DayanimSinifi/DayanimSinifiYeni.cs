﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace ElkonScada._0007_01_DayanimSinifi
{
    public partial class DayanimSinifiYeni : Form
    {

        public DayanimSinifiYeni()
        {
            InitializeComponent();
        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }

        private void tamam_btn_click(object sender, EventArgs e)
        {
            if (dayanimsinifitxt.Text != "" & durumutxt.Text != "")
            {
                string sql = "insert into DayanimSinifi(DayanimSinifi,Aciklama,Durumu)" +
                             "values('" + dayanimsinifitxt.Text + "','" + aciklamatxt.Text + "','" + durumutxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, SqlTableCheckDayanimSinifi.DatabaseConn);
                // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
                if (SqlTableCheckDayanimSinifi.DatabaseConn.State != ConnectionState.Open) SqlTableCheckDayanimSinifi.DatabaseConn.Open();
                cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
                SqlTableCheckDayanimSinifi.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
                ((DayanimSinifiBeton)Application.OpenForms["DayanimSinifiBeton"]).dayanimsinifigetir();
                this.Close();
            }

            if (dayanimsinifitxt.Text == "")
                errorProvider1.SetError(dayanimsinifitxt, hatamsgdayanim.Text);
            if(durumutxt.Text=="")
                errorProvider1.SetError(durumutxt, hatamsgdayanim.Text);
        }


        //dil değiştirme
        public void DilDegistir()
        {
            if (Localization.DilSettings.Default.Dil == "turkce")
            {
                Localization.Localization.Culture = new CultureInfo("");
            }
            else if (Localization.DilSettings.Default.Dil == "ingilizce")
            {
                Localization.Localization.Culture = new CultureInfo("en-US");
            }
            else if (Localization.DilSettings.Default.Dil == "ispanyolca")
            {
                Localization.Localization.Culture = new CultureInfo("es-ES");
            }
            else if (Localization.DilSettings.Default.Dil == "fransizca")
            {
                Localization.Localization.Culture = new CultureInfo("fr-FR");
            }
            else if (Localization.DilSettings.Default.Dil == "macarca")
            {
                Localization.Localization.Culture = new CultureInfo("hu-HU");
            }
            else if (Localization.DilSettings.Default.Dil == "polonyaca")
            {
                Localization.Localization.Culture = new CultureInfo("pl-PL");
            }
            else if (Localization.DilSettings.Default.Dil == "rusca")
            {
                Localization.Localization.Culture = new CultureInfo("ru-RU");
            }
            ES1539_1.Text = Localization.Localization.ES1539_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES403_1.Text = Localization.Localization.ES403_1;
            hatamsgdayanim.Text = Localization.Localization.hatamsgdayanim;
        }
        //

        private void YeniDayanimSinifi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            DurumuCbox.Items.Clear();
            switch (Localization.DilSettings.Default.Dil)
            {
                case "ingilizce":


                    DurumuCbox.Items.Add("Active");
                    DurumuCbox.Items.Add("Passive");
                    break;
                case "turkce":

                    DurumuCbox.Items.Add("Aktif");
                    DurumuCbox.Items.Add("pasif");
                    break;
                case "ispanyolca":

                    DurumuCbox.Items.Add("Activo");
                    DurumuCbox.Items.Add("Pasivo");
                    break;

                case "fransizca":

                    DurumuCbox.Items.Add("Actif");
                    DurumuCbox.Items.Add("Passif");
                    break;
                case "macarca":

                    DurumuCbox.Items.Add("Aktív");
                    DurumuCbox.Items.Add("Passzív");
                    break;
                case "polonyaca":

                    DurumuCbox.Items.Add("Aktywny");
                    DurumuCbox.Items.Add("Pasywny");
                    break;
                case "rusca":

                    DurumuCbox.Items.Add("активный");
                    DurumuCbox.Items.Add("пассивный");
                    break;


            }
            ((DayanimSinifiBeton)Application.OpenForms["DayanimSinifiBeton"]).dayanimsinifigetir();
        }

      
    }
}
