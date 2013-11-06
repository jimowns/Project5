using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Slots.linq
{
    public class LambdaSlots
    {
        private const int CAPACITY_DOWN = 1;
        private const int RESERVED_UP = 1;
        private const int MINIMUM_CAPACITY = 0;
        public int ID { set; get; }

        public LambdaSlots(int id)
        {
            this.ID = id;
        }

        public Slot SetSlotsUpdateData()
        {
            Connection.Entity entity = new Connection.Entity();
            var slots = entity.dataClassContext.Slots
                .Where(z =>
                          z.Id.Equals(this.ID)
                       ).ToList().First();
            slots.Capacity = slots.Capacity - CAPACITY_DOWN;
            entity.dataClassContext.SubmitChanges();
            return slots;
        }

        public Boolean GetControlCapatity()
        {
            var slots = new Entity();
            var result = slots.dataClassContext.Slots.Any(x =>
                    x.Id.Equals(this.ID)
                    && x.Capacity.Equals(MINIMUM_CAPACITY));
            return result;
        }
    }
}