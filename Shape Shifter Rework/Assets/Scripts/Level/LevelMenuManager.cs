using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject NextLevelUI;
    [SerializeField] private GameObject RestartUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivateNextLevelUI()
    {
        NextLevelUI.SetActive(true);
    }
    public void ActivateRestartUI()
    {
        RestartUI.SetActive(true);
    }
}
