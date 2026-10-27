using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E79 RID: 7801
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroVerify")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKuroVerify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB3C RID: 121660 RVA: 0x002BE040 File Offset: 0x002BC240
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVerify._ClassPtr;
		}

		// Token: 0x0601DB3D RID: 121661 RVA: 0x002BE04C File Offset: 0x002BC24C
		public UKuroVerify() : this(BuiltinUtils.AllocNativeUObject(UKuroVerify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB3E RID: 121662 RVA: 0x002BE074 File Offset: 0x002BC274
		public UKuroVerify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVerify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700776F RID: 30575
		// (get) Token: 0x0601DB3F RID: 121663 RVA: 0x002BE0A8 File Offset: 0x002BC2A8
		// (set) Token: 0x0601DB40 RID: 121664 RVA: 0x002BE0E1 File Offset: 0x002BC2E1
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

		// Token: 0x0601DB41 RID: 121665 RVA: 0x002BE104 File Offset: 0x002BC304
		public unsafe void CheckLib(string Hash)
		{
			FString fstring = FString.AllocTemp(Hash);
			UKuroVerify.__CheckLib_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DB42 RID: 121666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheckLib_Internal(IntPtr @this, in FString Hash);

		// Token: 0x0601DB43 RID: 121667 RVA: 0x002BE12E File Offset: 0x002BC32E
		static UKuroVerify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroVerify");
		}

		// Token: 0x0601DB44 RID: 121668 RVA: 0x002BE13C File Offset: 0x002BC33C
		protected UKuroVerify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401014C RID: 65868
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroVerify";

		// Token: 0x0401014D RID: 65869
		private static IntPtr _ClassPtr;

		// Token: 0x0401014E RID: 65870
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401014F RID: 65871
		internal static int __PropertyOffset_CheckCallback;

		// Token: 0x04010150 RID: 65872
		[Nullable(2)]
		private FKuroTinkerCheckSoCallback _CheckCallback;
	}
}
