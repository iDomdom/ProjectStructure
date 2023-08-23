namespace ProjectStructure.MainDmnsns
{
    public class AtticFloor
    {
        public Guid Id { get; set; }
        public double LenghtSlope { get; set; }  //Длина наружных стен этажа со стороны скатов, м
        public double LenghtGable { get; set; }  //Длина наружных стен этажа со стороны фронтонов, м
        public double PerimeterExternalWall { get; set; }  //Периметр наружных стен этажа
        public double PerimeterInternalBearingWalls { get; set; }  //Периметр внутренних несущих стен этажа
        public double PerimeterPartition { get; set; }  //Периметр перегородок этажа

        private double raisingRoofFirstSlope;  //Подъем крыши над последним  перекрытием со стороны первого ската
        public double RaisingRoofFirstSlope
        {
            get { return raisingRoofFirstSlope; }
            set
            {
                if (value != raisingRoofFirstSlope)
                {
                    raisingRoofFirstSlope = value;
                    RecalculationAverageRaising();
                }
            }
        }

        private void RecalculationAverageRaising()
        {
            averageRaising = (raisingRoofFirstSlope + raisingRoofSecondSlope) / 2;
        }

        private double raisingRoofSecondSlope;
        public double RaisingRoofSecondSlope
        {
            get { return raisingRoofSecondSlope; }
            set
            {
                if (value != raisingRoofSecondSlope)
                {
                    raisingRoofSecondSlope = value;
                    RecalculationAverageRaising();
                }
            }
        }
        private double averageRaising;
        public double AverageRaising
        {
            get { return averageRaising; }
            set { averageRaising = value; }
        }
    }
}