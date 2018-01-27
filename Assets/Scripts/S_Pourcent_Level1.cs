using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class S_PrctMap1 : MonoBehaviour {

	private float TotalConta;
	private float TotalaConta = 25;
	public static float pourcentageMap1;
	public Text pourcentage;


	private static S_PrctMap1 instance ;
    public static S_PrctMap1 Instance () 
    {
        return instance;
    }
		void Awake ()
    {
        if (instance != null)
        {
            Destroy (gameObject);
        }
        else 
        {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		CalculPrct();
		AffichagePrct ();
		
	}

	public void CalculPrct ()
	{
		TotalConta = GameObject.FindGameObjectsWithTag("mort").Length;
		pourcentageMap1 = TotalConta * 100 / TotalaConta;
	}

	void AffichagePrct ()
	{
		pourcentage.text = pourcentageMap1.ToString();
	}
}
