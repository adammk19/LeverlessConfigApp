using Newtonsoft.Json;
using Rapid_Trigger_Config.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapid_Trigger_Config
{
    internal class Settings
    {
        #region RT Descriptions
        public const string WhatIsRapidTrigger = "Rapid Trigger changes the actuation point dynamically with key press and release motions.";
        public const string RapidTriggerDescription = "Rapid Trigger is active once a key passes its actuation point.";
        public const string ContinuousRapidTriggerDescription = "Continuous Rapid Trigger is active once a key passes its actuation point and remains active until the key is fully released.";
        public static List<string> RTModes = new List<string> { "On", "Continuous", "Off" };
        #endregion

        #region Device Settings
        public const int MinActuationPoint = 25;
        public const int MaxActuationPoint = 1000;
        public const int SlidertStep = 25;
        public const int MinRTSensitivity = 25;
        public const int MaxRTSensitivity = 575;
        public const int BaudRate = 115200;
        #endregion

        #region Button Colours
        public const string ButtonPressedColour = "#a8b4f7";
        public const string ButtonUnpressedColour = "#FFFFFF";
        public static Color ButtonPressed = ColorTranslator.FromHtml(ButtonPressedColour);
        public static Color ButtonUnpressed = ColorTranslator.FromHtml(ButtonUnpressedColour);
        #endregion

        #region Serial Commands
        public const string cmdGetConfig = "getConfig"; // Get device configuration
        public const string cmdEnableRT = "enableRT"; // Enable RT
        public const string cmdEnableCRT = "enableCRT"; // Enable CRT
        public const string cmdDisableRT = "disableRT"; // Disable RT
        public const string cmdCalibrate = "calibrate"; // Trigger calibration
        public const string cmdSave = "save"; // Save settings
        public const string cmdLoad = "load"; // Load settings
        public const string cmdReset = "default"; // Reset settings
        // require parameters
        public const string cmdSetConfig = "setConfig"; // Set device configuration
        public const string cmdSetRTSens = "setSens"; // Set RT sensitivity
        public const string cmdGetRTSens = "getSens"; // Get RT sensitivity
        public const string cmdSetActuationPoint = "setAP"; // Set actuation point
        public const string cmdGetActuationPoint = "getAP"; // Get actuation point
        #endregion

        #region Global variables
        public static List<int> SelectedButtons = new List<int>();
        public static string ConfigString;
        public static string[] ConfigArray = new string[15]; // [0] = RT, [1] = CRT, [2] = Sens, [3-14] = AP1-AP12
        public static bool IsDeviceConnected = false;
        public static bool InitialLoad = false;
        public static string COMPort;
        #endregion
    }
}