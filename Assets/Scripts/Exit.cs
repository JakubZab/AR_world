using UnityEngine;

public class GameController : MonoBehaviour
{
    public void ExitGame()
    {
        // Wyjœcie z gry w edytorze Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Wyjœcie z gry w wersji zbudowanej
        Application.Quit();
#endif
    }
}
