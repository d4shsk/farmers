using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodsCatalog : MonoBehaviour
{
    [SerializeField] private List<Button> _buttons;

    [SerializeField] private Sprite grassSprite;
    [SerializeField] private GameObject goodPrefab;

    private List<Upgrade> _catalog = new List<Upgrade>();

    private void Start()
    {
        var grassMultiplier = new GrassMultiplier(1, grassSprite, "govno", "don't buy", 2);

        print(grassMultiplier);
        _catalog.Add(grassMultiplier);
    }

    public void LoadGoodsCatalog()
    {
        for (int i = 0; i < _catalog.Count; i++)
        {
            var good = goodPrefab.GetComponent<Good>();
            good.LoadGood(_catalog[i].cost, _catalog[i].logo, _catalog[i].goodName, _catalog[i].description);
        }
    }
}
