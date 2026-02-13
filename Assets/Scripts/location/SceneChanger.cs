using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] Fade fade;
    
    void Change()
    {
        //NewMove.position = fade.pos;
        SceneManager.LoadScene(fade.next);
    }
}
