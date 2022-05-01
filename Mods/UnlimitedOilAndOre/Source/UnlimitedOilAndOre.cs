using ICities;

namespace UnlimitedOilAndOreMod
{
    public class UnlimitedOilAndOre : IUserMod
    {
        public string Name
        {
            get { return "Unlimited Oil And Ore"; }
        }

        public string Description
        {
            get { return "Oil and ore are not reduced from terrain"; }
        }
    }

    public class UnlimitedOilAndOreResource : ResourceExtensionBase
    {
        public override void OnAfterResourcesModified(int x, int z, NaturalResource type, int amount)
        {
            if ((type == NaturalResource.Oil || type == NaturalResource.Ore) && amount < 0)
                resourceManager.SetResource(x, z, type, (byte)(resourceManager.GetResource(x, z, type) - amount), false);
        }
    }
}