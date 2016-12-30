﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DynamicListener : MonoBehaviour {

	public string mObjectListeningTag = "Enter Gameobject's tag";
	public bool thisIsListener = false;
	public bool mParameter = false;
	public string mSendMassage = "Enter GameObject's method name";
	public string mMessageParameter;
	protected Button b;
	protected GameObject mObjectListening;
	
	
	// Use this for initialization
	void Start () {
		this.b = this.GetComponent<Button>();
		this.GetObjectListening();
	}
	
	// Update is called once per frame
    void Update () {
		if(!this.mObjectListening)
			this.GetObjectListening();
	}
	
	void GetObjectListening () {
		if(this.thisIsListener)
			this.mObjectListening = this.gameObject;
		else
			this.mObjectListening = GameObject.FindGameObjectWithTag(this.mObjectListeningTag);
		
		if(this.mObjectListening)
			this.SetListener();
	}
	
	protected virtual void SetListener () {
		if(this.b){
			if(!this.mParameter)
				b.onClick.AddListener(() => this.mObjectListening.SendMessage(this.mSendMassage));
			else
				b.onClick.AddListener(() => this.mObjectListening.SendMessage(this.mSendMassage, this.mMessageParameter));
		}else{
			Debug.LogError("Dynamics listeners belongs to this button");	
		}	
	}
}
