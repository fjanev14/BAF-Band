using BafBand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BafBand.Controllers.api
{
    public class ConcertsController : ApiController
    {
        private ApplicationDbContext _context;
        public ConcertsController()
        {
            _context = new ApplicationDbContext();
        }
        //GET/api/concerts
        //GET/api/concerts

        public IEnumerable<Concert> GetConcerts()
        {
            return _context.Concerts.ToList();
        }
        //GET/api/concerts/1
        public Concert GetConcert(int id)
        {
            var concert = _context.Concerts.SingleOrDefault(c => c.Id == id);
            if (concert == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return concert;

        }
        //POST /api/concert
        [HttpPost]
        public Concert AddConcert([FromBody]Concert concert)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Concerts.Add(concert);
            _context.SaveChanges();
            return concert;
        }

        //EDIT /api/concert/1
        [HttpPut]
        public void EditConcert(int id, Concert concert)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var concertInDb = _context.Concerts.SingleOrDefault(c => c.Id == id);
            if (concertInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            concertInDb.Name = concert.Name;
            concertInDb.Rating = concert.Rating;
            concert.Date = concert.Date;
            _context.SaveChanges();

        }
        //DELETE/api/concert/1
        [HttpDelete]
        public void DeleteConcert(int id)
        {
            var customerInDb = _context.Concerts.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Concerts.Remove(customerInDb);
            _context.SaveChanges();
        }

    }
}

