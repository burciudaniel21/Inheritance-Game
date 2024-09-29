using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 movement;
    Weapon weapon;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Prevent rotation
        weapon = new Weapon("Sword", 5);
    }

    private void Update()
    {
        PerformAttack(weapon);
    }

    void FixedUpdate()
    {
        // Get player input
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed;

        // Create a movement vector based on input
        rb.velocity = new Vector3(moveX, 0, moveZ);
    }

    void PerformAttack(Weapon currentWeapon)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"The player has attacked using {currentWeapon.weaponName} and dealt {currentWeapon.weaponDamage}");
        }
    }
}
