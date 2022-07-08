using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Loading : MonoBehaviour
{
    [SerializeField]
    GameObject[] Items;


   private void Update()
    {
        LoadingScene();
        LoadLobby();
    }
    private void LoadingScene()
    {
        StartCoroutine(LoadingScreenEffects());
    }

    IEnumerator LoadingScreenEffects()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        Items[1].gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3.8f);
        Items[0].gameObject.SetActive(true);
    }


    private void LoadLobby()
    {
        StartCoroutine(LoadingLobby());
    }
    IEnumerator LoadingLobby()
    {
        yield return new WaitForSecondsRealtime(10f);
         SceneManager.LoadScene(1);
        StopAllCoroutines();
    }

}
