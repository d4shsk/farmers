using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesInventory : MonoBehaviour
{
    private List<Upgrade> currentUpgrades;

    public float currentGrassMultiplier = 1;

    public void AddUpgrade(Upgrade upgrade)
    {
        currentUpgrades.Add(upgrade);
        CalculateGrassMultiplier();
    }

    private void CalculateGrassMultiplier() {
        foreach (GrassMultiplier grassMultiplier in currentUpgrades)
        {
            currentGrassMultiplier += grassMultiplier.multiplieRatio;
        }
    }
}
