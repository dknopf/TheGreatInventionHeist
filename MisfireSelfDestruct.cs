using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class MisfireSelfDestruct : MonoBehaviour
{

    //Pauses animation when paused, and only counts down time until destruction when unpaused


    public Animator anim;
    public float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        //Plays the animation's length + one second 
        timeLeft = this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + 1;
        anim = this.GetComponent<Animator>();
        EventManager.StartListening(GameConstants.PauseGame, PauseAnimation);
        EventManager.StartListening(GameConstants.UnpauseGame, UnpauseAnimation);
    }


    void PauseAnimation()
    {
        anim.enabled = false;
    }
    void UnpauseAnimation()
    {
        anim.enabled = true;
    }

    private void Update()
    {
        if (anim.enabled)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                EventManager.EmitEvent(GameConstants.PropAnimationFinishedEvent, gameObject);
                Destroy(gameObject);
            }
        }
    }
}
