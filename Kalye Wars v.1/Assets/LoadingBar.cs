using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour
{
  public Transform loadingBarImage;
  public float TargetAmount = 100.0f;
  private float CurrentAmount = 0.0f;
  public float speed = 30;

    void Start()
    {
      CurrentAmount = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
      if (CurrentAmount<TargetAmount)
      {
        CurrentAmount += speed * Time.deltaTime;
        loadingBarImage.GetComponent<Image>().fillAmount = CurrentAmount / 100.0f;
      }
      else
      {
        LoadNextScene();
      }
    }
    void LoadNextScene()
    {
      int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene("Level 1");
    }
}
