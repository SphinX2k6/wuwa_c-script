using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AC RID: 1452
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroVerify")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKuroVerify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060082A6 RID: 33446 RVA: 0x000C131C File Offset: 0x000BF51C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVerify._ClassPtr;
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x000C1328 File Offset: 0x000BF528
		public UKuroVerify() : this(BuiltinUtils.AllocNativeUObject(UKuroVerify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x000C1350 File Offset: 0x000BF550
		public UKuroVerify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVerify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060082A9 RID: 33449 RVA: 0x000C1384 File Offset: 0x000BF584
		// (set) Token: 0x060082AA RID: 33450 RVA: 0x000C13BD File Offset: 0x000BF5BD
		public FKuroTinkerCheckSoCallback CheckCallback
		{
			get
			{
				base.FastCheckIsValid();
				FKuroTinkerCheckSoCallback result;
				if ((result = this._CheckCallback) == null)
				{
					result = (this._CheckCallback = new FKuroTinkerCheckSoCallback(base.NativePtr + (IntPtr)UKuroVerify.__PropertyOffset_CheckCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroVerify.__PropertyOffset_CheckCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x000C13E0 File Offset: 0x000BF5E0
		public unsafe void CheckLib(string Hash)
		{
			FString fstring = FString.AllocTemp(Hash);
			UKuroVerify.__CheckLib_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060082AC RID: 33452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheckLib_Internal(IntPtr @this, in FString Hash);

		// Token: 0x060082AD RID: 33453 RVA: 0x000C140A File Offset: 0x000BF60A
		static UKuroVerify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroVerify");
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x000C1418 File Offset: 0x000BF618
		protected UKuroVerify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038E1 RID: 14561
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroVerify";

		// Token: 0x040038E2 RID: 14562
		private static IntPtr _ClassPtr;

		// Token: 0x040038E3 RID: 14563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040038E4 RID: 14564
		internal static int __PropertyOffset_CheckCallback;

		// Token: 0x040038E5 RID: 14565
		[Nullable(2)]
		private FKuroTinkerCheckSoCallback _CheckCallback;
	}
}
