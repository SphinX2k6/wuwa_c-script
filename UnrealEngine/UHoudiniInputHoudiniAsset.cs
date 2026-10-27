using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D1 RID: 5329
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputHoudiniAsset")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UHoudiniInputHoudiniAsset : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134FB RID: 79099 RVA: 0x001C6532 File Offset: 0x001C4732
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputHoudiniAsset._ClassPtr;
		}

		// Token: 0x060134FC RID: 79100 RVA: 0x001C6540 File Offset: 0x001C4740
		public UHoudiniInputHoudiniAsset() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputHoudiniAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134FD RID: 79101 RVA: 0x001C6568 File Offset: 0x001C4768
		[NullableContext(1)]
		public UHoudiniInputHoudiniAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputHoudiniAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B45 RID: 19269
		// (get) Token: 0x060134FE RID: 79102 RVA: 0x001C659B File Offset: 0x001C479B
		// (set) Token: 0x060134FF RID: 79103 RVA: 0x001C65AB File Offset: 0x001C47AB
		public unsafe int AssetOutputIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputHoudiniAsset.__PropertyOffset_AssetOutputIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputHoudiniAsset.__PropertyOffset_AssetOutputIndex) = value;
			}
		}

		// Token: 0x06013500 RID: 79104 RVA: 0x001C65BC File Offset: 0x001C47BC
		static UHoudiniInputHoudiniAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputHoudiniAsset");
		}

		// Token: 0x06013501 RID: 79105 RVA: 0x001C65CA File Offset: 0x001C47CA
		protected UHoudiniInputHoudiniAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6E5 RID: 42725
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputHoudiniAsset";

		// Token: 0x0400A6E6 RID: 42726
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6E7 RID: 42727
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6E8 RID: 42728
		internal static int __PropertyOffset_AssetOutputIndex;
	}
}
