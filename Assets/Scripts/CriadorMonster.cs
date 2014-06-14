using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CriadorMonster : MonoBehaviour {


    public float rateSpawn;
    private float currentRateSpawn;
    public GameObject Monstro1;

    public float maxSpawnMonstros;

    public IList<GameObject> monstros = new List<GameObject>();
	// Use this for initialization
	void Start () {
        for (int i = 0; i < maxSpawnMonstros; i++)
        {
            GameObject monstro = Instantiate(Monstro1) as GameObject;
            monstros.Add(monstro);
            monstro.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        currentRateSpawn += Time.deltaTime;

        if (currentRateSpawn > rateSpawn)
        {
            currentRateSpawn = 0;
            Spawn();
        }
	}

    private void Spawn()
    {
        GameObject tempMonstro = null;

        for (int i = 0; i < maxSpawnMonstros; i++)
        {
            if (monstros[i].activeSelf == false)
            {
                tempMonstro = monstros[i];
                break;
            }
        }
        if (tempMonstro != null)
        {
            float randHeight = Random.Range(-3, 0);
            tempMonstro.transform.position = new Vector3(transform.position.x +randHeight, transform.position.y + 1, transform.position.z);
            tempMonstro.SetActive(true);
        }
    }
}
