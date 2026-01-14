using UnityEngine;

public class Target : MonoBehaviour
{
    public float scoreValue = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHit()
    {
        GameManager.Instance.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
