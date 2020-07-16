using UnityEngine;

public class Pistol : MonoBehaviour
{
   // public GameObject imppactEffect;
   // public ParticleSystem muzzleFlash;

    RaycastHit hit;
    [SerializeField]
    Transform ShootPoint;

    //Use to dmg the enemy
    [SerializeField]
    float damageEnemy = 10f;

    [SerializeField]
    int currentAmmo;

    //Rate Of Fire
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
       // muzzleFlash.Play();
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
                // Instatieate impact effect from the gun
              // GameObject impactGO = Instantiate(imppactEffect, hit.point, Quaternion.LookRotation(hit.normal));
              //  Destroy(impactGO, 2f);
            }

        }
    }

}
