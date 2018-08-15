using ControllerdanVieweVeriAktarma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControllerdanVieweVeriAktarma.DepartmenPersonelViewModel
{
    public class DepartmenPersonel
    {
        public Departmen  Departmen { get; set; }
        public List<Personel> Personel { get; set; }
    }
}