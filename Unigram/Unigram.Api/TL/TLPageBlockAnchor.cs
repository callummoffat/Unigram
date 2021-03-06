// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockAnchor : TLPageBlockBase 
	{
		public String Name { get; set; }

		public TLPageBlockAnchor() { }
		public TLPageBlockAnchor(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockAnchor; } }

		public override void Read(TLBinaryReader from)
		{
			Name = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Name ?? string.Empty);
		}
	}
}