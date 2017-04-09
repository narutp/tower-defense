using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;
	public TurretBlueprint laserBeamer;
	public TurretBlueprint rapidTurret;
	BuildManager buildManager;

	void Start() {
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret () {
		Debug.Log ("Select Stan");
		buildManager.SelectTurretToBuild (standardTurret);
	}

	public void SelectMissileLauncher () {
		Debug.Log ("Select Miss");
		buildManager.SelectTurretToBuild (missileLauncher);
	}

	public void SelectLaserBeamer () {
		Debug.Log ("Select Laser");
		buildManager.SelectTurretToBuild (laserBeamer);
	}
	public void SelectRapidTurret() {
		Debug.Log ("Select Rapid");
		buildManager.SelectTurretToBuild (rapidTurret);
	}
}
