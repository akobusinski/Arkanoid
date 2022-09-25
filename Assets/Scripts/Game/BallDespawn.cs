using UnityEngine;

public class BallDespawn : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) {
        Destroy(collision.gameObject);
    }
}
