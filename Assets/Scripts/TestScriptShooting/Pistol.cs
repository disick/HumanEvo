using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField]
    Transform ShootPoint;

    //Use to dmg the enemy
    [SerializeField]
    float damageEnemy = 10f;

    [SerializeField]
    int currentAmmo;

    //Rate Od Fire
    [SerializeField]
    float rateOfFire;
    float nextFire = 0;

    [SerializeField]
    float weaponRange;

    private void Update()
    {
        if (Input.GetButton("Fire1") && currentAmmo >0)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        if (Time.time > nextFire)
        {
            //FireRate
            nextFire = Time.time + rateOfFire;
            //Extract one from current Ammo
            currentAmmo--;

            if (Physics.Raycast(ShootPoint.position, ShootPoint.forward, out hit, weaponRange))
            {
                if (hit.transform.tag == "Enemy")
                {
                    Debug.Log("Hit Enemy");
                    EnemyHealth enemyHealthScript = hit.transform.GetComponent<EnemyHealth>();
                    enemyHealthScript.DeductHealth(damageEnemy);
                }
                else
                    Debug.Log(hit.transform.name);
            }

        }
    }

}
