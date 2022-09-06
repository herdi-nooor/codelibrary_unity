using System.IO;


public static class SaveSystem {
	
	/*
		 typeData class PlayerData  untuk tempat simpan data yang akan di save
	*/
	public static void SavePlayer (Player plyer)
	{
	  BinaryFormatter formatter = new BinaryFormatter();
	  string path = Application.persistentDataPath + "/player.fun";

	  PlayerData data = new PlayerData(player);
		
		formatter.Serialize(stream, data);
		stream.Close();
	}
	
	public static PlayerData LoadPlayer ()
	{
		string path = Application.persistentDataPath + "/player.fun";
		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);
			
			PlayerData data = formatter.Deserialize(stream) as PlayerData;
			stream.Close();
			
			return data;
		}
		else
		{
			Debug.LogError("Save data not found in " + path);
			return null;
		}
	}

}
