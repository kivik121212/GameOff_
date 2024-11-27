using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string scenename;
    public GameObject canvas;
    public GameObject textik;
    public GameObject anim;


    public void StartGame()
    {
        StartCoroutine(menushka());
        IEnumerator menushka()
        {
            textik.SetActive(false);
            canvas.SetActive(false);
            anim.GetComponent<Animator>().Play("menushka");
            yield return new WaitForSeconds(1.1f);
            SceneManager.LoadScene(scenename);
        }
    }
}
