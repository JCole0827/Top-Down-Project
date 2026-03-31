using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public int ButtonPressed;
    public GameObject keyPrefab;
    Vector3 keySpawn;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(keyPrefab, keySpawn, Quaternion.identity);
        }
        
    }
}
