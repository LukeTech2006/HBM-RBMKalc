using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class BaseColumn(int id = 0)
    {
        public int Id = id;
        public Point Coords;
        public double Heat;
        public double Steam;
        public double Water;

        public virtual Image GetBaseTexture() { return Resources.empty; }

        public static double GetPassiveHeatDiffusion() => 1.0;
    }
}