using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHud playerHud;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleDialogBox dialogBox;
    [SerializeField] BattleHud enemyHud;
    // Start is called before the first frame update
    private void Start()
    {
        SetupBattle();
    }

    // Update is called once per frame
    public void SetupBattle()
    {
        playerUnit.Setup();
        playerHud.SetData(playerUnit.Player);
        enemyHud.SetData(enemyUnit.Player);
        dialogBox.SetDialog($"A wild {playerUnit.Player.Main.Name} appeared"); 
    }
}
