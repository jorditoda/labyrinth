using UnityEngine;
using System.Collections;

public class Torchelight : MonoBehaviour {
	
	public GameObject TorchLight;
	public GameObject MainFlame;
	public GameObject BaseFlame;
	public GameObject Etincelles;
	public GameObject Fumee;
	public float MaxLightIntensity;
	public float IntensityLight;
	

	void Start () {
		TorchLight.GetComponent<Light>().intensity= IntensityLight;
		MainFlame.GetComponent<ParticleSystem>().emissionRate=IntensityLight*40f;
		BaseFlame.GetComponent<ParticleSystem>().emissionRate=IntensityLight*30f;	
		Etincelles.GetComponent<ParticleSystem>().emissionRate=IntensityLight*14f;
		Fumee.GetComponent<ParticleSystem>().emissionRate=IntensityLight*24f;
	}
	

	void Update () {
		if (IntensityLight<0) IntensityLight=0;
		if (IntensityLight>MaxLightIntensity) IntensityLight=MaxLightIntensity;		

		TorchLight.GetComponent<Light>().intensity=IntensityLight/2f+Mathf.Lerp(IntensityLight-0.1f,IntensityLight+0.1f,Mathf.Cos(Time.time*30));

		TorchLight.GetComponent<Light>().color=new Color(Mathf.Min(IntensityLight/1.5f,0.6888235f),Mathf.Min(IntensityLight/2f,0.513725f),0.098039f);
        MainFlame.GetComponent<ParticleSystem>().emissionRate = IntensityLight * 40f;
        BaseFlame.GetComponent<ParticleSystem>().emissionRate = IntensityLight * 30f;
        Etincelles.GetComponent<ParticleSystem>().emissionRate = IntensityLight * 14f;
        Fumee.GetComponent<ParticleSystem>().emissionRate = IntensityLight * 24f;

    }
}