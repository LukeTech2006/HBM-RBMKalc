namespace HBM_RBMKalc.fuels
{
    internal class HENp_237 : BaseFuel
    {
        public HENp_237() : base("HENp-237", 100000000, false, "sqrt(x) * 40 / 10", new FunctionType().SQUARE_ROOT, "x * 0.5", "x² * 50", 0.01, 0.02 * 0.5, 2800)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return Math.Sqrt(InFlux) * 40.0 / 10.0;
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
