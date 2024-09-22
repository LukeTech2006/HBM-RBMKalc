using HBM_RBMKalc.Properties;

namespace HBM_RBMKalc.columns
{
    internal class ModeratorColumn : BaseColumn
    {
        public ModeratorColumn() : base(6) { return; }

        public override Image GetBaseTexture() { return Resources.moderator; }
    }
}
