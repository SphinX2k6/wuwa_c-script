using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028C9 RID: 10441
	[UnrealObjectPath("/Script/StreamlineBlueprint.StreamlineLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStreamlineLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C18 RID: 158744 RVA: 0x003B2011 File Offset: 0x003B0211
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineLibrary._ClassPtr;
		}

		// Token: 0x06026C19 RID: 158745 RVA: 0x003B2020 File Offset: 0x003B0220
		public UStreamlineLibrary() : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C1A RID: 158746 RVA: 0x003B2048 File Offset: 0x003B0248
		[NullableContext(1)]
		public UStreamlineLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026C1B RID: 158747
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineFeatureSupport QueryStreamlineFeatureSupport(EStreamlineFeature Feature);

		// Token: 0x06026C1C RID: 158748
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsStreamlineFeatureSupported(EStreamlineFeature Feature);

		// Token: 0x06026C1D RID: 158749 RVA: 0x003B207B File Offset: 0x003B027B
		[NullableContext(1)]
		public static FStreamlineFeatureRequirements GetStreamlineFeatureInformation(EStreamlineFeature Feature)
		{
			return new FStreamlineFeatureRequirements(UStreamlineLibrary.__GetStreamlineFeatureInformation_Internal(Feature), null);
		}

		// Token: 0x06026C1E RID: 158750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakStreamlineFeatureRequirements(EStreamlineFeatureRequirementsFlags Requirements, ref bool D3D11Supported, ref bool D3D12Supported, ref bool VulkanSupported, ref bool VSyncOffRequired, ref bool HardwareSchedulingRequired);

		// Token: 0x06026C1F RID: 158751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStreamlineFeatureInformation_Internal(EStreamlineFeature Feature);

		// Token: 0x06026C20 RID: 158752 RVA: 0x003B2089 File Offset: 0x003B0289
		static UStreamlineLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineBlueprint.StreamlineLibrary");
		}

		// Token: 0x06026C21 RID: 158753 RVA: 0x003B2097 File Offset: 0x003B0297
		protected UStreamlineLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401545F RID: 87135
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineBlueprint.StreamlineLibrary";

		// Token: 0x04015460 RID: 87136
		private static IntPtr _ClassPtr;

		// Token: 0x04015461 RID: 87137
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
