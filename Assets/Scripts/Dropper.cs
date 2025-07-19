using UnityEngine;

public class Dropper: MonoBehaviour
{
    [SerializeField] private float timeToWait = 5f;
    
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
       
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        { 
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
            
        }
    }
}
