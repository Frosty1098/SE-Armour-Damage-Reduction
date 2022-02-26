using System.Collections.Generic;
using System.Linq;
using Sandbox.Definitions;
using VRage.Game.Components;
using System;

namespace CustomOverride
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    public class CustomOverridesCore : MySessionComponentBase
    {
        public override void BeforeStart()
        {
            SetUpdateOrder(MyUpdateOrder.AfterSimulation);
        }

        public override void LoadData()
        {
            CustomOverrideSettings();
        }
		

		 
		
		
        private static void CustomOverrideSettings()
        {

            // Armor Changesefficient
            IEnumerable<MyCubeBlockDefinition> CubeBlockDefinitions =
                MyDefinitionManager.Static.GetAllDefinitions().OfType<MyCubeBlockDefinition>();
            foreach (MyCubeBlockDefinition CubeBlockDefinition in CubeBlockDefinitions)
            {
				if ( CubeBlockDefinition.Id.SubtypeName.Contains ("Armor"))
				{
					
					if ( CubeBlockDefinition.Id.SubtypeName.Contains ("Small"))
					{
						if ( CubeBlockDefinition.Id.SubtypeName.Contains ("Heavy"))
						{
							CubeBlockDefinition.GeneralDamageMultiplier = 0.5f;
							//break;
						}
						else{
							CubeBlockDefinition.GeneralDamageMultiplier = 0.2f;
						}
					}
					else if ( CubeBlockDefinition.Id.SubtypeName.Contains ("Large"))
					{
						if ( CubeBlockDefinition.Id.SubtypeName.Contains ("Heavy"))
						{
							CubeBlockDefinition.GeneralDamageMultiplier = 1.1f;
							//break;
						}
						else{
							CubeBlockDefinition.GeneralDamageMultiplier = 0.7f;
						}
					}

				}					
            }

        }

    }
}