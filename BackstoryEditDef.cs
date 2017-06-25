using RimWorld;
using Verse;

namespace BackstoryEditor
{
    public class BackstoryEditDef : Def
    {
        public string backstoryName;
        public string backstoryDescription;


        public override void ResolveReferences()
        {
            base.ResolveReferences();
            if (BackstoryDatabase.TryGetWithIdentifier(this.backstoryName, out Backstory bs))
                bs.baseDesc = this.backstoryDescription;
        }
    }
}