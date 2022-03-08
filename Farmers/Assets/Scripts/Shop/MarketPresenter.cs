using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketPresenter : MonoBehaviour
{
    [SerializeField] private GameObject marketUI;
    [SerializeField] private GameObject gameInfo;

    public void ViewMarket() {
        marketUI.SetActive(true);
        gameInfo.SetActive(false);
    }

    public void HideMarket() {
        marketUI.SetActive(false);
        gameInfo.SetActive(true);
    }
}
