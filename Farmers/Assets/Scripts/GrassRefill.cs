using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GrassRefill : MonoBehaviour
{
    [SerializeField] private UnityEvent onGrassRefilled;
    [SerializeField] private float respawnTime;

    private float time;

    [HideInInspector] public bool grassEmpty;

    private void Start()
    {
        //onGrassRefilled.AddListener(SetBaseState());
    }

    void FixedUpdate()
    {
        if (grassEmpty)
        {
            time = time + Time.deltaTime;
            if (time >= respawnTime)
            {
                time = 0;
                onGrassRefilled.Invoke();
                grassEmpty = false;
            }
        }
    }
}
