namespace ProjectStructure.TechnicalTask
{
    public class ExternalEngineeringNetworks
    {
        public Guid Id { get; set; }
        public bool IsOutdoorPowerSystem { get; set; }
        public bool IsOutdoorWaterSystem { get; set; }
        public bool IsOutdoorSewerageSystem { get; set; }
        public bool IsDrainageSystem { get; set; }
    }
}