using UnityEngine;
using UnityEngine.InputSystem;
public class VR_Gun : MonoBehaviour
{
    public float damage;
    public float range;
    public float fireRate;
    private float nextFireTime = 0f;

    private InputAction shootAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootAction = InputSystem.actions.FindAction("XRI Right Interaction/Activate");
    }

    // Update is called once per frame
    void Update()
    {
        if (shootAction.IsPressed() && fireRate > 1)
        {
            Debug.Log("Pew Pew");
        }
    }
    void Shoot()
    {
        if (Time.time < nextFireTime)
            return;

    }
}
