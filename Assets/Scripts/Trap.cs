using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private string trapName = "Trap";
    [SerializeField] private int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DamagePlayer();
        }
    }

    private void DamagePlayer()
    {
        Debug.Log($"Player has been damaged by {trapName} for {damage} damage.");
    }
}
