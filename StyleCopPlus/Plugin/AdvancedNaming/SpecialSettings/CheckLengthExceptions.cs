using System;

namespace StyleCopPlus.Plugin.AdvancedNaming
{
	/// <summary>
	/// Specified exceptions for checking name length.
	/// </summary>
	public class CheckLengthExceptions : SimpleSpecialSetting
	{
		/// <summary>
		/// Gets help text for current setting.
		/// </summary>
		public override string HelpText
		{
			get { return SpecialSettingResources.CheckLengthExceptionsHelp; }
		}

		/// <summary>
		/// Gets warning text for invalid definition string.
		/// </summary>
		public override string WarningText
		{
			get { return SpecialSettingResources.CheckLengthExceptionsWarning; }
		}

		/// <summary>
		/// Checks if specified character is valid.
		/// </summary>
		public override bool IsValidChar(char c)
		{
			if (Char.IsWhiteSpace(c))
				return true;

			if (Char.IsLetterOrDigit(c))
				return true;

			if (c == '_')
				return true;

			return false;
		}
	}
}
