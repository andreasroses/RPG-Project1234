using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour{
  public GameObject UiObject;

  void Start(){
    UiObject.SetActive(false);
  }

  void OnTriggerEnter(Collider other)
  {
    if(other.tag == "Player")
    {
    UiObject.SetActive(true);
    }
  }

  void Update(){
    
  }

  void OnTriggerExit(Collider other)
  {
        UiObject.SetActive(false);
  }
}