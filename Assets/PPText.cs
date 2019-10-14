using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPText : MonoBehaviour
{

    public string name;

    void Awake()
    {
        PlayerPrefs.SetInt(name, 0);
    }

    void Update()
    {
        GetComponent<Text>().text = string.Format("SCORE\n{0:#00000}", PlayerPrefs.GetInt(name));
    }
}
