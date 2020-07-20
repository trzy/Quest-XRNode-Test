using UnityEngine;
using UnityEngine.XR;

public class Test : MonoBehaviour
{
  // Update is called once per frame
  void Update()
  {
    InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.Head);

    if (!device.isValid)
    {
      Debug.Log("XR device is invalid");
    }

    if (device.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 devicePos))
    {
      Debug.LogFormat("DEVICE POS={0}", devicePos);
    }

    if (device.TryGetFeatureValue(CommonUsages.leftEyePosition, out Vector3 leftEyePos))
    {
      Debug.LogFormat("EYE POS={0}", leftEyePos);
    }
  }
}
  