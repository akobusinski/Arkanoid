using UnityEngine;

public class Movement : MonoBehaviour {
    public GameObject ball;
    public float speed = 15f;
    [SerializeField] private float BallSpawnCooldown = 0f;
    [SerializeField] private float BallSpawnCooldown_ = 0.1f;
    void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            BallSpawnCooldown -= Time.deltaTime;
            if (0 >= BallSpawnCooldown) {
                Manager.Instance.balls.Add(Instantiate<GameObject>(ball, transform.position + new Vector3(0f, 1f, 0f), Quaternion.Euler(0f, 0f, 0f)));
                BallSpawnCooldown = BallSpawnCooldown_;
            }
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            transform.position = Vector2.Lerp(transform.position, transform.position + new Vector3(-speed, 0f, 0f), Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            transform.position = Vector2.Lerp(transform.position, transform.position + new Vector3(speed, 0f, 0f), Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            BallSpawnCooldown = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            BallSpawnCooldown = BallSpawnCooldown_;
        }
        transform.position = new Vector2(Mathf.Max(Mathf.Min(transform.position.x, 4.6f), -4.5f), transform.position.y);
    }
    void OnCollisionEnter2D(Collision2D collision) {
        collision.collider.attachedRigidbody.AddTorque(Random.Range(-100f, 100f));
    }
}
