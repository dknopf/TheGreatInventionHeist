using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class LearnMoreButtonClicked : MonoBehaviour
{
    // Start is called before the first frame update
    public string level;
    public string learnMoreText;
    public string pathToImage;

    private CreateModal modalMaker = new CreateModal();
    public void ButtonClicked()
    {
        modalMaker.CreateMultiPageModal(level, learnMoreText, pathToImage, GameConstants.LearnMoreModal);
        EventManager.EmitEvent(GameConstants.PauseGame);
    }
}
