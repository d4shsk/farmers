using UnityEngine;

public class GrassMultiplier : Upgrade
{
    public float multiplieRatio;

    public GrassMultiplier(int cost, string upgradeName, float multiplieRatio) : base(cost, upgradeName)
    {
        this.multiplieRatio = multiplieRatio;
    }
}
