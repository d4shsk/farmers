using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPresenter : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    public void UpdateMoney(int currentMoney) {
        moneyText.text = currentMoney.ToString();
    }
}
