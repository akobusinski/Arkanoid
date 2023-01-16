using UnityEngine;

public class Block : MonoBehaviour {
    [SerializeField] private AudioSource diesoundeffect;
    void OnCollisionEnter2D(Collision2D _) {
        
         diesoundeffect.Play();
        Destroy(gameObject);
        Score.Instance.score += (ulong) Random.Range(10f, 20f);
        Manager.Instance.blocks -= 1;
       
    }
}
