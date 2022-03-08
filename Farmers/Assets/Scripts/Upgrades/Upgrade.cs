using UnityEngine;
using UnityEngine.UI;

public class Upgrade
{
    public int cost;
    public Sprite logo;
    public string goodName;
    public string description;

    public Upgrade(int cost, Sprite logo, string goodName, string description) {
        this.cost = cost;
        this.logo = logo;
        this.goodName = goodName;
        this.description = description;
    }
}
