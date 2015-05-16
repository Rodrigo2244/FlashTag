using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{
    enum SpawnType
    {
        Pyramid,
        ThreeSidedColumn
    }

    private SpawnType spawnedType;
    private SpawnType[] spawnTypes;
    private GameObject loadedObject;
    private GameObject spawnedObject;

    void Awake()
    {
        CreateTypeArray();

        int index = Random.Range(0, spawnTypes.Length);

        loadedObject = (GameObject)Resources.Load(spawnTypes[index].ToString());
    }

	void Start () 
    {
        spawnedObject = (GameObject)Instantiate(loadedObject, transform.position, Quaternion.Euler(270,0,0));
	}

    private void CreateTypeArray()
    {
        spawnTypes = (SpawnType[])System.Enum.GetValues(typeof(SpawnType));
    }
}
