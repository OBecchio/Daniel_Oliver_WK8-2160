using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public UIManager Instance
    {
        get
        {
            return instance;
        }
        set
        {
            instance = value;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;        
        DontDestroyOnLoad(Instance);
    }

    // Update is called once per frame
    void Update()
    {
        int displayScore = ScoreKeeper.Instance.score;
        Debug.Log(displayScore);
    }
}
