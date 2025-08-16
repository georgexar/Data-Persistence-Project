using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StartGame()
    {
        GameManager.Instance.playerName = nameInput.text;
        SceneManager.LoadScene("main");
    }
}
