using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpdateScore : MonoBehaviour
{
    Text _Score;

    private void Start()
    {
        _Score = gameObject.GetComponent<Text>();
    }

    public void NewScore(int number)
    {
        _Score.text = "Score: " + number.ToString();
    }
}

     
