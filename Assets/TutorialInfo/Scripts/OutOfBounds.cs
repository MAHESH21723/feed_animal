using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float upperBound = 30f;
    private float lower = -30f;

    void Update()
    {
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lower)
        {
            Debug.Log("GAME OVER!!!");
            Destroy(gameObject);
        }
    }
}
