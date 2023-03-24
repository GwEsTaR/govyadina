using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MeropAPI.Entities;

namespace MeropAPI.Controllers
{
    public class АктивностиController : ApiController
    {
        private MeropEntities1 db = new MeropEntities1();

        // GET: api/Активности
        public IQueryable<Активности> GetАктивности()
        {
            return db.Активности;
        }

        // GET: api/Активности/5
        [ResponseType(typeof(Активности))]
        public IHttpActionResult GetАктивности(int id)
        {
            Активности активности = db.Активности.Find(id);
            if (активности == null)
            {
                return NotFound();
            }

            return Ok(активности);
        }

        // PUT: api/Активности/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutАктивности(int id, Активности активности)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != активности.КодАктивности)
            {
                return BadRequest();
            }

            db.Entry(активности).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!АктивностиExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Активности
        [ResponseType(typeof(Активности))]
        public IHttpActionResult PostАктивности(Активности активности)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Активности.Add(активности);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = активности.КодАктивности }, активности);
        }

        // DELETE: api/Активности/5
        [ResponseType(typeof(Активности))]
        public IHttpActionResult DeleteАктивности(int id)
        {
            Активности активности = db.Активности.Find(id);
            if (активности == null)
            {
                return NotFound();
            }

            db.Активности.Remove(активности);
            db.SaveChanges();

            return Ok(активности);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool АктивностиExists(int id)
        {
            return db.Активности.Count(e => e.КодАктивности == id) > 0;
        }
    }
}