using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public ParticleSystem ps;
    public float upSpeed;

    private ParticleSystem.EmissionModule em;

    public float score;
    public Text scoreText;
    public bool isPlaying = false;

    void Start()
    {
        em = ps.emission;
    }

    void Update()
    {
        if (isPlaying)
        {
            score += Time.deltaTime * 5f;
            scoreText.text = Mathf.RoundToInt(score).ToString();

            gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0, upSpeed * (Time.timeScale)));
                transform.localEulerAngles = new Vector3(0, 0, 0);
                em.enabled = true;
            }
            else
            {
                em.enabled = false;
            }
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            transform.localEulerAngles = new Vector3(0, 0, 0);
            score = 0;
            scoreText.text = "0";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            isPlaying = false;
            playButton.SetActive(true);
            Time.timeScale = 1;
        }
        
        if(collision.gameObject.tag == "Enemy")
        {
            isPlaying = false;
            playButton.SetActive(true);
            Time.timeScale = 1;
        }
    }

    public GameObject playButton;
    public void SetUpGame()
    {
        isPlaying = true;
        playButton.SetActive(false);
    }
}
