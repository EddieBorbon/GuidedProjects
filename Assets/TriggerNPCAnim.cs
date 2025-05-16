using UnityEngine;

public class TriggerNPCAnim : MonoBehaviour
{
    public Animator npcAnimator;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            int randomIndex = Random.Range(1,4);
            npcAnimator.SetInteger("TalkIndex", randomIndex);
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")){
            npcAnimator.SetInteger("TalkIndex", 0);
        }
    }
}
