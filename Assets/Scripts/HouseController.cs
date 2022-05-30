using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 public class HouseController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);

        //PlayerController player = collision.GetComponent<PlayerController>();

        //if (player != null)
        //{
        //    GameManager.Instance.LoadScene();
        //}
    }
}
