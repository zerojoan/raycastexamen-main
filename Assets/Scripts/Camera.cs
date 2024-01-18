using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickCollisions: MonoBehaviour
{
 private Ray pulsacion;
 private RaycastHit colision;

 void Update ()
 {
  if(Input.GetMouseButton(0))
  {
   pulsacion=Camera.main.ScreenPointToRay(Input.mousePosition);
   if(Physics.Raycast(pulsacion,out colision))
   {
    Debug.Log(colision.collider.name); 
   }
  }
 }
}