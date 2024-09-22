namespace HBM_RBMKalc.fuels
{
    internal class MEAm_242m : BaseFuel
    {
        public MEAm_242m() : base("MEAm-242m", 100000000, true, "((x + 20) - (x + 20)² / 10000) / 10 * 0.35", new FunctionType().NEGATIVE_QUADRATIC, "x * 0.5", "x² * 50", 0.0175, 0.02 * 0.5, 2386)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return ((InFlux + 20.0) - Math.Pow((InFlux + 20.0), 2) / 10000.0) / 10.0 * 0.35;
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
