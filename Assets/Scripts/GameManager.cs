using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] float _delaylevelTime = 1f;
    private void Awake()
    {
        SingletonThisGameObject();
    }

    void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void LoadScene(int _levelIndex=0)
    {
        StartCoroutine(LoadSceneAsync(_levelIndex));
    }
    IEnumerator LoadSceneAsync(int _levelIndex)
    {
        yield return new WaitForSeconds(_delaylevelTime);
        yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + _levelIndex);
    }
}
