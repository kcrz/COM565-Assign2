﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioengineeringResearch.DataOperations
{
    /// <summary>
    /// Dedicated class for handling strings
    /// Author: Kenneth Cruz
    /// 30 Apr 2015
    /// </summary>
    class DataStrings
    {
        public const String EMPLOYEE_TAG = "EM";
        public const String VISITOR_TAG = "VT";

        public const String DATA_DIRECTORY = "DataDirectory";

        public const String EMPTY_STRING = "";
        public const String NEWLINE = "\n";
        public const String HYPHEN = "-";

        public const String USER_STATUS = "User Status: ";

        public const String ADMIN_USER = "Admin";
        public const String RECEPTIONIST_USER = "Receptionist";
        public const String NORMAL_USER = "Employee";
        public const String NOT_LOGGED_IN = "Not logged in";

        public const String WELCOME_MSG = "Welcome to Bioengineering Research Ltd.";
        public const String LOGOUT_MSG = "Do you want to log out?";

        public const String WELCOME = "Welcome";
        public const String ALERT = "Alert";
        public const String INFORMATION = "Information";
        public const String YOUR_NEW_ID = "Your new ID is: ";
        public const String INVALID_ID = "Invalid ID";
        public const String INVALID_ID_PIN = "Invalid ID or PIN";
        public const String INVALID_LOGIN_CREDENTIAL = "Invalid ID and password";
        public const String VISITORS_NO_LOGIN = "Sorry. Visitors are not allowed to log in";
        public const String UNAUTHORISED_ACCESS = "Unauthorised access attempted.";
        public const String ACCESS_DENIED = "Access Denied.";
        public const String SEARCH_RESULT = "Search Result";
        public const String SELECT_UPDATE_ITEM = "Select a user to update";
        public const String UPDATE_SUCCESSFUL = "Update successful";

        public const String LOGIN_OK = "Login Successful";

        public const String NO_PERSON_FOUND = "No Person found";
        public const String NO_VISITORS_FOUND = "No visistors found";
        public const String NO_EMPLOYEES_FOUND = "No employees found";
        public const String NO_ITEM_FOUND = "No item found";
        public const String NO_ITEM_TO_EXPORT = "No item to export";

        public const String FAILED_TO_ADD_EMPLOYEE = "Failed to add Employee. Check if all fields are valid";
        public const String FAILED_TO_ADD_VISITOR = "Failed to add Visitor. Check if all fields are valid";
        public const String FAILED_TO_UPDATE_INFO = "Failed to update database. Please contact administrators";

        public const String SELECT_ITEM_DELETION = "Select an item to be deleted";
        public const String SELECT_HISTORY_SEARCH_OPTION = "Please Select a Search Option";
        public const String PIN_DOES_NOT_MATCH = "PIN does not match";
        
        public const String ADD_UPDATE_FORM_FIELD_CHECK = "Please populate all fields and select a date in the future";
        public const String ADD_FORM_ADMIN_STATUS = ADMIN_USER + " - " + "Add New Person";
        public const String ADD_FORM_RECEPTIONIST_STATUS = RECEPTIONIST_USER + " - " + "Add New Person";

        public const String DOOR_OPEN_NOTICE = " Door is now open. Closing in 10 seconds.";
        public const String DOOR_MULTIPLE_INVALID_ATTEMPT = "Multiple failed attempts detected. \nContacting security personnel.";

        public const String CONTACTING_POLICE = "Contacting Police";

        public const String FIRE_SIMULATOR = "FIRE Simulator";
        public const String FIRE_SELECT_LOCATION = "Select location to begin fire simulation";
        public const String WARNING = "WARNING: ";
        public const String IS_ON_FIRE = " is on FIRE!!!";
        public const String FIRE_GEN_ADMIN = "Deactivate door lock: F1, A1, A2, A3, B1";
        public const String FIRE_RESEARCH_SUPP = "Deactivate door lock: F2, B2, B3";
        public const String FIRE_CORRIDOR_A = "Deactivate door lock: F1, F3, F4, A1 - A8, B1";
        public const String FIRE_CORRIDOR_B = "Deactivate door lock: F3, F4";
        public const String FIRE_CORRIDOR_C = "Deactivate door lock: F3 - F6, C1 - C8";
        public const String FIRE_SRA_1 = "Deactivate door lock: F3 - F6, C1, C2, C8";
        public const String FIRE_SRA_2 = "Deactivate door lock: F3 - F6, C1, C7, C8";
        public const String FIRE_SRA_3 = "Deactivate door lock: F3 - F6, C1, C3, C8";
        public const String FIRE_SRA_4 = "Deactivate door lock: F3 - F6, C1, C4, C8";
        public const String FIRE_SRA_5 = "Deactivate door lock: F3 - F6, C1, C5, C8";
        public const String FIRE_SRA_6 = "Deactivate door lock: F3 - F6, C1, C6, C8";

        public const String DOOR = "Door ";
        public const String SELECT_CARD_READER_SIMUL = "Please select a cardreader location for simulation";
        public const String CARD_READER_FAILURE = " Card Reader failure. Notifying Reception and Maintenance";
        public const String CARD_READER_SIM_ID = "reader_failure_sim";
        public const String DOOR_INTRUDER_SIM = "door_intruder_sim";

        public const String INTRUDER_SELECT_LOCATION = "Please select a location for simulation";
        public const String INTRUDER_DETECTED = " has detected an Intruder. Notifying security personnel.";

        public const String EXPORT_TITLE = "Choose location to save to";
        public const String EXPORT_HISTORY_FILENAME = "AccessHistory.csv";
        public const String EXPORT_PEOPLE_FILENAME = "PeopleData.csv";
        public const String EXPORT__FILTER = "CSV (*.csv)|*.csv";

    }
}
