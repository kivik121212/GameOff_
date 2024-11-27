using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoprosTest : MonoBehaviour
{
    public GameObject OldVopros;
    public GameObject NewVopros;

    public GameObject RightAnswer;

    void Start()
    {
        RightAnswer.SetActive(false);
        NewVopros.SetActive(false);
    }

    public void Wrong()
    {

    }

    public void Right()
    {
        RightAnswer.SetActive(true);
    }

    public void Understand()
    {
        RightAnswer.SetActive(false);
        OldVopros.SetActive(false);
        NewVopros.SetActive(true);
    }
}
