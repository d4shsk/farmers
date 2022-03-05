using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetGrass : MonoBehaviour
{
    [SerializeField] private UnityEvent onGrassEnter;
    [SerializeField] private UnityEvent onGrassLeft;

    [SerializeField] private float raycastLength;
    [SerializeField] private Vector3 startPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<GrassPalce>())
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
        RaycastHit2D raycast = Physics2D.Raycast(transform.position + startPosition, Vector2.down * -raycastLength);
        Debug.DrawRay(transform.position, Vector2.down * Vector2.down * -raycastLength);

        if (raycast.collider)
        {
            raycast.collider.gameObject.TryGetComponent<Grass>(out Grass grass);
            if (grass)
            {
                grass.CollectGrass();
            }
        }
    }
}
