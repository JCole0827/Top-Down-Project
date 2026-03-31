using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int keyscollected;
    public GameObject door;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Key")
        {
            //add one to our coin counter
            keyscollected += 1;

            other.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        if (keyscollected >= 4)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                door.SetActive(false);
            }
        }
    }
}
