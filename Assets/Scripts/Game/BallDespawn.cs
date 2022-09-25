using UnityEngine;

public class BallDespawn : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision");
        Destroy(collision.gameObject);
    }
}
