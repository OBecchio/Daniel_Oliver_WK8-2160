using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static ScoreKeeper instance;

    public static ScoreKeeper Instance
    {
        get
        {
            return instance;
        }
    }
    public int score { get; set;}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;        
        DontDestroyOnLoad(Instance);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPickUp(int pointsAmount)
    {
        score = score + pointsAmount; 
    }
}
