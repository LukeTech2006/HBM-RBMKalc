namespace HBM_RBMKalc.simcore
{
    internal class SimulationStatusReport
    {
        public required double FastFlux;
        public required double SlowFlux;
        public required double AverageColumnTemperature;
        public required double AverageFuelTemperature;
        public required double AverageFuelDepletion;
        public required double AverageXenonLevel;
        public required SimulationStatusReportDetails[,] Details;
    }
}
