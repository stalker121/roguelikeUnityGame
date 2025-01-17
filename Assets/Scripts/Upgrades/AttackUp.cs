using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Upgrades/AttackUp")]
public class AttackUp : PowerUps {

    public int extraAttacks;

    public override void Apply() {
        player.GetComponent<PlayerMovement>().numberOfBullets += extraAttacks;
    }
}
