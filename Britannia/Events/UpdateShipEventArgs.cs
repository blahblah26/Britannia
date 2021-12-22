using System;
using Britannia.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Britannia.Events
{
    public class UpdateShipEventArgs : EventArgs
    {
        private Ship _s;
        public UpdateShipEventArgs(Ship s)
        {
            _s = s;
        }

        public Ship getShip()
        {
            return _s;
        }
    }
}
