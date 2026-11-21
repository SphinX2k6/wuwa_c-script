using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CD RID: 1485
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroBooleanEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroBooleanEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060083F0 RID: 33776 RVA: 0x000C3F87 File Offset: 0x000C2187
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBooleanEventBinder._ClassPtr;
		}

		// Token: 0x060083F1 RID: 33777 RVA: 0x000C3F94 File Offset: 0x000C2194
		public UKuroBooleanEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroBooleanEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x000C3FBC File Offset: 0x000C21BC
		public UKuroBooleanEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBooleanEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x060083F3 RID: 33779 RVA: 0x000C3FF0 File Offset: 0x000C21F0
		// (set) Token: 0x060083F4 RID: 33780 RVA: 0x000C4029 File Offset: 0x000C2229
		public FOnBooleanEventTrigger Callback
		{
			get
			{
				base.FastCheckIsValid();
				FOnBooleanEventTrigger result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FOnBooleanEventTrigger(base.NativePtr + (IntPtr)UKuroBooleanEventBinder.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroBooleanEventBinder.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060083F5 RID: 33781 RVA: 0x000C404A File Offset: 0x000C224A
		static UKuroBooleanEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroBooleanEventBinder");
		}

		// Token: 0x060083F6 RID: 33782 RVA: 0x000C4058 File Offset: 0x000C2258
		protected UKuroBooleanEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039AE RID: 14766
		public new const string __ObjectPath = "/Script/KuroUtility.KuroBooleanEventBinder";

		// Token: 0x040039AF RID: 14767
		private static IntPtr _ClassPtr;

		// Token: 0x040039B0 RID: 14768
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039B1 RID: 14769
		internal static int __PropertyOffset_Callback;

		// Token: 0x040039B2 RID: 14770
		[Nullable(2)]
		private FOnBooleanEventTrigger _Callback;
	}
}
