using UnityEngine;
using UnityEngine.InputSystem;
public class VR_Gun : MonoBehaviour
{
    public float damage;
    public float range;
    public float fireRate;
    private float nextFireTime = 0f;
    private bool isGrabbed = false;
    public Transform muzzle;
    public GameObject impactEffect;

    private InputAction shootAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootAction = InputSystem.actions.FindAction("XRI Right Interaction/Activate");
    }

    // Update is called once per frame
    void Update()
    {
        if (shootAction.IsPressed() && isGrabbed)
        {
            Debug.Log("Pew Pew");
            Shoot();
        }
    }
    void Shoot()
    {
        if (Time.time < nextFireTime)
            return;
        nextFireTime = Time.time + fireRate;

        RaycastHit hit;
        if (Physics.Raycast(muzzle.position, muzzle.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.OnHit();
            }
            Debug.Log(hit.transform.name);
            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
    public void Grab()
    {
        isGrabbed = true;
    }
    public void Release()
    {
        isGrabbed = false;
    }
}
