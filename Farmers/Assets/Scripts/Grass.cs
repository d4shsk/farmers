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

    [SerializeField] private Sprite baseSprite;
    [SerializeField] private Sprite collectedSprite;

    private GrassRefill grassRefill;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        grassRefill = GetComponent<GrassRefill>();
    }

    public void SetBaseState() { // �� ����� ������������ ���������
        spriteRenderer.sprite = baseSprite;
    }

    public void CollectGrass() {
        if (!grassRefill.grassEmpty) {
            onGrassCollected.Invoke();
            spriteRenderer.sprite = collectedSprite;
            grassRefill.grassEmpty = true;
        }
        
    }
}
