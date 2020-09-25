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

        nextLevelAudio.Play();

        SceneManager.LoadScene("LevelOne");
    }
}
