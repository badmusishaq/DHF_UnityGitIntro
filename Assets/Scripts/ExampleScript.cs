using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    private int myNumber = 5;
    public float myRandFloat = 1.0f;
    public string newText = "Bienvenue";

    float newFloat = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myNumber = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandMethod()
    {

    }
}

public class RandExampleClass
{
    ExampleScript myNewExampleScript;
    void RunScript()
    {
        myNewExampleScript = new ExampleScript();
        myNewExampleScript.myRandFloat = 3.5f;
        myNewExampleScript.newText = "Au revoir";

        myNewExampleScript.RandMethod();
    }
}
