using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CollectionItems : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    [SerializeField] Text _scoreText;
     int _score;
    private void Awake()
    {
        _scoreText.text = _score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Diamond"))
        {
            _score++;
            _scoreText.text = _score.ToString();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Door"))
        
        {
            SceneManager.LoadScene(2);
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            _panel.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Eagle"))
        {
            SceneManager.LoadScene(2);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(1);
        }
    }
    public void RestartOnclick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void QuitGameOnClick()
    {
        Application.Quit();
    }
}
