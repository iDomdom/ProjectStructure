using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.TechnicalTask
{
    public class TechnicalTask
    {
        public Guid Id { get; set; }   
        public City City { get; set; }
        public Decoration Decoration { get; set; }
        public ExternalEngineeringNetworks ExternalEngineeringNetworks { get; set; }
        public bool IsShrinkConstruction { get; set; }
        public bool IsVaporarium { get; set; }
        public bool IsKilnDriedLumber { get; set; }  //Пиломатериалы камерной сушки
        public bool IsRentingVehicles { get; set; }  //Учесть в смете стоимость аренды автомобильной техники отдельным разделом?
        public bool IsRentingBytovka { get; set; }  //Учесть в смете стоимость аренды инвентарных бытовых сооружений отдельным разделом?
    }
}
