﻿using UnityEngine;
using System.Collections;

public class Car : Part {
	
	/// <summary>
	/// The speed of the robot
	/// </summary>
	private float mSpeed;

	/// <summary>
	/// The jump strengtj pf the robot
	/// </summary>
	private float mJumpForce = 5f;

	// Use this for initialization
	protected void Start () {
		this.mPart = PART.CAR;
	}
	
	// Update is called once per frame
	protected void Update () {
		
	}
	
	public float GetSpeed(){
		return this.mSpeed;
	}
	
	public float GetJumpPower(){
		return this.mJumpForce;
	}
	
	public void SetSpeed(float speed){
		this.mSpeed = speed/this.mRobot.GetRobotMass();
		
	}

	public void SetJumpStrength(float strength){
		this.mJumpForce = strength/this.mRobot.GetRobotMass();
	}
}
