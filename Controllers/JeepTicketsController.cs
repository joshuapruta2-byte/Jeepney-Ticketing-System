using JeepTicketingSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeepTicketingSystem.Controllers
{
    public class JeepTicketsController : Controller
    {
        public ActionResult Index()
        {
            var tickets = FakeTicketRepository.GetAll();
            return View(tickets);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(JeepTicket ticket)
        {
            if (ModelState.IsValid)
            {
                FakeTicketRepository.Add(ticket);
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        public ActionResult Edit(int id)
        {
            var ticket = FakeTicketRepository.Get(id);
            if (ticket == null)
                return HttpNotFound();

            return View(ticket);
        }

        [HttpPost]
        public ActionResult Edit(JeepTicket ticket)
        {
            if (ModelState.IsValid)
            {
                FakeTicketRepository.Update(ticket);
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        public ActionResult Delete(int id)
        {
            var ticket = FakeTicketRepository.Get(id);
            if (ticket == null)
                return HttpNotFound();

            return View(ticket);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FakeTicketRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
