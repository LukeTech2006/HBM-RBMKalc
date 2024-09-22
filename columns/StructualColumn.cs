using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class StructualColumn : BaseColumn
    {
        public StructualColumn() : base(1) { return; }

        public override Image GetBaseTexture() { return Resources.blank; }
    }
}