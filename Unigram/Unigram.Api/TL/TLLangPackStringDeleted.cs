// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLLangPackStringDeleted : TLLangPackStringBase 
	{
		public TLLangPackStringDeleted() { }
		public TLLangPackStringDeleted(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.LangPackStringDeleted; } }

		public override void Read(TLBinaryReader from)
		{
			Key = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Key ?? string.Empty);
		}
	}
}