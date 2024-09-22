using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class FuelColumn : BaseColumn
    {
        public FuelColumn() : base(2) { return; }

        public override Image GetBaseTexture() { return Resources.fuel; }
    }
}