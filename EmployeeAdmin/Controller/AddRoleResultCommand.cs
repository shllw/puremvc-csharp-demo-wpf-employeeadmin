﻿/* 
	PureMVC CSharp / WPF / EmployeeAdmin Demo - Login
	By Andy Adamczak <andy.adamczak@puremvc.org>
	Copyright(c) 2009 Andy Adamczak, Some rights reserved.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Windows;

namespace Demo.PureMVC.EmployeeAdmin.Controller
{
	public class AddRoleResultCommand : SimpleCommand, ICommand
	{
		public override void Execute(INotification notification)
		{
			bool result = (bool) notification.Body;

			if (!result) {
				MessageBox.Show("Role already exists for this user!", "Add User Role");
			}
		}
	}
}
