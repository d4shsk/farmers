using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(GrassRefill))]

public class Grass : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private UnityEvent onGrassCollected;

    [SerializeField] private Color baseColor;
    [SerializeField] private Color collectedColor;

    private GrassRefill grassRefill;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        grassRefill = GetComponent<GrassRefill>();
    }

    public void SetBaseState() { // Ну чисто базированное состояние
        spriteRenderer.color = baseColor;
    }

    public void CollectGrass() {
        if (!grassRefill.grassEmpty) {
            onGrassCollected.Invoke();
            spriteRenderer.color = collectedColor;
            grassRefill.grassEmpty = true;
        }
        
    }
}
