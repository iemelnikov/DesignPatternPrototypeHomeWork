namespace DesignPatternPrototypeHomeWork
{
    /// <summary>
    /// Минеральное озеро
    /// </summary>
    internal class SaltLake : Lake, ICloneable
    {
        /// Солёность
        public float Salinity { get; set; }

        /// <summary>
        /// Тип химического состава
        /// </summary>
        public SaltLakeChemicalType ChemicalType { get; set; }

        public SaltLake(float waterVolume, float surfaceArea, float maxDepth, string name, float salinity, SaltLakeChemicalType chemicalType) : base(waterVolume, surfaceArea, maxDepth, name)
        {
            Salinity = salinity;
            ChemicalType = chemicalType;
        }

        public override SaltLake MyClone()
        {
            return new SaltLake(WaterVolume, SurfaceArea, MaxDepth, Name, Salinity, ChemicalType);
        }

        public override object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"WaterVolume = {WaterVolume}, SurfaceArea = {SurfaceArea}, IsArtificial = {IsArtificial}, MaxDepth = {MaxDepth}, Name= {Name}, Salinity = {Salinity}, ChemicalType = {ChemicalType}";
        }
    }

    /// <summary>
    /// Тип минерального озера по химическому составу
    /// </summary>
    internal enum SaltLakeChemicalType
    {
        /// <summary>
        /// Карбонатное
        /// </summary>
        Carbonate,
        /// <summary>
        /// Cульфатное
        /// </summary>
        Sulfate,
        /// <summary>
        /// Хлоридное
        /// </summary>
        Chloride
    }
}
