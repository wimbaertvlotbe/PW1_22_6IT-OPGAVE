using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System;
using OrderToepassing;
using System.Reflection;
using System.Text;
using System.Numerics;

namespace PW1_22_6IT_OPGAVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MijnLeesXmlBestandProducten()
        {
            /*
             * ZIE OPDRACHT 3
             */
        }
        private void NieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            * ZIE OPDRACHT 4
            */
        }
        private void KlantNaarBestelBon_Click(object sender, EventArgs e)
        {
            /*
             * ZIE OPDRACHT 5
             */
        }
        private void KlantenLijstCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * ZIE OPDRACHT 5
             */
        }
        private void ProductNaarBestelBon_Click(object sender, EventArgs e)
        {
            /*
             * ZIE OPDRACHT 6
             */
        }
        private void ProductenLb_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            * ZIE OPDRACHT 6
            */
            //Event die 'afvuurt' wanneer er op een item in de listbox 'productenLb' wordt geklikt 
        }
        public void XmlSchrijfBestandBestelbon()
        {
            /*
            * ZIE OPDRACHT 7
            */
            //Onderstaande lijn is de laatste programmalijn in deze method. 'bestandsnaam' is de naam van je opgeslagen Xml-bestelbon
            //System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", bestandsNaam);
        }
        private void OpslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            * ZIE OPDRACHT 7
            */
            XmlSchrijfBestandBestelbon();
        }
        private void ToonBestelbedrag_Click(object sender, EventArgs e)
        {
            /*
            * ZIE OPDRACHT 8
            */
        }
        private void AfsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * ZIE OPDRACHT 9
             */
        }
        private string PrintKlantGegevens(Klant klant)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"klantnummer : {klant.KlantNummer}");
            sb.Append(Environment.NewLine);
            sb.Append($"{klant.Naam} {klant.VoorNaam}");
            sb.Append(Environment.NewLine);
            sb.Append($"{klant.Adres}");
            sb.Append(Environment.NewLine);
            sb.Append($"{klant.PostNummer} {klant.Woonplaats}");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        private string PrintProductGegevens(Product p, int bestelhoeveelheid)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{p.ProductNummer,-20}{p.ProductNaam,-30}{p.Prijs,-12:C2}{bestelhoeveelheid,-12}");
            return sb.ToString();
        }

    }
}