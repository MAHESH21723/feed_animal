using UnityEngine;

public class PlayerContllor : MonoBehaviour
{
    public float horizontalInput;
    private float speed=30f;
    public GameObject Proprefab;
    private float Outrange = 18f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Proprefab, transform.position, Proprefab.transform.rotation);
        }
        if (transform.position.x < -Outrange)
        {
            transform.position = new Vector3(-Outrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Outrange)
        {
            transform.position = new Vector3(Outrange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
       
    }
}
