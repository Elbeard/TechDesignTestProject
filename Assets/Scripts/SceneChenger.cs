using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChenger : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex;
   public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneIndex);
    }
}
