using UnityEngine;
using System.Collections;

public class TestAndroidPlugin : MonoBehaviour {

    private AndroidJavaClass ajc;

    // Use this for initialization
    void Start () {

        Debug.Log("Androidtion is to be called");


        ajc = new AndroidJavaClass("br.eti.francisco.mylibrary.Helper");
        ajc.CallStatic("doInAndroid");
        Debug.Log("Androidtion is called");
    }
	
	// Update is called once per frame
	void Update () {
        if(ajc != null)
        {
            int valor = ajc.CallStatic<int>("getValue");
            Debug.Log("Android value: " + valor);
        }
	}
}
