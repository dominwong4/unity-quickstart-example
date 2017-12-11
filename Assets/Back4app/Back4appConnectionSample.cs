using UnityEngine;
using System.Collections;
using Parse;
using System.Threading.Tasks;

public class Back4appConnectionSample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Uncomment below if you want to test the database

//		ParseObject gameScore = new ParseObject ("GameSocre");
//		gameScore["score"] = 9999;
//		gameScore["playerName"] = "Unity3d Latest Parse Version";
//		Task saveTask = gameScore.SaveAsync();

		// Saving the Parse Installation
		ParseInstallation.CurrentInstallation.SaveAsync ();
	}

	// Update is called once per frame
	void Update () {

	}
}
