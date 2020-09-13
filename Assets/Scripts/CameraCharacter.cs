using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;


public class CameraCharacter : MonoBehaviour

{
    //    public float speed = 1;
    //    public float incrementFactor = 0.02f;
    //    public float spawnHelper = 4.5f;
    //    public GameObject ball;
    //    public float ballForce = 700;
    //    public GameObject button;

    //    //We use this when we implement UI
    //    public static bool camMoving = false;

    //    private CharacterController cameraChar;
    //    //A boolean whose value will be determined by OnTriggerEnter
    //    private bool collision = false;
    //    private Camera _cam;


    //    // Use this for initialization
    //    void Start()
    //    {
    //        cameraChar = gameObject.GetComponent<CharacterController>();
    //        _cam = GetComponent<Camera>();
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        Debug.Log("Speed is " + speed);

    //        float mousePosx = Input.mousePosition.x;
    //        float mousePosy = Input.mousePosition.y;

    //        Vector3 BallInstantiatePoint = _cam.ScreenToWorldPoint(new Vector3(mousePosx, mousePosy, _cam.nearClipPlane + spawnHelper));

    //        //This checks if we have collided
    //        if (!collision && camMoving)
    //        {
    //            transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
    //            //cameraChar.Move(Vector3.forward * Time.deltaTime * speed);
    //            //This is so that the camera's movement will speed up
    //            speed = speed + incrementFactor;
    //        }
    //        else if (collision || !camMoving)
    //        {
    //            cameraChar.Move(Vector3.zero);
    //        }

    //        if (Input.GetMouseButtonDown(0) && camMoving)
    //        {
    //            GameObject ballRigid;
    //            ballRigid = Instantiate(ball, BallInstantiatePoint, transform.rotation) as GameObject;
    //            ballRigid.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballForce);
    //        }

    //    }
    //    private void OnTriggerEnter(Collider other)
    //    {
    //        if (other.CompareTag("glass"))
    //        {
    //            collision = true;
    //            Debug.Log("Collided with glass!! Man down!!");
    //            camMoving = false;
    //            button.SetActive(true);
    //        }
    //    }
    //    public void StartCam()
    //    {
    //        camMoving = !camMoving;
    //    }
    //    public void Reset()
    //    {
    //        SceneManager.LoadScene("Scene1");

    public float spawnHelper = 4.5f;
public GameObject ball;
public float ballForce = 700;
    public float CameraSpeed;

private Camera _cam;

void Start()
{
    _cam = GetComponent<Camera>();
}

// Update is called once per frame
void Update()
{

    //Local floats
    float mousePosx = Input.mousePosition.x;
    float mousePosy = Input.mousePosition.y;

    //Confusing part :-)
    Vector3 BallInstantiatePoint = _cam.ScreenToWorldPoint(new Vector3(mousePosx, mousePosy, _cam.nearClipPlane + spawnHelper));
       transform.Translate(new Vector3(0, 0, CameraSpeed) * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
    {
        GameObject ballRigid;
        ballRigid = Instantiate(ball, BallInstantiatePoint, transform.rotation) as GameObject;
        ballRigid.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballForce);
    }
}
}