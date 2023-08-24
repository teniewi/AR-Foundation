using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public GameObject Bebaling,KincirBel, Plane;
    [SerializeField] BalingBaling baling;
    [SerializeField] KincirBelakang kincir;

    Animator animator;


    void Awake()
    {
        baling = Bebaling.GetComponent<BalingBaling>();
        kincir = KincirBel.GetComponent<KincirBelakang>();
        animator = Plane.GetComponent<Animator>();

        baling.enabled = false;
        kincir.enabled = false;
    }
    public void Anim()
    {
        animator.Play("Play",  -1, 0f);
        baling.enabled = true;
        kincir.enabled = true;
    }

    public void BackScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
