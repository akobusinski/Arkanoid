using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("GameMenu");
    }
}
