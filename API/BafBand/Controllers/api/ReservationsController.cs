using BafBand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BafBand.Controllers.api
{
    public class ReservationsController : ApiController
    {
        private ApplicationDbContext _context;
        public ReservationsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET/api/reservations
        public IEnumerable<Reservation> GetReservations()
        {
            return _context.Reservations.ToList();
        }
        //GET/api/concerts/1
        public Reservation GetReservation(int id)
        {
            var reservation = _context.Reservations.SingleOrDefault(c => c.Id == id);
            if (reservation == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return reservation;

        }
        
       
        
        [HttpPost]
        public IHttpActionResult AddReservation([FromBody] Reservation model)
        { 
            
            _context.Reservations.Add(model);
            _context.SaveChanges();
            return Json(_context.Reservations.ToArray());
        }
        


        [System.Web.Http.HttpDelete]
        public void DeleteReservation(int id)
        {
            var reservationInDb = _context.Reservations.SingleOrDefault(c => c.Id == id);
            if (reservationInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Reservations.Remove(reservationInDb);
            _context.SaveChanges();
        }


    }
}
