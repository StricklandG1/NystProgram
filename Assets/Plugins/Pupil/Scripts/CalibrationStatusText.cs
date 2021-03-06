using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace PupilLabs
{
    [RequireComponent(typeof(CalibrationController))]
    public class CalibrationStatusText : MonoBehaviour
    {
        public SubscriptionsController subsCtrl;
        public Text statusText;

        private CalibrationController calibrationController;

        void Awake()
        {
            SetStatusText("Not connected");
            calibrationController = GetComponent<CalibrationController>();
        }

        void OnEnable()
        {
            subsCtrl.requestCtrl.OnConnected += OnConnected;
            calibrationController.OnCalibrationStarted += OnCalibrationStarted;
            calibrationController.OnCalibrationRoutineDone += OnCalibrationRoutineDone;
            calibrationController.OnCalibrationSucceeded += CalibrationSucceeded;
            calibrationController.OnCalibrationFailed += CalibrationFailed;
        }

        void OnDisable()
        {
            subsCtrl.requestCtrl.OnConnected -= OnConnected;
            calibrationController.OnCalibrationStarted -= OnCalibrationStarted;
            calibrationController.OnCalibrationRoutineDone -= OnCalibrationRoutineDone;
            calibrationController.OnCalibrationSucceeded -= CalibrationSucceeded;
            calibrationController.OnCalibrationFailed -= CalibrationFailed;
        }

        private void OnConnected()
        {
            string text = "";
            //text += "\n\nPlease warm up your eyes and press 'C' to start the calibration or 'P' to preview the calibration targets.";
            SetStatusText(text);
        }

        private void OnCalibrationStarted()
        {
            statusText.enabled = false;
        }

        private void OnCalibrationRoutineDone()
        {
            statusText.enabled = true;
            SetStatusText("Calibration routine is done. Waiting for results ...");
        }

        private void CalibrationSucceeded()
        {
            statusText.enabled = true;
            SetStatusText("Calibration succeeded.");

            StartCoroutine(DisableTextAfter(1));
        }

        private void CalibrationFailed()
        {
            statusText.enabled = true;
            SetStatusText("Calibration failed.");

            StartCoroutine(DisableTextAfter(1));
        }

        private void SetStatusText(string text)
        {
            if (statusText != null)
            {
                statusText.text = text;
            }
        }

        IEnumerator DisableTextAfter(float delay)
        {
            yield return new WaitForSeconds(delay);
            statusText.enabled = false;
        }
    }
}
