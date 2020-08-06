using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	
	//float sensS, cutoffS;
	//Color colS;
    public Texture mainTexture;
    public Color[] col;

    // Use this for initialization
    void Start () {
		//sensS = GetComponent<Renderer>().material.GetFloat("_Sens");
		//cutoffS = GetComponent<Renderer>().material.GetFloat("_Cutoff");
		//colS = GetComponent<Renderer>().material.GetColor("_Color");
	}
	
	// Update is called once per frame
	void Update () {
        //if (mainTexture == null)
        //{
        //    mainTexture = GetComponent<Renderer>().material.mainTexture;
        //}

        //if (mainTexture != null)
        //{
        //    col = mainTexture.hideFlags;
        //}
       
    }

	string r = "99", g = "205", b ="77";
	void OnGUI () {
		//try{
		//	Color col = new Color(int.Parse(r) / 255f, int.Parse(g) / 255f, int.Parse(b) / 255f);
		//	GetComponent<Renderer>().material.color = col; 

		//}catch(UnityException e){
		//}
	}
}
