using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class BoilerColumn : BaseColumn
    {
        public BoilerColumn() : base(5) { return; }

        public override Image GetBaseTexture() { return Resources.boiler; }
    }
}
