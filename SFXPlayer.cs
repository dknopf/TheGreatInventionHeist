using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class SFXPlayer : MonoBehaviour
{
    public Dictionary<(string, string), string> propSoundDict = new Dictionary<(string, string), string>();
    void Start()
    {
        InitializePropSoundDict();
        EventManager.StartListening(GameConstants.PropCollisionEvent, playInteractionSFX);
    }

    private void InitializePropSoundDict()
    {
        //Level0_0

            //Misfires
        propSoundDict.Add(("frameProp", "screenProp"), "fail");
        propSoundDict.Add(("frameProp", "warpGeneratorProp"), "fail");
        propSoundDict.Add(("sidingProp", "screenProp"), "fail");
        propSoundDict.Add(("sidingProp", "warpGeneratorProp"), "fail");
        propSoundDict.Add(("screenProp", "warpGeneratorProp"), "fail");
        propSoundDict.Add(("fluxAntennaProp", "capsuleProp"), "fail");
        propSoundDict.Add(("fluxAntennaProp", "screenProp"), "fail");
        propSoundDict.Add(("fluxAntennaProp", "screenCapsuleProp"), "fail");
        propSoundDict.Add(("fluxAntennaProp", "warpGeneratorProp"), "fail");
        propSoundDict.Add(("fluxAntennaProp", "warpCapsuleProp"), "fail");
        propSoundDict.Add(("fluxAntennaProp", "sidingProp"), "fail");
        propSoundDict.Add(("fluxAntennaProp", "frameProp"), "fail");

            //Successess
        propSoundDict.Add(("frameProp", "sidingProp"), "propSuccess");
        propSoundDict.Add(("capsuleProp", "screenProp"), "computerBeeps");
        propSoundDict.Add(("capsuleProp", "warpGeneratorProp"), "poweringUp");
        propSoundDict.Add(("warpCapsuleProp", "screenProp"), "computerBeeps");
        propSoundDict.Add(("screenCapsuleProp", "warpGeneratorProp"), "poweringUp");

        //Level1_1

            //Misfires
        propSoundDict.Add(("heliumProp", "tankProp"), "fail");
        propSoundDict.Add(("heliumProp", "canvasProp"), "airWhoosh");
        propSoundDict.Add(("heliumProp", "bodyProp"), "airWhoosh");
        propSoundDict.Add(("heliumProp", "ballastProp"), "fail");
        propSoundDict.Add(("heliumProp", "steerableBodyProp"), "airWhoosh");
        propSoundDict.Add(("heliumProp", "weightedBodyProp"), "fail");
        propSoundDict.Add(("heliumProp", "emptyBlimpProp"), "fail");
        propSoundDict.Add(("hydrogenProp", "canvasProp"), "airWhoosh");
        propSoundDict.Add(("hydrogenProp", "tankProp"), "fail");
        propSoundDict.Add(("hydrogenProp", "bodyProp"), "airWhoosh");
        propSoundDict.Add(("hydrogenProp", "ballastProp"), "fail");
        propSoundDict.Add(("hydrogenProp", "steerableBodyProp"), "fireCrackle");
        propSoundDict.Add(("hydrogenProp", "weightedBodyProp"), "fireCrackle");
        propSoundDict.Add(("hydrogenProp", "emptyBlimpProp"), "fireCrackle");
        propSoundDict.Add(("tailfinProp", "frameProp"), "fail");
        propSoundDict.Add(("motorProp", "frameProp"), "fail");
        propSoundDict.Add(("tailfinProp", "bodyProp"), "fail");
        propSoundDict.Add(("motorProp", "bodyProp"), "fail");
        propSoundDict.Add(("airProp", "bodyProp"), "fail");
        propSoundDict.Add(("airProp", "weightedBodyProp"), "fail");
        propSoundDict.Add(("airProp", "steerableWeightedBodyProp"), "fail");
        propSoundDict.Add(("airProp", "steerableBodyProp"), "fail");
        propSoundDict.Add(("airProp", "emptyBlimpProp"), "fail");
        propSoundDict.Add(("heliumProp", "frameProp"), "fail");
        propSoundDict.Add(("airProp", "frameProp"), "fail");
        propSoundDict.Add(("hydrogenProp", "frameProp"), "fail");
        propSoundDict.Add(("emptyTankProp", "frameProp"), "fail");
        propSoundDict.Add(("emptyTankProp", "bodyProp"), "fail");
        propSoundDict.Add(("emptyTankProp", "steerableBodyProp"), "fail");
        propSoundDict.Add(("tailfinProp", "weightedBodyProp"), "fail");
        propSoundDict.Add(("motorProp", "weightedBodyProp"), "fail");

            //Successess
        propSoundDict.Add(("frameProp", "canvasProp"), "clothSound");
        propSoundDict.Add(("motorProp", "tailfinProp"), "steampunkMotor");
        propSoundDict.Add(("airProp", "tankProp"), "clankTanks");
        propSoundDict.Add(("bodyProp", "steeringMechanismProp"), "propSuccess");
        propSoundDict.Add(("bodyProp", "ballastProp"), "clankTanks");
        propSoundDict.Add(("steeringMechanismProp", "weightedBodyProp"), "propSuccess");
        propSoundDict.Add(("steerableBodyProp", "ballastProp"), "clankTanks");


        //Level1_2

            //Misfires
        propSoundDict.Add(("frameProp", "wheelsProp"), "fail");
        propSoundDict.Add(("frameProp", "engineProp"), "fail");
        propSoundDict.Add(("frameProp", "propellerProp"), "fail");
        propSoundDict.Add(("frameProp", "aileronProp"), "fail");
        propSoundDict.Add(("frameProp", "rudderProp"), "fail");
        propSoundDict.Add(("frameProp", "elevatorProp"), "fail");
        propSoundDict.Add(("frameProp", "fueledEngineProp"),  "fail");
        propSoundDict.Add(("engineProp", "bodyProp"), "sputteringMotor");
        propSoundDict.Add(("engineProp", "wheeledBodyProp"), "sputteringMotor");
        propSoundDict.Add(("engineProp", "propellerBodyProp"), "sputteringMotor");
        propSoundDict.Add(("engineProp", "wheeledPropellerBodyProp"), "sputteringMotor");
        propSoundDict.Add(("fueledEngineProp", "bodyProp"), "fireCrackle");
        propSoundDict.Add(("fueledEngineProp", "wheeledBodyProp"), "fireCrackle");
        propSoundDict.Add(("fueledEngineProp", "propellerBodyProp"), "fireCrackle");
        propSoundDict.Add(("fueledEngineProp", "wheeledPropellerBodyProp"), "fireCrackle");
        propSoundDict.Add(("aileronProp", "motorizedPropellerBodyProp"), "fail");
        propSoundDict.Add(("elevatorProp", "motorizedPropellerBodyProp"), "fail");
        propSoundDict.Add(("rudderProp", "motorizedPropellerBodyProp"), "fail");
        propSoundDict.Add(("bodyProp", "aileronProp"), "fail");
        propSoundDict.Add(("bodyProp", "rudderProp"), "fail");
        propSoundDict.Add(("bodyProp", "elevatorProp"), "fail");
        propSoundDict.Add(("wheeledBodyProp", "aileronProp"), "fail");
        propSoundDict.Add(("wheeledBodyProp", "rudderProp"), "fail");
        propSoundDict.Add(("wheeledBodyProp", "elevatorProp"), "fail");
        propSoundDict.Add(("motorizedBodyProp", "aileronProp"), "fail");
        propSoundDict.Add(("motorizedBodyProp", "rudderProp"), "fail");
        propSoundDict.Add(("motorizedBodyProp", "elevatorProp"), "fail");
        propSoundDict.Add(("propellerBodyProp", "aileronProp"), "fail");
        propSoundDict.Add(("propellerBodyProp", "rudderProp"), "fail");
        propSoundDict.Add(("propellerBodyProp", "elevatorProp"), "fail");
        propSoundDict.Add(("motorizedWheeledBodyProp", "aileronProp"), "fail");
        propSoundDict.Add(("motorizedWheeledBodyProp", "rudderProp"), "fail");
        propSoundDict.Add(("motorizedWheeledBodyProp", "elevatorProp"), "fail");
        propSoundDict.Add(("wheeledPropellerBodyProp", "aileronProp"), "fail");
        propSoundDict.Add(("wheeledPropellerBodyProp", "rudderProp"), "fail");
        propSoundDict.Add(("wheeledPropellerBodyProp", "elevatorProp"), "fail");

            //Successess
        propSoundDict.Add(("wheelsProp", "bodyProp"), "propSuccess");
        propSoundDict.Add(("wheelsProp", "motorizedBodyProp"), "propSuccess");
        propSoundDict.Add(("wheelsProp", "propellerBodyProp"), "propSuccess");
        propSoundDict.Add(("wheelsProp", "motorizedPropellerBodyProp"), "propSuccess");
        propSoundDict.Add(("propellerProp", "bodyProp"), "propellor");
        propSoundDict.Add(("propellerProp", "wheeledBodyProp"), "propSuccess");
        propSoundDict.Add(("propellerProp", "motorizedBodyProp"), "motorPropeller");
        propSoundDict.Add(("propellerProp", "motorizedWheeledBodyProp"), "motorPropeller");
        propSoundDict.Add(("engineProp", "fuelProp"), "motor");
        propSoundDict.Add(("frameProp", "clothProp"), "clothSound");
        propSoundDict.Add(("unsteerableBodyProp", "aileronProp"), "steeringMechanisms");
        propSoundDict.Add(("unsteerableBodyProp", "elevatorProp"), "steeringMechanisms");
        propSoundDict.Add(("unsteerableBodyProp", "rudderProp"), "steeringMechanisms");
        propSoundDict.Add(("waterProp", "fueledEngineProp"), "waterCoolant");
        propSoundDict.Add(("cooledEngineProp", "bodyProp"), "motor");
        propSoundDict.Add(("cooledEngineProp", "wheeledBodyProp"), "motor");
        propSoundDict.Add(("cooledEngineProp", "propellerBodyProp"), "motorPropeller");
        propSoundDict.Add(("cooledEngineProp", "wheeledPropellerBodyProp"), "motorPropeller");
        propSoundDict.Add(("rollPlaneProp", "elevatorProp"), "steeringMechanisms");
        propSoundDict.Add(("rollPlaneProp", "rudderProp"), "steeringMechanisms");
        propSoundDict.Add(("tiltPlaneProp", "aileronProp"), "steeringMechanisms");
        propSoundDict.Add(("turnPlaneProp", "aileronProp"), "steeringMechanisms");
        propSoundDict.Add(("tiltPlaneProp", "rudderProp"), "steeringMechanisms");
        propSoundDict.Add(("turnPlaneProp", "elevatorProp"), "steeringMechanisms");
        propSoundDict.Add(("tiltTurnPlaneProp", "aileronProp"), "steeringMechanisms");
        propSoundDict.Add(("rollTiltPlaneProp", "rudderProp"), "steeringMechanisms");
        propSoundDict.Add(("rollTurnPlaneProp", "elevatorProp"), "steeringMechanisms");
        //Level1_3

            //Misfires
        propSoundDict.Add(("payloadProp", "frameProp"), "fail");
        propSoundDict.Add(("payloadProp", "launchProp"), "fail");
        propSoundDict.Add(("guidedPayloadProp", "launchProp"), "fail");
        propSoundDict.Add(("oxidizerProp", "heliumProp"), "fail");
        propSoundDict.Add(("oxidizerProp", "igniterProp"), "explosion");
        propSoundDict.Add(("oxidizerProp", "combustionChamberProp"), "weakExplosion");
        propSoundDict.Add(("petroleumProp", "heliumProp"), "fail");
        propSoundDict.Add(("petroleumProp", "igniterProp"), "fail");
        propSoundDict.Add(("petroleumProp", "combustionChamberProp"), "fail");
        propSoundDict.Add(("heliumProp", "igniterProp"), "fail");
        propSoundDict.Add(("heliumProp", "valvesProp"), "fail");
        propSoundDict.Add(("heliumProp", "combustionChamberProp"), "fail");
        propSoundDict.Add(("heliumProp", "valvedOxidizerProp"), "fail");
        propSoundDict.Add(("heliumProp", "valvedPetroleumProp"), "fail");
        propSoundDict.Add(("finsProp", "frameProp"), "fail");
        propSoundDict.Add(("computerProp", "payloadFrameProp"), "fail");
        propSoundDict.Add(("computerProp", "finnedFrameProp"), "fail");
        propSoundDict.Add(("computerProp", "launchpadFrameProp"), "fail");
        propSoundDict.Add(("computerProp", "finnedPayloadFrameProp"), "fail");
        propSoundDict.Add(("combustionChamberProp", "dualTanksProp"), "fail");
        propSoundDict.Add(("combustionChamberProp", "payloadFrameProp"), "fail");
        propSoundDict.Add(("combustionChamberProp", "finnedFrameProp"), "fail");
        propSoundDict.Add(("combustionChamberProp", "launchpadFrameProp"), "fail");
        propSoundDict.Add(("combustionChamberProp", "guidedPayloadFrameProp"), "fail");
        propSoundDict.Add(("combustionChamberProp", "finnedPayloadFrameProp"), "fail");
        propSoundDict.Add(("fuelSupplyProp", "launchpadFrameProp"), "fail");
        propSoundDict.Add(("fuelSupplyProp", "guidedPayloadFrameProp"), "fail");
        propSoundDict.Add(("fuelSupplyProp", "finnedPayloadFrameProp"), "fail");
        propSoundDict.Add(("fuelSupplyProp", "immovableFrameProp"), "fail");
        propSoundDict.Add(("frameProp", "propulsionSystemProp"), "fail");
        propSoundDict.Add(("igniterProp", "frameProp"), "fail");
        propSoundDict.Add(("igniterProp", "launchpadFrameProp"), "fail");
        propSoundDict.Add(("igniterProp", "payloadFrameProp"), "fail");
        propSoundDict.Add(("igniterProp", "finnedFrameProp"), "fail");
        propSoundDict.Add(("igniterProp", "guidedPayloadFrameProp"), "fail");
        propSoundDict.Add(("igniterProp", "finnedPayloadFrameProp"), "fail");
        propSoundDict.Add(("valvesProp", "combustionChamberProp"), "fail");
        propSoundDict.Add(("valvesProp", "emptyChamberProp"), "fail");
        propSoundDict.Add(("dualTanksProp", "emptyChamberProp"), "fail");
        propSoundDict.Add(("dualTanksProp", "frameProp"), "fail");
        propSoundDict.Add(("dualTanksProp", "launchpadFrameProp"), "fail");
        propSoundDict.Add(("dualTanksProp", "payloadFrameProp"), "fail");
        propSoundDict.Add(("dualTanksProp", "finnedFrameProp"), "fail");
        propSoundDict.Add(("dualTanksProp", "guidedPayloadFrameProp"), "fail");
        propSoundDict.Add(("dualTanksProp", "finnedPayloadFrameProp"), "fail");
        propSoundDict.Add(("heliumProp", "launchpadFrameProp"), "fail");
        propSoundDict.Add(("heliumProp", "payloadFrameProp"), "fail");
        propSoundDict.Add(("heliumProp", "finnedFrameProp"), "fail");
        propSoundDict.Add(("heliumProp", "guidedPayloadFrameProp"), "fail");
        propSoundDict.Add(("heliumProp", "finnedPayloadFrameProp"), "fail");
        propSoundDict.Add(("heliumProp", "propulsionSystemProp"), "fail");
        propSoundDict.Add(("heliumProp", "guidanceSystemProp"), "fail");
        propSoundDict.Add(("petroleumProp", "emptyChamberProp"), "fail");
        propSoundDict.Add(("heliumProp", "emptyChamberProp"), "fail");
        propSoundDict.Add(("oxidizerProp", "emptyChamberProp"), "weakExplosion");

            //Successess
        propSoundDict.Add(("payloadProp", "guidanceSystemProp"), "propSuccess");
        propSoundDict.Add(("payloadProp", "finnedFrameProp"), "propSuccess");
        propSoundDict.Add(("payloadProp", "launchpadFrameProp"), "propSuccess");
        propSoundDict.Add(("payloadProp", "propulsionFrameProp"), "propSuccess");
        propSoundDict.Add(("payloadProp", "finnedPropulsionFrameProp"), "propSuccess");
        propSoundDict.Add(("oxidizerProp", "petroleumProp"), "clankTanks");
        propSoundDict.Add(("oxidizerProp", "valvesProp"), "clankTanks");
        propSoundDict.Add(("oxidizerProp", "valvedPetroleumProp"), "gasEscape");
        propSoundDict.Add(("petroleumProp", "valvesProp"), "clankTanks");
        propSoundDict.Add(("petroleumProp", "valvedOxidizerProp"), "gasEscape");
        propSoundDict.Add(("finsProp", "payloadFrameProp"), "propSuccess");
        propSoundDict.Add(("finsProp", "launchpadFrameProp"), "propSuccess");
        propSoundDict.Add(("finsProp", "guidedPayloadFrameProp"), "propSuccess");
        propSoundDict.Add(("finsProp", "propulsionFrameProp"), "propSuccess");
        propSoundDict.Add(("finsProp", "payloadPropulsionFrameProp"), "propSuccess");
        propSoundDict.Add(("igniterProp", "emptyChamberProp"), "fireCrackle");
        propSoundDict.Add(("launchProp", "frameProp"), "propSuccess");
        propSoundDict.Add(("computerProp", "codeProp"), "computerBeeps");
        propSoundDict.Add(("guidanceSystemProp", "payloadFrameProp"), "computerBeeps");
        propSoundDict.Add(("guidanceSystemProp", "payloadPropulsionFrameProp"), "computerBeeps");
        propSoundDict.Add(("combustionChamberProp", "fuelSupplyProp"), "rocketPropulsion");
        propSoundDict.Add(("dualTanksProp", "valvesProp"), "gasEscape");
        propSoundDict.Add(("payloadFrameProp", "propulsionSystemProp"), "propSuccess");
        propSoundDict.Add(("finnedFrameProp", "guidedPayloadProp"), "propSuccess");
        propSoundDict.Add(("finnedFrameProp", "propulsionSystemProp"), "propSuccess");
        propSoundDict.Add(("propulsionSystemProp", "launchpadFrameProp"), "propSuccess");
        propSoundDict.Add(("propulsionSystemProp", "guidedPayloadFrameProp"), "propSuccess");
        propSoundDict.Add(("propulsionSystemProp", "finnedPayloadFrameProp"), "propSuccess");
        propSoundDict.Add(("guidanceSystemProp", "finnedPayloadFrameProp"), "propSuccess");
        propSoundDict.Add(("propulsionFrameProp", "guidedPayloadProp"), "propSuccess");
        propSoundDict.Add(("finsProp", "unfinnedFrameProp"), "propSuccess");
        propSoundDict.Add(("guidanceSystemProp", "unguidedFrameProp"), "computerBeeps");
        propSoundDict.Add(("guidedPayloadProp", "finnedPropulsionFrameProp"), "propSuccess");
        propSoundDict.Add(("propulsionSystemProp", "immovableFrameProp"), "propSuccess");



        //Level2_1

            //Misfires
        propSoundDict.Add(("tungstenFilamentProp", "screwcapProp"), "fail");
        propSoundDict.Add(("tungstenFilamentProp", "electricalContactProp"), "fail");
        propSoundDict.Add(("tungstenFilamentProp", "lampProp"), "fail");
        propSoundDict.Add(("tungstenFilamentProp", "screwcapContactProp"), "fail");
        propSoundDict.Add(("wiresProp", "aluminumFilamentProp"), "acidSizzle");
        propSoundDict.Add(("wiresProp", "screwcapProp"), "fail");
        propSoundDict.Add(("wiresProp", "electricalContactProp"), "fail");
        propSoundDict.Add(("wiresProp", "screwcapContactProp"), "fail");
        propSoundDict.Add(("glassShellProp", "electricalContactProp"), "fail");
        propSoundDict.Add(("glassShellProp", "lampProp"), "fail");
        propSoundDict.Add(("glassShellProp", "wiredFilamentProp"), "fail");
        propSoundDict.Add(("glassShellProp", "screwcapContactProp"), "fail");
        propSoundDict.Add(("aluminumFilamentProp", "screwcapProp"), "fail");
        propSoundDict.Add(("aluminumFilamentProp", "electricalContactProp"), "fail");
        propSoundDict.Add(("aluminumFilamentProp", "inertShellProp"), "fail");
        propSoundDict.Add(("argonProp", "innerLightbulbProp"), "gasEscape");
        propSoundDict.Add(("screwcapProp", "wiredFilamentProp"), "fail");
        propSoundDict.Add(("screwcapProp", "inertShellProp"), "fail");
        propSoundDict.Add(("electricalContactProp", "wiredFilamentProp"), "fail");
        propSoundDict.Add(("lampProp", "innerLightbulbProp"), "lightbulbFlame");
        propSoundDict.Add(("lampProp", "flammableLightbulbProp"), "lightbulbFlame");
        propSoundDict.Add(("wiredFilamentProp", "inertShellProp"), "fail");
        propSoundDict.Add(("inertShellProp", "screwcapContactProp"), "fail");
        propSoundDict.Add(("screwcapProp", "lampProp"), "fail");

            //Successess
        propSoundDict.Add(("tungstenFilamentProp", "wiresProp"), "propSuccess");
        propSoundDict.Add(("glassShellProp", "argonProp"), "glassClink");
        propSoundDict.Add(("glassShellProp", "innerLightbulbProp"), "glassClink");
        propSoundDict.Add(("argonProp", "flammableLightbulbProp"), "propSuccess");
        propSoundDict.Add(("screwcapProp", "electricalContactProp"), "propSuccess");
        propSoundDict.Add(("lampProp", "unpoweredLightbulbProp"), "screwingIn");
        propSoundDict.Add(("wiredFilamentProp", "screwcapContactProp"), "propSuccess");
        propSoundDict.Add(("inertShellProp", "innerLightbulbProp"), "glassClink");


        //Level2_2

            //Misfires
        propSoundDict.Add(("positiveTerminalProp", "casingProp"), "fail");
        propSoundDict.Add(("positiveTerminalProp", "anodeProp"), "fail");
        propSoundDict.Add(("positiveTerminalProp", "electrolyteCasingProp"), "fail");
        propSoundDict.Add(("positiveTerminalProp", "anodeCasingProp"), "fail");
        propSoundDict.Add(("positiveTerminalProp", "separatedAnodeCasingProp"), "fail");
        propSoundDict.Add(("positiveTerminalProp", "separatedAnodeTerminalProp"), "fail");
        propSoundDict.Add(("positiveTerminalProp", "separatedElectrolyteAnodeCasingProp"), "fail");
        propSoundDict.Add(("positiveTerminalProp", "electrolyteAnodeCasingProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "casingProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "cathodeProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "electrolyteCasingProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "cathodeCasingProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "separatedCathodeCasingProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "separatedCathodeTerminalProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "separatedElectrolyteCathodeCasingProp"), "fail");
        propSoundDict.Add(("negativeTerminalProp", "electrolyteCathodeCasingProp"), "fail");
        propSoundDict.Add(("anodeProp", "cathodeProp"), "shortOut");
        propSoundDict.Add(("anodeProp", "cathodeTerminalProp"), "shortOut");
        propSoundDict.Add(("anodeProp", "electrolyteCasingProp"), "fail");
        propSoundDict.Add(("anodeProp", "cathodeCasingProp"), "shortOut");
        propSoundDict.Add(("anodeProp", "separatedCathodeCasingProp"), "shortOut");
        propSoundDict.Add(("anodeProp", "separatedCathodeTerminalProp"), "shortOut");
        propSoundDict.Add(("anodeProp", "separatedElectrolyteCathodeCasingProp"), "shortOut");
        propSoundDict.Add(("anodeProp", "electrolyteCathodeCasingProp"), "shortOut");
        propSoundDict.Add(("cathodeProp", "anodeTerminalProp"), "shortOut");
        propSoundDict.Add(("cathodeProp", "electrolyteCasingProp"), "fail");
        propSoundDict.Add(("cathodeProp", "anodeCasingProp"), "shortOut");
        propSoundDict.Add(("cathodeProp", "separatedAnodeCasingProp"), "shortOut");
        propSoundDict.Add(("cathodeProp", "separatedAnodeTerminalProp"), "shortOut");
        propSoundDict.Add(("cathodeProp", "separatedElectrolyteAnodeCasingProp"), "shortOut");
        propSoundDict.Add(("cathodeProp", "electrolyteAnodeCasingProp"), "shortOut");
        propSoundDict.Add(("sufuricAcidProp", "cathodeTerminalProp"), "acidSizzle");
        propSoundDict.Add(("sufuricAcidProp", "anodeTerminalProp"), "acidSizzle");
        propSoundDict.Add(("waterProp", "cathodeTerminalProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "anodeTerminalProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "cathodeCasingProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "anodeCasingProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "electrolytelessBatteryProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "separatedCathodeCasingProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "separatedAnodeCasingProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "separatedCathodeTerminalProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "separatedAnodeTerminalProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "interiorBatteryProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "metalSeparatorProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "clothSeparatorProp"), "waterSplash");
        propSoundDict.Add(("waterProp", "flashlightProp"), "waterSplash");
        propSoundDict.Add(("cathodeTerminalProp", "anodeTerminalProp"), "shortOut");
        propSoundDict.Add(("cathodeTerminalProp", "anodeCasingProp"), "shortOut");
        propSoundDict.Add(("cathodeTerminalProp", "electrolyteAnodeCasingProp"), "shortOut");
        propSoundDict.Add(("cathodeTerminalProp", "metalSeparatorProp"), "shortOut");
        propSoundDict.Add(("anodeTerminalProp", "cathodeCasingProp"), "shortOut");
        propSoundDict.Add(("anodeTerminalProp", "electrolyteCathodeCasingProp"), "shortOut");
        propSoundDict.Add(("anodeTerminalProp", "metalSeparatorProp"), "fail");
        propSoundDict.Add(("cathodeCasingProp", "metalSeparatorProp"), "fail");
        propSoundDict.Add(("anodeCasingProp", "metalSeparatorProp"), "fail");
        propSoundDict.Add(("electrolyteCathodeCasingProp", "metalSeparatorProp"), "fail");
        propSoundDict.Add(("electrolyteAnodeCasingProp", "metalSeparatorProp"), "fail");
            //Successess
        propSoundDict.Add(("positiveTerminalProp", "cathodeProp"), "propSuccess");
        propSoundDict.Add(("negativeTerminalProp", "anodeProp"), "propSuccess");
        propSoundDict.Add(("casingProp", "electrolyteProp"), "propSuccess");
        propSoundDict.Add(("casingProp", "cathodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("casingProp", "anodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("casingProp", "separatedCathodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("casingProp", "separatedAnodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("casingProp", "interiorBatteryProp"), "propSuccess");
        propSoundDict.Add(("waterProp", "sulfuricAcidProp"), "propSuccess");
        propSoundDict.Add(("clothSeparatorProp", "cathodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("clothSeparatorProp", "anodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("clothSeparatorProp", "cathodeCasingProp"), "propSuccess");
        propSoundDict.Add(("clothSeparatorProp", "anodeCasingProp"), "propSuccess");
        propSoundDict.Add(("clothSeparatorProp", "electrolyteCathodeCasingProp"), "propSuccess");
        propSoundDict.Add(("clothSeparatorProp", "electrolyteAnodeCasingProp"), "propSuccess");
        propSoundDict.Add(("flashlightProp", "readyBatteryProp"), "propSuccess");
        propSoundDict.Add(("electrolyteProp", "cathodeCasingProp"), "propSuccess");
        propSoundDict.Add(("electrolyteProp", "anodeCasingProp"), "propSuccess");
        propSoundDict.Add(("electrolyteProp", "electrolytelessBatteryProp"), "propSuccess");
        propSoundDict.Add(("electrolyteProp", "separatedCathodeCasingProp"), "propSuccess");
        propSoundDict.Add(("electrolyteProp", "separatedAnodeCasingProp"), "propSuccess");
        propSoundDict.Add(("cathodeTerminalProp", "electrolyteCasingProp"), "propSuccess");
        propSoundDict.Add(("cathodeTerminalProp", "separatedAnodeCasingProp"), "propSuccess");
        propSoundDict.Add(("cathodeTerminalProp", "separatedAnodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("cathodeTerminalProp", "separatedElectrolyteAnodeCasingProp"), "propSuccess");
        propSoundDict.Add(("anodeTerminalProp", "electrolyteCasingProp"), "propSuccess");
        propSoundDict.Add(("anodeTerminalProp", "separatedCathodeCasingProp"), "propSuccess");
        propSoundDict.Add(("anodeTerminalProp", "separatedCathodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("anodeTerminalProp", "separatedElectrolyteCathodeCasingProp"), "propSuccess");
        propSoundDict.Add(("electrolyteCasingProp", "separatedCathodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("electrolyteCasingProp", "separatedAnodeTerminalProp"), "propSuccess");
        propSoundDict.Add(("electrolyteCasingProp", "interiorBatteryProp"), "propSuccess");
        propSoundDict.Add(("separatedAnodeTerminalProp", "cathodeCasingProp"), "propSuccess");
        propSoundDict.Add(("separatedCathodeTerminalProp", "anodeCasingProp"), "propSuccess");
        propSoundDict.Add(("separatedCathodeTerminalProp", "electrolyteAnodeCasingProp"), "propSuccess");
        propSoundDict.Add(("separatedAnodeTerminalProp", "electrolyteCathodeCasingProp"), "propSuccess");

    }

    public void playInteractionSFX()
    {
        var sender = EventManager.GetSender(GameConstants.PropCollisionEvent);
        GameObject prop1 = (GameObject)sender;
        GameObject prop2 = EventManager.GetGameObject(GameConstants.PropCollisionEvent);

        try
        {
            SFXManager.PlaySound(propSoundDict[(prop1.name, prop2.name)]);
        }
        catch (KeyNotFoundException e)
        {
            try
            {
                SFXManager.PlaySound(propSoundDict[(prop2.name, prop1.name)]);
            }
            catch(KeyNotFoundException f)
            {
                SFXManager.PlaySound("fail");
            }
        }
    }
    public void playUIClick()
    {
        SFXManager.PlaySound("uiClick");
    }
    public void playLevelHover()
    {
        SFXManager.PlaySound("levelHover");
    }
    public void playPropDrop()
    {
        SFXManager.PlaySound("propDrop");
    }
    public void playTheFlash()
    {
        SFXManager.PlaySound("theFlash");
    }
}
