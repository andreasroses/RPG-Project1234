using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleUnit : MonoBehaviour
{
    [SerializeField] PlayerInfo main;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;
    public Player Player {get; set;}
    public void Setup(){
        Player = new Player(main,level);
        if(isPlayerUnit)
            GetComponent<Image>().sprite = Player.Main.BackSprite;
        else
            GetComponent<Image>().sprite = Player.Main.FrontSprite;
    }
}
