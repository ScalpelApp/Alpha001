using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TrackedObjectsManager : MonoBehaviour {

    private StateManager sm;

    public Text scalpelText;
    
	// Use this for initialization
	void Start () {
        
        //scalpelToggle.isOn = false;

        //scalpelToggle.Text = "Not Tracked";

        //scalpelEventHandler = scalpelImage.GetComponent<customEventHandler>().IsTrackedBool;

        sm = TrackerManager.Instance.GetStateManager();
    }
	
	// Update is called once per frame
	void Update ()
    {
        IList<TrackableBehaviour> activeTrackables = (IList<TrackableBehaviour>)sm.GetActiveTrackableBehaviours();

        foreach (TrackableBehaviour tb in activeTrackables)
        {
            // As you iterate, you compare with current game object name
            // if you have 3 and 5 and target object is 5 then you get a match.
            //scalpelToggle.Text = tb.TrackableName;

            scalpelText.text = tb.TrackableName;
        }

        //if (GameObject.Find("ScalpelImageTarget").GetComponent<customEventHandler>().isTracked)
        //{
        //    print("***** IS TRACKED *****");

        //    scalpelToggle.isOn = true;
        //}
    }
}
