using UnityEngine;
using UnityEngine.SceneManagement;

public class UIExitButton : MonoBehaviour
{
   public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
