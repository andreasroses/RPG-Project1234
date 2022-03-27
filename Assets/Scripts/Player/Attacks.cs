using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
   public MoveBase Base {get;set;}
   public int PP {get;set;}

   public Attacks(MoveBase pBase){
       Base = pBase;
       PP = pBase.PP;
   }
}
