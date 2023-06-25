// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAdmin
{
	/// <summary>
	/// Input parameters for the <see cref="RTCAdminInterface.Kick" /> function.
	/// </summary>
	public class KickOptions
	{
		/// <summary>
		/// Room name to kick the participant from
		/// </summary>
		public string RoomName { get; set; }

		/// <summary>
		/// Product User ID of the participant to kick from the room
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct KickOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_TargetUserId;

		public string RoomName
		{
			set
			{
				Helper.TryMarshalSet(ref m_RoomName, value);
			}
		}

		public ProductUserId TargetUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_TargetUserId, value);
			}
		}

		public void Set(KickOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = RTCAdminInterface.KickApiLatest;
				RoomName = other.RoomName;
				TargetUserId = other.TargetUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as KickOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_RoomName);
			Helper.TryMarshalDispose(ref m_TargetUserId);
		}
	}
}