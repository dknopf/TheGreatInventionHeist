using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class GetLearnMoreText
{

    public Dictionary<string, Dictionary<string, (string, string)>> markerDict = new Dictionary<string, Dictionary<string, (string, string)>>();

    public Dictionary<string, (string, string)> Level0_0Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level1_1Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level1_2Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level1_3Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level2_1Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level2_2Dict = new Dictionary<string, (string, string)>();
    public Dictionary<string, (string, string)> Level2_3Dict = new Dictionary<string, (string, string)>();





    string Level0_0 = "Level0_0/Diagrams/";
    string Level1_1 = "Level1_1/Diagrams/";
    string Level1_2 = "Level1_2/Diagrams/";
    string Level1_3 = "Level1_3/Diagrams/";
    string Level2_1 = "Level2_1/Diagrams/";
    string Level2_2 = "Level2_2/Diagrams/";
    string Level2_3 = "Level2_3/Diagrams/";

    public GetLearnMoreText()
    {
        SetUpDict();
    }

    public void SetUpDict()
    {
        //Level0_0
        Level0_0Dict.Add(DialogueConstants.Level0_0.capsuleScreen, (DialogueConstants.Level0_0.capsuleMaterial, Level0_0 + "0_0diagram1"));

        //Level1_1
        Level1_1Dict.Add(DialogueConstants.Level1_1.bodyBallast, (DialogueConstants.Level1_1.airWeight, Level1_1 + "1_1diagram1"));
        Level1_1Dict.Add(DialogueConstants.Level1_1.steerableBodyBallast, (DialogueConstants.Level1_1.airWeight, Level1_1 + "1_1diagram1"));
        Level1_1Dict.Add(DialogueConstants.Level1_1.heliumCanvas, (DialogueConstants.Level1_1.lighterThanAirTravel, Level1_1 + "1_1diagram2"));
        Level1_1Dict.Add(DialogueConstants.Level1_1.heliumBody, (DialogueConstants.Level1_1.lighterThanAirTravel, Level1_1 + "1_1diagram2"));
        Level1_1Dict.Add(DialogueConstants.Level1_1.hydrogenCanvas, (DialogueConstants.Level1_1.lighterThanAirTravel, Level1_1 + "1_1diagram2"));
        Level1_1Dict.Add(DialogueConstants.Level1_1.hydrogenBody, (DialogueConstants.Level1_1.lighterThanAirTravel, Level1_1 + "1_1diagram2"));

        //Level1_2
        Level1_2Dict.Add(DialogueConstants.Level1_2.frameCloth, (DialogueConstants.Level1_2.wingShape, Level1_2 + "1_2diagram1"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.propellerMotorizedBody, (DialogueConstants.Level1_2.thrust, Level1_2 + "1_2diagram2"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.unsteerableBodyAileron, (DialogueConstants.Level1_2.steering, Level1_2 + "1_2diagram3"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.unsteerableBodyElevator, (DialogueConstants.Level1_2.steering, Level1_2 + "1_2diagram3"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.unsteerableBodyRudder, (DialogueConstants.Level1_2.steering, Level1_2 + "1_2diagram3"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.rollPlaneRudder, (DialogueConstants.Level1_2.steering, Level1_2 + "1_2diagram3"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.turnPlaneAileron, (DialogueConstants.Level1_2.steering, Level1_2 + "1_2diagram3"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.tiltPlaneRudder, (DialogueConstants.Level1_2.steering, Level1_2 + "1_2diagram3"));
        Level1_2Dict.Add(DialogueConstants.Level1_2.turnPlaneElevator, (DialogueConstants.Level1_2.steering, Level1_2 + "1_2diagram3"));

        //Level1_3
        Level1_3Dict.Add(DialogueConstants.Level1_3.combustionChamberFuelSupply, (DialogueConstants.Level1_3.explosionPropulsion, Level1_3 + "1_3diagram1"));
        Level1_3Dict.Add(DialogueConstants.Level1_3.computerCode, (DialogueConstants.Level1_3.codeHistory, Level1_3 + "1_3diagram2"));
        Level1_3Dict.Add(DialogueConstants.Level1_3.oxidizerValvedPetroleum, (DialogueConstants.Level1_3.fireInSpace, Level1_3 + "1_3diagram3"));


        //Level2_1
        Level2_1Dict.Add(DialogueConstants.Level2_1.tungstenFilamentWires, (DialogueConstants.Level2_1.meltingPoint, Level2_1 + "2_1diagram1"));
        Level2_1Dict.Add(DialogueConstants.Level2_1.argonFlammableLightbulb, (DialogueConstants.Level2_1.filamentExplodes, Level2_1 + "2_1diagram2"));
        Level2_1Dict.Add(DialogueConstants.Level2_1.wiredFilamentScrewcapContact, (DialogueConstants.Level2_1.completeCircuit, Level2_1 + "2_1diagram3"));

        //Level2_2
        Level2_2Dict.Add(DialogueConstants.Level2_2.positiveTerminalCathode, (DialogueConstants.Level2_2.electrodeMaterials, Level2_2 + "2_2diagram1"));
        Level2_2Dict.Add(DialogueConstants.Level2_2.negativeTerminalAnode, (DialogueConstants.Level2_2.electrodeMaterials, Level2_2 + "2_2diagram1"));
        Level2_2Dict.Add(DialogueConstants.Level2_2.electrolyteCathodeCasing, (DialogueConstants.Level2_2.electrolyteReaction, Level2_2 + "2_2diagram2"));
        Level2_2Dict.Add(DialogueConstants.Level2_2.casingElectrolyte, (DialogueConstants.Level2_2.electrolyteReaction, Level2_2 + "2_2diagram2"));
        Level2_2Dict.Add(DialogueConstants.Level2_2.anodeCathode, (DialogueConstants.Level2_2.shortCircuit, Level2_2 + "2_2diagram3"));

        //Level2_3

        markerDict.Add("Level0_0", Level0_0Dict);
        markerDict.Add("Level1_1", Level1_1Dict);
        markerDict.Add("Level1_2", Level1_2Dict);
        markerDict.Add("Level1_3", Level1_3Dict);
        markerDict.Add("Level2_1", Level2_1Dict);
        markerDict.Add("Level2_2", Level2_2Dict);
        markerDict.Add("Level2_3", Level2_3Dict);

    }


    public bool CheckAndEmit(string level, string dialogueConstant)
    {
        //Debug.Log("CheckAndEmit opened in getlearnmore");
        try
        {
            var (learnMoreText, pathToDiagram) = markerDict[level][dialogueConstant];
            EventManager.SetDataGroup(GameConstants.LearnMoreInteractionEvent, level, learnMoreText, pathToDiagram);
            EventManager.EmitEvent(GameConstants.LearnMoreInteractionEvent);
            return true;
            //Debug.Log("CheckAndEMit in getmorelearntext emitted event");
        }
        catch (KeyNotFoundException e)
        {
            EventManager.SetDataGroup(GameConstants.LearnMoreInteractionEvent, null, null, null);
            EventManager.EmitEvent(GameConstants.LearnMoreInteractionEvent);
            return false;
            //Debug.Log("Catch keynotfound exception in CheckAndEMit in getLearnMOreTExt");
        }
    }
}
