using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNames : MonoBehaviour
{
     public IEnumerator onClick() 
      {
      yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(4);
      }

      public void onClick_wrapper() 
      {
      StartCoroutine(onClick());
      }
}
