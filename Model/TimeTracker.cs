using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Model
{
    public class TimeTracker
    {
        public DateTime FirstArrival { get; set; }
        public DateTime FirstDeparture { get; set; }
        public DateTime? SecondArrival { get; set; }
        public DateTime? SecondDeparture { get; set; }
        public DateTime? ThirdArrival { get; set; }
        public DateTime? ThirdDeparture { get; set; }
        public DateTime? FourthArrival { get; set; }
        public DateTime? FourthDeparture { get; set; }
        public int TotalHours { get; set; }
        public int Mileage { get; set; }
        public int TravelTime { get; set; }
        public int ParkingTolls { get; set; }
        public int LabTime { get; set; }
        public int ReinspectionTime { get; set; }
        public int StandbyTime { get; set; }
    }
}
