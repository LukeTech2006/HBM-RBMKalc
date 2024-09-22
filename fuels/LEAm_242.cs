namespace HBM_RBMKalc.fuels
{
    internal class LEAm_242 : BaseFuel
    {
        public LEAm_242() : base("LEAm-242", 100000000, true, "sqrt(x + 10) * 60 / 10", new FunctionType().SQUARE_ROOT, "x * 0.5", "x² * 50", 0.015, 0.02 * 0.5, 2386)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return Math.Sqrt(InFlux + 10) * 60.0 / 10.0;
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