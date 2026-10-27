using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EBC RID: 7868
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroIntEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroIntEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDCF RID: 122319 RVA: 0x002C2C04 File Offset: 0x002C0E04
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroIntEventBinder._ClassPtr;
		}

		// Token: 0x0601DDD0 RID: 122320 RVA: 0x002C2C10 File Offset: 0x002C0E10
		public UKuroIntEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroIntEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DDD1 RID: 122321 RVA: 0x002C2C38 File Offset: 0x002C0E38
		public UKuroIntEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroIntEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077B3 RID: 30643
		// (get) Token: 0x0601DDD2 RID: 122322 RVA: 0x002C2C6C File Offset: 0x002C0E6C
		// (set) Token: 0x0601DDD3 RID: 122323 RVA: 0x002C2CA5 File Offset: 0x002C0EA5
		public FOnIntEventTrigger Callback
		{
			get
			{
				base.FastCheckIsValid();
				FOnIntEventTrigger result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FOnIntEventTrigger(base.NativePtr + (IntPtr)UKuroIntEventBinder.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroIntEventBinder.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601DDD4 RID: 122324 RVA: 0x002C2CC6 File Offset: 0x002C0EC6
		static UKuroIntEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroIntEventBinder");
		}

		// Token: 0x0601DDD5 RID: 122325 RVA: 0x002C2CD4 File Offset: 0x002C0ED4
		protected UKuroIntEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102DC RID: 66268
		public new const string __ObjectPath = "/Script/KuroUtility.KuroIntEventBinder";

		// Token: 0x040102DD RID: 66269
		private static IntPtr _ClassPtr;

		// Token: 0x040102DE RID: 66270
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102DF RID: 66271
		internal static int __PropertyOffset_Callback;

		// Token: 0x040102E0 RID: 66272
		[Nullable(2)]
		private FOnIntEventTrigger _Callback;
	}
}
