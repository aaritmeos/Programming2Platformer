using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    public Collider2D stitch;
    public Rigidbody2D lilo;
    void Start()
    {
        
    }
    void Update()
    {
        if (lilo.IsTouching(stitch) == true)
        {
            Debug.Log("He's touching me!");
        }
    }
}
