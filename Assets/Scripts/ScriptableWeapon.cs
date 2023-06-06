using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/New Weapon")]
public class ScriptableWeapon : ScriptableObject
{
    public string weaponName;
    public string weaponDescription;
    public Sprite weaponSprite;
    public float weaponDamage;
    public float weaponMagicDamage;
    public string traducción1;
    public string traducción2;
}

   