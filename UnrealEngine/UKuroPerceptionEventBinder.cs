using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E0 RID: 1504
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroPerceptionEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroPerceptionEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084E4 RID: 34020 RVA: 0x000C5379 File Offset: 0x000C3579
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerceptionEventBinder._ClassPtr;
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x000C5388 File Offset: 0x000C3588
		public UKuroPerceptionEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084E6 RID: 34022 RVA: 0x000C53B0 File Offset: 0x000C35B0
		public UKuroPerceptionEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060084E7 RID: 34023 RVA: 0x000C53E4 File Offset: 0x000C35E4
		// (set) Token: 0x060084E8 RID: 34024 RVA: 0x000C541D File Offset: 0x000C361D
		public FOnPerceptionEventTrigger Callback
		{
			get
			{
				base.FastCheckIsValid();
				FOnPerceptionEventTrigger result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FOnPerceptionEventTrigger(base.NativePtr + (IntPtr)UKuroPerceptionEventBinder.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroPerceptionEventBinder.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x000C543E File Offset: 0x000C363E
		static UKuroPerceptionEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroPerceptionEventBinder");
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x000C544C File Offset: 0x000C364C
		protected UKuroPerceptionEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A0E RID: 14862
		public new const string __ObjectPath = "/Script/KuroUtility.KuroPerceptionEventBinder";

		// Token: 0x04003A0F RID: 14863
		private static IntPtr _ClassPtr;

		// Token: 0x04003A10 RID: 14864
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A11 RID: 14865
		internal static int __PropertyOffset_Callback;

		// Token: 0x04003A12 RID: 14866
		[Nullable(2)]
		private FOnPerceptionEventTrigger _Callback;
	}
}
