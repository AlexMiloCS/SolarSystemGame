using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollider : MonoBehaviour
{


    public Rigidbody Fragment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sun")
        {
            Destroy(this.gameObject);
        }
        else 
        {
            SplitObjects();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
    void SplitObjects()
    {
       
        int fragnum = Random.Range(10, 20);
        for (int i = 0; i < fragnum; i++)
        {
            float size = Random.Range(0.1f, 1.0f);
            float pos = Random.Range(1.0f, 4.0f);
            Rigidbody clone;
            clone = Instantiate(Fragment, transform.position + transform.forward *pos, Quaternion.identity);
            clone.transform.localScale = Vector3.one * size;
            Vector3 velocity = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
            clone.AddForce(velocity * 100f);
            Destroy(clone.gameObject, 5.0f);
        }

    }

}
