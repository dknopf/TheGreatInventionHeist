using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueConstants : MonoBehaviour
{
    public struct Level0_0
    {
        //Load in dialogue
        public const string loadInDialogue = "Huh? I suddenly can’t remember how to rebuild my time machine! Good thing I have you, my trusty lab assistant! Can you help me put our TimeWarper3000 back together?";
        public const string exitLoadInModal = "Luckily, all the parts of the time machine are in the inventory. Click on the frame prop, drag it out of the inventory, and let go of it. Quick, no time to dawdle!";
        public const string frameDraggedIn = "Great! Now, let’s combine it with the siding to build a capsule. Drag out the siding and drop it on top of the frame. Sometimes you’ll need to scroll down in the inventory to see more items!";


        //Tooltips
        public const string frameTooltip = "The frame is the base of the time machine.";
        public const string sidingTooltip = "The siding makes up the walls of the time machine.";
        public const string screenTooltip = "The screen, even though it looks like a microwave, will allow you to choose a year to travel to.";
        public const string warpGeneratorTooltip = "The warp generator lets you warp space and time.";
        public const string fluxAntennaTooltip = "The flux antenna alters the flux waves in your current time dimension.";


        //Misfires
        public const string frameScreen = "It looks like those two things don’t fit together. There are lots of ways to build an invention, but not everything will work!";
        public const string frameWarpGenerator = "It looks like those two things don’t fit together. There are lots of ways to build an invention, but not everything will work!";
        public const string sidingScreen = "It looks like those two things don’t fit together. There are lots of ways to build an invention, but not everything will work!";
        public const string sidingWarpGenerator = "It looks like those two things don’t fit together. There are lots of ways to build an invention, but not everything will work!";
        public const string screenWarpGenerator = "It looks like those two things don’t fit together. There are lots of ways to build an invention, but not everything will work!";
        public const string fluxAntennaCapsule = "There might be items in the inventory that don’t fit into the final invention. Don’t worry if you don’t use everything!";
        public const string fluxAntennaScreen = "There might be items in the inventory that don’t fit into the final invention. Don’t worry if you don’t use everything!";
        public const string fluxAntennaScreenCapsule = "There might be items in the inventory that don’t fit into the final invention. Don’t worry if you don’t use everything!";
        public const string fluxAntennaWarpGenerator = "There might be items in the inventory that don’t fit into the final invention. Don’t worry if you don’t use everything!";
        public const string fluxAntennaWarpCapsule= "There might be items in the inventory that don’t fit into the final invention. Don’t worry if you don’t use everything!";
        public const string fluxAntennaSiding = "There might be items in the inventory that don’t fit into the final invention. Don’t worry if you don’t use everything!";
        public const string fluxAntennaFrame = "There might be items in the inventory that don’t fit into the final invention. Don’t worry if you don’t use everything!";

        //Successess
        public const string frameSiding = "Nice, we made a capsule! Now, try combining other things to finish building the time machine. If you get stuck, hover your mouse over an inventory item for information about it.";
        public const string capsuleScreen = "Nice job! If you’d like to learn more about how this part of the time machine works, click the button below.";
        public const string capsuleWarpGenerator = "Nice job! If you’d like to learn more about how this part of the time machine works, click the button below.";
        public const string warpCapsuleScreen = "Nice, you fixed the time machine! You can always check this box for hints and advice.";
        public const string screenCapsuleWarpGenerator = "Nice, you fixed the time machine! You can always check this box for hints and advice.";

        //Learn more text
        public const string capsuleMaterial = "The time machine is made of Timemium, which is a super strong substance that can withstand time travel! Not to be confused with Mimeium, which is commonly found in France.";
    }

    public struct Level1_1
    {
        //Load in dialogue
        public const string loadInDialogue = "What just happened? It seems my memory was stolen? Right as I was making a breakthrough with my revolutionary lighter-than-air technology! Can you help me finish building my blimp?";

        //tooltips boyyyyyy
        public const string heliumTooltip = "Helium is one of the least dense gases in the universe. It’s even lighter than air!";
        public const string hydrogenTooltip = "Hydrogen is the least dense gas. Beware, it can catch on fire...";
        public const string canvasTooltip = "A big piece of woven cloth.";
        public const string frameTooltip = "The skeleton of a blimp. The frame is what makes it hold its shape!";
        public const string motorTooltip = "Motors and propellers can make things fly.";
        public const string airTooltip = "Air is the gas that you breathe! It is mostly made up of Nitrogen and Oxygen.";
        public const string tankTooltip = "A nice empty tank.";
        public const string tailfinTooltip = "The fins at the back of the blimp. They can be moved up and down to push air in certain directions!";

        //Misfires
        public const string heliumCanvas = "Oh dear. It looks like we made a balloon… and it floated away. This must be because helium is less dense than air.";
        public const string heliumTank = "Hmmm… I think helium gas isn't dense enough to weigh down our blimp!";
        public const string heliumBody = "Ach, it seems like our blimp floats, but there’s nothing to weigh it down!";
        public const string heliumBallast = "Our ballast tank is already full of air, if we put lightweight helium in it we won’t be able to go back down!";
        public const string heliumSteerableBody = "Ach! There was nothing to weigh it down and it floated away!";
        public const string heliumWeightedBody = "Hurrumph. It seems like our blimp floats, but there’s no way of controlling its direction.";
        public const string hydrogenCanvas = "Oh dear. It looks like we made a balloon… and it floated away. This is because hydrogen is less dense than air.";
        public const string hydrogenTank = "Hmmm… I think hydrogen gas isn't dense enough to weigh down our blimp!";
        public const string hydrogenBody = "It seems like our blimp floats, but there’s nothing to weigh it down! Maybe it needs something denser than hydrogen so it doesn't fly away!";
        public const string hydrogenBallast = "We already put air in the tank!";
        public const string hydrogenSteerablebody = "Nein!!! A spark from the motor ignited the hydrogen and our blimp exploded! Don’t forget, hydrogen catches on fire very easily.";
        public const string hydrogenWeightedBody = "Hurrumph. A spark ignited the hydrogen and our blimp exploded! Don’t forget, hydrogen catches on fire very easily.";
        public const string hydrogenEmptyBlimp = "Nein!!! A spark from the motor ignited the hydrogen and our blimp exploded! Don’t forget, hydrogen catches on fire very easily.";
        public const string tailfinFrame = "We need to be able to fill our blimp with gas before we can steer it!";
        public const string motorFrame = "We need to be able to fill our blimp with gas before we can steer it!";
        public const string tailfinBody = "Maybe we should connect something that can move the tailfins first.";
        public const string motorBody = "Maybe we should hook this motor up to what steers the blimp first.";
        public const string airBody = "We can't have lighter-than-air travel if we're not lighter than air!";
        public const string airWeightedBody = "We can't have lighter-than-air travel if we're not lighter than air!";
        public const string airSteerableWeightedBody = "We can't have lighter-than-air travel if we're not lighter than air!";
        public const string airSteerableBody = "We can't have lighter-than-air travel if we're not lighter than air!";
        public const string airEmptyBlimp = "We can't have lighter-than-air travel if we're not lighter than air!";
        public const string heliumFrame = "The frame is full of holes!. If we don’t put a cover on it all the gas will float out.";
        public const string airFrame = "The frame is full of holes!. If we don’t put a cover on it all the gas will float out.";
        public const string hydrogenFrame = "The frame is full of holes!. If we don’t put a cover on it all the gas will float out.";
        public const string tankFrame = "This is just an ol’ empty tank! Let’s fill it with something first.";
        public const string tankBody = "This is just an ol’ empty tank! Let’s fill it with something first.";
        public const string tankSteerableBody = "You have the right idea! If we fill this tank with something and then attach it to the blimp we won’t float into space!";
        public const string tailfinWeightedBody = "Maybe we should connect something to the tailfins that can make them move first.";
        public const string motorWeightedBody = "Maybe we should hook this motor up to the part that steers the blimp first.";


        //Successess
        public const string frameCanvas = "Well done, friend! We made the body of the blimp.";
        public const string motorTailfin = "Hurrah! We put together a device to steer the blimp.";
        public const string airTank = "Fantastic! A tank full of air will keep our blimp from floating away forever. By replacing light helium with heavy air while flying we can bring our blimp down to Earth!";
        public const string bodySteeringMechanism = "Fantastic! Now we can steer the blimp left, right, up, and down.";
        public const string bodyBallast = "Well done friend! Now our blimp body is weighed down and won’t float away forever.";
        public const string steeringMechanismWeightedBody = "Great job, I think we’re getting close!";
        public const string steerableBodyBallast = "Great job, I think we’re getting close! Now our blimp won't float away!";
        public const string heliumEmptyBlimp = "Hurrah! We’ve done it!";

        //Learn more text

        public const string airWeight = "If we just fill our blimp with helium, it will float away forever! By adding air, which is denser than helium, we can make sure our blimp doesn’t float too far upwards. Air is made up mostly of heavy nitrogen and oxygen, so changing the amount of air in our blimp mid-flight can make it go up or down!";
        public const string lighterThanAirTravel = "The balloon pushes air out of the way whenever it moves. This air needs somewhere to go, so it pushes back against the balloon. Air is denser closer to the ground. So, air below the balloon pushes more than above the balloon. This is strong enough to lift the balloon up!";
    }

    public struct Level1_2
    {
        //Load in dialogue
        public const string loadInDialogue = "What just happened? Those rapscallions must have stolen our memories! I’m Orville Wright, and this is my brother Wilbur! We were about to finish building our flying machine, can you help us complete it?";

        //tooltips
        public const string wheelsTooltip = "Wheels are round objects that spin and make things easier to move.";
        public const string propellerTooltip = "A propeller makes an airplane move forward. The faster it spins, the faster the plane will move!";
        public const string engineTooltip = "An engine is a machine with moving parts that turns power into motion.";
        public const string fuelTooltip = "Fuel is liquid that is burned to create power. Careful, it can explode!";
        public const string frameTooltip = "This is the skeleton of the airplane. The frame is what makes it hold its shape!";
        public const string clothTooltip = "Cloth is a woven fabric that could be used to stretch over something.";
        public const string aileronTooltip = "The ailerons are movable flaps attached to the wings that help the plane rotate along its center.";
        public const string elevatorTooltip = "The elevators are movable flaps on the tailfin of an airplane that controls how it points up and down.";
        public const string rudderTooltip = "The rudders are movable flaps on the tailfin of an airplane that controls how it moves side to side.";
        public const string waterTooltip = "Water is great to cool things down.";

        //Misfires
        public const string frameAnything = "Let’s try adding stretching something over the frame to complete the wings of the plane first!";
        public const string engineBody = "Gosh, don’t you think our engine needs something to power it before we attach it to the body?";
        public const string engineWheeledBody = "Gosh, don’t you think our engine needs something to power it before we attach it to the body?";
        public const string enginePropellerBody = "Gosh, don’t you think our engine needs something to power it before we attach it to the body?";
        public const string engineWheeledPropellerBody = "Gosh, don’t you think our engine needs something to power it before we attach it to the body?";
        public const string frameFueledEngine = "Hmm, this looks like it could move forward, but with no wings how will it move upwards?";
        public const string fueledEngineBody = "Hmmmm. It seems like there’s a chance our engine could overheat. All that movement will cause it to heat up, how can we cool it down?";
        public const string fueledEngineWheeledBody = "Hmmmm. It seems like there’s a chance our engine could overheat. All that movement will cause it to heat up, how can we cool it down?";
        public const string fueledEnginePropellerBody = "Hmmmm. It seems like there’s a chance our engine could overheat. All that movement will cause it to heat up, how can we cool it down?";
        public const string fueledEngineWheeledPropellerBody = "Hmmmm. It seems like there’s a chance our engine could overheat. All that movement will cause it to heat up, how can we cool it down?";
        public const string aileronMotorizedPropellerBody = "Before we think about steering our plane in the air, we need to steer it on the ground!";
        public const string elevatorMotorizedPropellerBody = "Before we think about steering our plane in the air, we need to steer it on the ground!";
        public const string rudderMotorizedPropellerBody = "Before we think about steering our plane in the air, we need to steer it on the ground!";
        public const string bodyAileron = "We shouldn’t focus on steering in the air until we can fly!";
        public const string bodyRudder = "We shouldn’t focus on steering in the air until we can fly!";
        public const string bodyElevator = "We shouldn’t focus on steering in the air until we can fly!";
        public const string wheeledBodyAileron = "We shouldn’t focus on steering in the air until we can fly!";
        public const string wheeledBodyRudder = "We shouldn’t focus on steering in the air until we can fly!";
        public const string wheeledBodyElevator = "We shouldn’t focus on steering in the air until we can fly!";
        public const string motorizedBodyAileron = "We shouldn’t focus on steering in the air until we can fly!";
        public const string motorizedBodyRudder = "We shouldn’t focus on steering in the air until we can fly!";
        public const string motorizedBodyElevator = "We shouldn’t focus on steering in the air until we can fly!";
        public const string propellerBodyAileron = "We shouldn’t focus on steering in the air until we can fly!";
        public const string propellerBodyRudder = "We shouldn’t focus on steering in the air until we can fly!";
        public const string propellerBodyElevator = "We shouldn’t focus on steering in the air until we can fly!";
        public const string motorizedWheeledBodyAileron = "We shouldn’t focus on steering in the air until we can fly!";
        public const string motorizedWheeledBodyRudder = "We shouldn’t focus on steering in the air until we can fly!";
        public const string motorizedWheeledBodyElevator = "We shouldn’t focus on steering in the air until we can fly!";
        public const string wheeledPropellerBodyAileron = "We shouldn’t focus on steering in the air until we can fly!";
        public const string wheeledPropellerBodyRudder = "We shouldn’t focus on steering in the air until we can fly!";
        public const string wheeledPropellerBodyElevator = "We shouldn’t focus on steering in the air until we can fly!";
        public const string fueledEnginePropeller = "The propeller has to be attached to the nose of the airplane.There’s no air to push on the inside of the plane!";

        //Successes
        public const string wheelsBody = "Well done! Now our plane can roll across the ground. This will help us gain some speed for takeoff!";
        public const string wheelsMotorizedBody = "Well done! Now our plane can roll across the ground. This will help us gain some speed for takeoff!";
        public const string wheelsPropellerBody = "Well done! Now our plane can roll across the ground. This will help us gain some speed for takeoff!";
        public const string wheelsMotorizedPropellerBody = "Well done! Now our plane can roll across the ground. This will help us gain some speed for takeoff!";
        public const string propellerBody = "This propeller will absolutely help our contraption move in the air. The propeller can push air backwards, moving the plane forwards.";
        public const string propellerWheeledBody = "This propeller will absolutely help our contraption move in the air. The propeller can push air backwards, moving the plane forwards.";
        public const string propellerMotorizedBody = "The propeller will push our airplane forward and keep air moving over our wings!";
        public const string propellerMotorizedWheeledBody = "The propeller will push our airplane forward and keep air moving over our wings!";
        public const string engineFuel = "Fuel in the engine seems like a swell idea. That way the reaction can power the engine, making it spin!";
        public const string frameCloth = "We’ve made the wings of the plane! Remember, the air below the wing’s curve pushes against the wing more than the air on top, lifting the whole plane up!";
        public const string unsteerableBodyAileron = "The aileron helps us steer our plane.";
        public const string unsteerableBodyElevator = "The elevator helps us steer our plane.";
        public const string unsteerableBodyRudder = "The rudder helps us steer our plane.";
        public const string waterFueledEngine = "Thank goodness, we needed to cool down that engine or it would’ve blown to bits! When engines spin their movement creates lots of heat that could do in our airplane.";
        public const string cooledEngineBody = "Now that we’ve cooled down the engine, attaching it to the body is a swell idea.";
        public const string cooledEngineWheeledBody = "Now that we’ve cooled down the engine, attaching it to the body is a swell idea.";
        public const string cooledEnginePropellerBody = "The propeller will push our airplane forward and keep air moving over our wings!";
        public const string cooledEngineWheeledPropellerBody = "The propeller will push our airplane forward and keep air moving over our wings!";
        public const string rollPlaneElevator = "By moving the elevator up and down, we can push air up and down, pointing the plane towards the ground or towards the sky.";
        public const string rollPlaneRudder = "By moving the rudder side to side, we can push air to the side, turning our plane to the opposite side.";
        public const string tiltPlaneAileron = "Moving the ailerons on the wings up and down pushes air so that the wings point towards the sky or the ground, rolling the plane.";
        public const string turnPlaneAileron = "Moving the ailerons on the wings up and down pushes air so that the wings point towards the sky or the ground, rolling the plane.";
        public const string tiltPlaneRudder = "By moving the rudder side to side we can push air to the side, turning our plane to the opposite side.";
        public const string turnPlaneElevator = "By moving the elevator up and down, we can push air up and down, pointing the plane towards the ground or towards the sky.";
        public const string tiltTurnPlaneAileron = "Thanks for the help, pal, you're all Wright by us!";
        public const string rollTiltPlaneRudder = "Thanks for the help, pal, you're all Wright by us!";
        public const string rollTurnPlaneElevator = "Thanks for the help, pal, you're all Wright by us!";

        //Learn more text
        public const string wingShape = "By designing a wing like so, the air will move around it at different speeds. The air will flow faster over the curved top than the bottom! Because the air on top moves faster, it pushes against the wing less. So, the air on the bottom pushes up on the wing more, bringing the whole plane upwards!";
        public const string thrust = "A propeller is needed to push an airplane forward so that it can take off and move during flight. The engine powers the propeller, which makes it spin very fast. When the propeller spins, it acts like a bunch of tiny wings. Instead of pushing air down, the propeller pushes air backwards, which makes the entire airplane move forward.";
        public const string steering = "Each of these parts controls the direction of the plane. By moving flaps attached to the plane, air is pushed in different directions, which changes where the plane goes.";
    }

    public struct Level1_3
    {
        //Load in dialogue
        public const string loadInDialogue = "This is totally bogus! It seems those punks just stole my memory! I’m Margaret Hamilton, a programmer for NASA. Can you help us put a rocketship together so we can fly to the moon?";

        //Tooltips
        public const string payloadTooltip = "The payload holds what your rocket is delivering, such as people or satellites.";
        public const string oxidizerTooltip = "The oxidizer tank holds a type of chemical which a fuel requires to burn.";
        public const string petroleumTooltip = "Petroleum is gasoline. This is what you put in your car!";
        public const string heliumTooltip = "Helium is a very light gas, but it can’t catch on fire.";
        public const string finsTooltip = "Fins help stabilize the rocket during flight.";
        public const string igniterTooltip = "An igniter starts fires. Make sure to put it somewhere safe!";
        public const string emptyChamberTooltip = "This chamber can handle heavy-duty explosions.";
        public const string valvesTooltip = "Valves control if liquid moves through pipes, similar to a sink faucet at home.";
        public const string launchTooltip = "The launchpad is where the rocket is built and where it blasts off from.";
        public const string computerTooltip = "A computer controls many parts of the rocket, such as its flight path.";
        public const string codeTooltip = "Code is the instructions to the computer telling it what to do.";
        public const string frameTooltip = "The frame holds the rocket together. It’s often made from strong but lightweight materials, like titanium or aluminum.";

        //Misfires
        public const string payloadFrame = "I think usually they build the body on the launchpad where it will blast off.";
        public const string payloadLaunchpad = "We can’t put the payload in the scaffolding without something to support it!";
        public const string guidedPayloadLaunchpad = "We can’t put the payload in the scaffolding without something to support it!";
        public const string oxidizerHelium = "Our oxidizer will burn, but helium won’t! With helium as fuel, our rocket will never blast off.";
        public const string oxidizerIgniter = "Jeepers! The explosion wasn’t contained and we blew everything up!";
        public const string oxidizerCombustionChamber = "Pretty underwhelming. We’re gonna need a bigger explosion to boost a rocket.";
        public const string petroleumHelium = "Helium doesn’t burn, which makes it a bad oxidizer. Without an oxidizer, our petroleum won’t explode in space.";
        public const string petroleumIgniter = "Without an oxidizer, our petroleum won’t be able to explode in space.";
        public const string petroleumCombustionChamber = "Without an oxidizer, our petroleum won’t be able to explode in space.";
        public const string heliumIgniter = "I don’t know about that, helium isn’t flammable.";
        public const string heliumValves = "There’s no point in attaching valves to that tank, since helium makes bad rocket fuel.";
        public const string heliumCombustionChamber = "There’s no point in putting a helium tank in the combustion chamber, since helium doesn’t explode.";
        public const string heliumValvedOxidizer = "There’s no point in attaching helium to the oxidizer since helium won’t burn. The rocket won’t be able to fly that way.";
        public const string heliumValvedPetroleum = "There’s no point in attaching helium to the petroleum since helium won’t burn. We won’t be able to light the petroleum if we can’t start a fire in space!";
        public const string finsFrame = "Have you thought about building the rocket on the launchpad?";
        public const string computerPayloadFrame = "The computer is useless without code telling it what to do.";
        public const string computerFinnedFrame = "The computer is useless without code telling it what to do.";
        public const string computerLaunchpadFrame = "The computer is useless without code telling it what to do.";
        public const string computerFinnedPayloadFrame = "The computer is useless without code telling it what to do.";
        public const string combustionChamberDualTanks = "We need a way to control how much liquid from the tanks flows through the pipes.";
        public const string combustionChamberPayloadFrame = "There’s no fuel to combust!";
        public const string combustionChamberFinnedFrame = "There’s no fuel to combust!";
        public const string combustionChamberLaunchpadFrame = "There’s no fuel to combust!";
        public const string combustionChamberGuidedPayloadFrame = "There’s no fuel to combust!";
        public const string combustionChamberFinnedPayloadFrame = "There’s no fuel to combust!";
        public const string fuelSupplyLaunchpadFrame = "We shouldn’t attach the fuel to the frame without a safe place to make it explode!";
        public const string fuelSupplyGuidedPayloadFrame = "We shouldn’t attach the fuel to the frame without a safe place to make it explode!";
        public const string fuelSupplyFinnedPayloadFrame = "We shouldn’t attach the fuel to the frame without a safe place to make it explode!";
        public const string fuelSupplyImmovableFrame = "We shouldn’t attach the fuel to the frame without a safe place to make it explode!";
        public const string framePropulsionSystem = "Have you thought about building the rocket on the launchpad?";
        public const string igniterFrame = "We need to contain this igniter somehow, otherwise we’ll set fire to our rocket.";
        public const string igniterFuelSupply = "If we don't ignite our fuel supply in a safe space the rocket will go kablooey!";
        public const string igniterLaunchpadFrame = "We need to contain this igniter somehow, otherwise we’ll set fire to our rocket.";
        public const string igniterPayloadFrame = "We need to contain this igniter somehow, otherwise we’ll set fire to our rocket.";
        public const string igniterFinnedFrame = "We need to contain this igniter somehow, otherwise we’ll set fire to our rocket.";
        public const string igniterGuidedPayloadFrame = "We need to contain this igniter somehow, otherwise we’ll set fire to our rocket.";
        public const string igniterFinnedPayloadFrame = "We need to contain this igniter somehow, otherwise we’ll set fire to our rocket.";
        public const string valvesCombustionChamber = "Let’s hook up the valves to our fuel supply first!";
        public const string valvesEmptyChamber = "Let’s hook up the valves to our fuel supply first!";
        public const string dualTanksEmptyChamber = "We need a way to control how much liquid from the tanks flows through the pipes.";
        public const string dualTanksFrame = "We need to build the propulsion system first. How could we get these fuel tanks to create an explosion?";
        public const string dualTanksLaunchpadFrame = "We need to build the propulsion system first. How could we get these fuel tanks to create an explosion?";
        public const string dualTanksPayloadFrame = "We need to build the propulsion system first. How could we get these fuel tanks to create an explosion?";
        public const string dualTanksFinnedFrame = "We need to build the propulsion system first. How could we get these fuel tanks to create an explosion?";
        public const string dualTanksGuidedPayloadFrame = "We need to build the propulsion system first. How could we get these fuel tanks to create an explosion?";
        public const string dualTanksFinnedPayloadFrame = "We need to build the propulsion system first. How could we get these fuel tanks to create an explosion?";
        public const string heliumFrame = "If anything, the helium would be a part of the system that propels the rocket.";
        public const string heliumLaunchpadFrame = "If anything, the helium would be a part of the system that propels the rocket.";
        public const string heliumPayloadFrame = "If anything, the helium would be a part of the system that propels the rocket.";
        public const string heliumFinnedFrame = "If anything, the helium would be a part of the system that propels the rocket.";
        public const string heliumGuidedPayloadFrame = "If anything, the helium would be a part of the system that propels the rocket.";
        public const string heliumFinnedPayloadFrame = "If anything, the helium would be a part of the system that propels the rocket.";
        public const string heliumGuidanceSystem = "If anything, the helium would be a part of the system that propels the rocket.";
        public const string petroleumEmptyChamber = "Petroleum won’t explode in outer space without another substance to provide oxygen.";
        public const string heliumEmptyChamber = "If anything, this helium wouldn’t be able to explode in outer space without another substance to provide oxygen.";
        public const string oxidizerEmptyChamber = "Just the oxidizer by itself won’t create a powerful enough explosion to propel a rocket.";
        public const string heliumPropulsionSystem = "It seems like the rocket already has what it needs to launch into space!";
        public const string heliumPropulsionFrame = "It seems like the rocket already has what it needs to launch into space!";
        public const string heliumPayloadPropulsionFrame = "It seems like the rocket already has what it needs to launch into space!";
        public const string heliumFinnedPropulsionFrame = "It seems like the rocket already has what it needs to launch into space!";
        public const string heliumDualTanks = "Helium isn’t flammable, so adding it to our fuel supply would stop the reaction that lets us blast off!";
        public const string emptyChamberFuelSupply = "There’s no point in attaching this chamber to the fuel supply if the chamber is empty!";

        //Successess
        public const string payloadGuidanceSystem = "Now the payload knows where to go! That’s ace!";
        public const string payloadFinnedFrame = "This rocket’s starting to come together!";
        public const string payloadLaunchpadFrame = "Good plan to build the rocket right on the launchpad.";
        public const string payloadPropulsionFrame = "Groovy! This rocket’s starting to come together!";
        public const string payloadFinnedPropulsionFrame = "Groovy! This rocket’s starting to come together!";
        public const string oxidizerPetroleum = "Nice job! Now, with the oxygen that the oxidizer provides, the petroleum will be able to explode in outer space.";
        public const string oxidizerValves = "We can use the valves to control how much oxidizer we want!";
        public const string oxidizerValvedPetroleum = "Sweet! We can use the right amount of oxidizer to start a fire in space that will make the petroleum explode! Now we just need a place to burn it.";
        public const string petroleumValves = "We can use the valves to control how much petroleum we want!";
        public const string petroleumValvedOxidizer = "Sweet! We can use the right amount of oxidizer to start a fire in space that will make the petroleum explode! Now we just need a place to burn it.";
        public const string finsPayloadFrame = "Now that we’ve got fins, our rocket will be much more stable during flight. Fins, baby!";
        public const string finsLaunchpadFrame = "Now that we’ve got fins, our rocket will be much more stable during flight. Fins, baby!";
        public const string finsGuidedPayloadFrame = "Outer space, here we come!";
        public const string finsPropulsionFrame = "Now that we’ve got fins, our rocket will be much more stable during flight. Fins, baby!";
        public const string finsPayloadPropulsionFrame = "Outer space, here we come!";
        public const string igniterEmptyChamber = "Cool beans, if we explode something here the energy will go out the back of our rocket, making it fly!";
        public const string launchFrame = "Solid start to building a rocket.";
        public const string computerCode = "Phew, with all that code I wrote the rocket will fly straight to the moon.";
        public const string guidanceSystemPayloadFrame = "This rocket’s starting to come together!";
        public const string guidedPayloadLaunchpadFrame = "This rocket’s starting to come together!";
        public const string guidanceSystemPayloadPropulsionFrame = "Outer space, here we come!";
        public const string combustionChamberFuelSupply = "If we create an explosion in the combustion chamber we can funnel it out the back of the rocket. This will push the whole rocket forward!";
        public const string dualTanksValves = "Sweet! We can use the right amount of oxidizer to start a fire in space that will make the petroleum explode! Now we just need a place to burn it.";
        public const string payloadFramePropulsionSystem = "Outer space, here we come!";
        public const string finnedFrameGuidedPayload = "Outer space, here we come!";
        public const string finnedFramePropulsionSystem = "Outer space, here we come!";
        public const string propulsionSystemLaunchpadFrame = "This baby’s all powered up, we’re almost ready to go!";
        public const string propulsionSystemGuidedPayloadFrame = "Outer space, here we come!";
        public const string propulsionSystemFinnedPayloadFrame = "Outer space, here we come!";
        public const string propulsionFrameGuidedPayload = "Outer space, here we come!";
        public const string finsUnfinnedFrame = "Hooray, the rocket is complete! Humanity is blasting off into the future!";
        public const string guidanceSystemUnguidedFrame = "Hooray, the rocket is complete! Humanity is blasting off into the future!";
        public const string guidedPayloadFinnedPropulsionFrame = "Hooray, the rocket is complete! Humanity is blasting off into the future!";
        public const string propulsionSystemImmovableFrame = "Hooray, the rocket is complete! Humanity is blasting off into the future!";
        public const string guidanceSystemFinnedPayloadFrame = "Outer space, here we come!";

        //Learn more text
        public const string fireInSpace = "Petroleum is highly combustible, so when it lights on fire it causes a huge explosion. That explosion is big enough to propel a rocket! But you need oxygen to light a fire, and there’s no oxygen in space. By using just the right amount of oxidizer (which is flammable) and petroleum, we can start a fire in space.";
        public const string explosionPropulsion = "Using the oxidizer to start a fire, we can make petroleum explode in space! Openings in the back of the chamber will direct the explosion out the back of the rocket. The explosion creates force. The explosion moves backwards, and the force it creates pushes the rocket forward!";
        public const string codeHistory = "To code a computer, a programmer uses techniques in software engineering (I actually created this term!). This involves imagining all the different things code needs to address, as well as testing it in different situations. For example, if an astronaut makes a mistake, the code controlling a rocketship will recognize that and warn them. Onboard the Apollo rockets, I worked on code that helped with guidance, navigation, and control of the spacecraft.";

    }

    public struct Level2_1
    {
        //Load in dialogue
        public const string loadInDialogue = "Wow, it seems someone did steal my memory, even when I told them not to! What hogwash! I’m Thomas Edison, some call me America’s Greatest Inventor. Can you help me finish up my new bulb of light?";

        //Tooltips

        public const string tungstenFilamentTooltip = "Tungsten is a metal with high resistance and a high melting point.";
        public const string aluminumFilamentTooltip = "Aluminum is a metal with low resistance and a medium melting point.";
        public const string wiresTooltip = "These wires have a low resistance, so electrons can flow through them easily!";
        public const string glassShellTooltip = "This piece of glass is the casing for the lightbulb.";
        public const string argonTooltip = "Argon is an inert, colorless gas that pretty much doesn’t affect anything.";
        public const string screwcapTooltip = "The screwcap is a conductive metal shell that can be screwed into a socket.";
        public const string electricalContactTooltip = "The electrical contact is a conductive piece of metal that lets electrons flow from a socket.";
        public const string lampTooltip = "This lamp could light up an entire room! It’s connected to a circuit!";

        //Misfires

        public const string tungstenFilamentScrewcap = "Don’t monkey around with the filament before we connect it to the circuit!";
        public const string tungstenFilamentElectricalContact = "Don’t monkey around with the filament before we connect it to the circuit!";
        public const string tungstenFilamentLamp = "Don’t monkey around with the filament before we connect it to the circuit!";
        public const string tungstenFilamentScrewcapContact = "Don’t monkey around with the filament before we connect it to the circuit!";
        public const string wiresAluminumFilament = "The melting point of aluminum is too low, if we attach it to electricity it’ll melt!";
        public const string wiresScrewcap = "Perhaps try connecting the wires to something else first, you loony.";
        public const string wiresElectricalContact = "Perhaps try connecting the wires to something else first, you loony.";
        public const string wiresScrewcapContact = "Perhaps try connecting the wires to something else first, you loony.";
        public const string glassShellElectricalContact = "It might be a good idea to build out the inside of the lightbulb before attaching the glass.";
        public const string glassShellLamp = "We’ll need some sort of metal to conduct the electricity from the lamp.";
        public const string glassShellWiredFilament = "We’ll need some sort of metal to conduct the electricity from the lamp.";
        public const string glassShellScrewcapContact = "We shouldn’t seal our lightbulb without a way to make light first.";
        public const string aluminumFilamentScrewcap = "Don’t we need something to connect the filament up first?";
        public const string aluminumFilamentElectricalContact = "Perhaps we need something to connect the filament up first?";
        public const string aluminumFilamentInertShell = "There’s nothing to connect up our filament to electricity yet!";
        public const string argonInnerLightbulb = "It seems we’re on the right path, friend, but our gas will float away without something to hold it!";
        public const string screwcapWiredFilament = "With only the screwcap, electricity won’t be able to flow out of the lightbulb. We need to attach it to another part to make a complete circuit!";
        public const string screwcapInertShell = "It might be a good idea to build out the inside of the lightbulb before attaching the glass.";
        public const string electricalContactWiredFilament = "With only the electrical contact, electricity won’t be able to flow out of the lightbulb. We need to attach it to another part to make a complete circuit";
        public const string lampInnerLightbulb = "Uh oh, we’re really in the soup now! Our filament caught on fire! If only there was some way to prevent fires from starting.";
        public const string lampFlammableLightbulb = "Uh oh, we’re really in the soup now! Our filament caught on fire! If only there was some way to prevent fires from starting.";
        public const string wiredFilamentInertShell = "Before attaching the glass shell, let’s find a way to hook up our filament to an electric circuit.";
        public const string inertShellScrewcapContact = "Before attaching the glass shell, let’s find a way to hook up our filament.";
        public const string screwcapLamp = "We need to build the lightbulb before attaching it to the lamp!";
        public const string glassShellWires = "The wires need to be attached to something they can power!";
        public const string glassShellAluminumFilament = "There’s nothing in this shell to power the filament! What a cockamamie idea!";
        public const string glassShellTungstenFilament = "There’s nothing in this shell to power the filament! What a cockamamie idea!";
        public const string inertShellWires = "The wires need to be attached to something they can power!";
        public const string inertShellAluminumFilament = "There’s nothing in this shell to power the filament! What a cockamamie idea!";
        public const string inertShellElectricalContact = "Maybe we should build out the inside of the lightbulb before attaching the glass shell.";
        public const string electricalContactLamp = "Let’s build the lightbulb before attaching it to power!";
        public const string aluminumFilamentWiredFilament = "The lightbulb already has a filament, you scoundrel!";
        public const string aluminumFilamentInnerLightbulb = "The lightbulb already has a filament, you scoundrel!";
        public const string aluminumFilamentUnpoweredLightbulb = "The lightbulb already has a filament, you chowderhead!";
        public const string aluminumFilamentFlammableLightbulb = "The lightbulb already has a filament, you chowderhead!";
        public const string wiredFilamentLamp = "We need a way to connect the filament to the lamp to complete the circuit!";

        //Successess
        public const string tungstenFilamentWires = "Our filament is ready to be connected to the rest of the circuit. This sure is nifty!";
        public const string glassShellArgon = "By filling the lightbulb with argon, our filament won’t catch fire! Whoopee!";
        public const string glassShellInnerLightbulb = "Wow, we’re almost ready to go! Making light is a cinch!";
        public const string argonFlammableLightbulb = "By filling the lightbulb with argon, our filament won’t catch fire! Whoopee!";
        public const string screwcapElectricalContact = "This will work perfectly to hook up our circuit.";
        public const string lampUnpoweredLightbulb = "Wow, look at that glow! We’re all razzle-dazzle now!";
        public const string wiredFilamentScrewcapContact = "Our circuit is complete, I’m sure the filament will glow now.";
        public const string inertShellInnerLightbulb = "I have a good feeling about this, now we just need to power it up!";

        //Learn more text
        public const string filamentExplodes = "The filament needs to be protected from oxygen in the air so it doesn’t catch on fire. The air in the bulb can either be removed with a vacuum, or replaced with a gas that doesn’t affect anything, like argon.";
        public const string meltingPoint = "A metal must be heated to high temperatures before it will create a useful amount of light. Most metals will actually melt before reaching such extreme temperatures. Lightbulbs are made with tungsten filaments because tungsten has a very high melting temperature. That means it won’t melt before emitting light!";
        public const string completeCircuit = "One wire connects to the electrical contact and the other connects to the screwcap. This makes a path for electrons to flow from power, to the electrical contact, into the filament, and out through the screwcap to the ground. Electrons flowing on this path power the filament, creating light!";
    }

    public struct Level2_2
    {
        //Load in dialogue
        public const string loadInDialogue = "Huh? Why can’t I remember anything?! How ever will I invent my electrical storage device! I feel a spark between us, can you help me create my precious battery?";

        //Tooltips
        public const string positiveTerminalTooltip = "The positive terminal is the end of the circuit. Electrons want to go here!";
        public const string negativeTerminalTooltip = "The negative terminal is the start of the circuit. Electrons want to leave from here!";
        public const string casingTooltip = "The casing is made of steel and will hold the parts of the battery.";
        public const string anodeTooltip = "The anode is a chunk of zinc. Zinc gives away electrons easily.";
        public const string cathodeTooltip = "The cathode is a chunk of copper. Copper takes in electrons easily.";
        public const string sulfuricAcidTooltip = "Sulfuric acid can be used to make a liquid electrolyte.";
        public const string waterTooltip = "Water can be used to make a liquid electrolyte.";
        public const string metalSeparatorTooltip = "The metal separator is made of a material that electrons can flow through.";
        public const string clothSeparatorTooltip = "The cloth separator is made of a fabric that electrons can’t go through.";
        public const string flashlightTooltip = "A device with a lightbulb that can be powered by electricity.";

        //Misfires
        public const string positiveTerminalCasing = "The positive terminal needs to be attached to something that takes in electrons first! I’m positive about that. ";
        public const string positiveTerminalAnode = "The positive terminal needs to be attached to something that takes in electrons, not gives them away! I’m positive about that.";
        public const string positiveTerminalElectrolyteCasing = "The positive terminal needs to be attached to something that takes in electrons first! I’m positive about that. ";
        public const string positiveTerminalAnodeCasing = "The positive terminal needs to be attached to something that takes in electrons, not gives them away! I’m positive about that.";
        public const string positiveTerminalSeparatedAnodeCasing = "The positive terminal needs to be attached to something that takes in electrons, not gives them away! I’m positive about that.";
        public const string positiveTerminalSeparatedAnodeTerminal = "The positive terminal needs to be attached to something that takes in electrons, not gives them away! I’m positive about that.";
        public const string positiveTerminalSeparatedElectrolyteAnodeCasing = "The positive terminal needs to be attached to something that takes in electrons, not gives them away! I’m positive about that.";
        public const string positiveTerminalElectrolyteAnodeCasing = "The positive terminal needs to be attached to something that takes in electrons, not gives them away! I’m positive about that.";
        public const string negativeTerminalCasing = "The negative terminal needs to be attached to something that gives away electrons first!";
        public const string negativeTerminalCathode = "The negative terminal needs to be attached to something that gives away electrons, not takes them in!";
        public const string negativeTerminalElectrolyteCasing = "The negative terminal needs to be attached to something that gives away electrons, not takes them in!";
        public const string negativeTerminalCathodeCasing = "The negative terminal needs to be attached to something that gives away electrons, not takes them in!";
        public const string negativeTerminalSeparatedCathodeCasing = "The negative terminal needs to be attached to something that gives away electrons, not takes them in!";
        public const string negativeTerminalSeparatedCathodeTerminal = "The negative terminal needs to be attached to something that gives away electrons, not takes them in!";
        public const string negativeTerminalSeparatedElectrolyteCathodeCasing = "The negative terminal needs to be attached to something that gives away electrons, not takes them in!";
        public const string negativeTerminalElectrolyteCathodeCasing = "The negative terminal needs to be attached to something that gives away electrons, not takes them in!";
        public const string anodeCathode = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string anodeCathodeTerminal = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string anodeElectrolyteCasing = "Let's attach the anode to its terminal before we put it in the casing!";
        public const string anodeCathodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string anodeSeparatedCathodeCasing = "Before we put the anode into the battery we need something that will connect it to the outside of the casing.";
        public const string anodeSeparatedCathodeTerminal = "You’re on the right track, but we need a way to connect the anode to the outside of the battery first!";
        public const string anodeSeparatedElectrolyteCathodeCasing = "You’re on the right track, but we need a way to connect the anode to the outside of the battery first!"; public const string anodeElectrolyteCathodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string cathodeAnodeTerminal = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string cathodeElectrolyteCasing = "Let's attach the cathode to its terminal before we put it in the casing!";
        public const string cathodeAnodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string cathodeSeparatedAnodeCasing = "You’re on the right track, but we need a way to connect the cathode to the outside of the battery first!";
        public const string cathodeSeparatedAnodeTerminal = "You’re on the right track, but we need a way to connect the cathode to the outside of the battery first!";
        public const string cathodeSeparatedElectrolyteAnodeCasing = "You’re on the right track, but we need a way to connect the cathode to the outside of the battery first!";
        public const string cathodeElectrolyteAnodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string sulfuricAcidCathodeTerminal = "Darn, the sulfuric acid by itself won’t work as an electrolyte solution.";
        public const string sulfuricAcidAnodeTerminal = "Darn, the sulfuric acid by itself won’t work as an electrolyte solution.";
        public const string waterCathodeTerminal = "Uh oh, now everything is just all wet!";
        public const string waterAnodeTerminal = "What are we supposed to do with a wet anode terminal?";
        public const string waterCathodeCasing = "Who's gonna clean up all this random water everywhere?";
        public const string waterAnodeCasing = "We're building a battery, not a pool!";
        public const string waterElectrolytelessBattery = "We're building a battery, not a pool! We need to combine this water with another substance to make a good electrolyte!";
        public const string waterSeparatedCathodeCasing = "Water you doing? We can’t build a battery like this!";
        public const string waterSeparatedAnodeCasing = "Water you doing? We can’t build a battery like this!";
        public const string waterSeparatedCathodeTerminal = "Water you doing? We can’t build a battery like this!";
        public const string waterSeparatedAnodeTerminal = "Uh oh, now everything is just all wet!";
        public const string waterInteriorBattery = "What are we supposed to do with a wet battery?";
        public const string waterMetalSeparator = "Uh oh, now everything is just all wet!";
        public const string waterClothSeparator = "Uh oh, now everything is just all wet!";
        public const string waterFlashlight = "Uh oh, now everything is just all wet!";
        public const string cathodeTerminalAnodeTerminal = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string cathodeTerminalAnodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string cathodeTerminalElectrolyteAnodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string cathodeTerminalMetalSeparator = "I don’t think that metal would make a good separator because it conducts electricity.";
        public const string anodeTerminalCathodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string anodeTerminalElectrolyteCathodeCasing = "Sorry to be so negative, but if you touch the anode and the cathode together the battery will break!";
        public const string anodeTerminalMetalSeparator = "I don’t think that metal would make a good separator because it conducts electricity.";
        public const string cathodeCasingMetalSeparator = "I don’t think that metal would make a good separator because it conducts electricity.";
        public const string anodeCasingMetalSeparator = "I don’t think that metal would make a good separator because it conducts electricity.";
        public const string electrolyteCathodeCasingMetalSeparator = "I don’t think that metal would make a good separator because it conducts electricity.";
        public const string electrolyteAnodeCasingMetalSeparator = "I don’t think that metal would make a good separator because it conducts electricity.";
        public const string anodeCasing = "We should attach the anode to something that can be reached from outside the battery. That will help us create a circuit! ";
        public const string cathodeCasing = "We should attach the cathode to something that can be reached from outside the battery. That will help us create a circuit!";
        public const string metalSeparatorElectrolytelessBattery = "This component already has a separator!";
        public const string metalSeparatorSeparatedCathodeCasing = "This component already has a separator!";
        public const string metalSeparatorSeparatedAnodeCasing = "This component already has a separator!";
        public const string metalSeparatorReadyBattery = "This component already has a separator!";
        public const string metalSeparatorSeparatedCathodeTerminal = "This component already has a separator!";
        public const string metalSeparatorSeparatedAnodeTerminal = "This component already has a separator!";
        public const string metalSeparatorSeparatedElectrolyteCathodeCasing = "This component already has a separator!";
        public const string metalSeparatorSeparatedElectrolyteAnodeCasing = "This component already has a separator!";
        public const string metalSeparatorInteriorBattery = "This component already has a separator!";

        //Successess
        public const string positiveTerminalCathode = "Fantastic, now we have a place for the electrons to flow to!";
        public const string negativeTerminalAnode = "Super, the electrons will flow out of the anode terminal now!";
        public const string casingElectrolyte = "This should effectively hold our electrolyte solution in the battery. Fantastic!";
        public const string casingCathodeTerminal = "This should effectively hold our electrolyte solution in the battery. How delightful!";
        public const string casingAnodeTerminal = "This should effectively hold our electrolyte solution in the battery. How delightful!";
        public const string casingSeparatedCathodeTerminal = "This should effectively hold our electrolyte solution in the battery. How delightful!";
        public const string casingSeparatedAnodeTerminal = "This should effectively hold our electrolyte solution in the battery. How delightful!";
        public const string casingInteriorBattery = "This should effectively hold our electrolyte solution in the battery. How delightful!";
        public const string waterSulfuricAcid = "This chemical solution will work perfectly as our electrolyte! Spiffy";
        public const string clothSeparatorCathodeTerminal = "This separator will keep our anode and cathode apart, preventing a short circuit. It’s made of cloth, so it can’t conduct electricity!";
        public const string clothSeparatorAnodeTerminal = "This separator will keep our anode and cathode apart, preventing a short circuit. It’s made of cloth, so it can’t conduct electricity!";
        public const string clothSeparatorCathodeCasing = "This separator will keep our anode and cathode apart, preventing a short circuit. It’s made of cloth, so it can’t conduct electricity!";
        public const string clothSeparatorAnodeCasing = "This separator will keep our anode and cathode apart, preventing a short circuit. It’s made of cloth, so it can’t conduct electricity!";
        public const string clothSeparatorElectrolyteCathodeCasing = "This separator will keep our anode and cathode apart, preventing a short circuit. It’s made of cloth, so it can’t conduct electricity!";
        public const string clothSeparatorElectrolyteAnodeCasing = "This separator will keep our anode and cathode apart, preventing a short circuit. It’s made of cloth, so it can’t conduct electricity!";
        public const string flashlightReadyBattery = "What a powerful device we’ve created!";
        public const string electrolyteCathodeCasing = "This electrolyte substance will help particles pass from the anode to the cathode.";
        public const string electrolyteAnodeCasing = "This electrolyte substance will help particles pass from the anode to the cathode.";
        public const string electrolyteElectrolytelessBattery = "This electrolyte substance will help particles pass from the anode to the cathode.";
        public const string electrolyteSeparatedCathodeCasing = "This electrolyte substance will help particles pass from the anode to the cathode.";
        public const string electrolyteSeparatedAnodeCasing = "This electrolyte substance will help particles pass from the anode to the cathode.";
        public const string cathodeTerminalElectrolyteCasing = "We’re getting close! We just need somewhere for electrons to flow from!";
        public const string cathodeTerminalSeparatedAnodeCasing = "Our battery is almost complete, we just need a way to make electrons move from the anode to the cathode.";
        public const string cathodeTerminalSeparatedAnodeTerminal = "Incredible, we’re nearing completion!";
        public const string cathodeTerminalSeparatedElectrolyteAnodeCasing = "We’ve created a complete battery! Now lets plug it in somewhere to test it!";
        public const string anodeTerminalElectrolyteCasing = "We’re making great progress! Now we just need somewhere for the electrons to flow to!";
        public const string anodeTerminalSeparatedCathodeCasing = "Our battery is almost complete, we just need a way to make electrons move from the anode to the cathode.";
        public const string anodeTerminalSeparatedCathodeTerminal = "Incredible, we’re nearing completion!";
        public const string anodeTerminalSeparatedElectrolyteCathodeCasing = "We’ve created a complete battery! Now lets plug it in somewhere to test it!";
        public const string electrolyteCasingSeparatedCathodeTerminal = "This battery’s really coming together! Power to ya!";
        public const string electrolyteCasingSeparatedAnodeTerminal = "This battery’s really coming together!";
        public const string electrolyteCasingInteriorBattery = "This battery’s really coming together!";
        public const string separatedAnodeTerminalCathodeCasing = "I think we just need one more thing for our battery to power something!";
        public const string separatedCathodeTerminalAnodeCasing = "I think we just need one more thing for our battery to power something!";
        public const string separatedCathodeTerminalElectrolyteAnodeCasing = "Let’s test our battery out!";
        public const string separatedAnodeTerminalElectrolyteCathodeCasing = "Let’s test our battery out!";

        //Learn more text
        public const string electrodeMaterials = "When a battery is used to power a device, the terminals of the anode and cathode are connected through a circuit. This circuit works because negatively charged electrons want to flow to the positive cathode. The anode and cathode are always made of different substances, one of which attracts electrons more strongly than the other. That means the cathode will take in electrons once they reach it, completing the circuit.";
        public const string electrolyteReaction = "The electrolyte helps convert chemical energy into electrical energy. It extracts electrons from the anode through a chemical reaction called oxidation. These electrons flow through wires and create an electric current. The electrolyte also moves positively charged atoms, called ions, from the anode to the cathode. In some batteries, the electrolyte is a liquid made of sulfuric acid and water (like this one!). In other batteries, it could be a paste or a gel.";
        public const string shortCircuit = "Electrons want to go from negative to positive to complete a circuit. If we connect the anode directly to the cathode, the electrons will go right from the anode to the cathode. When this happens, electrons don’t take the path intended (through the wires connected to the battery), so nothing will get powered. This is called a short circuit because the electrons avoid going the long way to complete a circuit!";
    }

    public struct GameComplete
    {
        public const string gameCompleteModalText = "Congratulations, you recreated history’s most brilliant inventions! Thanks to your efforts, we were able to catch EVIL Inc and save the world!";
    }

    public struct Level2_3
    {
        //Load in dialogue
        public const string loadInDialogue = "";
    }
}
