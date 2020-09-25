using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagLogicEndGame : MonoBehaviour
{
<<<<<<< Updated upstream
    private void OnTriggerEnter(Collider other)
    {
=======

    AudioSource endGameAudio;
    private void Start()
    {
        endGameAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        endGameAudio.Play();
>>>>>>> Stashed changes
        GameObject.Find("GameController").GetComponent<GameControllerScript>().GameWin();
    }
}
