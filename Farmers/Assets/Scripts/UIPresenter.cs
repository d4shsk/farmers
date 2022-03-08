using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPresenter : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    [SerializeField] private Text grassText;

    public void UpdateMoney(int currentMoney) {
        moneyText.text = currentMoney.ToString();
    }

    public void UpdateGrass(float grass) {
        grassText.text = Mathf.Round(grass).ToString();
    }
}
