namespace GildedRose.Items
{
    public class GenericItem : Item
    {
         public GenericItem(string name, int sellIn, int quality)
            : base(name, sellIn, quality)
        { }

       public override void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }

        private void UpdateSellIn()
        {
            this.SellIn--;
        }
        
        private void UpdateQuality()
        {
             if (this.SellIn < 0)
                this.Quality--;
                
            this.Quality--;


            FloorQualityToZero();
            CielQualityToFifty();
        }
    }
}
