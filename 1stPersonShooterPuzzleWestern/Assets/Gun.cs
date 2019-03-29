using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource mAudioSrc;
    public GameObject endScreen;
    public GameObject startScreen;


    void Start()
    {
        mAudioSrc = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        mAudioSrc.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            
            Enemy EnemyHitScan = hit.transform.gameObject.GetComponent(typeof(Enemy)) as Enemy;
            if(EnemyHitScan == null)
            {
                EnemyHitScan = hit.transform.parent.gameObject.GetComponent(typeof(Enemy)) as Enemy;
            }
            if (EnemyHitScan != null)
            {
                EnemyHitScan.enemyHit = true;
            }

            if (endScreen != null)
            {
                Destroy(endScreen.gameObject);
            }

            if (startScreen != null)
            {
                Destroy(startScreen.gameObject);
            }


            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 1f);
        }
    }

}
