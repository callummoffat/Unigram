// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionPhoneCall : TLMessageActionBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Reason = (1 << 0),
			Duration = (1 << 1),
		}

		public bool HasReason { get { return Flags.HasFlag(Flag.Reason); } set { Flags = value ? (Flags | Flag.Reason) : (Flags & ~Flag.Reason); } }
		public bool HasDuration { get { return Flags.HasFlag(Flag.Duration); } set { Flags = value ? (Flags | Flag.Duration) : (Flags & ~Flag.Duration); } }

		public Flag Flags { get; set; }
		public Int64 CallId { get; set; }
		public TLPhoneCallDiscardReasonBase Reason { get; set; }
		public Int32? Duration { get; set; }

		public TLMessageActionPhoneCall() { }
		public TLMessageActionPhoneCall(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionPhoneCall; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			CallId = from.ReadInt64();
			if (HasReason) Reason = TLFactory.Read<TLPhoneCallDiscardReasonBase>(from);
			if (HasDuration) Duration = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt64(CallId);
			if (HasReason) to.WriteObject(Reason);
			if (HasDuration) to.WriteInt32(Duration.Value);
		}

		private void UpdateFlags()
		{
			HasReason = Reason != null;
			HasDuration = Duration != null;
		}
	}
}