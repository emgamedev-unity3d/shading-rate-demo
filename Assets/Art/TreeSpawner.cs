using System.Collections.Generic;
using NUnit.Framework.Internal.Builders;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    private BoxCollider m_Collider;

    public List<GameObject> m_TreePrefabs;


    public int Amount;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Collider = GetComponent<BoxCollider>();

        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        int count = 0;

        while (count < Amount)
        {
            Vector3 pos = RandomPointInBounds(m_Collider.bounds);

            RaycastHit hit;

            if (Physics.Raycast(pos, Vector3.down, out hit))
            {

                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Forest"))
                {
                    
                    
                    
                    
                    GameObject tree = Instantiate(m_TreePrefabs[count%(m_TreePrefabs.Count)], hit.point, Quaternion.Euler(0,Random.Range(0,360), 0), transform);

                    tree.transform.localScale *= Random.Range(0.8f, 1.5f);

                    count++;
                }
                
                
            }
        }

    }
    
    public static Vector3 RandomPointInBounds(Bounds bounds) {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
