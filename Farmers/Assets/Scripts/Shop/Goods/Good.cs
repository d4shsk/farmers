using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Good : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI price;
    [SerializeField] private Image logo;
    [SerializeField] private TextMeshProUGUI goodName;
    [SerializeField] private TextMeshProUGUI description;
    public void LoadGood(int cost, Sprite logo, string goodName, string description) {
        this.price.text = cost.ToString();
        this.logo.sprite = logo;
        this.goodName.text = goodName;
        this.description.text = description;
    }
}
