Public class Player : MonoBehaviour {
	
	public int level = 3;
	public int health = 40;
	
	public void SavePlayer (){
		SaveSystem.SavePlayer(this);
	}
	
	/// fungsi untuk meload data pelayer
	public void LoadPlayer (){
		/// mengambil data yang sudah di save
		PlayerData data = SaveSystem.LoadPlayer();
		
		/// mengatur data yang sudah diload
		level = data.level;
		health = data.health;
		
		Vector3 position;
		position.x = data.position[0];
		position.y = data.position[1];
		position.z = data.position[2];
		transform.position = position;
		
	}
	 
}
