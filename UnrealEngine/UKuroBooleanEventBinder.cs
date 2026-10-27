using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EAE RID: 7854
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroBooleanEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroBooleanEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD1C RID: 122140 RVA: 0x002C1CB7 File Offset: 0x002BFEB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBooleanEventBinder._ClassPtr;
		}

		// Token: 0x0601DD1D RID: 122141 RVA: 0x002C1CC4 File Offset: 0x002BFEC4
		public UKuroBooleanEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroBooleanEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD1E RID: 122142 RVA: 0x002C1CEC File Offset: 0x002BFEEC
		public UKuroBooleanEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBooleanEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007799 RID: 30617
		// (get) Token: 0x0601DD1F RID: 122143 RVA: 0x002C1D20 File Offset: 0x002BFF20
		// (set) Token: 0x0601DD20 RID: 122144 RVA: 0x002C1D59 File Offset: 0x002BFF59
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

		// Token: 0x0601DD21 RID: 122145 RVA: 0x002C1D7A File Offset: 0x002BFF7A
		static UKuroBooleanEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroBooleanEventBinder");
		}

		// Token: 0x0601DD22 RID: 122146 RVA: 0x002C1D88 File Offset: 0x002BFF88
		protected UKuroBooleanEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010293 RID: 66195
		public new const string __ObjectPath = "/Script/KuroUtility.KuroBooleanEventBinder";

		// Token: 0x04010294 RID: 66196
		private static IntPtr _ClassPtr;

		// Token: 0x04010295 RID: 66197
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010296 RID: 66198
		internal static int __PropertyOffset_Callback;

		// Token: 0x04010297 RID: 66199
		[Nullable(2)]
		private FOnBooleanEventTrigger _Callback;
	}
}
