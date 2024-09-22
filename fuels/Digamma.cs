namespace HBM_RBMKalc.fuels
{
    internal class Digamma : BaseFuel
    {
        public Digamma() : base("Digamma", 100000000, true, "(x + 10)² / 10000 * 1000", new FunctionType().QUADRATIC, "x * 0.5", "x² * 50", 0.01, 0.02 * 0.5, 100000)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return Math.Pow(InFlux + 10, 2) / 10000 * 1000;
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
