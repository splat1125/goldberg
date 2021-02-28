using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControl : MonoBehaviour
{
    public bool notMoved = true;
    public float force;

    private cameraFollower anchor;

    private Rigidbody2D myBody;
    public GameObject cam;
    public GameObject tgt1;
    public GameObject tgt2;
    public GameObject tgt3;
    public GameObject tgt4;
    public GameObject tgt5;
    
    // Start is called before the first frame update
    void Start()
    {
        anchor = cam.GetComponent<cameraFollower>();
        myBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(notMoved){
            if(Input.GetKeyDown(KeyCode.Space)){
                myBody.AddForce(new Vector2(1, 0) * force);
                notMoved = false;
            }
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "checkpoint1"){
            anchor.anchorTransform = tgt1.transform;
        }
        if(other.gameObject.name == "checkpoint2"){
            anchor.anchorTransform = tgt2.transform;
        }
        if(other.gameObject.name == "checkpoint3"){
            anchor.anchorTransform = tgt3.transform;
        }
        if(other.gameObject.name == "checkpoint4"){
            anchor.anchorTransform = tgt4.transform;
        }
        if(other.gameObject.name == "checkpoint5"){
            anchor.anchorTransform = tgt5.transform;
        }
    }
}
