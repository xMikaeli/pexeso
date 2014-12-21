using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pexeso.data;

namespace pexeso.logic
{
       
    class Hra
    {
         public List<Karticka> Cards = new List<Karticka>();
         public List<HerniPole> Bars = new List<HerniPole>();
         public Hrac player = new Hrac();
    
         public Hra () {}

    public void cardsInit()
    {
       for (int i=1; i<=4; i++) 
       {
       Karticka card = new Karticka();
       card.Picture = Properties.Resources.Image1;
       card.Selected = false;
       card.CardName = "i";
       Cards.Add(card);
       }
    
    }

    public void poleinit()
    {
        for (int i=1; i<=8; i++)
        {
        HerniPole pole = new HerniPole();
        pole.BarID =
        pole.add(pole);
    
        }
    
    
    }
    

    }
}
