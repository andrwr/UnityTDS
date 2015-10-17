using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour
{

    public Transform weaponHold;
    public Transform weaponHold2;

    public Gun startingGun;
    Gun equippedGun;

    void Start()
    {
        if (startingGun != null)
        {
            EquipGun(startingGun);
        }
    }

    public void EquipGun(Gun gunToEquip)
    {
        if (equippedGun != null)
        {
            Destroy(equippedGun.gameObject);
        }
        equippedGun = Instantiate(gunToEquip, weaponHold.position, weaponHold.rotation) as Gun;
        equippedGun.transform.parent = weaponHold;
        equippedGun = Instantiate(gunToEquip, weaponHold2.position, weaponHold2.rotation) as Gun;
        equippedGun.transform.parent = weaponHold2;
    }

    public void Shoot()
    {
        if (equippedGun != null)
        {
            equippedGun.Shoot();
        }
    }
}