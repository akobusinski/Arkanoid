using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {
    public TextMeshProUGUI scoreText;
    private ulong _score = 0;
    private static Score _instance;
    [HideInInspector] public static Score Instance {
        get {
            return _instance;
        }
    }
    void Awake() {
        if (_instance != null && _instance != this) {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }
    public ulong score { // wtf
        get {
            return _score;
        }

        set {
            _score = value;
            scoreText.text = string.Format("Score: {0}", _score);
        }
    }
}
