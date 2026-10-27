using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B5 RID: 4789
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UFieldSystemMetaDataProcessingResolution : UFieldSystemMetaData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011898 RID: 71832 RVA: 0x0019BB56 File Offset: 0x00199D56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldSystemMetaDataProcessingResolution._ClassPtr;
		}

		// Token: 0x06011899 RID: 71833 RVA: 0x0019BB64 File Offset: 0x00199D64
		public UFieldSystemMetaDataProcessingResolution() : this(BuiltinUtils.AllocNativeUObject(UFieldSystemMetaDataProcessingResolution.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601189A RID: 71834 RVA: 0x0019BB8C File Offset: 0x00199D8C
		[NullableContext(1)]
		public UFieldSystemMetaDataProcessingResolution(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldSystemMetaDataProcessingResolution.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x0601189B RID: 71835 RVA: 0x0019BBBF File Offset: 0x00199DBF
		// (set) Token: 0x0601189C RID: 71836 RVA: 0x0019BBD3 File Offset: 0x00199DD3
		public unsafe TEnumAsByte<EFieldResolutionType> ResolutionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFieldSystemMetaDataProcessingResolution.__PropertyOffset_ResolutionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFieldSystemMetaDataProcessingResolution.__PropertyOffset_ResolutionType) = value;
			}
		}

		// Token: 0x0601189D RID: 71837 RVA: 0x0019BBE8 File Offset: 0x00199DE8
		[NullableContext(2)]
		public UFieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(EFieldResolutionType ResolutionType)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UFieldSystemMetaDataProcessingResolution>(UFieldSystemMetaDataProcessingResolution.__SetMetaDataaProcessingResolutionType_Internal(base.NativePtr, ResolutionType));
		}

		// Token: 0x0601189E RID: 71838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetMetaDataaProcessingResolutionType_Internal(IntPtr @this, TEnumAsByte<EFieldResolutionType> ResolutionType);

		// Token: 0x0601189F RID: 71839 RVA: 0x0019BC00 File Offset: 0x00199E00
		static UFieldSystemMetaDataProcessingResolution()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution");
		}

		// Token: 0x060118A0 RID: 71840 RVA: 0x0019BC0E File Offset: 0x00199E0E
		protected UFieldSystemMetaDataProcessingResolution(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009652 RID: 38482
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution";

		// Token: 0x04009653 RID: 38483
		private static IntPtr _ClassPtr;

		// Token: 0x04009654 RID: 38484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009655 RID: 38485
		internal static int __PropertyOffset_ResolutionType;
	}
}
