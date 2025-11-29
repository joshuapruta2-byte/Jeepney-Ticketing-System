using System.Collections.Generic;
using System.Linq;

namespace JeepTicketingSystem.Models
{
    public static class FakeTicketRepository
    {
        private static List<JeepTicket> _tickets = new List<JeepTicket>();
        private static int _nextId = 1;

        public static List<JeepTicket> GetAll()
        {
            return _tickets;
        }

        public static JeepTicket Get(int id)
        {
            return _tickets.FirstOrDefault(x => x.Id == id);
        }

        public static void Add(JeepTicket ticket)
        {
            ticket.Id = _nextId++;
            _tickets.Add(ticket);
        }

        public static void Update(JeepTicket ticket)
        {
            var old = Get(ticket.Id);
            if (old != null)
            {
                old.PassengerName = ticket.PassengerName;
                old.Route = ticket.Route;
                old.Fare = ticket.Fare;
                old.TravelDate = ticket.TravelDate;
            }
        }

        public static void Delete(int id)
        {
            var t = Get(id);
            if (t != null)
                _tickets.Remove(t);
        }
    }
}
