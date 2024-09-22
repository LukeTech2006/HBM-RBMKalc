using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class HeatexColumn : BaseColumn
    {
        public HeatexColumn() : base(11) { return; }

        public override Image GetBaseTexture() { return Resources.heatex; }
    }
}
