using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 cameraPos;
    public Transform XROrigin;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //cameraPos = new Vector3(0, 1.1176f, 0);
    }
}
