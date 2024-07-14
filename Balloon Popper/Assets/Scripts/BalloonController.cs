using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class BalloonController : MonoBehaviour
{
    public float upSpeed;

    int score = 0;

    AudioSource audioSource;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();  
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 7f)
        {
            //SceneManager.LoadScene("Game");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0);
    }

    private void OnMouseDown()
    {
        score++;

        scoreText.text = score.ToString();

        audioSource.Play();

        ResetPosition();
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-2.5f, 2.5f);

        transform.position = new Vector2(randomX, -7f);
    }


}
