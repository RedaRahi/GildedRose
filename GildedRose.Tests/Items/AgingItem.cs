namespace GildedRose.Items
{
    public class AgingItem : Item
    { 
        public AgingItem(string name , int sellIn, int quality) 
            : base(name, sellIn, quality)
        { }

        public override void Update()
        {
            this.UpdateSellIn();
            this.UpdateQuality();
        }

        private void UpdateSellIn()
        {
            this.SellIn--; 
        }

         private void UpdateQuality()
        {
            this.Quality++;


            FloorQualityToZero();
            CielQualityToFifty();
        
        }
    }
}