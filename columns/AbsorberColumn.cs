using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class AbsorberColumn : BaseColumn
    {
        public AbsorberColumn() : base(7) { return; }

        public override Image GetBaseTexture() { return Resources.absorber; }
    }
}
