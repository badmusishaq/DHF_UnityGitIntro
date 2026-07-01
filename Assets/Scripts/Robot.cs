using UnityEngine;

public class Robot : MonoBehaviour
{
    public string gameMessage = "Let's goooooooo!";

    public float speed;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameMessage = "God bless Nigeria";
        Debug.Log(gameMessage);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameMessage != "God bless Nigeria")
        {
            Debug.Log("Game updating...");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A is pressed");
        }

        //transform.Rotate(speed * Time.deltaTime, 0, 0);
        /*if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.Rotate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }*/


        //transform.Rotate(speed * Time.deltaTime * Input.GetAxis("Vertical") , 0, 0);
        transform.Rotate(speed * Time.deltaTime * Input.GetAxis("Mouse Y") , 0, 0);

    }
}
