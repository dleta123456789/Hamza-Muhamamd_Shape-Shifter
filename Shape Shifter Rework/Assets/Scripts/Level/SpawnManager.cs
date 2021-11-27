using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> spawnObjects = new List<GameObject>();
    [SerializeField] private List<GameObject> spawnPoints = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject spawn in spawnPoints)
        {
            Spawner(spawn.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawner(Transform spawnPos)
    {
        int index = Random.Range(0, spawnObjects.Count);
        Instantiate(spawnObjects[index], spawnPos.position+ spawnObjects[index].transform.position, spawnPos.rotation);
    }
}
