using UnityEngine;

public class player2script : MonoBehaviour
{
    public float speed=6f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                transform.position+= Vector3.forward *speed *Time.deltaTime;

            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                transform.position+= Vector3.right *speed *Time.deltaTime;

            }
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position+= Vector3.left *speed *Time.deltaTime;

            }
            if(Input.GetKey(KeyCode.DownArrow))
            {
                transform.position+= Vector3.back *speed *Time.deltaTime;

            }

        
        
    }
}
