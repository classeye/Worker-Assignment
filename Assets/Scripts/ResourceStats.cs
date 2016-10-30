using UnityEngine;
using System.Collections;

public class ResourceStats : MonoBehaviour {

    //raw resources
    public int food;
    public int lumber;
    public int cotton;
    public int fur;
    public int ore;

    // processed goods

	void Start () {
        food = 0;
        lumber = 0;
        cotton = 0;
        fur = 0;
        ore = 0;
	}
}
