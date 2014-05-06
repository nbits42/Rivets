﻿using System;
using System.Threading.Tasks;

namespace Rivets
{
	public interface IAppLinkNavigation
	{

		Task<NavigationResult> Navigate(AppLink appLink);

		Task<NavigationResult> Navigate(Uri url);

		Task<NavigationResult> Navigate(string url);

		Task<NavigationResult> Navigate(AppLink appLink, RefererAppLink refererAppLink);

		Task<NavigationResult> Navigate(Uri url, RefererAppLink refererAppLink);

		Task<NavigationResult> Navigate(string url, RefererAppLink refererAppLink);

		Task<NavigationResult> Navigate(AppLink appLink, AppLinkData appLinkData);

		Task<NavigationResult> Navigate(Uri url, AppLinkData appLinkData);

		Task<NavigationResult> Navigate(string url, AppLinkData appLinkData);

		Task<NavigationResult> Navigate(AppLink appLink, AppLinkData appLinkData, RefererAppLink refererAppLink);

		Task<NavigationResult> Navigate(Uri url, AppLinkData appLinkData, RefererAppLink refererAppLink);

		Task<NavigationResult> Navigate(string url, AppLinkData appLinkData, RefererAppLink refererAppLink);
	}
}

