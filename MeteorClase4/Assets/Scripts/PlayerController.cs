using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform Bullet;
    public Transform CannonPosition;
    public int score;
    public Text ScoreText;
    public Text timer;
    private float timeRemaining;
    public Slider health;
    
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 75;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 60)
        {
            float minutes = Mathf.Round(timeRemaining / 60);
            float seconds = Mathf.Round(timeRemaining % 60);
            if (seconds <= 9)
            {
                timer.text = "Timer: " + minutes + ":0" + seconds;
            }
            else
            {
                timer.text = "Timer: " + minutes + ":" + seconds;
            }
        }
        else
        {
            timer.text = "Timer: 00:" + Mathf.Round(timeRemaining);
        }
        timeRemaining -= Time.deltaTime;
        ScoreText.text = "Score: " + score;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h, v, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(Bullet, CannonPosition.position, Quaternion.identity);
    }


}
