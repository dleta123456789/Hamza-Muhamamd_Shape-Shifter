using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public GameObject ScoreManager;
    
    [SerializeField] private TextMeshProUGUI lastAttemptValue;
    private void Awake()
    {
        lastAttemptValue.text = $"Current Score: " + ScoreManager.GetComponent<ScoreManager>().currentScore;

    }
    // Start is called before the first frame update
    void Start()
    {
        //lastAttemptValue.text = $"Current Score: "+ ScoreManager.GetComponent<ScoreManager>().currentScore ;
        SceneManager.sceneLoaded += OnSceneLoaded;
        ScoreManager = FindObjectOfType<ScoreManager>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        lastAttemptValue.text = $"Current Score: " + ScoreManager.GetComponent<ScoreManager>().currentScore;
    }
    public void StartGame()
    {
        ScoreManager.GetComponent<ScoreManager>().currentScore = 0;
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log("Mode= "+mode);
        //lastAttemptValue.text = $"Current Score: " + ScoreManager.GetComponent<ScoreManager>().currentScore;
        //lastAttemptValue.text = "Testing!";
    }
}
