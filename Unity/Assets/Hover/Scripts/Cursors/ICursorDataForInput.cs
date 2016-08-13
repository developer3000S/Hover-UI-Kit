﻿using UnityEngine;

namespace Hover.Cursors {

	/*================================================================================================*/
	public interface ICursorDataForInput : ICursorData {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		void SetIsRaycast(bool pIsRaycast);

		/*--------------------------------------------------------------------------------------------*/
		void SetRaycastLocalDirection(Vector3 pRaycastLocalDirection);

		/*--------------------------------------------------------------------------------------------*/
		void SetCapability(CursorCapabilityType pCapability);
		
		/*--------------------------------------------------------------------------------------------*/
		void SetSize(float pSize);

		/*--------------------------------------------------------------------------------------------*/
		void SetTriggerStrength(float pTriggerStrength);

		/*--------------------------------------------------------------------------------------------*/
		void SetWorldPosition(Vector3 pWorldPosition);

		/*--------------------------------------------------------------------------------------------*/
		void SetWorldRotation(Quaternion pWorldRotation);

		/*--------------------------------------------------------------------------------------------*/
		void SetIdle(ICursorIdle pIdle);


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		void SetUsedByInput(bool pIsUsed);

		/*--------------------------------------------------------------------------------------------*/
		void ActivateIfUsedByInput();

	}

}