using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private float score;
    public TextMeshProUGUI scoreText;
    public GameObject[] Targets; 

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(float points)
    {
        score += points;
        Debug.Log("Score: " + score);
        UpdateUI();
    }
    public void UpdateUI()
    {
        scoreText.text = "Score: " + score;
    }
    public void ResetGame()
    {
        score = 0;
        UpdateUI();
        foreach (GameObject target in Targets)
        {
            target.GetComponent<Target>().ResetTarget();
        }
    }
}
