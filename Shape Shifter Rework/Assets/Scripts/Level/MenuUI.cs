using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    private ScoreManager scoreManager;
    private void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>().GetComponent<ScoreManager>();
        //SceneManager.sceneLoaded += SceneManager.OnSceneLoaded;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
