using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(UpgradesInventory))]

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> onMoneyChanged;
    [SerializeField] private UnityEvent<float> onGrassAmountChanged;
    [SerializeField] private float baseGrassAddAmount;

    private UpgradesInventory upgradesInventory;

    public float money;
    private float grass;

    private void Start()
    {
        upgradesInventory = GetComponent<UpgradesInventory>();
    }

    public void AddMoney(int amount) {
        money += amount;
        onMoneyChanged.Invoke(money);
    }

    public void AddGrass() {
        grass += baseGrassAddAmount * upgradesInventory.CalculateGrassMultiplier();
        onGrassAmountChanged.Invoke(grass);
    }
}
