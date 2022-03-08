using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(UpgradesInventory))]

public class GetGrass : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> onGrassCollected;
    [SerializeField] private UnityEvent onGrassEnter;
    [SerializeField] private UnityEvent onGrassLeft;

    [SerializeField] private float baseGrassAddAmount;

    private Grass currentGrass;
    private UpgradesInventory upgradesInventory;

    private void Start()
    {
        upgradesInventory = GetComponent<UpgradesInventory>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.TryGetComponent<Grass>(out currentGrass);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<GrassPalce>())
        {
            onGrassEnter.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<GrassPalce>())
        {
            onGrassLeft.Invoke();
        }
    }

    public void CollectGrass() {
        if (currentGrass) {
            if (currentGrass.GrassCollectable())
            {
                var grassToAdd = baseGrassAddAmount * upgradesInventory.GetGrassMultiplier();

                onGrassCollected.Invoke(grassToAdd);
                currentGrass.SetGrassEmpty();
            }
        }
    }
}
