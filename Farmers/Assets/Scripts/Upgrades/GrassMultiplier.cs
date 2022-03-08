using UnityEngine;

public class GrassMultiplier : Upgrade
{
    public float multiplieRatio;

    public GrassMultiplier(int cost, Sprite logo, string goodName, string description, float ratio) : base(cost, logo, goodName, description) {
        multiplieRatio = ratio;
    }
}
