using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
   public IEnumerator onClick() 
      {
      yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
      }

      public void onClick_wrapper() 
      {
      StartCoroutine(onClick());
      }
}