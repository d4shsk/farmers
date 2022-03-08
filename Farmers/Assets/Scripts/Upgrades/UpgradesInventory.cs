using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerStats))]

public class UpgradesInventory : MonoBehaviour
{
    [SerializeField] private float baseGrassMultiplier = 1;

    private Upgrade[] availableUpgrades =
    {
        new GrassMultiplier(20, "Grass multiplier", 2)
    };

    private List<Upgrade> currentUpgrades = new List<Upgrade>();

    private float currentGrassMultiplier;

    private PlayerStats playerStats;

    private void Start()
    {
        currentGrassMultiplier = baseGrassMultiplier;
        playerStats = GetComponent<PlayerStats>();
    }

    public void TryAddUpgrade(int upgradeId)
    {
        var upgrade = availableUpgrades[upgradeId];
        if (playerStats.CheckMoneyAvailable(upgrade.cost))
        {
            print("upgrade bought");
            playerStats.ChangeMoney(-upgrade.cost);
            currentUpgrades.Add(upgrade);
            CalculateGrassMultiplier();
        }
        else {
            print("more money need");
        }
    }

    public void CalculateGrassMultiplier() {
        currentGrassMultiplier = baseGrassMultiplier;

        foreach (GrassMultiplier grassMultiplier in currentUpgrades)
        {
            currentGrassMultiplier += grassMultiplier.multiplieRatio;
        }
    }

    public float GetGrassMultiplier() {
        return currentGrassMultiplier;
    }
}
