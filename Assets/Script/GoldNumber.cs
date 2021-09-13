using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldNumber : MonoBehaviour
{

    Text GoldUI;
    public Players players;

    void Start()
    {
        GoldUI = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update()
    {
        GoldUI.text = players.CurrentPlayerGold.ToString();
    }

}
