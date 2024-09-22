using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class ReflectorColumn : BaseColumn
    {
        public ReflectorColumn() : base(8) { return; }

        public override Image GetBaseTexture() { return Resources.reflector; }
    }
}
