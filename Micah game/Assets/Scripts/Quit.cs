using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
     
public class Quit : MonoBehaviour
{
     public IEnumerator onClick() 
      {
      yield return new WaitForSeconds(1f);
        Application.Quit();
      }
    
    
    public void onClick_wrapper() 
      {
      StartCoroutine(onClick());
      }
    

}




      
   


   
