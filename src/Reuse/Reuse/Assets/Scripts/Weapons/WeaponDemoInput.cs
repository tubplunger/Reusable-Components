using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDemoInput : MonoBehaviour
{
    public WeaponController weaponController;

    void Update()
    {
        if (weaponController == null)
            return;

        if (Input.GetKey(KeyCode.Space))
        {
            weaponController.TryFire();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponController.EquipWeaponByIndex(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponController.EquipWeaponByIndex(1);
        }
    }
}
