using UnityEngine;
using System.Collections;

public class LandResources : MonoBehaviour {
    public int landType; //0 plains, 1 tundra, 2 desert
    int baseLumber;
    int baseFood;
    int baseCotton;
    int baseFur;
    int baseOre;

    public int isWooded; //0 not wooded, 1 light woods, 2 forested
    int woodLumber;
    int woodFood;
    int woodCotton;
    int woodFur;
    int woodOre;

    public int building; //0 no building, 1 farm, 2 lodge, 3 mine 
    int buildingLumber;
    int buildingFood;
    int buildingCotton;
    int buildingFur;
    int buildingOre;

    public int hasRoad; //0 noRoad, 1 hasRoad
    int roadLumber;
    int roadFood;
    int roadCotton;
    int roadFur;
    int roadOre;
    
    //yield stats
    int yieldLumber;
    int yieldFood;
    int yieldCotton;
    int yieldFur;
    int yieldOre;

    //output stats
    

    public int rsrcHarv; //0 none, 1 lumber, 2 food, 3 cotton, 4 fur, 5 ore
    public int speclPrst; //0 noSpecialist, 1 specialistPresent

    void Start () {
        calcYield();
    }

    void output()
    {
        if (rsrcHarv == 0)
        {
            return;
        }

        switch (rsrcHarv)
        {
            case 1: //lumber
                break;
            case 2: //food
                break;
            case 3: //cotton
                break;
            case 4: //fur
                break;
            case 5: //ore
                break;
        }
    }

    void calcYield(){
        calcBase();
        calcWood();
        calcBuilding();
        calcRoad();
        
        yieldLumber = baseLumber + woodLumber + buildingLumber + roadLumber;
        if (yieldLumber < 0)
        {
            yieldLumber = 0;
        }
        yieldFood = baseFood + woodFood + buildingFood + roadFood;
        if (yieldFood < 0)
        {
            yieldFood = 0;
        }
        yieldCotton = baseCotton + woodCotton + buildingCotton + roadCotton;
        if (yieldCotton < 0)
        {
            yieldCotton = 0;
        }
        yieldFur = baseFur + woodFur + buildingFur + roadFur;
        if (yieldFur < 0)
        {
            yieldFur = 0;
        }
        yieldOre = baseOre + woodOre + buildingOre + roadOre;
        if (yieldOre < 0)
        {
            yieldOre = 0;
        }
    }

    void calcBase(){
        switch (landType){
            case 0: //plains
                baseLumber = 0;
                baseFood = 3;
                baseCotton = 3;
                baseFur = 0;
                baseOre = 0;
                break;
            case 1: //tundra
                baseLumber = 0;
                baseFood = 2;
                baseCotton = 0;
                baseFur = 2;
                baseOre = 0;
                break;
            case 2: //desert
                baseLumber = 0;
                baseFood = 0;
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
                 woodLumber = 0;
                 woodFood = 0;
                 woodCotton = 0;
                 woodFur = 0;
                 woodOre = 0;
                break;
            case 1: //lightly wooded
                woodLumber = 2;
                woodFood = -1;
                woodCotton = -1;
                woodFur = 2;
                woodOre = 0;
                break;
            case 2: // forested
                woodLumber = 6;
                woodFood = -2;
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
                buildingLumber = 0;
                buildingFood = 0;
                buildingCotton = 0;
                buildingFur = 0;
                buildingOre = 0;
                break;
            case 1: //farm
                buildingLumber = 0;
                buildingFood = 1;
                buildingCotton = 1;
                buildingFur = 0;
                buildingOre = 0;
                break;
            case 2: //lodge
                buildingLumber = 1;
                buildingFood = 0;
                buildingCotton = 0;
                buildingFur = 1;
                buildingOre = 0;
                break;
            case 3: //mine
                buildingLumber = 0;
                buildingFood = 0;
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
                roadLumber = 0;
                roadFood = 0;
                roadCotton = 0;
                roadFur = 0;
                roadOre = 0;
                break;
            case 1: //has Road
                roadLumber = 1;
                roadFood = 0;
                roadCotton = 1;
                roadFur = 1;
                roadOre = 1;
                break;
        }
    }
}
