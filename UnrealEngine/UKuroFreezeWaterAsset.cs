using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001877 RID: 6263
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroFreezeWaterAsset")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroFreezeWaterAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060170EE RID: 94446 RVA: 0x002199FA File Offset: 0x00217BFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFreezeWaterAsset._ClassPtr;
		}

		// Token: 0x060170EF RID: 94447 RVA: 0x00219A08 File Offset: 0x00217C08
		public UKuroFreezeWaterAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroFreezeWaterAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060170F0 RID: 94448 RVA: 0x00219A30 File Offset: 0x00217C30
		[NullableContext(1)]
		public UKuroFreezeWaterAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFreezeWaterAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CB5 RID: 23733
		// (get) Token: 0x060170F1 RID: 94449 RVA: 0x00219A63 File Offset: 0x00217C63
		// (set) Token: 0x060170F2 RID: 94450 RVA: 0x00219A73 File Offset: 0x00217C73
		public unsafe float InteractionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFreezeWaterAsset.__PropertyOffset_InteractionSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFreezeWaterAsset.__PropertyOffset_InteractionSize) = value;
			}
		}

		// Token: 0x17005CB6 RID: 23734
		// (get) Token: 0x060170F3 RID: 94451 RVA: 0x00219A84 File Offset: 0x00217C84
		// (set) Token: 0x060170F4 RID: 94452 RVA: 0x00219A94 File Offset: 0x00217C94
		public unsafe float Attenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFreezeWaterAsset.__PropertyOffset_Attenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFreezeWaterAsset.__PropertyOffset_Attenuation) = value;
			}
		}

		// Token: 0x060170F5 RID: 94453 RVA: 0x00219AA5 File Offset: 0x00217CA5
		static UKuroFreezeWaterAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayInterface.KuroFreezeWaterAsset");
		}

		// Token: 0x060170F6 RID: 94454 RVA: 0x00219AB3 File Offset: 0x00217CB3
		protected UKuroFreezeWaterAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C82E RID: 51246
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayInterface.KuroFreezeWaterAsset";

		// Token: 0x0400C82F RID: 51247
		private static IntPtr _ClassPtr;

		// Token: 0x0400C830 RID: 51248
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C831 RID: 51249
		internal static int __PropertyOffset_InteractionSize;

		// Token: 0x0400C832 RID: 51250
		internal static int __PropertyOffset_Attenuation;
	}
}
