using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("GameScene");
    }
}
