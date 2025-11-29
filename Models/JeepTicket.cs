using System;

namespace JeepTicketingSystem.Models
{
    public class JeepTicket
    {
        public int Id { get; set; }
        public string PassengerName { get; set; }
        public string Route { get; set; }
        public decimal Fare { get; set; }
        public DateTime TravelDate { get; set; }
    }
}
