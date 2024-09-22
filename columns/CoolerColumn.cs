using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class CoolerColumn : BaseColumn
    {
        public CoolerColumn() : base(11) { return; }

        public override Image GetBaseTexture() { return Resources.cooler; }
    }
}
