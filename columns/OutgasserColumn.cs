using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class OutgasserColumn : BaseColumn
    {
        public OutgasserColumn() : base(9) { return; }

        public override Image GetBaseTexture() { return Resources.outgasser; }
    }
}
