namespace GildedRose.Items
{
    public abstract class Item
    {
        public string Name {get; protected set;}
        public int SellIn {get; protected set;}
        public int Quality {get; protected set;}
        
        public Item(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }
        public abstract void Update();
        protected void FloorQualityToZero()
        {
            if (this.Quality < 0)
                this.Quality = 0;
        }
        
        protected void CielQualityToFifty()
        {
            if (this.Quality > 50)
                this.Quality = 50;
        }


    }
}