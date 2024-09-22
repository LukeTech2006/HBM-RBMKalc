namespace HBM_RBMKalc.fuels
{
    internal class HEAm_242m : BaseFuel
    {
        public HEAm_242m() : base("HEAm-242m", 100000000, false, "x / 100 * 45", new FunctionType().LINEAR, "x * 0.5", "x² * 50", 0.02, 0.02 * 0.5, 2386)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return InFlux / 100.0 * 45.0;
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
