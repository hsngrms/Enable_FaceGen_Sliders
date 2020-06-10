using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace Enable_FaceGen_Sliders
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            new Harmony("hsngrms.enable.facegen.sliders").PatchAll();
            try
            {
                TaleWorlds.Core.FaceGen.ShowDebugValues = true;
            }
            catch
            {
            }
        }
        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage("FaceGen (Body) Sliders enabled"));
        }
    }
}