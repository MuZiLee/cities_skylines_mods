using ICities;

namespace UnlimitedSoilMod
{
    public class UnlimitedSoil : IUserMod
    {
        public string Name
        {
            get { return "Unlimited Soil"; }
        }

        public string Description
        { 
            get { return "Landscaping without limits"; } 
        }
    }

    public class UnlimitedSoilResource : ResourceExtensionBase
    {
        int m_DirtAmount;

        public override void OnCreated(IResource resource)
        {
            base.OnCreated(resource);
            m_DirtAmount = resource.maxDirt / 2;
        }

        public override int OnGetDirt(int amount)
        {
            return m_DirtAmount;
        }
    }
}