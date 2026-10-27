using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC5 RID: 7877
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroPerceptionEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroPerceptionEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE2B RID: 122411 RVA: 0x002C351F File Offset: 0x002C171F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerceptionEventBinder._ClassPtr;
		}

		// Token: 0x0601DE2C RID: 122412 RVA: 0x002C352C File Offset: 0x002C172C
		public UKuroPerceptionEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE2D RID: 122413 RVA: 0x002C3554 File Offset: 0x002C1754
		public UKuroPerceptionEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077B4 RID: 30644
		// (get) Token: 0x0601DE2E RID: 122414 RVA: 0x002C3588 File Offset: 0x002C1788
		// (set) Token: 0x0601DE2F RID: 122415 RVA: 0x002C35C1 File Offset: 0x002C17C1
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

		// Token: 0x0601DE30 RID: 122416 RVA: 0x002C35E2 File Offset: 0x002C17E2
		static UKuroPerceptionEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroPerceptionEventBinder");
		}

		// Token: 0x0601DE31 RID: 122417 RVA: 0x002C35F0 File Offset: 0x002C17F0
		protected UKuroPerceptionEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010300 RID: 66304
		public new const string __ObjectPath = "/Script/KuroUtility.KuroPerceptionEventBinder";

		// Token: 0x04010301 RID: 66305
		private static IntPtr _ClassPtr;

		// Token: 0x04010302 RID: 66306
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010303 RID: 66307
		internal static int __PropertyOffset_Callback;

		// Token: 0x04010304 RID: 66308
		[Nullable(2)]
		private FOnPerceptionEventTrigger _Callback;
	}
}
