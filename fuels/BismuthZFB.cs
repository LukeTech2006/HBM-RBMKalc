namespace HBM_RBMKalc.fuels
{
    internal class BismuthZFB : BaseFuel
    {
        public BismuthZFB() : base("Bismuth ZFB", 50000000, false, "sqrt(x) * 20 / 10", new FunctionType().SQUARE_ROOT, "x * 0.5", "x² * 50", 0.0175, 0.02 * 0.5, 2744)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return Math.Sqrt(InFlux) * 20.0 / 10.0;
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