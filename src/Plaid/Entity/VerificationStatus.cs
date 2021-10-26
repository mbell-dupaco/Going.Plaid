namespace Going.Plaid.Entity;

/// <summary>
/// <para>The verification status. One of the following:</para>
/// </summary>
public enum VerificationStatus
{
	/// <summary>
	/// <para>The information was successfully verified.</para>
	/// </summary>
	[EnumMember(Value = "VERIFIED")]
	Verified,

	/// <summary>
	/// <para>The verification has not yet been performed.</para>
	/// </summary>
	[EnumMember(Value = "UNVERIFIED")]
	Unverified,

	/// <summary>
	/// <para>The verification was attempted but could not be completed due to missing information.</para>
	/// </summary>
	[EnumMember(Value = "NEEDS_INFO")]
	NeedsInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNABLE_TO_VERIFY")]
	UnableToVerify,

	/// <summary>
	/// <para>The verification status is unknown.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,
}