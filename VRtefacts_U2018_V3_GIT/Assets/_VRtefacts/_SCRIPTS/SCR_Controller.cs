using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_Controller : MonoBehaviour
{

    public Text text_selected_object;

    public GameObject eagle;
    public GameObject eagleRoot;
    public GameObject boar;
    public GameObject boarRoot;
    public GameObject textile;
    public GameObject textileRoot;
    public GameObject wildcard;
    public GameObject wild_pipe;
    public GameObject wild_mask;
    public GameObject wild_toolbox;

    public GameObject light1;
    public GameObject light2;

    public float diss = 1;

    // Start is called before the first frame update
    void Start()
    {
        eagle.transform.localScale = new Vector3(0, 0, 0);
        boar.transform.localScale = new Vector3(0, 0, 0);
        textile.transform.localScale = new Vector3(0, 0, 0);
        wildcard.transform.localScale = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("l")) {
            light1.SetActive(false);
            light2.SetActive(false);
        }

        if (Input.GetKeyDown("o")) {
            light1.SetActive(true);
            light2.SetActive(true);
        }

        if (Input.GetKeyDown("space") || Input.GetKeyDown("0") || Input.GetKeyDown("[0]") )
        {
            print("space key was pressed");
            text_selected_object.text = "0";
            eagle.transform.localScale = new Vector3(0, 0, 0);
            boar.transform.localScale = new Vector3(0, 0, 0);
            textile.transform.localScale = new Vector3(0, 0, 0);
            wildcard.transform.localScale = new Vector3(0, 0, 0);
        } 
         if (Input.GetKey("1") || Input.GetKey("[1]") ) {
            print("1 key was pressed");
            text_selected_object.text = "1";

            eagle.transform.localScale = new Vector3(0, 0, 0);
            boar.transform.localScale = new Vector3(0, 0, 0);
            textile.transform.localScale = new Vector3(0, 0, 0);
            wildcard.transform.localScale = new Vector3(0, 0, 0);

            eagle.transform.localScale = new Vector3(1, 1, 1);

            Renderer[] eagleRenderers =  eagleRoot.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in eagleRenderers) {
                    Material mat = renderer.GetComponentInChildren<Renderer>().material;
                    diss = diss - Time.deltaTime * 0.5f;            
                    mat.SetFloat("_DissolveAmount", diss);
            }

            
        } 
         if (Input.GetKey("2") || Input.GetKey("[2]") ) {
            print("2 key was pressed");
            text_selected_object.text = "2";

            eagle.transform.localScale = new Vector3(0, 0, 0);
            boar.transform.localScale = new Vector3(0, 0, 0);
            textile.transform.localScale = new Vector3(0, 0, 0);
            wildcard.transform.localScale = new Vector3(0, 0, 0);

            boar.transform.localScale = new Vector3(1, 1, 1);

            Material mat = boarRoot.GetComponentInChildren<Renderer>().material;
            diss = diss - Time.deltaTime;            
            mat.SetFloat("_DissolveAmount", diss);
        } 
         if (Input.GetKey("3") || Input.GetKey("[3]") ) {
            print("3 key was pressed");
            text_selected_object.text = "3";

            eagle.transform.localScale = new Vector3(0, 0, 0);
            boar.transform.localScale = new Vector3(0, 0, 0);
            textile.transform.localScale = new Vector3(0, 0, 0);
            wildcard.transform.localScale = new Vector3(0, 0, 0);

            textile.transform.localScale = new Vector3(1, 1, 1);

            Material mat = textileRoot.GetComponentInChildren<Renderer>().material;
            diss = diss - Time.deltaTime;            
            mat.SetFloat("_DissolveAmount", diss);
        } 
         if (Input.GetKey("4") || Input.GetKey("[4]") ) {
            print("4 key was pressed");
            text_selected_object.text = "4";

            

            eagle.transform.localScale = new Vector3(0, 0, 0);
            boar.transform.localScale = new Vector3(0, 0, 0);
            textile.transform.localScale = new Vector3(0, 0, 0);
            wildcard.transform.localScale = new Vector3(0, 0, 0);

            wild_pipe.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            wild_mask.transform.localScale = new Vector3(0, 0, 0);
            wild_toolbox.transform.localScale = new Vector3(0, 0, 0);

            wildcard.transform.localScale = new Vector3(1, 1, 1);

            //Animator anim = wild_pipe.GetComponentInChildren<Animator>();
            //anim.Play("anim_diss_pipe");
            //wild_pipe.GetComponentInChildren<Animator>().
            
            
            Material mat = wild_pipe.GetComponentInChildren<Renderer>().material;
            diss = diss - Time.deltaTime;            
            mat.SetFloat("_DissolveAmount", diss);
            
            //StartCoroutine(Fade(mat));
            
        } 
         if (Input.GetKey("5") || Input.GetKey("[5]") ) {
            print("5 key was pressed");
            text_selected_object.text = "5";

            eagle.transform.localScale = new Vector3(0, 0, 0);
            boar.transform.localScale = new Vector3(0, 0, 0);
            textile.transform.localScale = new Vector3(0, 0, 0);
            wildcard.transform.localScale = new Vector3(0, 0, 0);

            wild_pipe.transform.localScale = new Vector3(0, 0, 0);
            wild_mask.transform.localScale = new Vector3(0.65f, 0.65f, 0.65f);
            wild_toolbox.transform.localScale = new Vector3(0, 0, 0);

            wildcard.transform.localScale = new Vector3(1, 1, 1);

            Material mat = wild_mask.GetComponentInChildren<Renderer>().material;
            diss = diss - Time.deltaTime;            
            mat.SetFloat("_DissolveAmount", diss);
        } 
         if (Input.GetKey("6") || Input.GetKey("[6]") ) {
            print("6 key was pressed");
            text_selected_object.text = "6";

            eagle.transform.localScale = new Vector3(0, 0, 0);
            boar.transform.localScale = new Vector3(0, 0, 0);
            textile.transform.localScale = new Vector3(0, 0, 0);
            wildcard.transform.localScale = new Vector3(0, 0, 0);

            wild_pipe.transform.localScale = new Vector3(0, 0, 0);
            wild_mask.transform.localScale = new Vector3(0, 0, 0);
            wild_toolbox.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);

            wildcard.transform.localScale = new Vector3(1, 1, 1);

            Material mat = wild_toolbox.GetComponentInChildren<Renderer>().material;
            diss = diss - Time.deltaTime;            
            mat.SetFloat("_DissolveAmount", diss);
            
        }

        if (!Input.anyKey) {
            diss = 1;
        }
    }

    IEnumerator Fade(Material mat) 
    {        
            //mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time) / 2 + 0.5f);

            float elapsedTime = 0;
            float value = 1;
            float speed = 0.01f;

            while (elapsedTime < 1f) {

                elapsedTime = elapsedTime + Time.deltaTime * speed;
                value = Mathf.Lerp(1f,0f,elapsedTime);
                mat.SetFloat("_DissolveAmount", value);
                //Debug.Log("Elapsed time is " + elapsedTime + " The dissove is: " + value);

            }        


            
            yield return null;
        
    }
}
