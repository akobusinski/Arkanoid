using UnityEngine;

public class BallDespawn : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision");
        Destroy(gameObject);
    }
}
