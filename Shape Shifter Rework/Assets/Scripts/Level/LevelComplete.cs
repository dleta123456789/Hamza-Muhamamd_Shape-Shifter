using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    private LevelMenuManager levelMenu;
    // Start is called before the first frame update
    void Start()
    {
        levelMenu = FindObjectOfType<LevelMenuManager>().GetComponent<LevelMenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Finish");
            levelMenu.ActivateNextLevelUI();
        }
    }
}
