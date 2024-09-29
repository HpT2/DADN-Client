using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public Stats totalStats;
    private Weapon weapon;
    private Armor armor;
    private Helmet helmet;
    private Shoes shoes;
    private Pet pet;
    private Character character;
    public Vector3 direction;

    public void FixedUpdate()
    {
        character.characterObj.transform.position += direction * totalStats.moveSpd * Time.fixedDeltaTime;
    }

    public void ApplyConfigs(WeaponConfig weaponConfig, ArmorConfig armorConfig, HelmetConfig helmetConfig, ShoesConfig shoesConfig, PetConfig petConfig, CharacterConfig charConfig)
    {
        //apply character
        character.Apply(charConfig, this);
        //apply weapon
        weapon.Apply(weaponConfig, this);
        //apply armor
        armor.Apply(armorConfig, this);
        //apply helmet
        helmet.Apply(helmetConfig, this);
        //apply shoes
        shoes.Apply(shoesConfig, this);
        //apply pet
        pet.Apply(petConfig, this);
    }
}
