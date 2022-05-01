using ICities;
using UnityEngine;

namespace YourModNamespaceHere 
{

    public class YourModName : IUserMod 
    {

        public string Name 
        {
            get { return "Your mod"; }
        }

        public string Description 
        {
            get { return "Your mod description"; }
        }
    }

    // Inherit interfaces and implement your mod logic here
    // You can use as many files and subfolders as you wish to organise your code, as long
    // as it remains located under the Source folder.
}
