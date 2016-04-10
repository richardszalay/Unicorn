﻿namespace Unicorn.Roles.Model
{
	/// <summary>
	/// Wraps a Sitecore SyncRole object along with the source filename it's from
	/// </summary>
	public interface IRoleData
	{
		string RoleName { get; }
		string[] ParentRoleNames { get; }
		string SerializedItemId { get; }
	}
}
