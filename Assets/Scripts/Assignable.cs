using UnityEngine;
using System.Collections;

public class Assignable : MonoBehaviour {

	int moveMode; //
	Transform lastPar;

	void start()
	{
		moveMode = 0;
		lastPar = null;
	}

	void update(){
		if (moveMode == 1) {
			move ();
		}
	}
		
	void assign(Transform tarPar){
		moveMode = 0;
		this.gameObject.transform.SetParent (tarPar);
	}

	void unassign(){
		lastPar = this.gameObject.transform.parent;
		///parent becomes foreground element
	}


	void startMove(){
		
	}

	void move(){
	}

	void endMove(Transform tarPar)
	{
		this.transform.SetParent (tarPar);
	}
}


