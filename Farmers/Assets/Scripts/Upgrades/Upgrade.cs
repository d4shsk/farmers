using UnityEngine;
using UnityEngine.UI;

public class Upgrade
{
    public int cost;
    public string upgradeName;

    public Upgrade(int cost, string upgradeName) {
        this.cost = cost;
        this.upgradeName = upgradeName;
    }
}
