using UnityEngine;



/// <summary>
/// Manage's battle state. Handles player and enemy turns, health, win/loss conditions.
/// </summary>
public class BattleManager : MonoBehaviour
{
    private BattleState currentState;


    [Header("Health Settings")]
    [SerializeField]
    private float playerMaxHealth = 100f;

    [SerializeField]
    private float playerHealth = 100f;

    [SerializeField]
    private float enemyMaxHealth = 100f;

    [SerializeField]
    private float enemyHealth = 100f;

    [Header("Mana Settings")]
    [SerializeField]
    private float playerMaxMana = 50f;
    [SerializeField]
    private float playerMana = 50f;
    [SerializeField]
    private float enemyMaxMana = 50f;
    [SerializeField]
    private float enemyMana = 50f;

    [Header("Cheer Settings")]
    private float minCheer; //fetch from ProgressManager

    [SerializeField]
    private float playerCheerAmount = 10f;

    [SerializeField]
    private float enemyCheerAmount = 10f;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    private void ManageStartState()
    {

    }

    private void ManagePlayerTurn()
    {

    }

    private void ManageEnemyTurn()
    {

    }

    private void ManagePauseState()
    {


    }

    private void ManageEndState()
    {

    }

    void CheckWinLossConditions()
    {

    }


}
