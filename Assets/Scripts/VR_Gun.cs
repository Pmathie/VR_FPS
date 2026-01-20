using UnityEngine;
using UnityEngine.InputSystem;
public class VR_Gun : MonoBehaviour
{
    public float damage;
    public float range;
    public float fireRate;
    private float nextFireTime = 0f;
    public Transform muzzle;
    public GameObject impactEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
       
    }
    public void Shoot()
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

}
