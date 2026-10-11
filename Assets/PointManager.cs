using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public static PointManager Instance;
    public int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance == null) 
            Instance = this;
    }

    public void addPoint()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
