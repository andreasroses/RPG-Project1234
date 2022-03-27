using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player",menuName = "Player/Create new player")]

public class PlayerInfo : ScriptableObject
{
   [SerializeField] string playerName;
   [SerializeField] int item;
   [SerializeField] Sprite frontSprite;
   [SerializeField] Sprite backSprite;

   [SerializeField] int maxHp;
   [SerializeField] int attack;
   [SerializeField] int defense;
   [SerializeField] int speed;
   [SerializeField] List<LearnableMove> learnableMoves;
   [SerializeField] bool enemy;
   public string GetName(){
     return playerName;
   }
   public string Name{
     get{return playerName;}
   }
    public int MaxHp{
     get{return maxHp;}
   }
   public int Attack{
     get{return attack;}
   }
   public int Defense{
     get{return defense;}
   }
   public int Speed{
     get{return speed;}
   }
   public int Item{
     get{return item;}
   }
   public Sprite BackSprite{
     get{return backSprite;}
   }
   public Sprite FrontSprite{
     get{return frontSprite;}
   }
    public List<LearnableMove> LearnableMoves{
     get{return learnableMoves;}
   }
   public bool Enemy{
     get {return enemy;}
   }
 }
