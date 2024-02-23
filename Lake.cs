namespace DesignPatternPrototypeHomeWork
{
    /// <summary>
    /// Озеро
    /// </summary>
    internal class Lake : WaterBody, ICloneable
    {
        /// Максимальная глубина
        public float MaxDepth { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name {  get; set; }

        public Lake(float waterVolume, float surfaceArea, float maxDepth, string name) : base(waterVolume, surfaceArea, false)
        {
            MaxDepth = maxDepth;
            Name = name;
        }

        public override Lake MyClone()
        {
            return new Lake(WaterVolume, SurfaceArea, MaxDepth, Name);
        }

        public override object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"WaterVolume = {WaterVolume}, SurfaceArea = {SurfaceArea}, IsArtificial = {IsArtificial}, MaxDepth = {MaxDepth}, Name= {Name}";
        }
    }
}
