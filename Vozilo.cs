using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KolekcijeKategorijeVozila
{
    internal class Vozilo
    {
        string model, kategorija;
        int godinaProizvodnje, brojKotaca;

        public string Model { get => model; set => model = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }

        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }

        public Vozilo(string m, int gP, int bK) {
            Model = m;
            godinaProizvodnje = gP;
            BrojKotaca = bK;
        }
        public Vozilo() { }

        public void Obradi()
        {
            if (BrojKotaca == 2)
            {
                Kategorija = "Motocikl";
            } 
            else if (BrojKotaca == 4)
            {
                Kategorija = "Automobil";
            }
            else
            {
                Kategorija = "Kamion";
            }
        }
        public XDocument toXml()
        {
            //if (Kategorija!=null) {
                var xml = new XElement("vozilo",
                        new XAttribute("model", Model),
                        new XAttribute("godinaProizvodnje", GodinaProizvodnje),
                        new XAttribute("brojKotaca", BrojKotaca),
                        new XAttribute("kategorije", Kategorija));
                return XDocument.Parse(xml.ToString());
            /*}else
            {
                var xml = new XElement("vozilo",
                            new XAttribute("model", Model),
                            new XAttribute("godinaProizvodnje", GodinaProizvodnje),
                            new XAttribute("brojKotaca", BrojKotaca));
                return XDocument.Parse(xml.ToString());
            }*/
        }
    }
}
