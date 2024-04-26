using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float top = 36;
    private float bottom = -8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > top)
        {
            Destroy(this.gameObject);
        }
        else if(transform.position.z < bottom)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            GameObject player = GameObject.FindWithTag("MainCharacter");
            Destroy(player);
        }   
    }
}
