using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMov : MonoBehaviour
{
    public Transform t;
    public float speed;
    public int difficulty;

    public Player p;

    void Update()
    {
        if (p.isPlaying)
        {
            t.Translate(-speed * Time.deltaTime, 0, 0);
            Time.timeScale += Time.deltaTime * difficulty * 0.02f;

            if (t.transform.position.x < -51f)
            {
                t.transform.position = new Vector3(0f, 0, 10f);
            }
        }
        else
        {
            t.Translate(-speed * Time.deltaTime * 0.5f, 0, 0);
            //Time.timeScale += Time.deltaTime * difficulty * 0.02f;

            if (t.transform.position.x < -51f)
            {
                t.transform.position = new Vector3(0f, 0, 10f);
            }
        }
    }
}
