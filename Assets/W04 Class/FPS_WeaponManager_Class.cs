using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_WeaponManager_Class : MonoBehaviour
{
    public List<FPS2_WeaponBase_Class>Weapons = new List<FPS2_WeaponBase_Class>();
    int currentWeaponIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Weapons.Count > 0) SelectWeapon(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SelectWeapon(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SelectWeapon(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) SelectWeapon(2);
    }

    void SelectWeapon(int index)
    { 
        if(index<0 || index>=Weapons.Count) return;
        for (int i = 0; i < Weapons.Count; i++)
        {
            Weapons[i].gameObject.SetActive(i==index);
        
        }
        currentWeaponIndex = index;
        Debug.Log("Selected Weapon:" + Weapons[currentWeaponIndex].weaponName);
    }
}
