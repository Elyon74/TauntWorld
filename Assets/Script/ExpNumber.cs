using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpNumber : MonoBehaviour
{

    Text ExpUI;
    public Players players;

    void Start()
    {
        ExpUI = GameObject.Find("Text (1)").GetComponent<Text>();
    }

    void Update()
    {
        //ExpUI.text = players.CurrentPlayerGold.ToString();
    }

}
