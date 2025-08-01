using Unity.Mathematics;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class RIDG : MonoBehaviour
{
    public Rigidbody RB;
    public float speed;
    public float jumpf=100f;

    public float rotateSpeed=20f;

    public float turnSmoothness = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = gameObject.GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(H,0,V).normalized;
        RB.MovePosition(RB.position+move*speed*Time.deltaTime);
        if(Input.GetButton("Jump"))
        {
            RB.AddForce(Vector3.up*jumpf);

        }
        if (move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSmoothness * Time.deltaTime);
        }
        
    }
}
