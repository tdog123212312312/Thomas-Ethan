using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
     
public class StreetMap : MonoBehaviour
{
 
      public IEnumerator onClick() 
      {
      yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
      }
      
      public void onClick_wrapper() 
      {
      StartCoroutine(onClick());
      }
   
}
