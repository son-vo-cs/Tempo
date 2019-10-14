using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    public GameObject n;
    GameObject note;
    Color old;
    int scoreChange = 10;

    public bool createmode;


    // Start is called before the first frame update
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    
    void Start()
    {
        old = sr.color;
    }


    void Update()
    {
        if (createmode) 
        {
            if(Input.GetKeyDown(key))
            {
                Instantiate(n, transform.position, Quaternion.identity);
            }
        }
        else { 
            if (Input.GetKeyDown(key))
            {
                StartCoroutine(Pressed());
            }
            if (Input.GetKeyDown(key) && active)
            {
                Destroy(note);
                AddScore();
                active = false;
            }
        }
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if (col.gameObject.tag == "Note")
            note = col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        active = false;
    }

    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + scoreChange);
    }

    IEnumerator Pressed()
    {
        sr.color = old * 0.75f;
        yield return new WaitForSeconds(0.1f);
        sr.color = old;
    }
}
