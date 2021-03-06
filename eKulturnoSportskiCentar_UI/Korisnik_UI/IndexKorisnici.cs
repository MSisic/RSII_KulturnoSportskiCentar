﻿using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKulturnoSportskiCentar_UI.Reports;

namespace eKulturnoSportskiCentar_UI.Korisnik_UI
{
    public partial class IndexKorisnici : Form
    {
        private WebAPIHelper korisniciServices = new WebAPIHelper("http://localhost:51348/", Global.KorisnikRoute);

        public IndexKorisnici()
        {
            InitializeComponent();
            Korisnici_DGV.AutoGenerateColumns = false;
        }
        
        private void BindGrid()
        {
            HttpResponseMessage response =
                korisniciServices.GetActionResponse("SearchByName", imePrezimeInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> korisnici = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result.OrderBy(x => x.Prezime).ToList(); ;
                Korisnici_DGV.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);

            }
        }

        private void DodajKorisnika_BTN_Click(object sender, EventArgs e)
        {
            DodajKorisnika f = new DodajKorisnika();
            f.MdiParent = MdiParent;
            Close();
            f.Show();
          
        }

        private void Izmjeni_BTN_Click(object sender, EventArgs e)
        {
            int korisnikID = Convert.ToInt32(Korisnici_DGV.SelectedRows[0].Cells[0].Value);
            UrediKorisnika f = new UrediKorisnika(korisnikID);
            f.MdiParent = MdiParent;
            Close();
            f.Show();
           
        }

        private void IndexKorisnici_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void Izvjesta_BTN_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response =
                korisniciServices.GetActionResponse("GetKorisniciReport", imePrezimeInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> korisnici = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;
                Korisnici_Statistic_Form f=new Korisnici_Statistic_Form();
                f.lista = korisnici;
                f.Show();
            }
        }
    } 
}
