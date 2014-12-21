using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pexeso.data;
using System.Drawing;

namespace pexeso.logic
{
       
    class Hra
    {
         public List<Karticka> Cards = new List<Karticka>();
         public List<HerniPole> Bars = new List<HerniPole>();
         public Hrac player = new Hrac();
         public Image[] poleObrazku = new Image[4] { 
            Properties.Resources.image2,
            Properties.Resources.image3,
            Properties.Resources.image4,
            Properties.Resources.image5
         };
    
         public Hra () {}

        public void cardsInit()
        {
           for (int i=0; i<4; i++) 
           {
               Karticka card = new Karticka();
               card.Picture = poleObrazku[i];
               card.Selected = false;
               card.CardName = "i";
               card.Count = 0;
               Cards.Add(card);
           }
    
        }

    public void barsInit()
    {
        for (int i=0; i<3; i++){
            for (int j=0; j<3; j++){
                HerniPole bar = new HerniPole();
                bar.BarID = i.ToString() + j.ToString();
                Bars.Add(bar);
            }
        
        }
    }

    public void complete(HerniPole bar)
    {
        foreach (var pole in Bars){
            System.Threading.Thread.Sleep(11); //pro hazeni ruznych cisel
            var rnd = new Random();
            var Luck = rnd.Next(4);
            pole.Card = Cards.ElementAt(Luck);

        }
    
    }


    }
}
