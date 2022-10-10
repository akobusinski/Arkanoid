using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour {
    public List<GameObject> balls = new List<GameObject>();
    public int balls_usable {
        get {
            return _balls;
        }

        set {
            _balls = value;
            ballsText.text = string.Format("Balls: {0}", _balls);
        }
    }
    public int blocks = 0;
    private static Manager _instance;
    public GameObject block;
    [SerializeField] private int rows = 4;
    [SerializeField] private int columns = 6;
    [SerializeField] private float columnMargin = 1.825f;
    [SerializeField] private float rowMargin = 1f;
    public TextMeshProUGUI ballsText;
    [HideInInspector] private int _balls = 0;
    [HideInInspector] public static Manager Instance {
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

    void GenerateBlocks() {
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < this.columns; column++) {
                Instantiate(block, new Vector3(-4.5f + columnMargin * column, 3f - rowMargin * row, 0f), Quaternion.Euler(0f, 0f, 0f));
                blocks += 1;
            }
        }
    }

    void Update() {
        if (blocks <= 0) {
            blocks = 0;
            GenerateBlocks();
            balls_usable = balls.Count + 1;
            foreach (GameObject ball in balls) {
                Destroy(ball);
            }
        }
    }
}
