namespace HBM_RBMKalc.dials
{
    internal class RBMKDials
    {
        public double dialPassiveCooling = 1.0;
        public double dialColumnHeatFlow = 0.2;
        public double dialDiffusionMod = 1.0;
        public double dialHeatProvision = 0.2;
        public double dialBoilerHeatConsumption = 0.1;
        public double dialControlSpeed = 1.0;
        public double dialReactivityMod = 1.0;
        public double dialControlSurgeMod = 1.0;
        public double dialFluxRange = 5.0;
        public double dialReasimRange = 10.0;
        public double dialReasimCount = 6.0;
        public double dialReasimOutputMod = 1.0;
        public bool dialReasimBoilers = false;
        public double dialReasimBoilerSpeed = 0.05;
        public bool dialDisableMeltdowns = false;
        public bool dialEnableMeltdownOverpressure = false;
    }
}
