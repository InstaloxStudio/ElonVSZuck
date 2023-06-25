// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters to use with Lobby RTC Rooms.
	/// </summary>
	public class LocalRTCOptions : ISettable
	{
		/// <summary>
		/// Flags for the local user in this room. The default is 0 if this struct is not specified. @see <see cref="RTC.JoinRoomOptions" />::Flags
		/// </summary>
		public uint Flags { get; set; }

		/// <summary>
		/// Set to true to enable Manual Audio Input. If manual audio input is enabled, audio recording is not started and the audio buffers
		/// must be passed manually using <see cref="RTCAudio.RTCAudioInterface.SendAudio" />. The default is false if this struct is not specified.
		/// </summary>
		public bool UseManualAudioInput { get; set; }

		/// <summary>
		/// Set to true to enable Manual Audio Output. If manual audio output is enabled, audio rendering is not started and the audio buffers
		/// must be received with <see cref="RTCAudio.RTCAudioInterface.AddNotifyAudioBeforeRender" /> and rendered manually. The default is false if this struct is not
		/// specified.
		/// </summary>
		public bool UseManualAudioOutput { get; set; }

		/// <summary>
		/// Set to true to start the outgoing audio stream muted by when first connecting to the RTC room. It must be manually unmuted with a
		/// call to <see cref="RTCAudio.RTCAudioInterface.UpdateSending" />. If manual audio output is enabled, this value is ignored. The default is false if this struct
		/// is not specified.
		/// </summary>
		public bool AudioOutputStartsMuted { get; set; }

		internal void Set(LocalRTCOptionsInternal? other)
		{
			if (other != null)
			{
				Flags = other.Value.Flags;
				UseManualAudioInput = other.Value.UseManualAudioInput;
				UseManualAudioOutput = other.Value.UseManualAudioOutput;
				AudioOutputStartsMuted = other.Value.AudioOutputStartsMuted;
			}
		}

		public void Set(object other)
		{
			Set(other as LocalRTCOptionsInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LocalRTCOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_Flags;
		private int m_UseManualAudioInput;
		private int m_UseManualAudioOutput;
		private int m_AudioOutputStartsMuted;

		public uint Flags
		{
			get
			{
				return m_Flags;
			}

			set
			{
				m_Flags = value;
			}
		}

		public bool UseManualAudioInput
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_UseManualAudioInput, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_UseManualAudioInput, value);
			}
		}

		public bool UseManualAudioOutput
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_UseManualAudioOutput, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_UseManualAudioOutput, value);
			}
		}

		public bool AudioOutputStartsMuted
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_AudioOutputStartsMuted, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_AudioOutputStartsMuted, value);
			}
		}

		public void Set(LocalRTCOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyInterface.LocalrtcoptionsApiLatest;
				Flags = other.Flags;
				UseManualAudioInput = other.UseManualAudioInput;
				UseManualAudioOutput = other.UseManualAudioOutput;
				AudioOutputStartsMuted = other.AudioOutputStartsMuted;
			}
		}

		public void Set(object other)
		{
			Set(other as LocalRTCOptions);
		}

		public void Dispose()
		{
		}
	}
}