namespace ProjectStructure.MainDmnsns
{
    public class Floor
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public double LenghtSlope { get; set; }  //Длина наружных стен этажа со стороны скатов, м
        public double LenghtGable { get; set; }  //Длина наружных стен этажа со стороны фронтонов, м
        public double Heigh { get; set; }
        public double PerimeterExternalWall { get; set; }  //Периметр наружных стен этажа
        public double PerimeterInternalBearingWalls { get; set; }  //Периметр внутренних несущих стен этажа
        public double PerimeterPartition { get; set; }  //Периметр перегородок этажа
        public double AreaOverlapping { get; set; }   //площадь Перекрытия над этажом 
    }
}