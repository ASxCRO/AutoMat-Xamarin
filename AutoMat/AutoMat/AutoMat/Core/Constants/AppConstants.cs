﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMat.Core.Constants
{
    public class AppConstants
    {
		public static string AppName = "AutoMat";
		public static string WebAPIkey = "AIzaSyAg4riVkvSMtWwKZ6_UssK28-2K6xOndrg";

		// OAuth
		// For Google login, configure at https://console.developers.google.com/
		public static string AndroidClientId = "915728342891-8mfpa7hmqhtfeugs61d6e9t1jhi4pt6m.apps.googleusercontent.com";
		public static string AndroidReverseClientId = "com.googleusercontent.apps.915728342891-8mfpa7hmqhtfeugs61d6e9t1jhi4pt6m";



		// These values do not need changing
		public static string Scope { get; } = "https://www.googleapis.com/auth/userinfo.email";
		public static string AuthorizeUrl { get; } = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl { get; } = "https://www.googleapis.com/oauth2/v4/token";
		public static string UserInfoUrl { get; } = "https://www.googleapis.com/oauth2/v2/userinfo";

		// Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
		public static string AndroidRedirectUrl = "com.googleusercontent.apps.915728342891-8mfpa7hmqhtfeugs61d6e9t1jhi4pt6m:/oauth2redirect";

		//realtime database
		public static string FirebaseDatabaseURL { get; } = "https://automat-29cec.firebaseio.com/";

		public static string FirebaseStorageURL { get; } = "automat-29cec.appspot.com";



	}
}

