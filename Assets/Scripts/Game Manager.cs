using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameover;
    public player player;
    private int score;
    private void Awake()
    {
        Application.targetFrameRate = 60;
        pause();
    }

    public void play()
    {
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameover.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        gameover.SetActive(true);
        playButton.SetActive(true);
        pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
