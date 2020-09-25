using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagLogic : MonoBehaviour
{

    AudioSource nextLevelAudio;

    private void Start()
    {
        nextLevelAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
<<<<<<< Updated upstream
=======

        nextLevelAudio.Play();
>>>>>>> Stashed changes
        SceneManager.LoadScene("LevelOne");
    }
}
