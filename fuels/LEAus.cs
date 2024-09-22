namespace HBM_RBMKalc.fuels
{
    internal class LEAus : BaseFuel
    {
        public LEAus() : base("LEAus", 1000000000, true, "30 / (1 + e^(-(x - 50)) / 10)", new FunctionType().SIGMOID, "x * 0.5", "x² * 50", 0.015, 0.02 * 0.5, 7029)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return InFlux / 100.0 * 20.0;
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
