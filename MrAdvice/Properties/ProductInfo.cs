#region Mr. Advice
// Mr. Advice
// A simple post build weaving package
// http://mradvice.arxone.com/
// Released under MIT license http://opensource.org/licenses/mit-license.php
#endregion

using System.Reflection;

using ArxOne.MrAdvice.Properties;

[assembly: AssemblyVersion("2")]
[assembly: AssemblyFileVersion(Product.Version)]

namespace ArxOne.MrAdvice.Properties
{
	/// <summary>
	/// Informations about product
	/// </summary>
	public static class Product
	{
		/// <summary>
		/// The version
		/// </summary>
		public const string Version = "2.8.5";
	}
}