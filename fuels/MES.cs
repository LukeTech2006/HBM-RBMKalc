namespace HBM_RBMKalc.fuels
{
    internal class MES : BaseFuel
    {
        public MES() : base("MES", 100000000, false, "(x - x² / 10000) / 100 * 75", new FunctionType().NEGATIVE_QUADRATIC, "x * 0.5", "x² * 50", 0.015, 0.02 * 0.5, 2750)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return (InFlux - Math.Pow(InFlux, 2) / 10000.0) / 100.0 * 75.0;
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
