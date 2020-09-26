using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    string currentSceneName = "";

    public int collectables = 0;
    public int collectablesAvailable = 0;

    public bool levelComplete = false;

    public GameObject winCanvas;

    // We give the controller the level order here, so we can go to it.
    public string[] LevelOrder = new string[] 
    {
        "Tutorial",
        "LevelOne"
    };


    public void GameWin()
    {
        if (!levelComplete)
        {
            levelComplete = true;

            GameObject[] _players = GameObject.FindGameObjectsWithTag("Player");

            // Disable controls for all player objects.
            foreach (GameObject _player in _players)
            {
                _player.GetComponent<PlayerController>().playerInControl = false;
            }

            Instantiate(winCanvas);

        }
    }

    public void NextLevel()
    {

        // The current level is not in the level order, so we just head to the first one.
        if (!LevelOrder.Contains(currentSceneName))
        {
            ChangeScene(LevelOrder[0]);
        }
        else
        {
            for (int i = 0; i < LevelOrder.Length; i++)
            {
                // Win the game if you are on the final level.
                if ( i + 1 == LevelOrder.Length )
                {
                    GameWin();
                    return;
                }
                else
                {
                    // Look for the level we are on, and go to the next one.
                    if ( LevelOrder[i] == currentSceneName )
                    {
                        ChangeScene(LevelOrder[i+1]);
                        return;
                    }
                }
            }
        }

    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
        Debug.Log("Attempting to go to scene: " + scene);
    }


    
    // This is ran when the scene changes.
    void SceneChanged()
    {
        // We don't need to know anything about the collectables, just how many there are.
        collectables = 0;
        collectablesAvailable = GameObject.FindGameObjectsWithTag("Collectable").Length;
        currentSceneName = SceneManager.GetActiveScene().name;
        levelComplete = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        // We want to use this Game Controller, so we don't want to remove it.
        DontDestroyOnLoad(this.gameObject);

        // Run this to initialize any variables.
        SceneChanged();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // These are used to keep track when the scene changes.
    // ============================================================
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SceneChanged();
    }
    // ============================================================

}
