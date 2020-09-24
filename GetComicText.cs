using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComicText
{
    public Dictionary<string, Dictionary<int, (string, string)>> masterDict = new Dictionary<string, Dictionary<int, (string, string)>>();

    public Dictionary<int, (string, string)> level1_1Dict = new Dictionary<int, (string, string)>();
    public Dictionary<int, (string, string)> level0_0Dict = new Dictionary<int, (string, string)>();
    public Dictionary<int, (string, string)> level1_2Dict = new Dictionary<int, (string, string)>();
    public Dictionary<int, (string, string)> level1_3Dict = new Dictionary<int, (string, string)>();
    public Dictionary<int, (string, string)> level2_1Dict = new Dictionary<int, (string, string)>();
    public Dictionary<int, (string, string)> level2_2Dict = new Dictionary<int, (string, string)>();
    public Dictionary<int, (string, string)> level2_3Dict = new Dictionary<int, (string, string)>();

    public string happy = "InventorHappy";
    public string sad = "InventorSad";
    public string badGuy = "BadGuy";


    public GetComicText()
    {
        SetUpDict();
    }


    public void SetUpDict()
    {
        //Key: num of current panel
        //Value: string of floating head file, dialogue


        //Level0_0
        level0_0Dict.Add(1, (happy, "Welcome, and thank you all for attending the unveiling of Time Corp’s latest invention!"));
        level0_0Dict.Add(2, (happy, "I’m proud to announce that after years of research, I, Dr. Ivy Crawford, have finally built a working time machine! "));
        level0_0Dict.Add(3, (happy, "Introducing… the TimeWarper3000!"));
        level0_0Dict.Add(4, (sad, "Uh oh, what’s that?! It looks just like my time machine, but evil! This can’t be good."));
        level0_0Dict.Add(5, (sad, "No, you’ve destroyed my life’s work! All my time spent on rapid development, for nothing!"));
            //Evil guys
        level0_0Dict.Add(6, (badGuy, "I am the overlord of EVIL Inc., and I’ve come from the future! Now that I’ve wrecked your TimeWarper3000, nothing can stop me! I’m going to control all technology and rule the world!!!"));
        level0_0Dict.Add(7, (badGuy, "My EVIL agents and I are going to go back in time and steal the memory of every important inventor, starting with you! Then only we will have the secrets of science! MWAHAHAHAHA!"));

        //Level 1_1
        level1_1Dict.Add(1, (happy, "Oh ho ho, it seems if I fill balloons with gases that are lighter than air, like helium, they’ll float!"));
        level1_1Dict.Add(2, (happy, "But hm, why does a balloon float? Perhaps because helium is a lot less dense than air!"));
        level1_1Dict.Add(3, (happy, "Density is how closely packed a substance is. Anything less dense than air floats, and anything more dense than air sinks."));
        level1_1Dict.Add(4, (happy, "If a helium balloon is lighter than the “pool” of air it is floating in, it will rise."));
        level1_1Dict.Add(5, (sad, "Ach, whats that ruckus? Is someone clanking around in my air tanks?"));


        //Level 1_2

        level1_2Dict.Add(1, (happy, "Orville, how do we make something big and heavy able to fly in the air for long distances? We can’t do lighter than air flight like a blimp, as our metal bird would be too heavy!"));
        level1_2Dict.Add(2, (happy, "Well, brother, I think that the shape of the wing can change how air moves around the plane."));
        level1_2Dict.Add(3, (happy, "If we design it like so, then the air will flow faster over the top of the wing than the bottom. The fast air will push against the wing less than the slow air below the wing. This will push the wings up!"));
        level1_2Dict.Add(4, (happy, "Aha, that’s it! If we can make a machine that pushes air past the wings fast enough, then it will be able to stay in the air for a long time! I imagine it’ll look something like this..."));
        level1_2Dict.Add(5, (sad, "Who are these chaps? They look suspiciously evil..."));


        //Level 1_3

        level1_3Dict.Add(1, (happy, "It’s so exciting that we’ve developed the technology to get us to the moon, and all this code I’ve written should help astronauts during space flight!"));
        level1_3Dict.Add(2, (happy, "Like most engines, rockets burn fuel. Most rocket engines turn the fuel into hot gas. The engine pushes the gas out its back. The gas makes the rocket move forward."));
        level1_3Dict.Add(3, (happy, "Unlike jet planes, rockets don’t need air to work. This is because they travel in space, where there is no air! Because fire needs oxygen, rockets carry an oxidizer on board, which starts the fire that heats gas!"));
        level1_3Dict.Add(4, (happy, "In order to get a rocket to the moon, it has to know how to get there! I’m going to write all these computer instructions, called code, to tell the rocket where to go!"));
        level1_3Dict.Add(5, (sad, "Who are you? You're bigger than the bugs I usually find in my code!"));


        //Level2_1
        level2_1Dict.Add(1, (happy, "Hmmm… I think I could harness the power of electricity to make a device that lights up a room!"));
        level2_1Dict.Add(2, (happy, "Electricity is the flow of electrons. Electrons are very small particles that carry energy."));
        level2_1Dict.Add(3, (happy, "These particles flow from one place to another, powering anything in between. Electrons can flow super easily through some materials, called conductors."));
        level2_1Dict.Add(4, (happy, "For electricity to flow, it needs a complete circuit. Electricity wants to flow from one end, where it’s powered, to the other end, called ground."));
        level2_1Dict.Add(5, (happy, "If you flow electricity through something with high resistance, the electrons will have to work hard to get through."));
        level2_1Dict.Add(6, (happy, "This high resistance means the electrons will bump into each other a lot. This will generate energy in the form of heat and light. This energy could power my light device!"));
        level2_1Dict.Add(7, (sad, "Gee, how’d it get so dark in here?! It sure would be a shame if someone were to steal my memory..."));


        //Level2_2
        level2_2Dict.Add(1, (happy, "I know there are a lot of great uses for electricity, but first, I need a way to create it! I wonder if I can use chemical reactions to create electric energy?"));
        level2_2Dict.Add(2, (happy, "Electricity is made up of very small particles called electrons. These electrons are usually attached to atoms, which make up everything in the universe."));
        level2_2Dict.Add(3, (happy, "By putting different chemicals together I can make their atoms react. Certain chemical reactions can separate electrons from their atoms. Some materials give up electrons easier than others!"));
        level2_2Dict.Add(4, (happy, "I can collect these electrons with a piece of metal called the anode. Then, electric current could flow from there through the wires, to the bulb, then to the positive terminal where the cathode takes them in."));
        level2_2Dict.Add(5, (sad, "It seems I have some shocking guests! Who are you?"));

        //Add level dicts to master dict
        masterDict.Add("Level0_0", level0_0Dict);
        masterDict.Add("Level1_1", level1_1Dict);
        masterDict.Add("Level1_2", level1_2Dict);
        masterDict.Add("Level1_3", level1_3Dict);
        masterDict.Add("Level2_1", level2_1Dict);
        masterDict.Add("Level2_2", level2_2Dict);
        masterDict.Add("Level2_3", level2_3Dict);
    }
    // Update is called once per frame

    public (string, string) getComicText(string level, int frameNum)
    {
        return masterDict[level][frameNum];
    }
}
