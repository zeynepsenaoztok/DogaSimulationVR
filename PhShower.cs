using UnityEngine;
using UnityEngine.UI;


public class PhShower : MonoBehaviour
{


    public ChemicalMixer chemicalMixer;

    public enum Mixing
    {
        AnB, CnD, EnF
    }

    [SerializeField]
    Mixing mixingType;


    // Start is called before the first frame update
    void Start()
    {

        //transform.GetChild(1).gameObject.GetComponent<TextMesh>().text = mixingType.ToString().Split("n")[0];
        //transform.GetChild(2).gameObject.GetComponent<TextMesh>().text = mixingType.ToString().Split("n")[1];

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(chemicalMixer.firstParticleList.Count);
        if (chemicalMixer.firstParticleList.Count + chemicalMixer.secondParticleList.Count == 0)
        {
            gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = "-";
        }
        else
        {
            //    gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = (chemicalMixer.firstParticleList.Count / (chemicalMixer.firstParticleList.Count + chemicalMixer.secondParticleList.Count)).ToString();

            float pha = -(Mathf.Log((0.5f), 10));
            float phb = (14 + (Mathf.Log((0.5f), 10)));
            float ph1 = ((chemicalMixer.firstParticleList.Count * (pha)) + (chemicalMixer.secondParticleList.Count * (phb))) / (chemicalMixer.firstParticleList.Count + chemicalMixer.secondParticleList.Count);

            Debug.Log("Sivinin ph i: " + ph1);
            Debug.Log("First List: " + chemicalMixer.firstParticleList.Count);
            Debug.Log("Second List: " + chemicalMixer.secondParticleList.Count);
            gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = ph1.ToString();


        }
    }
}