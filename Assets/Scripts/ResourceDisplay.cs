using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourceDisplay : MonoBehaviour {
    ResourceStats Resources;

    //ResourceBar pulls from resourceStats and updates displayed resource numbers

    public int foodNum;
    Text foodText;
    public int lumberNum;
    Text lumberText;
    public int cottonNum;
    Text cottonText;
    public int furNum;
    Text furText;
    public int oreNum;
    Text oreText;

    void Start () {
        Resources = GameObject.Find("GameManager").GetComponent<ResourceStats>();
        foodText = this.gameObject.transform.Find("foodBlock").Find("foodNum").GetComponent<Text>();
        lumberText = this.gameObject.transform.Find("lumberBlock").Find("lumberNum").GetComponent<Text>();
        cottonText = this.gameObject.transform.Find("cottonBlock").Find("cottonNum").GetComponent<Text>();
        furText = this.gameObject.transform.Find("furBlock").Find("furNum").GetComponent<Text>();
        oreText = this.gameObject.transform.Find("oreBlock").Find("oreNum").GetComponent<Text>();
    }
	
	void Update () {
        updateNumbers();
        displayNumbers();
	}

    void updateNumbers(){
        foodNum = Resources.food;
        lumberNum = Resources.lumber;
        cottonNum = Resources.cotton;
        furNum = Resources.fur;
        oreNum = Resources.ore;
    }

    void displayNumbers(){
        foodText.text = foodNum.ToString();
        lumberText.text = lumberNum.ToString();
        cottonText.text = cottonNum.ToString();
        furText.text = furNum.ToString();
        oreText.text = oreNum.ToString();
    }
}
