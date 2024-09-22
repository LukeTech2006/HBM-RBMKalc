using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class ModeratedFuelColumn : BaseColumn
    {
        private bool Moderated;

        public ModeratedFuelColumn() : base(200) { return; }

        public override Image GetBaseTexture() { return Resources.fuel; }
    }
}