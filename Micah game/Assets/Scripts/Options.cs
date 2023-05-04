using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{

        public IEnumerator onClick() 
      {
      yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
      }
      public void onClick_wrapper() 
      {
      StartCoroutine(onClick());
      }
}
