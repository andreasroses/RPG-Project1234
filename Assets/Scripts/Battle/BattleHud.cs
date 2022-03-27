using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleHud : MonoBehaviour
{
    [SerializeField]  Text nameText;
    [SerializeField]  Text levelText;
    [SerializeField] HPBar hpBar;
    // Start is called before the first frame update
    public void SetData(Player player){

        nameText.text = player.Main.Name;
        levelText.text = "Lvl Over 9000";
        hpBar.SetHP((float)player.HP/player.Main.MaxHp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
