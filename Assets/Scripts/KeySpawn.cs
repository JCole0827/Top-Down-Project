using UnityEngine;

public class KeyRespawn : MonoBehaviour
{
    public Vector3 keySpawn1, keySpawn2, keySpawn3, keySpawn4;
    public GameObject keyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(keyPrefab, keySpawn1, Quaternion.identity);
            Instantiate(keyPrefab, keySpawn2, Quaternion.identity);
            Instantiate(keyPrefab, keySpawn3, Quaternion.identity);
            Instantiate(keyPrefab, keySpawn4, Quaternion.identity);
        }
    }
}
