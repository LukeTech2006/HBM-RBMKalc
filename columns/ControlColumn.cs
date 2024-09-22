using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class ControlColumn : BaseColumn
    {

        public ControlColumn(bool isModerated = false) : base(3) { return; }

        public override Image GetBaseTexture() { return Resources.control; }
    }
}
