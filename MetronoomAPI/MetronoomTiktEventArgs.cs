using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetronoomAPI
{
    public class MetronoomTiktEventArgs : EventArgs
    {
        public DateTime TijdstipVanTik { get; set; }
    }
}
