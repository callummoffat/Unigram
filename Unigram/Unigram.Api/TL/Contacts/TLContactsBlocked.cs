// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Contacts
{
	public partial class TLContactsBlocked : TLContactsBlockedBase 
	{
		public TLContactsBlocked() { }
		public TLContactsBlocked(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsBlocked; } }

		public override void Read(TLBinaryReader from)
		{
			Blocked = TLFactory.Read<TLVector<TLContactBlocked>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Blocked);
			to.WriteObject(Users);
		}
	}
}