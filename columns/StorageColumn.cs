using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class StorageColumn : BaseColumn
    {
        public StorageColumn() : base(10) { return; }

        public override Image GetBaseTexture() { return Resources.storage; }
    }
}
