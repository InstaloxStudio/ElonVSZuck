// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about new packet queue size settings.
	/// </summary>
	public class SetPacketQueueSizeOptions
	{
		/// <summary>
		/// The ideal maximum amount of bytes the Incoming packet queue can consume
		/// </summary>
		public ulong IncomingPacketQueueMaxSizeBytes { get; set; }

		/// <summary>
		/// The ideal maximum amount of bytes the Outgoing packet queue can consume
		/// </summary>
		public ulong OutgoingPacketQueueMaxSizeBytes { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SetPacketQueueSizeOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private ulong m_IncomingPacketQueueMaxSizeBytes;
		private ulong m_OutgoingPacketQueueMaxSizeBytes;

		public ulong IncomingPacketQueueMaxSizeBytes
		{
			set
			{
				m_IncomingPacketQueueMaxSizeBytes = value;
			}
		}

		public ulong OutgoingPacketQueueMaxSizeBytes
		{
			set
			{
				m_OutgoingPacketQueueMaxSizeBytes = value;
			}
		}

		public void Set(SetPacketQueueSizeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = P2PInterface.SetpacketqueuesizeApiLatest;
				IncomingPacketQueueMaxSizeBytes = other.IncomingPacketQueueMaxSizeBytes;
				OutgoingPacketQueueMaxSizeBytes = other.OutgoingPacketQueueMaxSizeBytes;
			}
		}

		public void Set(object other)
		{
			Set(other as SetPacketQueueSizeOptions);
		}

		public void Dispose()
		{
		}
	}
}