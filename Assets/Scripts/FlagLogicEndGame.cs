using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagLogicEndGame : MonoBehaviour
{

    AudioSource endGameAudio;
    private void Start()
    {
        endGameAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        endGameAudio.Play();

        GameObject.Find("GameController").GetComponent<GameControllerScript>().GameWin();
    }
}
