namespace ProjectStructure.MainDmnsns
{
    public class DesignParameters
    {
        public Guid Id { get; set; }
        public List<Window> Windows { get; set; }
        public List<Door> Doors { get; set; }
        private double lengthWindowOpenings = Calculate();   //длина оконных проемов
        public double LengthWindowOpenings
        {
            get { return lengthWindowOpenings; }
            set { lengthWindowOpenings = value; }
        }  
        public double HeigthWindowOpenings { get; set; }   //высота оконных проемов
        public double PerimeterWindowOpenings { get; set; }
        public double AreaWindowOpenings { get; set; }
        public double QuantityWindows { get; set; }
        public double LengthAtticWindowOpenings { get; set; }  //длина мансардных оконных проемов
        public double HeigthAtticWindowOpenings { get; set; }
        public double PerimeterAtticWindowOpenings { get; set; }
        public double AreaAtticWindowOpenings { get; set; }
        public double QuantityAtticWindows { get; set; }
        public double DoorwayLength { get; set; }  //длина дверных проемов наружных
        public double DoorwayHeigh { get; set; }
        public double DoorwayPerimeter { get; set; }
        public double DoorwayArea { get; set; }
        public double DoorwayQuantity { get; set; }
        public double InternalDoorwayLength { get; set; }  //длина дверных проемов внутренних
        public double InternalDoorwayHeigh { get; set; }
        public double InternalDoorwayPerimeter { get; set; }
        public double InternalDoorwayArea { get; set; }
        public double InternalDoorwayQuantity { get; set; }
    }
}