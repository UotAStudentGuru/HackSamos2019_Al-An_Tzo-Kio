using System;
using System.Collections.Generic;
using System.Text;

namespace MagicBus.Common.Models
{
    public class Route : BaseModel
    {
        private string _destination;
        private DateTime _departure;

        public string Destination
        {
            get => _destination;
            set => _destination = value;
        }

        public DateTime Departure
        {
            get => _departure;
            set => _departure = value;
        }
    }
}
