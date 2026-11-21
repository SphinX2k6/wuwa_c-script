using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005DA RID: 1498
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroIntEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroIntEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600849A RID: 33946 RVA: 0x000C4BF0 File Offset: 0x000C2DF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroIntEventBinder._ClassPtr;
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x000C4BFC File Offset: 0x000C2DFC
		public UKuroIntEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroIntEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x000C4C24 File Offset: 0x000C2E24
		public UKuroIntEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroIntEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600849D RID: 33949 RVA: 0x000C4C58 File Offset: 0x000C2E58
		// (set) Token: 0x0600849E RID: 33950 RVA: 0x000C4C91 File Offset: 0x000C2E91
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

		// Token: 0x0600849F RID: 33951 RVA: 0x000C4CB2 File Offset: 0x000C2EB2
		static UKuroIntEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroIntEventBinder");
		}

		// Token: 0x060084A0 RID: 33952 RVA: 0x000C4CC0 File Offset: 0x000C2EC0
		protected UKuroIntEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039F2 RID: 14834
		public new const string __ObjectPath = "/Script/KuroUtility.KuroIntEventBinder";

		// Token: 0x040039F3 RID: 14835
		private static IntPtr _ClassPtr;

		// Token: 0x040039F4 RID: 14836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039F5 RID: 14837
		internal static int __PropertyOffset_Callback;

		// Token: 0x040039F6 RID: 14838
		[Nullable(2)]
		private FOnIntEventTrigger _Callback;
	}
}
