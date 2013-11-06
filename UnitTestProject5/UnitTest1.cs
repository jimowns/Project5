using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Klasses.Connection;
using WebApplication1.Klasses.Algemeen;

namespace UnitTestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var entity = new Entity();
            int aantal_buttons = entity.DB_Slots.Count;
            var buttons = new ButtonGenerator(aantal_buttons);

            for (int i = 0; i < aantal_buttons; i++)
            {
               // Panel1.Controls.Add(buttons.WriteButton(i, entity.DB_Slots.ElementAt(i).ID.ToString()));
                buttons.ClickSlots(i);
            }
        }
    }
}
