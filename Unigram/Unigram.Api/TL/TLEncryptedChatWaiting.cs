// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLEncryptedChatWaiting : TLEncryptedChatBase 
	{
		public Int64 AccessHash { get; set; }
		public Int32 Date { get; set; }
		public Int32 AdminId { get; set; }
		public Int32 ParticipantId { get; set; }

		public TLEncryptedChatWaiting() { }
		public TLEncryptedChatWaiting(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.EncryptedChatWaiting; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			AdminId = from.ReadInt32();
			ParticipantId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Id);
			to.WriteInt64(AccessHash);
			to.WriteInt32(Date);
			to.WriteInt32(AdminId);
			to.WriteInt32(ParticipantId);
		}
	}
}