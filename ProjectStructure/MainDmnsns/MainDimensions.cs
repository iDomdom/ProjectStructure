using ProjectStructure.Basements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.MainDmnsns
{
    public class MainDimensions
    {
        public Guid Id { get; set; }
        public List<Floor> Floors { get; set; }
        public AtticFloor? AtticFloor { get; set; }
        
        public int NumberExternalCorners { get; set; }   //Количество внешних углов наружных стен
        public int NumberInterrnalCorners { get; set; }   //Количество внутренних углов наружных стен

        //закоментил для тестов 15.09.2023
        //public OverBasement BasementOverlap { get; set; }  // Перекрытие над подвалом (тех.подпольем)
        //

        public double TerraceArea { get; set; }
        public double BalconyArea { get; set; }
        public DesignParameters DesignParameters { get; set; }  // рассчетные параметры
        

    }
}
