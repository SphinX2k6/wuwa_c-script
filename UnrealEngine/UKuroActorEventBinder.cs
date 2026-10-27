using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA8 RID: 7848
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroActorEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroActorEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DCC1 RID: 122049 RVA: 0x002C09E8 File Offset: 0x002BEBE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorEventBinder._ClassPtr;
		}

		// Token: 0x0601DCC2 RID: 122050 RVA: 0x002C09F4 File Offset: 0x002BEBF4
		public UKuroActorEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroActorEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DCC3 RID: 122051 RVA: 0x002C0A1C File Offset: 0x002BEC1C
		public UKuroActorEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700778D RID: 30605
		// (get) Token: 0x0601DCC4 RID: 122052 RVA: 0x002C0A50 File Offset: 0x002BEC50
		// (set) Token: 0x0601DCC5 RID: 122053 RVA: 0x002C0A89 File Offset: 0x002BEC89
		public FOnActorEventTrigger Callback
		{
			get
			{
				base.FastCheckIsValid();
				FOnActorEventTrigger result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FOnActorEventTrigger(base.NativePtr + (IntPtr)UKuroActorEventBinder.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroActorEventBinder.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601DCC6 RID: 122054 RVA: 0x002C0AAA File Offset: 0x002BECAA
		static UKuroActorEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActorEventBinder");
		}

		// Token: 0x0601DCC7 RID: 122055 RVA: 0x002C0AB8 File Offset: 0x002BECB8
		protected UKuroActorEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401024B RID: 66123
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActorEventBinder";

		// Token: 0x0401024C RID: 66124
		private static IntPtr _ClassPtr;

		// Token: 0x0401024D RID: 66125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401024E RID: 66126
		internal static int __PropertyOffset_Callback;

		// Token: 0x0401024F RID: 66127
		[Nullable(2)]
		private FOnActorEventTrigger _Callback;
	}
}
