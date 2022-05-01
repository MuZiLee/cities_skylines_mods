using System;
using System.IO;
using System.Reflection;
using ICities;
using UnityEngine;

namespace UnlimitedMoneyMod
{
    public class UnlimitedMoney : IUserMod {

        public string Name {
            get { return "Unlimited Money"; }
        }

        public string Description {
            get { return "Money never runs out"; }
        }
    }

     public class UnlimitedMoneyEconomy : EconomyExtensionBase {

         public override long OnUpdateMoneyAmount(long internalMoneyAmount) {
             return long.MaxValue;
         }

         public override bool OverrideDefaultPeekResource {
             get { return true; }
         }

         public override int OnPeekResource(EconomyResource resource, int amount) {
             return amount;
         }

     }
} 