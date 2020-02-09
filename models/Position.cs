namespace hohsys.API.models
{
    // Position catalog for employees responsabilities description
    public class Position: MyEntity
    {
        public string PositionName { get; set; }
        public string Description { get; set; }
        public virtual Employee Employee { get; set; }
    }
}