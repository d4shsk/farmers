using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetGrass : MonoBehaviour
{
    [SerializeField] private UnityEvent onGrassEnter;
    [SerializeField] private UnityEvent onGrassLeft;

    private Grass currentGrass;

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
            currentGrass.CollectGrass();
        }
    }
}
