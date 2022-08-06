using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class SnakeController : MonoBehaviour
{
    public int score;
    public float speed = 2.0f;
    public float moveRate = 0.3f;

    public SpriteRenderer spriteRenderer;

    private Vector2 moveDirection;

    private int currentStep,
        totalSteps;

    public GameObject tail;

    public List<Transform> tailPositions;

    public AudioSource eatSound;
    public AudioSource loseSound;

    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        moveDirection = Vector2.right;
        InvokeRepeating("Move", moveRate, moveRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentStep != totalSteps)
        {
            ChangeDirection();
        }
    }

    void Move()
    {
        Vector3 lastPos = transform.position;
        transform.Translate(moveDirection * speed);

        if (tailPositions.Count > 0)
        {
            tailPositions.Last().position = lastPos;
            tailPositions.Insert(0, tailPositions.Last());
            tailPositions.RemoveAt(tailPositions.Count - 1);
        }

        totalSteps++;
    }

    void ChangeDirection()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (moveDirection != Vector2.down)
            {
                moveDirection = Vector2.up;
                spriteRenderer.transform.eulerAngles = new Vector3(0, 0, -270);
                currentStep = totalSteps;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (moveDirection != Vector2.up)
            {
                moveDirection = Vector2.down;
                spriteRenderer.transform.eulerAngles = new Vector3(0, 0, -90);
                currentStep = totalSteps;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (moveDirection != Vector2.right)
            {
                moveDirection = Vector2.left;
                spriteRenderer.transform.eulerAngles = new Vector3(0, 0, -180);
                currentStep = totalSteps;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (moveDirection != Vector2.left)
            {
                moveDirection = Vector2.right;
                spriteRenderer.transform.eulerAngles = new Vector3(0, 0, 0);
                currentStep = totalSteps;
            }
        }
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("LastScore", score);
        PlayerPrefs.Save();

        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 spawnPos = new Vector2(100, 100);

        if (other.tag == "Apple")
        {
            GameObject newTail = Instantiate(tail, spawnPos, Quaternion.identity) as GameObject;
            newTail.transform.parent = GameObject.Find("Tail Holder").transform;
            tailPositions.Add(newTail.transform);
            eatSound.Play();
            score++;
            scoreText.text = score.ToString();
            SaveScore();
        }

        if (other.tag == "Tail")
        {
            loseSound.Play();
            StateController.initialScore = 0;
            SceneManager.LoadScene("Menu");
        }
    }

    void OnEnable()
    {
        speed = PlayerPrefs.GetFloat("Speed", 0.5f);
        score = StateController.initialScore;
        scoreText.text = score.ToString();
        Vector2 spawnPos = new Vector2(100, 100);

        for (int i = 0; i < score; i++)
        {
            GameObject newTail = Instantiate(tail, spawnPos, Quaternion.identity) as GameObject;
            newTail.transform.parent = GameObject.Find("Tail Holder").transform;
            tailPositions.Add(newTail.transform);
        }

        Debug.Log("Speed: " + speed);
    }
}
