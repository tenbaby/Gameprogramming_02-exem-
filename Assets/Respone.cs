using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respone : MonoBehaviour
{
    public List<GameObject> MobPool = new List<GameObject>();
    public GameObject[] Mobs;
    public int obj = 100;

    void Awake()
    {
        for (int i = 0; i < Mobs.Length; i++)
        {
            for (int k = 0; k < obj; k++)
            {
                MobPool.Add(CreateObj(Mobs[i], transform));
            }
        }
    }

    private void Start()
    {
        StartCoroutine(CreateMob());
    }

    IEnumerator CreateMob()
    {
        while (true)
        {
            MobPool[DeactiveMob()].SetActive(true);
            yield return new WaitForSeconds(Random.Range(1f, 3f));
        }
        
    }

    int DeactiveMob()
    {
        List<int> num = new List<int>();
        for (int i = 0; i < MobPool.Count; i++)
        {
            if (!MobPool[i].activeSelf)
                num.Add(i);
        }
        int x = 0;
        if (num.Count > 0)
        x = num[Random.Range(0, num.Count)];
        return x;
  
    }


    GameObject CreateObj(GameObject obj, Transform parent)
    {
        GameObject copy = Instantiate(obj);
        copy.transform.SetParent(parent);
        copy.SetActive(false);
        return copy;
    }
}
