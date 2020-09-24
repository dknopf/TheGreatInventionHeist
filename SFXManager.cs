using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class SFXManager : MonoBehaviour
{
    public static AudioClip uiClickSound, levelHoverSound, propSuccessSound, failSound, propDropSound, learnMoreSound, levelCompleteSound, theFlashSound, acidSizzleSound, airWhooshSound, clankTanksSound, clothSound, computerBeepsSound, explosionSound, fireCrackleSound, gasEscapeSound, glassClinkSound, lightbulbFlameSound, motorSound, planeFlyoverSound, poweringUpSound, propellorSound, rocketPropulsionSound, screwingInSound, shortOutSound, sputteringMotorSound, steampunkMotorSound, steeringMechanismsSound, waterCoolantSound, waterSplashSound, weakExplosionSound, motorPropellerSound;
    public AudioSource audioSrc;
    void Start()
    {
        EventManager.StartListening(GameConstants.PlaySFXEvent, PlaySfxEventHandler);

        audioSrc.volume = 0.5f;

        uiClickSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "uiClick");
        levelHoverSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "levelHover");
        propSuccessSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "propSuccess");
        failSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "fail");
        propDropSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "propDrop");
        learnMoreSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "learnMore");
        levelCompleteSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "levelComplete");
        theFlashSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "theFlash");
        acidSizzleSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "acidSizzle");
        airWhooshSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "airWhoosh");
        clankTanksSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "clankTanks");
        clothSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "clothSound");
        computerBeepsSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "computerBeeps");
        explosionSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "explosion");
        fireCrackleSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "fireCrackle");
        gasEscapeSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "gasEscape");
        glassClinkSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "glassClink");
        lightbulbFlameSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "lightbulbFlame");
        motorSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "motor");
        planeFlyoverSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "planeFlyover");
        poweringUpSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "poweringUp");
        propellorSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "propellor");
        rocketPropulsionSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "rocketPropulsion");
        screwingInSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "screwingIn");
        shortOutSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "shortOut");
        sputteringMotorSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "sputteringMotor");
        steampunkMotorSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "steampunkMotor");
        steeringMechanismsSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "steeringMechanisms");
        waterCoolantSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "waterCoolant");
        waterSplashSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "waterSplash");
        weakExplosionSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "weakExplosion");
        motorPropellerSound = Resources.Load<AudioClip>(GameConstants.SoundFolderPath + "motorPropeller");
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = GlobalStaticVariables.sfxVolume;
    }

    public static void PlaySound (string clip)
    {
        EventManager.SetData(GameConstants.PlaySFXEvent, clip);
        EventManager.EmitEvent(GameConstants.PlaySFXEvent);
    }

    private void PlaySfxEventHandler()
    {
        string clip = EventManager.GetString(GameConstants.PlaySFXEvent);
        switch (clip)
        {
            case "uiClick":
                audioSrc.PlayOneShot(uiClickSound);
                break;

            case "levelHover":
                audioSrc.PlayOneShot(levelHoverSound);
                break;

            case "propSuccess":
                audioSrc.PlayOneShot(propSuccessSound);
                break;

            case "fail":
                audioSrc.PlayOneShot(failSound);
                break;

            case "propDrop":
                audioSrc.PlayOneShot(propDropSound);
                break;

            case "learnMore":
                audioSrc.PlayOneShot(learnMoreSound);
                break;

            case "levelComplete":
                audioSrc.PlayOneShot(levelCompleteSound);
                break;

            case "theFlash":
                audioSrc.PlayOneShot(theFlashSound);
                break;

            case "acidSizzle":
                audioSrc.PlayOneShot(acidSizzleSound);
                break;

            case "airWhoosh":
                audioSrc.PlayOneShot(airWhooshSound);
                break;

            case "clankTanks":
                audioSrc.PlayOneShot(clankTanksSound);
                break;

            case "clothSound":
                audioSrc.PlayOneShot(clothSound);
                break;

            case "computerBeeps":
                audioSrc.PlayOneShot(computerBeepsSound);
                break;

            case "explosion":
                audioSrc.PlayOneShot(explosionSound);
                break;

            case "fireCrackle":
                audioSrc.PlayOneShot(fireCrackleSound);
                break;

            case "gasEscape":
                audioSrc.PlayOneShot(gasEscapeSound);
                break;

            case "glassClink":
                audioSrc.PlayOneShot(glassClinkSound);
                break;

            case "lightbulbFlame":
                audioSrc.PlayOneShot(lightbulbFlameSound);
                break;

            case "motor":
                audioSrc.PlayOneShot(motorSound);
                break;

            case "planeFlyover":
                audioSrc.PlayOneShot(planeFlyoverSound);
                break;

            case "poweringUp":
                audioSrc.PlayOneShot(poweringUpSound);
                break;

            case "propellor":
                audioSrc.PlayOneShot(propellorSound);
                break;

            case "rocketPropulsion":
                audioSrc.PlayOneShot(rocketPropulsionSound);
                break;

            case "screwingIn":
                audioSrc.PlayOneShot(screwingInSound);
                break;

            case "shortOut":
                audioSrc.PlayOneShot(shortOutSound);
                break;

            case "sputteringMotor":
                audioSrc.PlayOneShot(sputteringMotorSound);
                break;

            case "steampunkMotor":
                audioSrc.PlayOneShot(steampunkMotorSound);
                break;

            case "steeringMechanisms":
                audioSrc.PlayOneShot(steeringMechanismsSound);
                break;

            case "waterCoolant":
                audioSrc.PlayOneShot(waterCoolantSound);
                break;

            case "waterSplash":
                audioSrc.PlayOneShot(waterSplashSound);
                break;

            case "weakExplosion":
                audioSrc.PlayOneShot(weakExplosionSound);
                break;

            case "motorPropeller":
                audioSrc.PlayOneShot(motorPropellerSound);
                break;

        }
    }
}
