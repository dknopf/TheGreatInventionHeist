using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;

public class FinalPropScript : MonoBehaviour
{
    private CreateModal modalMaker = new CreateModal();
    private GetLevelCompleteText getText = new GetLevelCompleteText();
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2) + 100, Screen.height / 2, Camera.main.nearClipPlane));
        this.transform.position = newPosition;
        //Wait twice the length of the final animation
        EventManager.EmitEvent(GameConstants.FinalPropCreationEvent);
        StartCoroutine("PauseForAwe");
        
    }

    IEnumerator PauseForAwe()
    {
        
        float timeLeft = this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(timeLeft + 2); // wait for the length of the animation + 2 seconds
        string level = this.tag.Substring(0, this.tag.IndexOf("/", 0, this.tag.Length));

        this.GetComponent<ParticleSystem>().Stop();

        //Create level complete modal
        string UIAssetsPath = "UI Assets/";
        modalMaker.CreateMultiPageModal(level, getText.getLevelCompleteText(level), UIAssetsPath + level + "RealPhoto", "LevelCompleteModal");

        /*
        Enables the particle effect system for confetti
        at the same time as the level complete modal
        */
        GameObject confettiObject = this.transform.GetChild(0).gameObject;
        confettiObject.SetActive(true);

        EventManager.SetData(GameConstants.FinalPropCompleteEvent, level);
        EventManager.EmitEvent(GameConstants.FinalPropCompleteEvent);
        //EventManager.EmitEvent(GameConstants.PauseGame);

    }
}
