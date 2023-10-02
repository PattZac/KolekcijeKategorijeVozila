using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KolekcijeKategorijeVozila
{
    internal class Kamion : Vozilo
    {
        public XDocument toXml()
        {
            var xml = new XElement("vozilo",
                        new XAttribute("model", Model),
                        new XAttribute("godinaProizvodnje", GodinaProizvodnje),
                        new XElement("kategorije", "Kamion"));
            return XDocument.Parse(xml.ToString());
        }
        public Kamion(string m, int gP/*, int bK*/)
        {
            Model = m;
            GodinaProizvodnje = gP;
            //BrojKotaca = bK;
        }
}
}
