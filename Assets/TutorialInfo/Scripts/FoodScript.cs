
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    private float Fspeed = 10;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime * Fspeed);
    }
}
