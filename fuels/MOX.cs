namespace HBM_RBMKalc.fuels
{
    internal class MOX : BaseFuel
    {
        public MOX() : base("MOX", 100000000, false, "(1 - e^-x / 25) * 10)", new FunctionType().EULER, "x * 0.5", "x² * 50", 0.0065, 0.02 * 0.5, 3350)
        {
            return;
        }

        public double GetFastFlux(double InFlux, bool IsFastFlux = false)
        {
            if (!IsFastFlux) return (1.0 - Math.Pow(Math.E, -InFlux) / 25.0) * 10.0;
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