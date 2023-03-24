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
using MeropAPI.Models;

namespace MeropAPI.Controllers
{
    public class МероприятияController : ApiController
    {
        private MeropEntities1 db = new MeropEntities1();

        // GET: api/Мероприятия
        [ResponseType(typeof(List<ResponseMerop>))]
        public IHttpActionResult GetМероприятия()
        {
            return Ok(db.Мероприятия.ToList().ConvertAll(p => new ResponseMerop(p)));
        }

        // GET: api/Мероприятия/5
        [ResponseType(typeof(Мероприятия))]
        public IHttpActionResult GetМероприятия(int id)
        {
            Мероприятия мероприятия = db.Мероприятия.Find(id);
            if (мероприятия == null)
            {
                return NotFound();
            }

            return Ok(мероприятия);
        }

        // PUT: api/Мероприятия/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutМероприятия(int id, Мероприятия мероприятия)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != мероприятия.КодМероприятия)
            {
                return BadRequest();
            }

            db.Entry(мероприятия).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!МероприятияExists(id))
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

        // POST: api/Мероприятия
        [ResponseType(typeof(Мероприятия))]
        public IHttpActionResult PostМероприятия(Мероприятия мероприятия)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Мероприятия.Add(мероприятия);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = мероприятия.КодМероприятия }, мероприятия);
        }

        // DELETE: api/Мероприятия/5
        [ResponseType(typeof(Мероприятия))]
        public IHttpActionResult DeleteМероприятия(int id)
        {
            Мероприятия мероприятия = db.Мероприятия.Find(id);
            if (мероприятия == null)
            {
                return NotFound();
            }

            db.Мероприятия.Remove(мероприятия);
            db.SaveChanges();

            return Ok(мероприятия);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool МероприятияExists(int id)
        {
            return db.Мероприятия.Count(e => e.КодМероприятия == id) > 0;
        }
    }
}