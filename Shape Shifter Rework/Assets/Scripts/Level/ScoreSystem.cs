using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private ScoreManager scoreManager;
    private void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>().GetComponent<ScoreManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        scoreManager.currentScore= scoreManager.currentScore+1;
        Debug.Log("Score= "+ scoreManager.currentScore);
    }
}
