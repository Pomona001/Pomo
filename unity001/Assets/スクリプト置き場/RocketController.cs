using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour
{
    public GameObject bulletPrefab;
    int i;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)&& transform.position.x > -2.5f)
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)&& transform.position.x < 2.5f)
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow)&& transform.position.y < 4f)
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)&& transform.position.y > -4.5f)
        {
            transform.Translate(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            i++;
            if (i % 10 == 0)
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);    
        }
    }
}
