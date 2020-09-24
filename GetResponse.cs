using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class GetResponse : PropCollisionResponseTable
{


    //Creates a dict where each level (level1_1) has a value that is another dict, called level1_1Dict

    public Dictionary<string, Dictionary<(string, string), (string, string, string)>> levelDict = new Dictionary<string, Dictionary<(string, string), (string, string, string)>>();


    //The dictionaries of collisions, one for each level so that duplicate names are allowed
    public Dictionary<(string, string), (string, string, string)> level0_0Dict = new Dictionary<(string, string), (string, string, string)>();
    public Dictionary<(string, string), (string, string, string)> level1_1Dict = new Dictionary<(string, string), (string, string, string)>();
    public Dictionary<(string, string), (string, string, string)> level1_2Dict = new Dictionary<(string, string), (string, string, string)>();
    public Dictionary<(string, string), (string, string, string)> level1_3Dict = new Dictionary<(string, string), (string, string, string)>();
    public Dictionary<(string, string), (string, string, string)> level2_1Dict = new Dictionary<(string, string), (string, string, string)>();
    public Dictionary<(string, string), (string, string, string)> level2_2Dict = new Dictionary<(string, string), (string, string, string)>();
    public Dictionary<(string, string), (string, string, string)> level2_3Dict = new Dictionary<(string, string), (string, string, string)>();



    public GetLearnMoreText learnMore = new GetLearnMoreText();

    //A constructor, is called
    public GetResponse()
    {
        SetUpDict();
    }

    void SetUpDict()
    {
        //.Add can only be called within a function


        //Level0_0

            //Misfires
        level0_0Dict.Add(("frameProp", "screenProp"), (MisfireResponseID, DialogueConstants.Level0_0.frameScreen, null));
        level0_0Dict.Add(("frameProp", "warpGeneratorProp"), (MisfireResponseID, DialogueConstants.Level0_0.frameWarpGenerator, null));
        level0_0Dict.Add(("sidingProp", "screenProp"), (MisfireResponseID, DialogueConstants.Level0_0.sidingScreen, null));
        level0_0Dict.Add(("sidingProp", "warpGeneratorProp"), (MisfireResponseID, DialogueConstants.Level0_0.sidingWarpGenerator, null));
        level0_0Dict.Add(("screenProp", "warpGeneratorProp"), (MisfireResponseID, DialogueConstants.Level0_0.screenWarpGenerator, null));
        level0_0Dict.Add(("fluxAntennaProp", "capsuleProp"), (MisfireResponseID, DialogueConstants.Level0_0.fluxAntennaCapsule, null));
        level0_0Dict.Add(("fluxAntennaProp", "screenProp"), (MisfireResponseID, DialogueConstants.Level0_0.fluxAntennaScreen, null));
        level0_0Dict.Add(("fluxAntennaProp", "screenCapsuleProp"), (MisfireResponseID, DialogueConstants.Level0_0.fluxAntennaScreenCapsule, null));
        level0_0Dict.Add(("fluxAntennaProp", "warpGeneratorProp"), (MisfireResponseID, DialogueConstants.Level0_0.fluxAntennaWarpGenerator, null));
        level0_0Dict.Add(("fluxAntennaProp", "warpCapsuleProp"), (MisfireResponseID, DialogueConstants.Level0_0.fluxAntennaWarpCapsule, null));
        level0_0Dict.Add(("fluxAntennaProp", "sidingProp"), (MisfireResponseID, DialogueConstants.Level0_0.fluxAntennaSiding, null));
        level0_0Dict.Add(("fluxAntennaProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level0_0.fluxAntennaFrame, null));

            //Successess
        level0_0Dict.Add(("frameProp", "sidingProp"), (PropMergeResponseID, DialogueConstants.Level0_0.frameSiding, PropPrefabNames.Level0_0.capsuleProp));
        level0_0Dict.Add(("capsuleProp", "screenProp"), (PropMergeResponseID, DialogueConstants.Level0_0.capsuleScreen, PropPrefabNames.Level0_0.screenCapsuleProp));
        level0_0Dict.Add(("capsuleProp", "warpGeneratorProp"), (PropMergeResponseID, DialogueConstants.Level0_0.capsuleWarpGenerator, PropPrefabNames.Level0_0.warpCapsuleProp));
        level0_0Dict.Add(("warpCapsuleProp", "screenProp"), (PropMergeResponseID, DialogueConstants.Level0_0.warpCapsuleScreen, PropPrefabNames.Level0_0.finalTimeMachineProp));
        level0_0Dict.Add(("screenCapsuleProp", "warpGeneratorProp"), (PropMergeResponseID, DialogueConstants.Level0_0.screenCapsuleWarpGenerator, PropPrefabNames.Level0_0.finalTimeMachineProp));
        
        //Level1_1

            //Misfires
        level1_1Dict.Add(("heliumProp", "tankProp"), (MisfireResponseID, DialogueConstants.Level1_1.heliumTank, null));
        level1_1Dict.Add(("heliumProp", "canvasProp"), (MisfireResponseID, DialogueConstants.Level1_1.heliumCanvas, PropPrefabNames.Level1_1.canvasFloatProp));
        level1_1Dict.Add(("heliumProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.heliumBody, PropPrefabNames.Level1_1.bodyFloatProp));
        level1_1Dict.Add(("heliumProp", "ballastProp"), (MisfireResponseID, DialogueConstants.Level1_1.heliumBallast, null));
        level1_1Dict.Add(("heliumProp", "steerableBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.heliumSteerableBody, PropPrefabNames.Level1_1.steerableBodyFloatProp));
        level1_1Dict.Add(("heliumProp", "weightedBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.heliumWeightedBody, null));
        level1_1Dict.Add(("heliumProp", "emptyBlimpProp"), (PropMergeResponseID, DialogueConstants.Level1_1.heliumEmptyBlimp, PropPrefabNames.Level1_1.finalBlimpProp));
        level1_1Dict.Add(("hydrogenProp", "canvasProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenCanvas, PropPrefabNames.Level1_1.canvasFloatProp));
        level1_1Dict.Add(("hydrogenProp", "tankProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenTank, null));
        level1_1Dict.Add(("hydrogenProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenBody, PropPrefabNames.Level1_1.bodyFloatProp));
        level1_1Dict.Add(("hydrogenProp", "ballastProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenBallast, null));
        level1_1Dict.Add(("hydrogenProp", "steerableBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenSteerablebody, PropPrefabNames.Level1_1.steerableBodyFireProp));
        level1_1Dict.Add(("hydrogenProp", "weightedBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenWeightedBody, PropPrefabNames.Level1_1.weightedBodyFireProp));
        level1_1Dict.Add(("hydrogenProp", "emptyBlimpProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenEmptyBlimp, PropPrefabNames.Level1_1.emptyBlimpFireProp));
        level1_1Dict.Add(("tailfinProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_1.tailfinFrame, null));
        level1_1Dict.Add(("motorProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_1.motorFrame, null));
        level1_1Dict.Add(("tailfinProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.tailfinBody, null));
        level1_1Dict.Add(("motorProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.motorBody, null));
        level1_1Dict.Add(("airProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.airBody, null));
        level1_1Dict.Add(("airProp", "weightedBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.airWeightedBody, null));
        level1_1Dict.Add(("airProp", "steerableWeightedBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.airSteerableWeightedBody, null));
        level1_1Dict.Add(("airProp", "steerableBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.airSteerableBody, null));
        level1_1Dict.Add(("airProp", "emptyBlimpProp"), (MisfireResponseID, DialogueConstants.Level1_1.airEmptyBlimp, null));
        level1_1Dict.Add(("heliumProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_1.heliumFrame, null));
        level1_1Dict.Add(("airProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_1.airFrame, null));
        level1_1Dict.Add(("hydrogenProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_1.hydrogenFrame, null));
        level1_1Dict.Add(("tankProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_1.tankFrame, null));
        level1_1Dict.Add(("tankProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.tankBody, null));
        level1_1Dict.Add(("tankProp", "steerableBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.tankSteerableBody, null));
        level1_1Dict.Add(("tailfinProp", "weightedBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.tailfinWeightedBody, null));
        level1_1Dict.Add(("motorProp", "weightedBodyProp"), (MisfireResponseID, DialogueConstants.Level1_1.motorWeightedBody, null));

            //Successess
        level1_1Dict.Add(("frameProp", "canvasProp"), (PropMergeResponseID, DialogueConstants.Level1_1.frameCanvas, PropPrefabNames.Level1_1.bodyProp));
        level1_1Dict.Add(("motorProp", "tailfinProp"), (PropMergeResponseID, DialogueConstants.Level1_1.motorTailfin, PropPrefabNames.Level1_1.steeringMechanismProp));
        level1_1Dict.Add(("airProp", "tankProp"), (PropMergeResponseID, DialogueConstants.Level1_1.airTank, PropPrefabNames.Level1_1.ballastProp));
        //level1_1Dict.Add(("tankProp", "steeringMechanismProp"), (MisfireResponseID, "You need to fill up your ballast tank so your blimp doesn't float away!", null));
        level1_1Dict.Add(("bodyProp", "steeringMechanismProp"), (PropMergeResponseID, DialogueConstants.Level1_1.bodySteeringMechanism, PropPrefabNames.Level1_1.steerableBodyProp));
        level1_1Dict.Add(("bodyProp", "ballastProp"), (PropMergeResponseID, DialogueConstants.Level1_1.bodyBallast, PropPrefabNames.Level1_1.weightedBodyProp));
        level1_1Dict.Add(("steeringMechanismProp", "weightedBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_1.steeringMechanismWeightedBody, PropPrefabNames.Level1_1.emptyBlimpProp));
        level1_1Dict.Add(("steerableBodyProp", "ballastProp"), (PropMergeResponseID, DialogueConstants.Level1_1.steerableBodyBallast, PropPrefabNames.Level1_1.emptyBlimpProp));


        //Level1_2

            //Misfires
        level1_2Dict.Add(("frameProp", "wheelsProp"), (MisfireResponseID, DialogueConstants.Level1_2.frameAnything, null));
        level1_2Dict.Add(("frameProp", "engineProp"), (MisfireResponseID, DialogueConstants.Level1_2.frameAnything, null));
        level1_2Dict.Add(("frameProp", "propellerProp"), (MisfireResponseID, DialogueConstants.Level1_2.frameAnything, null));
        level1_2Dict.Add(("frameProp", "aileronProp"), (MisfireResponseID, DialogueConstants.Level1_2.frameAnything, null));
        level1_2Dict.Add(("frameProp", "rudderProp"), (MisfireResponseID, DialogueConstants.Level1_2.frameAnything, null));
        level1_2Dict.Add(("frameProp", "elevatorProp"), (MisfireResponseID, DialogueConstants.Level1_2.frameAnything, null));
        level1_2Dict.Add(("frameProp", "fueledEngineProp"), (MisfireResponseID, DialogueConstants.Level1_2.frameFueledEngine, null));
        level1_2Dict.Add(("engineProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.engineBody, null));
        level1_2Dict.Add(("engineProp", "wheeledBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.engineWheeledBody, null));
        level1_2Dict.Add(("engineProp", "propellerBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.enginePropellerBody, null));
        level1_2Dict.Add(("engineProp", "wheeledPropellerBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.engineWheeledPropellerBody, null));
        level1_2Dict.Add(("fueledEngineProp", "bodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.fueledEngineBody, PropPrefabNames.Level1_2.overheatEngineProp));
        level1_2Dict.Add(("fueledEngineProp", "wheeledBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.fueledEngineWheeledBody, PropPrefabNames.Level1_2.overheatEngineProp));
        level1_2Dict.Add(("fueledEngineProp", "propellerBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.fueledEnginePropellerBody, PropPrefabNames.Level1_2.overheatEngineProp));
        level1_2Dict.Add(("fueledEngineProp", "wheeledPropellerBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.fueledEngineWheeledPropellerBody, PropPrefabNames.Level1_2.overheatEngineProp));
        level1_2Dict.Add(("aileronProp", "motorizedPropellerBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.aileronMotorizedPropellerBody, null));
        level1_2Dict.Add(("elevatorProp", "motorizedPropellerBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.elevatorMotorizedPropellerBody, null));
        level1_2Dict.Add(("rudderProp", "motorizedPropellerBodyProp"), (MisfireResponseID, DialogueConstants.Level1_2.rudderMotorizedPropellerBody, null));
        level1_2Dict.Add(("bodyProp", "aileronProp"), (MisfireResponseID, DialogueConstants.Level1_2.bodyAileron, null));
        level1_2Dict.Add(("bodyProp", "rudderProp"), (MisfireResponseID, DialogueConstants.Level1_2.bodyRudder, null));
        level1_2Dict.Add(("bodyProp", "elevatorProp"), (MisfireResponseID, DialogueConstants.Level1_2.bodyElevator, null));
        level1_2Dict.Add(("wheeledBodyProp", "aileronProp"), (MisfireResponseID, DialogueConstants.Level1_2.wheeledBodyAileron, null));
        level1_2Dict.Add(("wheeledBodyProp", "rudderProp"), (MisfireResponseID, DialogueConstants.Level1_2.wheeledBodyRudder, null));
        level1_2Dict.Add(("wheeledBodyProp", "elevatorProp"), (MisfireResponseID, DialogueConstants.Level1_2.wheeledBodyElevator, null));
        level1_2Dict.Add(("motorizedBodyProp", "aileronProp"), (MisfireResponseID, DialogueConstants.Level1_2.motorizedBodyAileron, null));
        level1_2Dict.Add(("motorizedBodyProp", "rudderProp"), (MisfireResponseID, DialogueConstants.Level1_2.motorizedBodyRudder, null));
        level1_2Dict.Add(("motorizedBodyProp", "elevatorProp"), (MisfireResponseID, DialogueConstants.Level1_2.motorizedBodyElevator, null));
        level1_2Dict.Add(("propellerBodyProp", "aileronProp"), (MisfireResponseID, DialogueConstants.Level1_2.propellerBodyAileron, null));
        level1_2Dict.Add(("propellerBodyProp", "rudderProp"), (MisfireResponseID, DialogueConstants.Level1_2.propellerBodyRudder, null));
        level1_2Dict.Add(("propellerBodyProp", "elevatorProp"), (MisfireResponseID, DialogueConstants.Level1_2.propellerBodyElevator, null));
        level1_2Dict.Add(("motorizedWheeledBodyProp", "aileronProp"), (MisfireResponseID, DialogueConstants.Level1_2.motorizedWheeledBodyAileron, null));
        level1_2Dict.Add(("motorizedWheeledBodyProp", "rudderProp"), (MisfireResponseID, DialogueConstants.Level1_2.motorizedWheeledBodyRudder, null));
        level1_2Dict.Add(("motorizedWheeledBodyProp", "elevatorProp"), (MisfireResponseID, DialogueConstants.Level1_2.motorizedWheeledBodyElevator, null));
        level1_2Dict.Add(("wheeledPropellerBodyProp", "aileronProp"), (MisfireResponseID, DialogueConstants.Level1_2.wheeledPropellerBodyAileron, null));
        level1_2Dict.Add(("wheeledPropellerBodyProp", "rudderProp"), (MisfireResponseID, DialogueConstants.Level1_2.wheeledPropellerBodyRudder, null));
        level1_2Dict.Add(("wheeledPropellerBodyProp", "elevatorProp"), (MisfireResponseID, DialogueConstants.Level1_2.wheeledPropellerBodyElevator, null));
        level1_2Dict.Add(("fueledEngineProp", "propellerProp"), (MisfireResponseID, DialogueConstants.Level1_2.fueledEnginePropeller, null));

        //Successess
        level1_2Dict.Add(("wheelsProp", "bodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.wheelsBody, PropPrefabNames.Level1_2.wheeledBodyProp));
        level1_2Dict.Add(("wheelsProp", "motorizedBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.wheelsMotorizedBody, PropPrefabNames.Level1_2.motorizedWheeledBodyProp));
        level1_2Dict.Add(("wheelsProp", "propellerBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.wheelsPropellerBody, PropPrefabNames.Level1_2.wheeledPropellerBodyProp));
        level1_2Dict.Add(("wheelsProp", "motorizedPropellerBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.wheelsMotorizedPropellerBody, PropPrefabNames.Level1_2.unsteerableBodyProp));
        level1_2Dict.Add(("propellerProp", "bodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.propellerBody, PropPrefabNames.Level1_2.propellerBodyProp));
        level1_2Dict.Add(("propellerProp", "wheeledBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.propellerWheeledBody, PropPrefabNames.Level1_2.wheeledPropellerBodyProp));
        level1_2Dict.Add(("propellerProp", "motorizedBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.propellerMotorizedBody, PropPrefabNames.Level1_2.motorizedPropellerBodyProp));
        level1_2Dict.Add(("propellerProp", "motorizedWheeledBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.propellerMotorizedWheeledBody, PropPrefabNames.Level1_2.unsteerableBodyProp));
        level1_2Dict.Add(("engineProp", "fuelProp"), (PropMergeResponseID, DialogueConstants.Level1_2.engineFuel, PropPrefabNames.Level1_2.fueledEngineProp));
        level1_2Dict.Add(("frameProp", "clothProp"), (PropMergeResponseID, DialogueConstants.Level1_2.frameCloth, PropPrefabNames.Level1_2.bodyProp));
        level1_2Dict.Add(("unsteerableBodyProp", "aileronProp"), (PropMergeResponseID, DialogueConstants.Level1_2.unsteerableBodyAileron, PropPrefabNames.Level1_2.rollPlaneProp));
        level1_2Dict.Add(("unsteerableBodyProp", "elevatorProp"), (PropMergeResponseID, DialogueConstants.Level1_2.unsteerableBodyElevator, PropPrefabNames.Level1_2.tiltPlaneProp));
        level1_2Dict.Add(("unsteerableBodyProp", "rudderProp"), (PropMergeResponseID, DialogueConstants.Level1_2.unsteerableBodyRudder, PropPrefabNames.Level1_2.turnPlaneProp));
        level1_2Dict.Add(("waterProp", "fueledEngineProp"), (PropMergeResponseID, DialogueConstants.Level1_2.waterFueledEngine, PropPrefabNames.Level1_2.cooledEngineProp));
        level1_2Dict.Add(("cooledEngineProp", "bodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.cooledEngineBody, PropPrefabNames.Level1_2.motorizedBodyProp));
        level1_2Dict.Add(("cooledEngineProp", "wheeledBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.cooledEngineWheeledBody, PropPrefabNames.Level1_2.motorizedWheeledBodyProp));
        level1_2Dict.Add(("cooledEngineProp", "propellerBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.cooledEnginePropellerBody, PropPrefabNames.Level1_2.motorizedPropellerBodyProp));
        level1_2Dict.Add(("cooledEngineProp", "wheeledPropellerBodyProp"), (PropMergeResponseID, DialogueConstants.Level1_2.cooledEngineWheeledPropellerBody, PropPrefabNames.Level1_2.unsteerableBodyProp));
        level1_2Dict.Add(("rollPlaneProp", "elevatorProp"), (PropMergeResponseID, DialogueConstants.Level1_2.rollPlaneElevator, PropPrefabNames.Level1_2.rollTiltPlaneProp));
        level1_2Dict.Add(("rollPlaneProp", "rudderProp"), (PropMergeResponseID, DialogueConstants.Level1_2.rollPlaneRudder, PropPrefabNames.Level1_2.rollTurnPlaneProp));
        level1_2Dict.Add(("tiltPlaneProp", "aileronProp"), (PropMergeResponseID, DialogueConstants.Level1_2.tiltPlaneAileron, PropPrefabNames.Level1_2.rollTiltPlaneProp));
        level1_2Dict.Add(("turnPlaneProp", "aileronProp"), (PropMergeResponseID, DialogueConstants.Level1_2.turnPlaneAileron, PropPrefabNames.Level1_2.rollTurnPlaneProp));
        level1_2Dict.Add(("tiltPlaneProp", "rudderProp"), (PropMergeResponseID, DialogueConstants.Level1_2.tiltPlaneRudder, PropPrefabNames.Level1_2.tiltTurnPlaneProp));
        level1_2Dict.Add(("turnPlaneProp", "elevatorProp"), (PropMergeResponseID, DialogueConstants.Level1_2.turnPlaneElevator, PropPrefabNames.Level1_2.tiltTurnPlaneProp));
        level1_2Dict.Add(("tiltTurnPlaneProp", "aileronProp"), (PropMergeResponseID, DialogueConstants.Level1_2.tiltTurnPlaneAileron, PropPrefabNames.Level1_2.finalPlaneProp));
        level1_2Dict.Add(("rollTiltPlaneProp", "rudderProp"), (PropMergeResponseID, DialogueConstants.Level1_2.rollTiltPlaneRudder, PropPrefabNames.Level1_2.finalPlaneProp));
        level1_2Dict.Add(("rollTurnPlaneProp", "elevatorProp"), (PropMergeResponseID, DialogueConstants.Level1_2.rollTurnPlaneElevator, PropPrefabNames.Level1_2.finalPlaneProp));
        //Level1_3

            //Misfires
        level1_3Dict.Add(("payloadProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_3.payloadFrame, null));
        level1_3Dict.Add(("payloadProp", "launchProp"), (MisfireResponseID, DialogueConstants.Level1_3.payloadLaunchpad, null));
        level1_3Dict.Add(("guidedPayloadProp", "launchProp"), (MisfireResponseID, DialogueConstants.Level1_3.guidedPayloadLaunchpad, null));
        level1_3Dict.Add(("oxidizerProp", "heliumProp"), (MisfireResponseID, DialogueConstants.Level1_3.oxidizerHelium, null));
        level1_3Dict.Add(("oxidizerProp", "igniterProp"), (MisfireResponseID, DialogueConstants.Level1_3.oxidizerIgniter, null));
        level1_3Dict.Add(("oxidizerProp", "combustionChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.oxidizerCombustionChamber, null));
        level1_3Dict.Add(("petroleumProp", "heliumProp"), (MisfireResponseID, DialogueConstants.Level1_3.petroleumHelium, null));
        level1_3Dict.Add(("petroleumProp", "igniterProp"), (MisfireResponseID, DialogueConstants.Level1_3.petroleumIgniter, null));
        level1_3Dict.Add(("petroleumProp", "combustionChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.petroleumCombustionChamber, null));
        level1_3Dict.Add(("heliumProp", "igniterProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumIgniter, null));
        level1_3Dict.Add(("heliumProp", "valvesProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumValves, null));
        level1_3Dict.Add(("heliumProp", "combustionChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumCombustionChamber, null));
        level1_3Dict.Add(("heliumProp", "valvedOxidizerProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumValvedOxidizer, null));
        level1_3Dict.Add(("heliumProp", "valvedPetroleumProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumValvedPetroleum, null));
        level1_3Dict.Add(("finsProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_3.finsFrame, null));
        level1_3Dict.Add(("computerProp", "payloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.computerPayloadFrame, null));
        level1_3Dict.Add(("computerProp", "finnedFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.computerFinnedFrame, null));
        level1_3Dict.Add(("computerProp", "launchpadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.computerLaunchpadFrame, null));
        level1_3Dict.Add(("computerProp", "finnedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.computerFinnedPayloadFrame, null));
        level1_3Dict.Add(("combustionChamberProp", "dualTanksProp"), (MisfireResponseID, DialogueConstants.Level1_3.combustionChamberDualTanks, null));
        level1_3Dict.Add(("combustionChamberProp", "payloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.combustionChamberPayloadFrame, null));
        level1_3Dict.Add(("combustionChamberProp", "finnedFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.combustionChamberFinnedFrame, null));
        level1_3Dict.Add(("combustionChamberProp", "launchpadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.combustionChamberLaunchpadFrame, null));
        level1_3Dict.Add(("combustionChamberProp", "guidedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.combustionChamberGuidedPayloadFrame, null));
        level1_3Dict.Add(("combustionChamberProp", "finnedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.combustionChamberFinnedPayloadFrame, null));
        level1_3Dict.Add(("fuelSupplyProp", "launchpadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.fuelSupplyLaunchpadFrame, null));
        level1_3Dict.Add(("fuelSupplyProp", "guidedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.fuelSupplyGuidedPayloadFrame, null));
        level1_3Dict.Add(("fuelSupplyProp", "finnedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.fuelSupplyFinnedPayloadFrame, null));
        level1_3Dict.Add(("fuelSupplyProp", "immovableFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.fuelSupplyImmovableFrame, null));
        level1_3Dict.Add(("frameProp", "propulsionSystemProp"), (MisfireResponseID, DialogueConstants.Level1_3.framePropulsionSystem, null));
        level1_3Dict.Add(("igniterProp", "fuelSupplyProp"), (MisfireResponseID, DialogueConstants.Level1_3.igniterFuelSupply, null));
        level1_3Dict.Add(("igniterProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_3.igniterFrame, null));
        level1_3Dict.Add(("igniterProp", "launchpadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.igniterLaunchpadFrame, null));
        level1_3Dict.Add(("igniterProp", "payloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.igniterPayloadFrame, null));
        level1_3Dict.Add(("igniterProp", "finnedFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.igniterFinnedFrame, null));
        level1_3Dict.Add(("igniterProp", "guidedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.igniterGuidedPayloadFrame, null));
        level1_3Dict.Add(("igniterProp", "finnedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.igniterFinnedPayloadFrame, null));
        level1_3Dict.Add(("valvesProp", "combustionChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.valvesCombustionChamber, null));
        level1_3Dict.Add(("valvesProp", "emptyChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.valvesEmptyChamber, null));
        level1_3Dict.Add(("dualTanksProp", "emptyChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.dualTanksEmptyChamber, null));
        level1_3Dict.Add(("dualTanksProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_3.dualTanksFrame, null));
        level1_3Dict.Add(("dualTanksProp", "launchpadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.dualTanksLaunchpadFrame, null));
        level1_3Dict.Add(("dualTanksProp", "payloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.dualTanksPayloadFrame, null));
        level1_3Dict.Add(("dualTanksProp", "finnedFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.dualTanksFinnedFrame, null));
        level1_3Dict.Add(("dualTanksProp", "guidedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.dualTanksGuidedPayloadFrame, null));
        level1_3Dict.Add(("dualTanksProp", "finnedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.dualTanksFinnedPayloadFrame, null));
        level1_3Dict.Add(("heliumProp", "frameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumFrame, null));
        level1_3Dict.Add(("heliumProp", "launchpadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumLaunchpadFrame, null));
        level1_3Dict.Add(("heliumProp", "payloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumPayloadFrame, null));
        level1_3Dict.Add(("heliumProp", "finnedFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumFinnedFrame, null));
        level1_3Dict.Add(("heliumProp", "guidedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumGuidedPayloadFrame, null));
        level1_3Dict.Add(("heliumProp", "finnedPayloadFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumFinnedPayloadFrame, null));
        level1_3Dict.Add(("heliumProp", "propulsionSystemProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumPropulsionSystem, null));
        level1_3Dict.Add(("heliumProp", "guidanceSystemProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumGuidanceSystem, null));
        level1_3Dict.Add(("petroleumProp", "emptyChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.petroleumEmptyChamber, null));
        level1_3Dict.Add(("heliumProp", "emptyChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumEmptyChamber, null));
        level1_3Dict.Add(("oxidizerProp", "emptyChamberProp"), (MisfireResponseID, DialogueConstants.Level1_3.oxidizerEmptyChamber, null));
        level1_3Dict.Add(("heliumProp", "propulsionFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumPropulsionFrame, null));
        level1_3Dict.Add(("heliumProp", "payloadPropulsionFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumPayloadPropulsionFrame, null));
        level1_3Dict.Add(("heliumProp", "finnedPropulsionFrameProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumFinnedPropulsionFrame, null));
        level1_3Dict.Add(("heliumProp", "dualTanksProp"), (MisfireResponseID, DialogueConstants.Level1_3.heliumDualTanks, null));
        level1_3Dict.Add(("emptyChamberProp", "fuelSupplyProp"), (MisfireResponseID, DialogueConstants.Level1_3.emptyChamberFuelSupply, null));

        //Successess
        level1_3Dict.Add(("payloadProp", "guidanceSystemProp"), (PropMergeResponseID, DialogueConstants.Level1_3.payloadGuidanceSystem, PropPrefabNames.Level1_3.guidedPayloadProp));
        level1_3Dict.Add(("payloadProp", "finnedFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.payloadFinnedFrame, PropPrefabNames.Level1_3.finnedPayloadFrameProp));
        level1_3Dict.Add(("payloadProp", "launchpadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.payloadLaunchpadFrame, PropPrefabNames.Level1_3.payloadFrameProp));
        level1_3Dict.Add(("payloadProp", "propulsionFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.payloadPropulsionFrame, PropPrefabNames.Level1_3.payloadPropulsionFrameProp));
        level1_3Dict.Add(("payloadProp", "finnedPropulsionFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.payloadFinnedPropulsionFrame, PropPrefabNames.Level1_3.unguidedFrameProp));
        level1_3Dict.Add(("oxidizerProp", "petroleumProp"), (PropMergeResponseID, DialogueConstants.Level1_3.oxidizerPetroleum, PropPrefabNames.Level1_3.dualTanksProp));
        level1_3Dict.Add(("oxidizerProp", "valvesProp"), (PropMergeResponseID, DialogueConstants.Level1_3.oxidizerValves, PropPrefabNames.Level1_3.valvedOxidizerProp));
        level1_3Dict.Add(("oxidizerProp", "valvedPetroleumProp"), (PropMergeResponseID, DialogueConstants.Level1_3.oxidizerValvedPetroleum, PropPrefabNames.Level1_3.fuelSupplyProp));
        level1_3Dict.Add(("petroleumProp", "valvesProp"), (PropMergeResponseID, DialogueConstants.Level1_3.petroleumValves, PropPrefabNames.Level1_3.valvedPetroleumProp));
        level1_3Dict.Add(("petroleumProp", "valvedOxidizerProp"), (PropMergeResponseID, DialogueConstants.Level1_3.petroleumValvedOxidizer, PropPrefabNames.Level1_3.fuelSupplyProp));
        level1_3Dict.Add(("finsProp", "payloadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finsPayloadFrame, PropPrefabNames.Level1_3.finnedPayloadFrameProp));
        level1_3Dict.Add(("finsProp", "launchpadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finsLaunchpadFrame, PropPrefabNames.Level1_3.finnedFrameProp));
        level1_3Dict.Add(("finsProp", "guidedPayloadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finsGuidedPayloadFrame, PropPrefabNames.Level1_3.immovableFrameProp));
        level1_3Dict.Add(("finsProp", "propulsionFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finsPropulsionFrame, PropPrefabNames.Level1_3.finnedPropulsionFrameProp));
        level1_3Dict.Add(("finsProp", "payloadPropulsionFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finsPayloadPropulsionFrame, PropPrefabNames.Level1_3.unguidedFrameProp));
        level1_3Dict.Add(("igniterProp", "emptyChamberProp"), (PropMergeResponseID, DialogueConstants.Level1_3.igniterEmptyChamber, PropPrefabNames.Level1_3.combustionChamberProp));
        level1_3Dict.Add(("launchProp", "frameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.launchFrame, PropPrefabNames.Level1_3.launchpadFrameProp));
        level1_3Dict.Add(("computerProp", "codeProp"), (PropMergeResponseID, DialogueConstants.Level1_3.computerCode, PropPrefabNames.Level1_3.guidanceSystemProp));
        level1_3Dict.Add(("guidanceSystemProp", "payloadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.guidanceSystemPayloadFrame, PropPrefabNames.Level1_3.guidedPayloadFrameProp));
        level1_3Dict.Add(("guidedPayloadProp", "launchpadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.guidedPayloadLaunchpadFrame, PropPrefabNames.Level1_3.guidedPayloadFrameProp));
        level1_3Dict.Add(("guidanceSystemProp", "payloadPropulsionFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.guidanceSystemPayloadPropulsionFrame, PropPrefabNames.Level1_3.unfinnedFrameProp));
        level1_3Dict.Add(("combustionChamberProp", "fuelSupplyProp"), (PropMergeResponseID, DialogueConstants.Level1_3.combustionChamberFuelSupply, PropPrefabNames.Level1_3.propulsionSystemProp));
        level1_3Dict.Add(("dualTanksProp", "valvesProp"), (PropMergeResponseID, DialogueConstants.Level1_3.dualTanksValves, PropPrefabNames.Level1_3.fuelSupplyProp));
        level1_3Dict.Add(("payloadFrameProp", "propulsionSystemProp"), (PropMergeResponseID, DialogueConstants.Level1_3.payloadFramePropulsionSystem, PropPrefabNames.Level1_3.payloadPropulsionFrameProp));
        level1_3Dict.Add(("finnedFrameProp", "guidedPayloadProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finnedFrameGuidedPayload, PropPrefabNames.Level1_3.immovableFrameProp));
        level1_3Dict.Add(("finnedFrameProp", "propulsionSystemProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finnedFramePropulsionSystem, PropPrefabNames.Level1_3.finnedPropulsionFrameProp));
        level1_3Dict.Add(("propulsionSystemProp", "launchpadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.propulsionSystemLaunchpadFrame, PropPrefabNames.Level1_3.propulsionFrameProp));
        level1_3Dict.Add(("propulsionSystemProp", "guidedPayloadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.propulsionSystemGuidedPayloadFrame, PropPrefabNames.Level1_3.unfinnedFrameProp));
        level1_3Dict.Add(("propulsionSystemProp", "finnedPayloadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.propulsionSystemFinnedPayloadFrame, PropPrefabNames.Level1_3.unguidedFrameProp));
        level1_3Dict.Add(("guidanceSystemProp", "finnedPayloadFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.guidanceSystemFinnedPayloadFrame, PropPrefabNames.Level1_3.immovableFrameProp));
        level1_3Dict.Add(("propulsionFrameProp", "guidedPayloadProp"), (PropMergeResponseID, DialogueConstants.Level1_3.propulsionFrameGuidedPayload, PropPrefabNames.Level1_3.unfinnedFrameProp));
        level1_3Dict.Add(("finsProp", "unfinnedFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.finsUnfinnedFrame, PropPrefabNames.Level1_3.finalRocketProp));
        level1_3Dict.Add(("guidanceSystemProp", "unguidedFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.guidanceSystemUnguidedFrame, PropPrefabNames.Level1_3.finalRocketProp));
        level1_3Dict.Add(("guidedPayloadProp", "finnedPropulsionFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.guidedPayloadFinnedPropulsionFrame, PropPrefabNames.Level1_3.finalRocketProp));
        level1_3Dict.Add(("propulsionSystemProp", "immovableFrameProp"), (PropMergeResponseID, DialogueConstants.Level1_3.propulsionSystemImmovableFrame, PropPrefabNames.Level1_3.finalRocketProp));



        //Level2_1

            //Misfires
        level2_1Dict.Add(("tungstenFilamentProp", "screwcapProp"), (MisfireResponseID, DialogueConstants.Level2_1.tungstenFilamentScrewcap, null));
        level2_1Dict.Add(("tungstenFilamentProp", "electricalContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.tungstenFilamentElectricalContact, null));
        level2_1Dict.Add(("tungstenFilamentProp", "lampProp"), (MisfireResponseID, DialogueConstants.Level2_1.tungstenFilamentLamp, null));
        level2_1Dict.Add(("tungstenFilamentProp", "screwcapContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.tungstenFilamentScrewcapContact, null));
        level2_1Dict.Add(("wiresProp", "aluminumFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.wiresAluminumFilament, null));
        level2_1Dict.Add(("wiresProp", "screwcapProp"), (MisfireResponseID, DialogueConstants.Level2_1.wiresScrewcap, null));
        level2_1Dict.Add(("wiresProp", "electricalContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.wiresElectricalContact, null));
        level2_1Dict.Add(("wiresProp", "screwcapContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.wiresScrewcapContact, null));
        level2_1Dict.Add(("glassShellProp", "electricalContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.glassShellElectricalContact, null));
        level2_1Dict.Add(("glassShellProp", "lampProp"), (MisfireResponseID, DialogueConstants.Level2_1.glassShellLamp, null));
        level2_1Dict.Add(("glassShellProp", "wiredFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.glassShellWiredFilament, null));
        level2_1Dict.Add(("glassShellProp", "screwcapContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.glassShellScrewcapContact, null));
        level2_1Dict.Add(("aluminumFilamentProp", "screwcapProp"), (MisfireResponseID, DialogueConstants.Level2_1.aluminumFilamentScrewcap, null));
        level2_1Dict.Add(("aluminumFilamentProp", "electricalContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.aluminumFilamentElectricalContact, null));
        level2_1Dict.Add(("aluminumFilamentProp", "inertShellProp"), (MisfireResponseID, DialogueConstants.Level2_1.aluminumFilamentInertShell, null));
        level2_1Dict.Add(("argonProp", "innerLightbulbProp"), (MisfireResponseID, DialogueConstants.Level2_1.argonInnerLightbulb, null));
        level2_1Dict.Add(("screwcapProp", "wiredFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.screwcapWiredFilament, null));
        level2_1Dict.Add(("screwcapProp", "inertShellProp"), (MisfireResponseID, DialogueConstants.Level2_1.screwcapInertShell, null));
        level2_1Dict.Add(("electricalContactProp", "wiredFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.electricalContactWiredFilament, null));
        level2_1Dict.Add(("lampProp", "innerLightbulbProp"), (MisfireResponseID, DialogueConstants.Level2_1.lampInnerLightbulb, PropPrefabNames.Level2_1.innerLightbulbFireProp));
        level2_1Dict.Add(("lampProp", "flammableLightbulbProp"), (MisfireResponseID, DialogueConstants.Level2_1.lampFlammableLightbulb, PropPrefabNames.Level2_1.flammableLightbulbFireProp));
        level2_1Dict.Add(("wiredFilamentProp", "inertShellProp"), (MisfireResponseID, DialogueConstants.Level2_1.wiredFilamentInertShell, null));
        level2_1Dict.Add(("inertShellProp", "screwcapContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.inertShellScrewcapContact, null));
        level2_1Dict.Add(("screwcapProp", "lampProp"), (MisfireResponseID, DialogueConstants.Level2_1.screwcapLamp, null));
        level2_1Dict.Add(("glassShellProp", "wiresProp"), (MisfireResponseID, DialogueConstants.Level2_1.glassShellWires, null));
        level2_1Dict.Add(("glassShellProp", "aluminumFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.glassShellAluminumFilament, null));
        level2_1Dict.Add(("glassShellProp", "tungstenFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.glassShellTungstenFilament, null));
        level2_1Dict.Add(("inertShellProp", "wiresProp"), (MisfireResponseID, DialogueConstants.Level2_1.inertShellWires, null));
        level2_1Dict.Add(("inertShellProp", "aluminumFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.inertShellAluminumFilament, null));
        level2_1Dict.Add(("inertShellProp", "electricalContactProp"), (MisfireResponseID, DialogueConstants.Level2_1.inertShellElectricalContact, null));
        level2_1Dict.Add(("electricalContactProp", "lampProp"), (MisfireResponseID, DialogueConstants.Level2_1.electricalContactLamp, null));
        level2_1Dict.Add(("aluminumFilamentProp", "wiredFilamentProp"), (MisfireResponseID, DialogueConstants.Level2_1.aluminumFilamentWiredFilament, null));
        level2_1Dict.Add(("aluminumFilamentProp", "innerLightbulbProp"), (MisfireResponseID, DialogueConstants.Level2_1.aluminumFilamentInnerLightbulb, null));
        level2_1Dict.Add(("aluminumFilamentProp", "unpoweredLightbulbProp"), (MisfireResponseID, DialogueConstants.Level2_1.aluminumFilamentUnpoweredLightbulb, null));
        level2_1Dict.Add(("aluminumFilamentProp", "flammableLightbulbProp"), (MisfireResponseID, DialogueConstants.Level2_1.aluminumFilamentFlammableLightbulb, null));
        level2_1Dict.Add(("wiredFilamentProp", "lampProp"), (MisfireResponseID, DialogueConstants.Level2_1.wiredFilamentLamp, null));

        //Successess
        level2_1Dict.Add(("tungstenFilamentProp", "wiresProp"), (PropMergeResponseID, DialogueConstants.Level2_1.tungstenFilamentWires, PropPrefabNames.Level2_1.wiredFilamentProp));
        level2_1Dict.Add(("glassShellProp", "argonProp"), (PropMergeResponseID, DialogueConstants.Level2_1.glassShellArgon, PropPrefabNames.Level2_1.inertShellProp));
        level2_1Dict.Add(("glassShellProp", "innerLightbulbProp"), (PropMergeResponseID, DialogueConstants.Level2_1.glassShellInnerLightbulb, PropPrefabNames.Level2_1.flammableLightbulbProp));
        level2_1Dict.Add(("argonProp", "flammableLightbulbProp"), (PropMergeResponseID, DialogueConstants.Level2_1.argonFlammableLightbulb, PropPrefabNames.Level2_1.unpoweredLightbulbProp));
        level2_1Dict.Add(("screwcapProp", "electricalContactProp"), (PropMergeResponseID, DialogueConstants.Level2_1.screwcapElectricalContact, PropPrefabNames.Level2_1.screwcapContactProp));
        level2_1Dict.Add(("lampProp", "unpoweredLightbulbProp"), (PropMergeResponseID, DialogueConstants.Level2_1.lampUnpoweredLightbulb, PropPrefabNames.Level2_1.finalLightbulbProp));
        level2_1Dict.Add(("wiredFilamentProp", "screwcapContactProp"), (PropMergeResponseID, DialogueConstants.Level2_1.wiredFilamentScrewcapContact, PropPrefabNames.Level2_1.innerLightbulbProp));
        level2_1Dict.Add(("inertShellProp", "innerLightbulbProp"), (PropMergeResponseID, DialogueConstants.Level2_1.inertShellInnerLightbulb, PropPrefabNames.Level2_1.unpoweredLightbulbProp));


        //Level2_2

        //Misfires
        level2_2Dict.Add(("positiveTerminalProp", "casingProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalCasing, null));
        level2_2Dict.Add(("positiveTerminalProp", "anodeProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalAnode, null));
        level2_2Dict.Add(("positiveTerminalProp", "electrolyteCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalElectrolyteCasing, null));
        level2_2Dict.Add(("positiveTerminalProp", "anodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalAnodeCasing, null));
        level2_2Dict.Add(("positiveTerminalProp", "separatedAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalSeparatedAnodeCasing, null));
        level2_2Dict.Add(("positiveTerminalProp", "separatedAnodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalSeparatedAnodeTerminal, null));
        level2_2Dict.Add(("positiveTerminalProp", "separatedElectrolyteAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalSeparatedElectrolyteAnodeCasing, null));
        level2_2Dict.Add(("positiveTerminalProp", "electrolyteAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.positiveTerminalElectrolyteAnodeCasing, null));
        level2_2Dict.Add(("negativeTerminalProp", "casingProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalCasing, null));
        level2_2Dict.Add(("negativeTerminalProp", "cathodeProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalCathode, null));
        level2_2Dict.Add(("negativeTerminalProp", "electrolyteCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalElectrolyteCasing, null));
        level2_2Dict.Add(("negativeTerminalProp", "cathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalCathodeCasing, null));
        level2_2Dict.Add(("negativeTerminalProp", "separatedCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalSeparatedCathodeCasing, null));
        level2_2Dict.Add(("negativeTerminalProp", "separatedCathodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalSeparatedCathodeTerminal, null));
        level2_2Dict.Add(("negativeTerminalProp", "separatedElectrolyteCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalSeparatedElectrolyteCathodeCasing, null));
        level2_2Dict.Add(("negativeTerminalProp", "electrolyteCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.negativeTerminalElectrolyteCathodeCasing, null));
        level2_2Dict.Add(("anodeProp", "cathodeProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeCathode, PropPrefabNames.Level2_2.cathodeAnodeZapProp));
        level2_2Dict.Add(("anodeProp", "cathodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeCathodeTerminal, PropPrefabNames.Level2_2.cathodeTerminalAnodeZapProp));
        level2_2Dict.Add(("anodeProp", "electrolyteCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeElectrolyteCasing, null));
        level2_2Dict.Add(("anodeProp", "cathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeCathodeCasing, PropPrefabNames.Level2_2.cathodeCasingAnodeZapProp));
        level2_2Dict.Add(("anodeProp", "separatedCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeSeparatedCathodeCasing, null));
        level2_2Dict.Add(("anodeProp", "separatedCathodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeSeparatedCathodeTerminal, null));
        level2_2Dict.Add(("anodeProp", "separatedElectrolyteCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeSeparatedElectrolyteCathodeCasing, null));
        level2_2Dict.Add(("anodeProp", "electrolyteCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeElectrolyteCathodeCasing, PropPrefabNames.Level2_2.cathodeTerminalElectrolyteAnodeCasingZapProp));
        level2_2Dict.Add(("cathodeProp", "anodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeAnodeTerminal, PropPrefabNames.Level2_2.anodeTerminalCathodeZapProp));
        level2_2Dict.Add(("cathodeProp", "electrolyteCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeElectrolyteCasing, null));
        level2_2Dict.Add(("cathodeProp", "anodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeAnodeCasing, PropPrefabNames.Level2_2.anodeCasingCathodeZapProp));
        level2_2Dict.Add(("cathodeProp", "separatedAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeSeparatedAnodeCasing, null));
        level2_2Dict.Add(("cathodeProp", "separatedAnodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeSeparatedAnodeTerminal, null));
        level2_2Dict.Add(("cathodeProp", "separatedElectrolyteAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeSeparatedElectrolyteAnodeCasing, null));
        level2_2Dict.Add(("cathodeProp", "electrolyteAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeElectrolyteAnodeCasing, PropPrefabNames.Level2_2.cathodeElectrolyteAnodeCasingZapProp));
        level2_2Dict.Add(("sulfuricAcidProp", "cathodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.sulfuricAcidCathodeTerminal, null));
        level2_2Dict.Add(("sulfuricAcidProp", "anodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.sulfuricAcidAnodeTerminal, null));
        level2_2Dict.Add(("waterProp", "cathodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterCathodeTerminal, null));
        level2_2Dict.Add(("waterProp", "anodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterAnodeTerminal, null));
        level2_2Dict.Add(("waterProp", "cathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterCathodeCasing, null));
        level2_2Dict.Add(("waterProp", "anodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterAnodeCasing, null));
        level2_2Dict.Add(("waterProp", "electrolytelessBatteryProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterElectrolytelessBattery, null));
        level2_2Dict.Add(("waterProp", "separatedCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterSeparatedCathodeCasing, null));
        level2_2Dict.Add(("waterProp", "separatedAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterSeparatedAnodeCasing, null));
        level2_2Dict.Add(("waterProp", "separatedCathodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterSeparatedCathodeTerminal, null));
        level2_2Dict.Add(("waterProp", "separatedAnodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterSeparatedAnodeTerminal, null));
        level2_2Dict.Add(("waterProp", "interiorBatteryProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterInteriorBattery, null));
        level2_2Dict.Add(("waterProp", "metalSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterMetalSeparator, null));
        level2_2Dict.Add(("waterProp", "clothSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterClothSeparator, null));
        level2_2Dict.Add(("waterProp", "flashlightProp"), (MisfireResponseID, DialogueConstants.Level2_2.waterFlashlight, null));
        level2_2Dict.Add(("cathodeTerminalProp", "anodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeTerminalAnodeTerminal, PropPrefabNames.Level2_2.cathodeTerminalAnodeTerminalZapProp));
        level2_2Dict.Add(("cathodeTerminalProp", "anodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeTerminalAnodeCasing, PropPrefabNames.Level2_2.anodeCasingCathodeTerminalZapProp));
        level2_2Dict.Add(("cathodeTerminalProp", "electrolyteAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeTerminalElectrolyteAnodeCasing, PropPrefabNames.Level2_2.cathodeTerminalElectrolyteAnodeCasingZapProp));
        level2_2Dict.Add(("cathodeTerminalProp", "metalSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeTerminalMetalSeparator, null));
        level2_2Dict.Add(("anodeTerminalProp", "cathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeTerminalCathodeCasing, PropPrefabNames.Level2_2.anodeCasingCathodeTerminalZapProp));
        level2_2Dict.Add(("anodeTerminalProp", "electrolyteCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeTerminalElectrolyteCathodeCasing, PropPrefabNames.Level2_2.cathodeTerminalElectrolyteAnodeCasingZapProp));
        level2_2Dict.Add(("anodeTerminalProp", "metalSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeTerminalMetalSeparator, null));
        level2_2Dict.Add(("cathodeCasingProp", "metalSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeCasingMetalSeparator, null));
        level2_2Dict.Add(("anodeCasingProp", "metalSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeCasingMetalSeparator, null));
        level2_2Dict.Add(("electrolyteCathodeCasingProp", "metalSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.electrolyteCathodeCasingMetalSeparator, null));
        level2_2Dict.Add(("electrolyteAnodeCasingProp", "metalSeparatorProp"), (MisfireResponseID, DialogueConstants.Level2_2.electrolyteAnodeCasingMetalSeparator, null));
        level2_2Dict.Add(("anodeProp", "casingProp"), (MisfireResponseID, DialogueConstants.Level2_2.anodeCasing, null));
        level2_2Dict.Add(("cathodeProp", "casingProp"), (MisfireResponseID, DialogueConstants.Level2_2.cathodeCasing, null));
        level2_2Dict.Add(("metalSeparatorProp", "electrolytelessBatteryProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorElectrolytelessBattery, null));
        level2_2Dict.Add(("metalSeparatorProp", "separatedCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorSeparatedCathodeCasing, null));
        level2_2Dict.Add(("metalSeparatorProp", "separatedAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorSeparatedAnodeCasing, null));
        level2_2Dict.Add(("metalSeparatorProp", "readyBatteryProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorReadyBattery, null));
        level2_2Dict.Add(("metalSeparatorProp", "separatedCathodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorSeparatedCathodeTerminal, null));
        level2_2Dict.Add(("metalSeparatorProp", "separatedAnodeTerminalProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorSeparatedAnodeTerminal, null));
        level2_2Dict.Add(("metalSeparatorProp", "separatedElectrolyteCathodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorSeparatedElectrolyteCathodeCasing, null));
        level2_2Dict.Add(("metalSeparatorProp", "separatedElectrolyteAnodeCasingProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorSeparatedElectrolyteAnodeCasing, null));
        level2_2Dict.Add(("metalSeparatorProp", "interiorBatteryProp"), (MisfireResponseID, DialogueConstants.Level2_2.metalSeparatorInteriorBattery, null));

        //Successess
        level2_2Dict.Add(("positiveTerminalProp", "cathodeProp"), (PropMergeResponseID, DialogueConstants.Level2_2.positiveTerminalCathode, PropPrefabNames.Level2_2.cathodeTerminalProp));
        level2_2Dict.Add(("negativeTerminalProp", "anodeProp"), (PropMergeResponseID, DialogueConstants.Level2_2.negativeTerminalAnode, PropPrefabNames.Level2_2.anodeTerminalProp));
        level2_2Dict.Add(("casingProp", "electrolyteProp"), (PropMergeResponseID, DialogueConstants.Level2_2.casingElectrolyte, PropPrefabNames.Level2_2.electrolyteCasingProp));
        level2_2Dict.Add(("casingProp", "cathodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.casingCathodeTerminal, PropPrefabNames.Level2_2.cathodeCasingProp));
        level2_2Dict.Add(("casingProp", "anodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.casingAnodeTerminal, PropPrefabNames.Level2_2.anodeCasingProp));
        level2_2Dict.Add(("casingProp", "separatedCathodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.casingSeparatedCathodeTerminal, PropPrefabNames.Level2_2.separatedCathodeCasingProp));
        level2_2Dict.Add(("casingProp", "separatedAnodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.casingSeparatedAnodeTerminal, PropPrefabNames.Level2_2.separatedAnodeCasingProp));
        level2_2Dict.Add(("casingProp", "interiorBatteryProp"), (PropMergeResponseID, DialogueConstants.Level2_2.casingInteriorBattery, PropPrefabNames.Level2_2.electrolytelessBatteryProp));
        level2_2Dict.Add(("waterProp", "sulfuricAcidProp"), (PropMergeResponseID, DialogueConstants.Level2_2.waterSulfuricAcid, PropPrefabNames.Level2_2.electrolyteProp));
        level2_2Dict.Add(("clothSeparatorProp", "cathodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.clothSeparatorCathodeTerminal, PropPrefabNames.Level2_2.separatedCathodeTerminalProp));
        level2_2Dict.Add(("clothSeparatorProp", "anodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.clothSeparatorAnodeTerminal, PropPrefabNames.Level2_2.separatedAnodeTerminalProp));
        level2_2Dict.Add(("clothSeparatorProp", "cathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.clothSeparatorCathodeCasing, PropPrefabNames.Level2_2.separatedCathodeCasingProp));
        level2_2Dict.Add(("clothSeparatorProp", "anodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.clothSeparatorAnodeCasing, PropPrefabNames.Level2_2.separatedAnodeCasingProp));
        level2_2Dict.Add(("clothSeparatorProp", "electrolyteCathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.clothSeparatorElectrolyteCathodeCasing, PropPrefabNames.Level2_2.separatedElectrolyteCathodeCasingProp));
        level2_2Dict.Add(("clothSeparatorProp", "electrolyteAnodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.clothSeparatorElectrolyteAnodeCasing, PropPrefabNames.Level2_2.separatedElectrolyteAnodeCasingProp));
        level2_2Dict.Add(("flashlightProp", "readyBatteryProp"), (PropMergeResponseID, DialogueConstants.Level2_2.flashlightReadyBattery, PropPrefabNames.Level2_2.finalBatteryProp));
        level2_2Dict.Add(("electrolyteProp", "cathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteCathodeCasing, PropPrefabNames.Level2_2.electrolyteCathodeCasingProp));
        level2_2Dict.Add(("electrolyteProp", "anodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteAnodeCasing, PropPrefabNames.Level2_2.electrolyteAnodeCasingProp));
        level2_2Dict.Add(("electrolyteProp", "electrolytelessBatteryProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteElectrolytelessBattery, PropPrefabNames.Level2_2.readyBatteryProp));
        level2_2Dict.Add(("electrolyteProp", "separatedCathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteSeparatedCathodeCasing, PropPrefabNames.Level2_2.separatedElectrolyteCathodeCasingProp));
        level2_2Dict.Add(("electrolyteProp", "separatedAnodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteSeparatedAnodeCasing, PropPrefabNames.Level2_2.separatedElectrolyteAnodeCasingProp));
        level2_2Dict.Add(("cathodeTerminalProp", "electrolyteCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.cathodeTerminalElectrolyteCasing, PropPrefabNames.Level2_2.electrolyteCathodeCasingProp));
        level2_2Dict.Add(("cathodeTerminalProp", "separatedAnodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.cathodeTerminalSeparatedAnodeCasing, PropPrefabNames.Level2_2.electrolytelessBatteryProp));
        level2_2Dict.Add(("cathodeTerminalProp", "separatedAnodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.cathodeTerminalSeparatedAnodeTerminal, PropPrefabNames.Level2_2.interiorBatteryProp));
        level2_2Dict.Add(("cathodeTerminalProp", "separatedElectrolyteAnodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.cathodeTerminalSeparatedElectrolyteAnodeCasing, PropPrefabNames.Level2_2.readyBatteryProp));
        level2_2Dict.Add(("anodeTerminalProp", "electrolyteCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.anodeTerminalElectrolyteCasing, PropPrefabNames.Level2_2.electrolyteAnodeCasingProp));
        level2_2Dict.Add(("anodeTerminalProp", "separatedCathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.anodeTerminalSeparatedCathodeCasing, PropPrefabNames.Level2_2.electrolytelessBatteryProp));
        level2_2Dict.Add(("anodeTerminalProp", "separatedCathodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.anodeTerminalSeparatedCathodeTerminal, PropPrefabNames.Level2_2.interiorBatteryProp));
        level2_2Dict.Add(("anodeTerminalProp", "separatedElectrolyteCathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.anodeTerminalSeparatedElectrolyteCathodeCasing, PropPrefabNames.Level2_2.readyBatteryProp));
        level2_2Dict.Add(("electrolyteCasingProp", "separatedCathodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteCasingSeparatedCathodeTerminal, PropPrefabNames.Level2_2.separatedElectrolyteCathodeCasingProp));
        level2_2Dict.Add(("electrolyteCasingProp", "separatedAnodeTerminalProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteCasingSeparatedAnodeTerminal, PropPrefabNames.Level2_2.separatedElectrolyteAnodeCasingProp));
        level2_2Dict.Add(("electrolyteCasingProp", "interiorBatteryProp"), (PropMergeResponseID, DialogueConstants.Level2_2.electrolyteCasingInteriorBattery, PropPrefabNames.Level2_2.readyBatteryProp));
        level2_2Dict.Add(("separatedAnodeTerminalProp", "cathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.separatedAnodeTerminalCathodeCasing, PropPrefabNames.Level2_2.electrolytelessBatteryProp));
        level2_2Dict.Add(("separatedCathodeTerminalProp", "anodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.separatedCathodeTerminalAnodeCasing, PropPrefabNames.Level2_2.electrolytelessBatteryProp));
        level2_2Dict.Add(("separatedCathodeTerminalProp", "electrolyteAnodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.separatedCathodeTerminalElectrolyteAnodeCasing, PropPrefabNames.Level2_2.readyBatteryProp));
        level2_2Dict.Add(("separatedAnodeTerminalProp", "electrolyteCathodeCasingProp"), (PropMergeResponseID, DialogueConstants.Level2_2.separatedAnodeTerminalElectrolyteCathodeCasing, PropPrefabNames.Level2_2.readyBatteryProp));


        //Adding level dicts to master dict
        levelDict.Add("level0_0", level0_0Dict);
        levelDict.Add("level1_1", level1_1Dict);
        levelDict.Add("level1_2", level1_2Dict);
        levelDict.Add("level1_3", level1_3Dict);
        levelDict.Add("level2_1", level2_1Dict);
        levelDict.Add("level2_2", level2_2Dict);
        //levelDict.Add("level2_3", level2_3Dict);

    }

    public override (string responseID, string dialog, GameObject resultingProp, bool isLearnMore)
        getResponse(GameObject prop1, GameObject prop2)
    {
        //Gets the level from the tag, turns "Level1_1/Prefab" into "Level_1"
        string level = prop1.tag.Substring(0, prop1.tag.IndexOf("/", 0, prop1.tag.Length));


        //If the pair (1,2) doesn't exist check (2,1) then return fail
        try
        {
            //Working solution for using tags to get around duplicate names
            //Then checks the dict for the appropriate level for the combo

            var (str1, str2, str3)  = levelDict[level.ToLower()][(prop1.name, prop2.name)];
            //learnMore.CheckAndEmit(level, str2);
            return (str1, str2, Resources.Load<GameObject>(prop1.tag + "/" + str3), learnMore.CheckAndEmit(level, str2));




            //return levelDict[level][(prop1.name, prop2.name)];
            //return responseDict[(prop1.name, prop2.name)];

        }
        catch (KeyNotFoundException e)
        {
            try
            {
                var (str1, str2, str3) = levelDict[level.ToLower()][(prop2.name, prop1.name)];
                //learnMore.CheckAndEmit(level, str2);
                return (str1, str2, Resources.Load<GameObject>(prop1.tag + "/" + str3), learnMore.CheckAndEmit(level, str2));


                //return responseDict[(prop2.name, prop1.name)];
            }
            catch (KeyNotFoundException f)
            {
                return (FailStateResponseID, null, null, false);
            }
        }
        }
    // Update is not being called?
    void Update()
    {
    }


    //Code for instantiating copies of the prefab, not in use right now
    //But keep in case of future use

    //public GameObject InstantiateCopy(string propName, string spriteFilePath)
    //{
    //    Debug.Log("Went into instantiate to create a copy");
    //    //Loads the prefab (test for now) from the resources folder
    //    GameObject propPrefab = Resources.Load<GameObject>("GlobalPrefabs/PropPrefab");
    //    //Creates a new GameObject that is a copy of the prop prefab
    //    GameObject newProp = GameObject.Instantiate(propPrefab);
    //    newProp.name = propName;
    //    //Currently the box colliders are incorrectly sized still, maybe this will be fixed with sprites
    //    BoxCollider2D boxCollider = newProp.AddComponent<BoxCollider2D>();
    //    boxCollider.isTrigger = true;
    //    //Adds the correct sprite to the prop
    //    SpriteRenderer sr = newProp.GetComponent<SpriteRenderer>();
    //    sr.sprite = Resources.Load<Sprite>(spriteFilePath);
    //    return newProp;
    //}

}
