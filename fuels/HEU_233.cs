namespace HBM_RBMKalc.fuels
{
    internal class HEU_233 : BaseFuel
    {
        public HEU_233() : base("HEU-233", 100000000, false, "x / 100 * 27.5", new FunctionType().LINEAR, "x * 0.5", "x² * 50", 0.0125, 0.02 * 0.5, 2865)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return InFlux / 100.0 * 27.5;
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
