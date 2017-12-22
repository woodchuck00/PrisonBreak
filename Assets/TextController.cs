using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell,mirror,sheets_0,sheets_1,lock_0,lock_1,cell_mirror,freedom};
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);

        if (myState == States.cell) {
            state_cell();
        } else if(myState == States.sheets_0) {
            state_sheets_0();
        } else if (myState == States.mirror) {
            state_mirror();
        } else if (myState == States.lock_0) {
            state_lock_0();
        } else if (myState == States.sheets_1) {
            state_sheets_1();
        } else if (myState == States.cell_mirror) {
            state_cell_mirror();
        } else if (myState == States.lock_1) {
            state_lock_1();
        } else if (myState == States.freedom) {
            state_freedom();
        }
    }

    void state_cell() {
        text.text = "The story doesn’t matter in a way. We will be using the example of a very simple prison escape scene. " +
                "The important thing is that the user knows at every stage what keys they can press, and that the computer responds " +
                "appropriately to those key presses until the game is over. At the end of the game the text will simply state this, and " +
                "invite the player to play again.\n\n" +
                "Press S to view Sheets, M to view mirror, and L to view lock";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.sheets_0;
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            myState = States.mirror;
        }
        if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.lock_0;
        }
    }
    void state_sheets_0() {
        text.text = "Something about sheets\n\n" +
                "Press R to return to cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }
    void state_sheets_1() {
        text.text = "Something about sheets\n\n" +
                "Press R to return to cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell_mirror;
        }
    }
    void state_mirror() {
        text.text = "Something about mirror\n\n" +
                "Press R to return to cell, T to take the mirror";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
        if (Input.GetKeyDown(KeyCode.T)) {
            myState = States.cell_mirror;
        }
    }
    void state_cell_mirror() {
        text.text = "Something about mirror\n\n" +
                "Press S to see sheets, L to look at lock, R to return";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.mirror;
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.sheets_1;
        }
        if(Input.GetKeyDown(KeyCode.L)) {
            myState = States.lock_1;
        }
    }
    void state_lock_0() {
        text.text = "Something about lock\n\n" +
                "Press R to return to cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }
    void state_lock_1() {
        text.text = "Something about lock\n\n" +
                "Press R to return to cell, O to open the lock";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell_mirror;
        }
        if (Input.GetKeyDown(KeyCode.O)) {
            myState = States.freedom;
        }
    }
    void state_freedom() {
        text.text = "you are now free\n\n" +
                "Press R to restart";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }

}
