using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D7 RID: 983
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARTrackedQRCode")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UARTrackedQRCode : UARTrackedImage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600371C RID: 14108 RVA: 0x00053A54 File Offset: 0x00051C54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTrackedQRCode._ClassPtr;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00053A60 File Offset: 0x00051C60
		public UARTrackedQRCode() : this(BuiltinUtils.AllocNativeUObject(UARTrackedQRCode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00053A88 File Offset: 0x00051C88
		public UARTrackedQRCode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTrackedQRCode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x00053ABB File Offset: 0x00051CBB
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x00053ACF File Offset: 0x00051CCF
		public unsafe string QRCode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UARTrackedQRCode.__PropertyOffset_QRCode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UARTrackedQRCode.__PropertyOffset_QRCode)), value);
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x00053AE4 File Offset: 0x00051CE4
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x00053AF4 File Offset: 0x00051CF4
		public unsafe int Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTrackedQRCode.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedQRCode.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00053B05 File Offset: 0x00051D05
		static UARTrackedQRCode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTrackedQRCode");
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00053B13 File Offset: 0x00051D13
		protected UARTrackedQRCode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017E6 RID: 6118
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTrackedQRCode";

		// Token: 0x040017E7 RID: 6119
		private static IntPtr _ClassPtr;

		// Token: 0x040017E8 RID: 6120
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017E9 RID: 6121
		internal static int __PropertyOffset_QRCode;

		// Token: 0x040017EA RID: 6122
		internal static int __PropertyOffset_Version;
	}
}
