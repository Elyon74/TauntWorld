using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldNumber : MonoBehaviour
{

    public Players players;
    public Text GoldUI;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SetCountText()
    {
        GoldUI = GameObject.Find("Text1").GetComponent<Text>();
        GoldUI.text = players.CurrentPlayerGold.ToString();
    }
}
