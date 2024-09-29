using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Config/Character")]
public class CharacterConfig : ScriptableObject
{
    public GameObject characterPrefab;
    public Skill skill;
    public Stats stats;
}
