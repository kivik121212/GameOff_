using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehod : MonoBehaviour
{
    public string scenename;

    public void tiik()
    {
        SceneManager.LoadScene(scenename);
    }
}
