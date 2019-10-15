using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System.Threading;

public class LADevNoteScript : MonoBehaviour
{
    //static string path = ;
    StreamReader noteStream = new StreamReader("Assets/LADevoteeNotes.txt");
    string snoteStream = "SL;DK;FJ;;SL;DK;FJ;;FJ;SL;DK;;;D;;D;;;;DK;;;DK;;;DK;;;SD;;SKL;;SKL;;;SKL;;;SKL;D;SKL;SKL;D;SKL;S;D;SKL;SKL;SKL;;SKL;D;SKL;F;SKL;DKL;KL;F;D;FKL;KL;D;FKL;D;F;DKL;S;SKL;DKL;JKL;S;FK;FK;J;K;;LD;F;;SKL;;SKL;SKL;D;SKL;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;";
    //public GameObject n;
    public GameObject snote;
    public GameObject dnote;
    public GameObject fnote;
    public GameObject jnote;
    public GameObject knote;
    public GameObject lnote;

    // Start is called before the first frame update
    void Start()
    {
        /*
        snote = GameObject.Find("S Note");
        dnote = GameObject.Find("D Note");
        fnote = GameObject.Find("F Note");
        jnote = GameObject.Find("J Note");
        knote = GameObject.Find("K Note");
        lnote = GameObject.Find("L Note");
        */

        StartCoroutine(noteCoroutine());
    }

    IEnumerator noteCoroutine()
    {
        //while (!snoteStream.EndOfStream)
        while(true)
        {       
            //string inp_ln = noteStream.ReadLine();
            char[] noteArr = snoteStream.ToCharArray();

            foreach (char c in noteArr)
            {

                switch (c)
                {
                    case ';':
                        yield return new WaitForSeconds(0.3f);
                        
                        break;
                    case 'S':
                        Instantiate(snote, new Vector3(-5, 6, 0), Quaternion.identity);
                        //n = (Note)snote.GetComponent(typeof(Note));
                        //n.setSpeed((float)-3);
                        break;
                    case 'D':
                        Instantiate(dnote, new Vector3(-3, 6, 0), Quaternion.identity);
                        //n = (Note)dnote.GetComponent(typeof(Note));
                        //n.setSpeed((float)-3);
                        break;
                    case 'F':
                        Instantiate(fnote, new Vector3(-1, 6, 0), Quaternion.identity);
                        //n = (Note)fnote.GetComponent(typeof(Note));
                        //n.setSpeed((float)-3);
                        break;
                    case 'J':
                        Instantiate(jnote, new Vector3(1, 6, 0), Quaternion.identity);
                        //n = (Note)jnote.GetComponent(typeof(Note));
                        //n.setSpeed((float)-3);
                        break;
                    case 'K':
                        Instantiate(knote, new Vector3(3, 6, 0), Quaternion.identity);
                        //n = (Note)knote.GetComponent(typeof(Note));
                        //n.setSpeed((float)-3);
                        break;
                    case 'L':
                        Instantiate(lnote, new Vector3(5, 6, 0), Quaternion.identity);
                        //n = (Note)snote.GetComponent(typeof(Note));
                        //n.setSpeed((float)-3);
                        break;
                        /*default:
                            note = GameObject.Find(c + " Note");
                            Instantiate(note, transform.position, Quaternion.identity);
                            Note n = (Note)note.GetComponent(typeof(Note));
                            n.setSpeed((float)-3);
                            break; */
                }

                
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
