using System.Collections.Generic;

namespace RotMG_Economy
{
    public class Offer
    {
        public List<Item> sellOffer { get; set; }
        public List<Item> buyOffer { get; set; }
        
        public Offer()
        {
            sellOffer = new List<Item>();
            buyOffer = new List<Item>();
        }
    }
}
