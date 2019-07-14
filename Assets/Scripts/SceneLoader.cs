using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Switch levels(scenes)
            // Older versions
            // Application.LoadLevel(0);// Put index number or scene name
            // Default mode is single, but if we want to make it additive,
            // we can simply use.
            SceneManager.LoadScene("LEVEL1", LoadSceneMode.Additive);
        }
        
    }
}
