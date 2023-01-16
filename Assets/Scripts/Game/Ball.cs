using UnityEngine;

public class Ball : MonoBehaviour {
    public float maxSpeed = 15f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private AudioSource diesoundeffect;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (rb.velocity.magnitude > maxSpeed) {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }
     void OnCollisionEnter2D(Collision2D _) {
      diesoundeffect.Play();
     }
}
