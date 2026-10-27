using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028CC RID: 10444
	[UnrealObjectPath("/Script/StreamlineDeepDVCBlueprint.StreamlineLibraryDeepDVC")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStreamlineLibraryDeepDVC : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C30 RID: 158768 RVA: 0x003B2180 File Offset: 0x003B0380
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineLibraryDeepDVC._ClassPtr;
		}

		// Token: 0x06026C31 RID: 158769 RVA: 0x003B218C File Offset: 0x003B038C
		public UStreamlineLibraryDeepDVC() : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryDeepDVC.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C32 RID: 158770 RVA: 0x003B21B4 File Offset: 0x003B03B4
		[NullableContext(1)]
		public UStreamlineLibraryDeepDVC(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryDeepDVC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026C33 RID: 158771
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDeepDVCSaturationBoost(float Intensity);

		// Token: 0x06026C34 RID: 158772
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDeepDVCMode(EStreamlineDeepDVCMode DeepDVCMode);

		// Token: 0x06026C35 RID: 158773
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDeepDVCIntensity(float Intensity);

		// Token: 0x06026C36 RID: 158774
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineFeatureSupport QueryDeepDVCSupport();

		// Token: 0x06026C37 RID: 158775
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDeepDVCSupported();

		// Token: 0x06026C38 RID: 158776
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDeepDVCModeSupported(EStreamlineDeepDVCMode DeepDVCMode);

		// Token: 0x06026C39 RID: 158777 RVA: 0x003B21E7 File Offset: 0x003B03E7
		[NullableContext(1)]
		public static TArray<EStreamlineDeepDVCMode> GetSupportedDeepDVCModes()
		{
			return new TArray<EStreamlineDeepDVCMode>(UStreamlineLibraryDeepDVC.__GetSupportedDeepDVCModes_Internal(), null);
		}

		// Token: 0x06026C3A RID: 158778
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineDeepDVCMode GetDefaultDeepDVCMode();

		// Token: 0x06026C3B RID: 158779
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDeepDVCSaturationBoost();

		// Token: 0x06026C3C RID: 158780
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineDeepDVCMode GetDeepDVCMode();

		// Token: 0x06026C3D RID: 158781
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDeepDVCIntensity();

		// Token: 0x06026C3E RID: 158782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedDeepDVCModes_Internal();

		// Token: 0x06026C3F RID: 158783 RVA: 0x003B21F4 File Offset: 0x003B03F4
		static UStreamlineLibraryDeepDVC()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineDeepDVCBlueprint.StreamlineLibraryDeepDVC");
		}

		// Token: 0x06026C40 RID: 158784 RVA: 0x003B2202 File Offset: 0x003B0402
		protected UStreamlineLibraryDeepDVC(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401546B RID: 87147
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineDeepDVCBlueprint.StreamlineLibraryDeepDVC";

		// Token: 0x0401546C RID: 87148
		private static IntPtr _ClassPtr;

		// Token: 0x0401546D RID: 87149
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
