namespace DesignPatternPrototypeHomeWork
{
    /// <summary>
    /// Водохранилище
    /// </summary>
    internal class Reservoir : WaterBody, ICloneable
    {
        /// Амплитуда колебания уровней воды
        public float WaterLevelDeviationAmplitude { get; set; }

        public Reservoir(float waterVolume, float surfaceArea, float waterLevelDeviationAmplitude) : base(waterVolume, surfaceArea, true)
        {
            WaterLevelDeviationAmplitude = waterLevelDeviationAmplitude;
        }

        public override Reservoir MyClone()
        {
            return new Reservoir(WaterVolume, SurfaceArea, WaterLevelDeviationAmplitude);
        }

        public override object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"WaterVolume = {WaterVolume}, SurfaceArea = {SurfaceArea}, IsArtificial = {IsArtificial}, WaterLevelDeviationAmplitude = {WaterLevelDeviationAmplitude}";
        }
    }
}
