using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class ModeratedControlColumn : BaseColumn
    {

        public ModeratedControlColumn() : base(300) { return; }

        public override Image GetBaseTexture() { return Resources.control; }
    }
}
