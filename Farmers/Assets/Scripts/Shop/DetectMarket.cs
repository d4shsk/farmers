using UnityEngine;
using UnityEngine.Events;

public class DetectMarket : MonoBehaviour
{
    [SerializeField] private UnityEvent marketEntered;
    [SerializeField] private UnityEvent marketLeft;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Market>()) {
            marketEntered.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Market>())
        {
            marketLeft.Invoke();
        }
    }
}
