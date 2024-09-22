namespace HBM_RBMKalc.fuels
{
    internal class AmericiumZFB : BaseFuel
    {
        public AmericiumZFB() : base("Americium ZFB", 50000000, false, "x / 100 * 20", new FunctionType().LINEAR, "x * 0.5", "x² * 50", 0.0175, 0.02 * 0.5, 2744)
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