// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is used to call <see cref="RTCAudioInterface.SetAudioOutputSettings" />.
	/// </summary>
	public class SetAudioOutputSettingsOptions
	{
		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The device Id to be used for this user. Pass NULL or empty string to use default output device.
		/// </summary>
		public string DeviceId { get; set; }

		/// <summary>
		/// The volume to be configured for this device (range 0.0 to 100.0). Volume 50 means that the audio volume is not modified
		/// and stays in its source value.
		/// </summary>
		public float Volume { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SetAudioOutputSettingsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_DeviceId;
		private float m_Volume;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string DeviceId
		{
			set
			{
				Helper.TryMarshalSet(ref m_DeviceId, value);
			}
		}

		public float Volume
		{
			set
			{
				m_Volume = value;
			}
		}

		public void Set(SetAudioOutputSettingsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = RTCAudioInterface.SetaudiooutputsettingsApiLatest;
				LocalUserId = other.LocalUserId;
				DeviceId = other.DeviceId;
				Volume = other.Volume;
			}
		}

		public void Set(object other)
		{
			Set(other as SetAudioOutputSettingsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_DeviceId);
		}
	}
}