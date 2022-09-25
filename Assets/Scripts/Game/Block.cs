using UnityEngine;

public class Block : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D _) {
        Destroy(gameObject);
        Score.Instance.score += (ulong) Random.Range(10f, 20f);
    }
}
