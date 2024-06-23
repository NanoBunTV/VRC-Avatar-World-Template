using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Lets you position the VRCCam for a good preview image before pressing "Publish"
[ExecuteInEditMode]
public class AutoVRCCam : MonoBehaviour
{
	Camera vrcCam, templateCam;
	Image previewCutoffImage;

	void Start() {
		templateCam = GetComponent<Camera>();
		if (previewCutoffImage == null) {
			previewCutoffImage = GetComponentInChildren<UnityEngine.UI.Image>();
		}
	}

    void Update()
    {
        if (vrcCam == null) {
			GameObject existingCam = GameObject.Find("VRCCam");
			if (existingCam != null) {
				vrcCam = existingCam.GetComponent<Camera>();
			}
		} else if (templateCam) {
			vrcCam.orthographic = templateCam.orthographic;
			vrcCam.orthographicSize = templateCam.orthographicSize;
			vrcCam.fieldOfView = templateCam.fieldOfView;
			vrcCam.nearClipPlane = templateCam.nearClipPlane;
			vrcCam.farClipPlane = templateCam.farClipPlane;
			vrcCam.clearFlags = templateCam.clearFlags;
			vrcCam.backgroundColor = templateCam.backgroundColor;
			vrcCam.cullingMask = templateCam.cullingMask;
			vrcCam.transform.position = templateCam.transform.position;
			vrcCam.transform.rotation = templateCam.transform.rotation;
		}

		previewCutoffImage.enabled = vrcCam == null;
		transform.localScale = Vector3.one;
    }
}
