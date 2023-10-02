using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KolekcijeKategorijeVozila
{
    internal class Motocikl : Vozilo
    {
        public XDocument toXml()
        {
            var xml = new XElement("vozilo",
                        new XAttribute("model", Model),
                        new XAttribute("godinaProizvodnje", GodinaProizvodnje),
                        new XElement("kategorije", "Motocikl"));
            return XDocument.Parse(xml.ToString());
        }
        public Motocikl(string m, int gP)
        {
            Model = m;
            GodinaProizvodnje = gP;
            //BrojKotaca = 2;
        }
    }
}
