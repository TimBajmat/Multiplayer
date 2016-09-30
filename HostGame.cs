using UnityEngine;
using UnityEngine.Networking;

public class HostGame : MonoBehaviour {

	private uint roomSize = 2;

	private string roomName;

	private NetworkManager networkManager;

	void Start()
	{
		networkManager = NetworkManager.singleton;
		if(networkManager.matchMaker == null)
		{
			networkManager.StartMatchMaker();
		}
	}

	public void SetRoomName(string _name)
	{
		roomName = _name;
	}

	public void CreateRoom()
	{
		if(roomName != "" && roomName != null)
		{
			Debug.Log("Creating Room: " + roomName + " Room Size: " + roomSize);

			networkManager.matchMaker.CreateMatch
				(roomName, roomSize, true, "", networkManager.OnMatchCreate);
		}
	}
}
