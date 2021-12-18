class Box
{
    private double Width;
    private double Height;
    private double Depth;
    public Box(double Width, double Height, double Depth)
    {
        this.Width = Width;
        this.Height = Height;
        this.Depth = Depth;
    }
    class WeightBox : Box
    {
        private double Weight;
        public WeightBox(double Width, double Height, double Depth, double Weight) : base(Width, Height, Depth)
        {
            this.Weight = Weight;
        }
    }
    class BoxManager
    {
        public static void Main(String[] args)
        {
            WeightBox box = new WeightBox(2.0, 3.0, 5.0, 125.5);
        }
    }
}