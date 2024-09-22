namespace HBM_RBMKalc.fuels
{
    internal class MEPu_239 : BaseFuel
    {
        public MEPu_239() : base("RBMK Fuel", 100000000, true, "sqrt(x + 20) * 35 / 10", new FunctionType().SQUARE_ROOT, "x * 0.5", "x² * 50", 0.0125, 0.02 * 0.5, 2744)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return Math.Sqrt(InFlux + 20) * 35.0 / 10.0;
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
