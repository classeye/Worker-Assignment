using UnityEngine;
using System.Collections;

public class LandResources : MonoBehaviour {
    ResourceStats Resources; //connects to resource bar

    //output stats
    public int rsrcHarv; //0 none, 1 food, 2 lumber, 3 cotton, 4 fur, 5 ore
    public int specialist; //0 noSpecialist, 1 food, 2 lumber, etc....

    public int landType; //0 plains, 1 tundra, 2 desert
    int baseFood;
    int baseLumber;
    int baseCotton;
    int baseFur;
    int baseOre;

    public int isWooded; //0 not wooded, 1 light woods, 2 forested
    int woodFood;
    int woodLumber;
    int woodCotton;
    int woodFur;
    int woodOre;

    public int building; //0 no building, 1 farm, 2 lodge, 3 mine 
    int buildingFood;
    int buildingLumber;
    int buildingCotton;
    int buildingFur;
    int buildingOre;

    public int hasRoad; //0 noRoad, 1 hasRoad
    int roadFood;
    int roadLumber;
    int roadCotton;
    int roadFur;
    int roadOre;
    
    //yield stats
    int yieldFood;
    int yieldLumber;
    int yieldCotton;
    int yieldFur;
    int yieldOre;



    void Start () {
        Resources = GameObject.Find("GameManager").GetComponent<ResourceStats>();
        calcYield();
        testOutput();    
        

    }

    void testOutput()
    {
        switch (rsrcHarv)
       {
            case 0:
                Debug.Log("nothing harvested");
                break;
            case 1:
                Debug.Log("Testing Output Food");
                Debug.Log("Food is equal to " + Resources.food);
                output();
                Debug.Log("Food is equal to " + Resources.food);
                break;
            case 2:
                Debug.Log("Testing Output lumber");
                Debug.Log("Lumber is equal to " + Resources.lumber);
                output();
                Debug.Log("Lumber is equal to " + Resources.lumber);
                break;
            case 3:
                Debug.Log("Testing Output Cotton");
                Debug.Log("Cotton is equal to " + Resources.cotton);
                output();
                Debug.Log("Cotton is equal to " + Resources.cotton);
                break;
            case 4:
                Debug.Log("Testing Output Fur");
                Debug.Log("Fur is equal to " + Resources.fur);
                output();
                Debug.Log("Fur is equal to " + Resources.fur);
                break;
            case 5:
                Debug.Log("Testing Output Ore");
                Debug.Log("Ore is equal to " + Resources.ore);
                output();
                Debug.Log("Ore is equal to " + Resources.ore);
                break;
        }
        

    }

    void output()
    {
        if (rsrcHarv == 0)
        {
            return;
        }

        switch (rsrcHarv)
        {
            case 1: //food
                Resources.food = Resources.food + yieldFood;
                break;
            case 2: //lumber
                Resources.lumber = Resources.lumber + yieldLumber;
                break;
            case 3: //cotton
                Resources.cotton = Resources.cotton + yieldCotton;
                break;
            case 4: //fur
                Resources.fur = Resources.fur + yieldFur;
                break;
            case 5: //ore
                Resources.ore = Resources.ore + yieldOre;
                break;
        }
    }

    void calcYield(){
        calcBase();
        calcWood();
        calcBuilding();
        calcRoad();
        
        yieldFood = baseFood + woodFood + buildingFood + roadFood;
        if (specialist == 1)
        {
            yieldFood = yieldFood * 2;
        }
        if (yieldFood < 0)
        {
            yieldFood = 0;
        }
        yieldLumber = baseLumber + woodLumber + buildingLumber + roadLumber;
        if (specialist == 2)
        {
            yieldLumber = yieldLumber * 2;
        }
        if (yieldLumber < 0)
        {
            yieldLumber = 0;
        }
        yieldCotton = baseCotton + woodCotton + buildingCotton + roadCotton;
        if (specialist == 3)
        {
            yieldCotton = yieldCotton * 2;
        }
        if (yieldCotton < 0)
        {
            yieldCotton = 0;
        }
        yieldFur = baseFur + woodFur + buildingFur + roadFur;
        if (specialist == 4)
        {
            yieldFur = yieldFur * 2;
        }
        if (yieldFur < 0)
        {
            yieldFur = 0;
        }
        yieldOre = baseOre + woodOre + buildingOre + roadOre;
        if (specialist == 5)
        {
            yieldOre = yieldOre * 2;
        }

        if (yieldOre < 0)
        {
            yieldOre = 0;
        }
    }

    void calcBase(){
        switch (landType){
            case 0: //plains
                baseFood = 3;
                baseLumber = 0;
                baseCotton = 3;
                baseFur = 0;
                baseOre = 0;
                break;
            case 1: //tundra
                baseFood = 2;
                baseLumber = 0;
                baseCotton = 0;
                baseFur = 2;
                baseOre = 0;
                break;
            case 2: //desert                
                baseFood = 0;
                baseLumber = 0;
                baseCotton = 0;
                baseFur = 0;
                baseOre = 2;
                break;
        }
    }

    void calcWood()
    {
        switch (isWooded)
        {
            case 0: //no wood
                 woodFood = 0;
                woodLumber = 0;
                woodCotton = 0;
                 woodFur = 0;
                 woodOre = 0;
                break;
            case 1: //lightly wooded
                woodFood = -1;            
                woodLumber = 2;
                woodCotton = -1;
                woodFur = 2;
                woodOre = 0;
                break;
            case 2: // forested
                woodFood = -2;
                woodLumber = 6;
                woodCotton = -2;
                woodFur = 3;
                woodOre = 0;
                break;
        }
    }

    void calcBuilding()
    {
        switch (building)
        {
            case 0: //noBuilding
                buildingFood = 0;
                buildingLumber = 0;
                buildingCotton = 0;
                buildingFur = 0;
                buildingOre = 0;
                break;
            case 1: //farm
                buildingFood = 1;
                buildingLumber = 0;
                buildingCotton = 1;
                buildingFur = 0;
                buildingOre = 0;
                break;
            case 2: //lodge
                buildingFood = 0;
                buildingLumber = 1;
                buildingCotton = 0;
                buildingFur = 1;
                buildingOre = 0;
                break;
            case 3: //mine
                buildingFood = 0;
                buildingLumber = 0;
                buildingCotton = 0;
                buildingFur = 0;
                buildingOre = 1;
                break;
        }
    }

    void calcRoad(){
        switch (hasRoad)
        {
            case 0: //noRoad
                roadFood = 0;
                roadLumber = 0;
                roadCotton = 0;
                roadFur = 0;
                roadOre = 0;
                break;
            case 1: //has Road
                roadFood = 0;
                roadLumber = 1;
                roadCotton = 1;
                roadFur = 0;
                roadOre = 1;
                break;
        }
    }
}
