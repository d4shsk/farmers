using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private UnityEvent<int> onMoneyChanged;

    private int money;

    public void addMoney(int amount) {
        money += amount;
        onMoneyChanged.Invoke(money);
    }
}
