namespace HBM_RBMKalc.fuels
{
    internal class MEU_235 : BaseFuel
    {
        public MEU_235() : base("MEU-235", 100000000, false, "log10(x + 1) * 0.5 * 20", new FunctionType().LOGARITHMIC, "x * 0.5", "x² * 50", 0.01, 0.02 * 0.5, 2865)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return Math.Log10(InFlux + 1) * 0.5 * 20.0;
            return 0;
        }

        public double GetSlowFlux(double InFlux, bool IsFastFlux = false)
        {
            return 0;
        }

        private double GetXenonGen(double InFlux)
        {
            return InFlux * 0.5;
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
