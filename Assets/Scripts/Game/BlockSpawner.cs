using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public GameObject block;
    [SerializeField] private int rows = 5;
    [SerializeField] private int columns = 10;
    [SerializeField] private float column_margin = 2f;
    [SerializeField] private float row_margin = 1f;

    void Start() {
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < this.columns; column++) {
                Instantiate(block, new Vector3(-9f + column_margin * column, 3f - row_margin * row, 0f), Quaternion.Euler(0f, 0f, 0f));
            }
        }
    }
}
