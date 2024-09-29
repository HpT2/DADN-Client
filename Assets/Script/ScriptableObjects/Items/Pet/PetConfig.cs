using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PetConfig", menuName = "Configs/Items/Pet")]
public class PetConfig : ItemConfig
{
    public float atk;
    public float moveSpd;
    public float atkSpd;
    public float atkRange;
    public RuntimeAnimatorController moveController;
    public RuntimeAnimatorController atkController;
}
