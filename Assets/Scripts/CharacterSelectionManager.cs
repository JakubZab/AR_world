using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionManager : MonoBehaviour
{
    public void SelectCharacter(string characterName)
    {
        // Przechowaj wybrany charakter, np. w PlayerPrefs
        PlayerPrefs.SetString("SelectedCharacter", characterName);
        PlayerPrefs.Save();

        // Za³aduj scenê AR
        SceneManager.LoadScene("GameMode");
    }
}
