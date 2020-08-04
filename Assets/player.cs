using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float GravityMultipler;



    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            if (transform.position.x > 400 && (transform.position.z > 209 && transform.position.z < 211))
            {
                var f = Terrain.activeTerrains;
                f[0].drawHeightmap = true;
                f[1].drawHeightmap = true;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 100 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 100 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -100 * Time.deltaTime, 0);
        }

    }
}
