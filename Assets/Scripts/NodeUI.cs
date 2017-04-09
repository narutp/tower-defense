using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour {

	public GameObject ui;
	public Text upgradeCost;
	public Button upgradeButton;
	public Text sellAmount;
	private Node target;

	public void setTarget(Node nodeTarget) {
		target = nodeTarget;
		transform.position = target.GetBuildPosition ();

		if (!target.isUpgraded) {
			upgradeCost.text = "$" + target.turretBlueprint.cost;
			upgradeButton.interactable = true;
		} else {
			upgradeCost.text = "DONE";
			upgradeButton.interactable = false;
		}

		sellAmount.text = "$" + target.turretBlueprint.GetSellAmount ();
		ui.SetActive (true);
	}

	public void Hide() {
		ui.SetActive (false);
	}

	public void Upgrade() {
		target.UpgradeTurret ();
		BuildManager.instance.DeselectNode ();
	}

	public void Sell() {
		target.SellTurret ();
		BuildManager.instance.DeselectNode ();
	}
}
