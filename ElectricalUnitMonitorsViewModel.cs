using System;
using System.Collections.Generic;
using IntelliHome.Data.Models;
using System.Linq;

namespace IntelliHome.Web.Models
{
    public class ElectricalUnitMonitorsViewModel
    {
        public IList<ElectricalUnitMonitor> ElectricalUnitMonitors { get; set; }
        public IList<ElectricalUnit> ElectricalUnits { get; set; }
        public IList<Room> Rooms { get; set; }

        public double TotalHouseCost => Rooms.Select(r => r.UsageCost).Sum();
        public double TotalHouseUsage => Rooms.Select(r => r.UsagekWh).Sum();
        public double TotalCo2Kg => TotalHouseUsage * 0.281;
    }
}
