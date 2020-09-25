using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class TriggerBoxController : MonoBehaviour
{

    GameObject playerChild;
<<<<<<< Updated upstream

    //switches player to a cirle
    private void OnTriggerEnter(Collider other)
    {
        
    other.GetComponent<BoxCollider>().enabled = false;

    Transform trans = other.transform;
    Transform childTrans = trans.Find("Shape - Cube");
=======
    AudioSource powerUpAudio;

    private void Start()
    {
        powerUpAudio = GetComponent<AudioSource>();
    }
    //switches player to a cirle
    private void OnTriggerEnter(Collider other)
    {

        AudioSource.PlayClipAtPoint(powerUpAudio.clip, transform.position);
        other.GetComponent<BoxCollider>().enabled = false;

        Transform trans = other.transform;
        Transform childTrans = trans.Find("Shape - Cube");
>>>>>>> Stashed changes

        if (childTrans != null)
        {
            playerChild = childTrans.gameObject;
        }

        playerChild.GetComponent<MeshRenderer>().enabled = false;
    

    
    }
}

