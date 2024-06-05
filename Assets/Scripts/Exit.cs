using UnityEngine;

public class GameController : MonoBehaviour
{
    public void ExitGame()
    {
        // Wyj�cie z gry w edytorze Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Wyj�cie z gry w wersji zbudowanej
        Application.Quit();
#endif
    }
}
