using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move",menuName = "Player/Create new player move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string name;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
    
    [SerializeField] bool isEnemy;
    public string Name{
        get {return name;}
    }
    public string Description{
        get {return description;}
    }
    public int Power{
        get {return power;}
    }
    public int Accuracy{
        get {return accuracy;}
    }
    public int PP{
        get {return pp;}
    }
    public bool IsEnemy{
        get {return isEnemy;}
    }
}

public class LearnableMove{
  [SerializeField] MoveBase moveBase;
  public MoveBase Base{
    get {return moveBase;}
  }

}