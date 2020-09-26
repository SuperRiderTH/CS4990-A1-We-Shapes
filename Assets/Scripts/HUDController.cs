using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    Text textTime;
    GameControllerScript gameController;

    // Start is called before the first frame update
    void Start()
    {
        textTime = GameObject.Find("TimeText").GetComponent<Text>();
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        textTime.text = gameController.timeString;
    }
}
