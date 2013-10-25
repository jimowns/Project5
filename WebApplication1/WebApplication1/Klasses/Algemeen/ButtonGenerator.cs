using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web;

namespace WebApplication1.Klasses.Algemeen
{
    public class ButtonGenerator
    {
        public Button[,] Bord { set; get; }
        public int GrooteButton { set; get; }
        public int Aantal { set; get; }

        public ButtonGenerator(int aantal)
        {
            this.Aantal = aantal;
        }
    }
}