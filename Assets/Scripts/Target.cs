using UnityEngine;

public class Target : MonoBehaviour
{
    public float scoreValue = 10f;
    private Vector3 startPosition;
    private Quaternion startRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHit()
    {
        GameManager.Instance.AddScore(scoreValue);
        gameObject.SetActive(false);
    }
    public void ResetTarget()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        gameObject.SetActive(true);
    }
}
