using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Spawning : NetworkBehaviour {

	//private NetworkStartPosition[] spawnPoints;

	void Start () {
		if(!isLocalPlayer)
		{
			//spawnPoints = FindObjectsOfType<NetworkStartPosition>();
		}
	}

}
