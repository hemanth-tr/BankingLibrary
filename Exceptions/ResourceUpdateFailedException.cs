﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary.Exceptions
{
	/// <summary>
	/// Exception thrown when resource is not created.
	/// </summary>
	public class ResourceUpdateFailedException : Exception
	{
		/// <summary>
		/// Instantiates <see cref="ResourceUpdateFailedException"/>
		/// </summary>
		/// <param name="errorMessage"></param>
		public ResourceUpdateFailedException(string errorMessage) : base(errorMessage)
		{
			ErrorMessage = errorMessage;
		}

		/// <summary>
		/// Gets or sets the error message for an exception.
		/// </summary>
		public string ErrorMessage { get; }
	}
}
