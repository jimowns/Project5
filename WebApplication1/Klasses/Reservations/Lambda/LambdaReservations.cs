using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Reservations.linq
{
    public class LambdaReservations
    {
        public List<Reservations> GetReservationsByID()
        {
            var list = new Entity();
            List<Reservations> reservations = list.DB_Reservations
                .Where(x =>
                        x.LecturerID.Equals(Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]))
                    ).ToList();
            return reservations;
        }

        public Reservation SetReservationInsertData()
        {
            var list = new Entity();
            Reservation reservation = new Reservation()
            {
                Lecturer_id = Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]),
                Slot_id = Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.SlotsID.ToString()])
            };
            list.dataClassContext.Reservations.InsertOnSubmit(reservation);
            list.dataClassContext.SubmitChanges();

            return reservation;
        }
    }
}