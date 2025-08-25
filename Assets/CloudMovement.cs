using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CloudMovement : MonoBehaviour
{

    public float cloudSpeed = 5;
    public float deadZone = -12;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * cloudSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}