using UnityEngine;
using System.Collections;

public class rockController : MonoBehaviour
{
    float fallSpeed, rotSpeed;
    public int GameOver_flag = 0;

    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
    }
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);
        if (transform.position.y < -5.5f)
        {
            GameOver_flag = 1;
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }
    }
}
