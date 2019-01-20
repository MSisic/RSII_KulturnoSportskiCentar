﻿using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKulturnoSportskiCentar_UI.DodatnaOprema_UI
{
    public partial class UrediDodatnaOprema : Form
    {
        private WebAPIHelper DodatnaOpremaServices = new WebAPIHelper("http://localhost:51348/", Global.DodatnaOpremaRoute);
        private DodatnaOprema dodatnaOprema { get; set; }

        public UrediDodatnaOprema(int dodatnaOpremaId)
        {
            InitializeComponent();
            HttpResponseMessage response = DodatnaOpremaServices.GetResponse(dodatnaOpremaId.ToString());
            this.AutoValidate = AutoValidate.Disable;
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                dodatnaOprema = null;
            }
            else
            {
                dodatnaOprema = response.Content.ReadAsAsync<DodatnaOprema>().Result;
            }
        }


        private void UrediDodatnaOprema_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void BindForm()
        {
            if (dodatnaOprema != null)
            {
                Naziv_Input.Text = dodatnaOprema.Naziv;

                Cijena_Input.Text = dodatnaOprema.Cijena.ToString();
                if (dodatnaOprema.Slika != null)
                {
                    Image slika = byteArrayToImage(dodatnaOprema.SlikaThumb);
                    Slika_PCB.Image = slika;
                }
            }
        }

        private Image byteArrayToImage(byte[] slikaThumb)
        {
            MemoryStream ms = new MemoryStream(slikaThumb);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Izmjeni_BTN_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {


                if (dodatnaOprema != null)
                {
                    dodatnaOprema.Naziv = Naziv_Input.Text;
                    dodatnaOprema.Cijena = Convert.ToDecimal(Cijena_Input.Text);

                }

                HttpResponseMessage response =
                    DodatnaOpremaServices.PutResponse(dodatnaOprema.DodatnaOpremaID, dodatnaOprema);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Oprema uspjenšno izmjenjena");
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error Code" +
                                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        #region Validacija
        private void Naziv_Input_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Naziv_Input.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(Naziv_Input, Messages.Name_Required);
            }
        }
        #endregion

        
    }
}