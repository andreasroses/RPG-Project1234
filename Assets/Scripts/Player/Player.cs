using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerInfo Main {get;set;}
    public int Level {get;set;}
    public List<Attacks> Moves {get;set;}
    public int HP {get; set;}
    public Player(PlayerInfo pMain, int pLevel){
        Main = pMain;
        Level = pLevel;
        HP = Main.MaxHp;
        Moves = new List<Attacks>();
        foreach(var move in Main.LearnableMoves){
           Moves.Add(new Attacks(move.Base));
        }         
        
    }
    public int Attack{
        get{return Mathf.FloorToInt((Main.Attack*Level)/100f)+5;}
    }
    public int Defense{
     get{return Mathf.FloorToInt((Main.Defense*Level)/100f)+5;}
   }
   public int Speed{
     get{return Mathf.FloorToInt((Main.Speed*Level)/100f)+5;}
   }
   public int MaxHP{
     get{return Mathf.FloorToInt((Main.MaxHp*Level)/100f)+10;}
   }
}
