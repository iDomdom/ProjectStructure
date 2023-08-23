namespace ProjectStructure.MainDmnsns
{
    public class Window
    {
        public Guid Id { get; set; }        
        public bool IsAtticWindow { get; set; }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    RecalculatePerimeterAndArea();
                }
            }
        }

        private double length;
        public double Length
        {
            get { return length; }
            set 
            { 
                if (length != value) 
                { 
                    length = value;
                    RecalculatePerimeterAndArea();
                }
            }
        }
        private double heigh;
        public double Heigh
        {
            get { return heigh; }
            set
            {
                if (heigh != value)
                {
                    heigh = value;
                    RecalculatePerimeterAndArea();
                }
            }
        }
        private double summaryArea;
        public double SummaryArea
        {
            get { return summaryArea; }
            set { if (summaryArea != value) summaryArea = value; }
        }

        private double summaryPerimeter;
        public double SummaryPerimeter
        {
            get { return summaryPerimeter; }
            set { if(summaryPerimeter != value) summaryPerimeter = value; }
        }

        private void RecalculatePerimeterAndArea()
        {
            summaryArea = length * heigh * quantity;
            summaryPerimeter = (length * 2 + heigh * 2) * quantity;
        }
    }
}

