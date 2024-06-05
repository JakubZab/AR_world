using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public enum TurnState { Move, Action, End }

public class TurnManager : MonoBehaviour
{
    public static TurnManager instance;

    public TurnState turnState;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        turnState = TurnState.Move;
    }

    public void EndTurn()
    {
        switch (turnState)
        {
            case TurnState.Move:
                turnState = TurnState.Action;
                break;
            case TurnState.Action:
                turnState = TurnState.End;
                break;
            case TurnState.End:
                NextTurn();
                break;
        }
    }

    void NextTurn()
    {
        // Tutaj dodaj kod do restartowania zdrowia wiedŸmina i prze³¹czania siê miêdzy NPC
    }


}
