using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTooltip
{

    public Dictionary<string, Dictionary<string, string>> tooltipMasterDict = new Dictionary<string, Dictionary<string, string>>();

    public Dictionary<string, string> level0_0TooltipDict = new Dictionary<string, string>();
    public Dictionary<string, string> level1_1TooltipDict = new Dictionary<string, string>();
    public Dictionary<string, string> level1_2TooltipDict = new Dictionary<string, string>();
    public Dictionary<string, string> level1_3TooltipDict = new Dictionary<string, string>();
    public Dictionary<string, string> level2_1TooltipDict = new Dictionary<string, string>();
    public Dictionary<string, string> level2_2TooltipDict = new Dictionary<string, string>();
    public Dictionary<string, string> level2_3TooltipDict = new Dictionary<string, string>();

    public GetTooltip()
    {
        SetUpDict();
    }

    void SetUpDict()
    {
        level0_0TooltipDict.Add("frameProp", DialogueConstants.Level0_0.frameTooltip);
        level0_0TooltipDict.Add("sidingProp", DialogueConstants.Level0_0.sidingTooltip);
        level0_0TooltipDict.Add("screenProp", DialogueConstants.Level0_0.screenTooltip);
        level0_0TooltipDict.Add("warpGeneratorProp", DialogueConstants.Level0_0.warpGeneratorTooltip);
        level0_0TooltipDict.Add("fluxAntennaProp", DialogueConstants.Level0_0.fluxAntennaTooltip);

        level1_1TooltipDict.Add("heliumProp", DialogueConstants.Level1_1.heliumTooltip);
        level1_1TooltipDict.Add("hydrogenProp", DialogueConstants.Level1_1.hydrogenTooltip);
        level1_1TooltipDict.Add("canvasProp", DialogueConstants.Level1_1.canvasTooltip);
        level1_1TooltipDict.Add("frameProp", DialogueConstants.Level1_1.frameTooltip);
        level1_1TooltipDict.Add("motorProp", DialogueConstants.Level1_1.motorTooltip);
        level1_1TooltipDict.Add("airProp", DialogueConstants.Level1_1.airTooltip);
        level1_1TooltipDict.Add("tankProp", DialogueConstants.Level1_1.tankTooltip);
        level1_1TooltipDict.Add("tailfinProp", DialogueConstants.Level1_1.tailfinTooltip);


        level1_2TooltipDict.Add("wheelsProp", DialogueConstants.Level1_2.wheelsTooltip);
        level1_2TooltipDict.Add("propellerProp", DialogueConstants.Level1_2.propellerTooltip);
        level1_2TooltipDict.Add("engineProp", DialogueConstants.Level1_2.engineTooltip);
        level1_2TooltipDict.Add("fuelProp", DialogueConstants.Level1_2.fuelTooltip);
        level1_2TooltipDict.Add("frameProp", DialogueConstants.Level1_2.frameTooltip);
        level1_2TooltipDict.Add("clothProp", DialogueConstants.Level1_2.clothTooltip);
        level1_2TooltipDict.Add("aileronProp", DialogueConstants.Level1_2.aileronTooltip);
        level1_2TooltipDict.Add("elevatorProp", DialogueConstants.Level1_2.elevatorTooltip);
        level1_2TooltipDict.Add("rudderProp", DialogueConstants.Level1_2.rudderTooltip);
        level1_2TooltipDict.Add("waterProp", DialogueConstants.Level1_2.waterTooltip);


        level1_3TooltipDict.Add("payloadProp", DialogueConstants.Level1_3.payloadTooltip);
        level1_3TooltipDict.Add("oxidizerProp", DialogueConstants.Level1_3.oxidizerTooltip);
        level1_3TooltipDict.Add("petroleumProp", DialogueConstants.Level1_3.petroleumTooltip);
        level1_3TooltipDict.Add("heliumProp", DialogueConstants.Level1_3.heliumTooltip);
        level1_3TooltipDict.Add("finsProp", DialogueConstants.Level1_3.finsTooltip);
        level1_3TooltipDict.Add("igniterProp", DialogueConstants.Level1_3.igniterTooltip);
        level1_3TooltipDict.Add("emptyChamberProp", DialogueConstants.Level1_3.emptyChamberTooltip);
        level1_3TooltipDict.Add("valvesProp", DialogueConstants.Level1_3.valvesTooltip);
        level1_3TooltipDict.Add("launchProp", DialogueConstants.Level1_3.launchTooltip);
        level1_3TooltipDict.Add("computerProp", DialogueConstants.Level1_3.computerTooltip);
        level1_3TooltipDict.Add("codeProp", DialogueConstants.Level1_3.codeTooltip);
        level1_3TooltipDict.Add("frameProp", DialogueConstants.Level1_3.frameTooltip);



        level2_1TooltipDict.Add("tungstenFilamentProp", DialogueConstants.Level2_1.tungstenFilamentTooltip);
        level2_1TooltipDict.Add("aluminumFilamentProp", DialogueConstants.Level2_1.aluminumFilamentTooltip);
        level2_1TooltipDict.Add("wiresProp", DialogueConstants.Level2_1.wiresTooltip);
        level2_1TooltipDict.Add("glassShellProp", DialogueConstants.Level2_1.glassShellTooltip);
        level2_1TooltipDict.Add("argonProp", DialogueConstants.Level2_1.argonTooltip);
        level2_1TooltipDict.Add("screwcapProp", DialogueConstants.Level2_1.screwcapTooltip);
        level2_1TooltipDict.Add("electricalContactProp", DialogueConstants.Level2_1.electricalContactTooltip);
        level2_1TooltipDict.Add("lampProp", DialogueConstants.Level2_1.lampTooltip);


        level2_2TooltipDict.Add("positiveTerminalProp", DialogueConstants.Level2_2.positiveTerminalTooltip);
        level2_2TooltipDict.Add("negativeTerminalProp", DialogueConstants.Level2_2.negativeTerminalTooltip);
        level2_2TooltipDict.Add("casingProp", DialogueConstants.Level2_2.casingTooltip);
        level2_2TooltipDict.Add("anodeProp", DialogueConstants.Level2_2.anodeTooltip);
        level2_2TooltipDict.Add("cathodeProp", DialogueConstants.Level2_2.cathodeTooltip);
        level2_2TooltipDict.Add("sulfuricAcidProp", DialogueConstants.Level2_2.sulfuricAcidTooltip);
        level2_2TooltipDict.Add("waterProp", DialogueConstants.Level2_2.waterTooltip);
        level2_2TooltipDict.Add("metalSeparatorProp", DialogueConstants.Level2_2.metalSeparatorTooltip);
        level2_2TooltipDict.Add("clothSeparatorProp", DialogueConstants.Level2_2.clothSeparatorTooltip);
        level2_2TooltipDict.Add("flashlightProp", DialogueConstants.Level2_2.flashlightTooltip);


        //Add each level dict to the master dict
        tooltipMasterDict.Add("Level0_0", level0_0TooltipDict);
        tooltipMasterDict.Add("Level1_1", level1_1TooltipDict);
        tooltipMasterDict.Add("Level1_2", level1_2TooltipDict);
        tooltipMasterDict.Add("Level1_3", level1_3TooltipDict);
        tooltipMasterDict.Add("Level2_1", level2_1TooltipDict);
        tooltipMasterDict.Add("Level2_2", level2_2TooltipDict);



    }

    public string getTooltip(string level, string propName)
    {
        string tooltip;
        try{
            tooltip = tooltipMasterDict[level][propName];
        }
        catch(KeyNotFoundException e)
        {
            tooltip = "An essential part of the final invention.";
        }
        return tooltip;
    }

}
