namespace HBM_RBMKalc.fuels
{
    internal class BaseFuel(string Name, int Yield, bool SelfIgniting, string FluxFunction, int FunctionType, string XenonGenFunction, string XenonBurnFunction, double HeatPerTickPerFlux, double Diffusion, int SkinMeltingPoint)
    {
        public string Name = Name;
        public int Yield = Yield;
        public bool SelfIgniting = SelfIgniting;
        public string FluxFunction = FluxFunction;
        public int FunctionType = FunctionType;
        public string XenonGenFunction = XenonGenFunction;
        public string XenonBurnFunction = XenonBurnFunction;
        public double HeatPerTickPerFlux = HeatPerTickPerFlux;
        public double Diffusion = Diffusion;
        public int SkinMeltingPoint = SkinMeltingPoint;

        public override string ToString()
        {
            return this.Name;
        }
    }
}
