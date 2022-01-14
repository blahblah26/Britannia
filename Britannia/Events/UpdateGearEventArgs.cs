using System;
using Britannia.Objects;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Britannia.Events
{
    public class UpdateGearEventArgs : EventArgs
    {
        private Gear _g;
        public UpdateGearEventArgs(Gear g)
        { 
            _g = g;
        }

        public Gear getGear()
        {
            return _g;
        }
    }
}
