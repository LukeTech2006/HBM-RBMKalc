using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class AutoControlColumn : BaseColumn
    {
        public AutoControlColumn() : base(4) { return; }

        public override Image GetBaseTexture() { return Resources.control_auto; }
    }
}
