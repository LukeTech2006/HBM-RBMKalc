namespace HBM_RBMKalc.fuels
{
    internal class Flashlead : BaseFuel
    {
        public Flashlead() : base("Flashlead", 100000000, true, "((x + 50) - (x + 50)² / 10000) / 100 * 40", new FunctionType().NEGATIVE_QUADRATIC, "x * 0", "x² * 50", 0.01, 0.02 * 0.5, 2050)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return ((InFlux + 50) - Math.Pow(InFlux + 50, 2) / 10000) / 100 * 40;
            return 0;
        }

        public double GetSlowFlux(double InFlux, bool IsFastFlux = false)
        {
            return 0;
        }

        private double GetXenonGen(double InFlux)
        {
            return InFlux * 0;
        }

        private double GetXenonBurn(double InFlux)
        {
            return Math.Pow(InFlux, 2) * 50.0;
        }

        public double GetXenon(double InFlux)
        {
            return GetXenonGen(InFlux) - GetXenonBurn(InFlux);
        }
    }
}
