namespace HBM_RBMKalc.fuels
{
    internal class Balefire : BaseFuel
    {
        public Balefire() : base("Balefire", 100000000, true, "(x + 35) / 100 * 100", new FunctionType().LINEAR, "x * 0", "x² * 50", 0.03, 0.02 * 0.5, 3652)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return (InFlux + 35) / 100 * 100;
            return 0;
        }

        public double GetSlowFlux(double InFlux, bool IsFastFlux = false)
        {
            return 0;
        }

        private double GetXenonGen(double InFlux)
        {
            return InFlux * 0;
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
