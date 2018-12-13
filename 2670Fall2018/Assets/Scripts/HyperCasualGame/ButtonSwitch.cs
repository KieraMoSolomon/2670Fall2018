using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitch : MonoBehaviour
{


    public Button ButtonPurchase;
    public Button ButtonStart;
    public StoreFollow itemValCheck;
    public IntData Cash;

    public void SwitchButtons()
    {
        if (Cash.value >= itemValCheck.ItemValue)
        {
            ButtonPurchase.gameObject.SetActive(false);
            ButtonStart.gameObject.SetActive(true);
        }
    }
}
