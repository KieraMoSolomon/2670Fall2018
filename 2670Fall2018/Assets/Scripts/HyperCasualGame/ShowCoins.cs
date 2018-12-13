using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCoins : MonoBehaviour
{

    public Text coinText;
    public IntData coins;

    public void updateScore()
    {
        coinText.text = coins.value.ToString();
    }

    public void addScore()
    {
        coins.value++;
    }

}
