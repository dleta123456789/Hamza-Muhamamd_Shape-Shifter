using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int lastAttemptScore = 0;
    public int currentScore
    {
        get { return lastAttemptScore; }
        set { lastAttemptScore = value; }
    }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        currentScore = lastAttemptScore;
        DontDestroyOnLoad(gameObject);
    }


    
    
    private int HighScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
