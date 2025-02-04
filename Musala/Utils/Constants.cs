﻿namespace Musala.Utils
{
    public class Constants
    {
        public const float weightLimitMin = 0;
        public const float weightLimitMax = 500;
        public const float batteryLevelMin = 0;
        public const float batteryLevelMax = 100;
        public const int maxCharacterLength = 100;
        public const float criticBatteryLevel = 25;
        public const float droneLoadingBatteryCost = 15;
        // regex
        public const string regexOnlyLettersNumbersAndDashes = "^[a-zA-Z0-9\\_-]+$";
        public const string regexOnlyLettersNumbersAndDashesErr = "Allowing to entry only letters, numbers and dashes.";
        public const string regexOnlyUpperCasesUnderScoreAndNumbers = "^[A-Z0-9\\_]+$";
        public const string regexOnlyUpperCasesUnderScoreAndNumbersErr = "Allowing only upper cases, under scores and numbers.";

        // table names
        public const string drone = "Drone";
        public const string medication = "Medication";
        public const string droneLoad = "DroneLoad";

        // drone error messages
        public const string droneWeightError = "Weight (gr) range for drone is: 0-500 gr.";

        // drone weight limit
        public const float lightWeight = 200;
        public const float middleWeight = 300;
        public const float cruiserWeight = 400;
        public const float heavyWeight = 500;

        // error messages
    }
}
