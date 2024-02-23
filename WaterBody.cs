namespace DesignPatternPrototypeHomeWork
{
    /// <summary>
    /// Водоём
    /// </summary>
    internal class WaterBody : ICloneable, IMyCloneable<WaterBody>
    {
        public WaterBody(float waterVolume, float surfaceArea, bool isArtificial)
        {
            WaterVolume = waterVolume;
            SurfaceArea = surfaceArea;
            IsArtificial = isArtificial;
        }

        /// <summary>
        /// Объём воды
        /// </summary>
        public float WaterVolume { get; set; }

        /// <summary>
        /// Площадь поверхности
        /// </summary>
        public float SurfaceArea { get; set; }

        /// <summary>
        /// Признак искусственного водоёма
        /// </summary>
        public bool IsArtificial { get; private set; }

        public virtual WaterBody MyClone()
        {
            return new WaterBody(WaterVolume, SurfaceArea, IsArtificial);
        }

        public virtual object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"WaterVolume = {WaterVolume}, SurfaceArea = {SurfaceArea}, IsArtificial = {IsArtificial}";
        }
    }
}
