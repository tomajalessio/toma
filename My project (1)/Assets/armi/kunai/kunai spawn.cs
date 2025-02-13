using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class kunaispawner : MonoBehaviour
{
    //asset del proiettile credo
    [SerializeField]
    private GameObject proiettile;
    // E' dove iniza a sparare credo
    [SerializeField]
    private Transform firePoint;
    //è l'azione per spare credo
    [SerializeField]
    private InputActionReference shootAction;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
       /* shootAction.action.WasPressedThisFrame-> non so cosa faccia
       */
        if(shootAction.action.WasPressedThisFrame()){
            Instantiate(proiettile, firePoint.position, firePoint.rotation);
        }
    }
}
