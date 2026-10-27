using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028FE RID: 10494
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.TASaveEventV2")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UTASaveEventV2 : USaveGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026E9F RID: 159391 RVA: 0x003B5CEF File Offset: 0x003B3EEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTASaveEventV2._ClassPtr;
		}

		// Token: 0x06026EA0 RID: 159392 RVA: 0x003B5CFC File Offset: 0x003B3EFC
		public UTASaveEventV2() : this(BuiltinUtils.AllocNativeUObject(UTASaveEventV2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026EA1 RID: 159393 RVA: 0x003B5D24 File Offset: 0x003B3F24
		public UTASaveEventV2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTASaveEventV2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095EC RID: 38380
		// (get) Token: 0x06026EA2 RID: 159394 RVA: 0x003B5D58 File Offset: 0x003B3F58
		// (set) Token: 0x06026EA3 RID: 159395 RVA: 0x003B5D91 File Offset: 0x003B3F91
		public TArray<FSingleEvent> EventsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSingleEvent> result;
				if ((result = this._EventsArray) == null)
				{
					result = (this._EventsArray = new TArray<FSingleEvent>(base.NativePtr + (IntPtr)UTASaveEventV2.__PropertyOffset_EventsArray, this));
				}
				return result;
			}
			set
			{
				this.EventsArray.CopyAssign(value);
			}
		}

		// Token: 0x06026EA4 RID: 159396 RVA: 0x003B5D9F File Offset: 0x003B3F9F
		static UTASaveEventV2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TASdkPlugin.TASaveEventV2");
		}

		// Token: 0x06026EA5 RID: 159397 RVA: 0x003B5DAD File Offset: 0x003B3FAD
		protected UTASaveEventV2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155DD RID: 87517
		public new const string __ObjectPath = "/Script/TASdkPlugin.TASaveEventV2";

		// Token: 0x040155DE RID: 87518
		private static IntPtr _ClassPtr;

		// Token: 0x040155DF RID: 87519
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040155E0 RID: 87520
		internal static int __PropertyOffset_EventsArray;

		// Token: 0x040155E1 RID: 87521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSingleEvent> _EventsArray;
	}
}
