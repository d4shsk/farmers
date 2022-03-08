using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> onMoneyChanged;
    [SerializeField] private UnityEvent<float> onGrassAmountChanged;

    [SerializeField] private float money;
    private float grass;

    public void ConvertGrassToMoney() {
        money += grass;
        grass = 0;
        onGrassAmountChanged.Invoke(grass);
        onMoneyChanged.Invoke(money);
    }

    public bool CheckMoneyAvailable(float amount)
    {
        if (money - amount >= 0)
        {
            return true;
        }
        else {
            return false;
        }
    }

    public void ChangeMoney(float amount) {
        money += amount;
        onMoneyChanged.Invoke(money);
    }

    public void ChangeGrass(float amount) {
        grass += amount;
        onGrassAmountChanged.Invoke(grass);
    }
}
