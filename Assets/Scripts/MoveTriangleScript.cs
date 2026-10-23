using UnityEngine;

public class MoveTriangleScript : MonoBehaviour
{
    public float speed = 2f;
    public float leftTime = 2f;
    public float downTime = 2f;

    private float timer = 0f;
    private bool movingLeft = true;

    void Start()
    {
        transform.localScale = new Vector3(2f, 2f, 2f);
        print("Triangle is now moving!");
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (movingLeft)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (timer >= leftTime)
            {
                timer = 0f;
                movingLeft = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            if (timer >= downTime)
            {
                timer = 0f;
                movingLeft = true;
            }
        }
    }
}
