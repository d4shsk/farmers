using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerStats))]

public class UpgradesInventory : MonoBehaviour
{
    private Upgrade[] availableUpgrades =
    {
        new GrassMultiplier(20, "Grass multiplier", 2)
    };

    private List<Upgrade> currentUpgrades = new List<Upgrade>();

    private float currentGrassMultiplier = 1;

    private PlayerStats playerStats;

    private void Start()
    {
        playerStats = GetComponent<PlayerStats>();
    }

    public void TryAddUpgrade(int upgradeId)
    {
        var upgrade = availableUpgrades[upgradeId];
        if (playerStats.money >= upgrade.cost)
        {
            print("upgrade bought");
            playerStats.money -= upgrade.cost;
            currentUpgrades.Add(upgrade);
        }
        else {
            print("more money need");
        }
    }

    public float CalculateGrassMultiplier() {
        foreach (GrassMultiplier grassMultiplier in currentUpgrades)
        {
            currentGrassMultiplier += grassMultiplier.multiplieRatio;
        }
        return currentGrassMultiplier;
    }
}
