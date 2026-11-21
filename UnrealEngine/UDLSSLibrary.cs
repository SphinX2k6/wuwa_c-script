using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015B RID: 347
	[UnrealObjectPath("/Script/DLSSBlueprint.DLSSLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDLSSLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001359 RID: 4953 RVA: 0x0001EAF1 File Offset: 0x0001CCF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDLSSLibrary._ClassPtr;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0001EB00 File Offset: 0x0001CD00
		public UDLSSLibrary() : this(BuiltinUtils.AllocNativeUObject(UDLSSLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0001EB28 File Offset: 0x0001CD28
		[NullableContext(1)]
		public UDLSSLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDLSSLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600135C RID: 4956
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDLSSSharpness(float Sharpness);

		// Token: 0x0600135D RID: 4957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDLSSMode(UDLSSMode DLSSMode);

		// Token: 0x0600135E RID: 4958
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSSupport QueryDLSSSupport();

		// Token: 0x0600135F RID: 4959
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSSupport QueryDLSSRRSupport();

		// Token: 0x06001360 RID: 4960
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSSupported();

		// Token: 0x06001361 RID: 4961
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSRRSupported();

		// Token: 0x06001362 RID: 4962
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSRREnabled();

		// Token: 0x06001363 RID: 4963
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSModeSupported(UDLSSMode DLSSMode);

		// Token: 0x06001364 RID: 4964
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSEnabled();

		// Token: 0x06001365 RID: 4965
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLAAEnabled();

		// Token: 0x06001366 RID: 4966 RVA: 0x0001EB5B File Offset: 0x0001CD5B
		[NullableContext(1)]
		public static TArray<UDLSSMode> GetSupportedDLSSModes()
		{
			return new TArray<UDLSSMode>(UDLSSLibrary.__GetSupportedDLSSModes_Internal(), null);
		}

		// Token: 0x06001367 RID: 4967
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDLSSSharpness();

		// Token: 0x06001368 RID: 4968
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSScreenPercentageRange(ref float MinScreenPercentage, ref float MaxScreenPercentage);

		// Token: 0x06001369 RID: 4969
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSRRMinimumDriverVersion(ref int MinDriverVersionMajor, ref int MinDriverVersionMinor);

		// Token: 0x0600136A RID: 4970
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSModeInformation(UDLSSMode DLSSMode, FVector2D ScreenResolution, ref bool bIsSupported, ref float OptimalScreenPercentage, ref bool bIsFixedScreenPercentage, ref float MinScreenPercentage, ref float MaxScreenPercentage, ref float OptimalSharpness);

		// Token: 0x0600136B RID: 4971
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSMode GetDLSSMode();

		// Token: 0x0600136C RID: 4972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSMinimumDriverVersion(ref int MinDriverVersionMajor, ref int MinDriverVersionMinor);

		// Token: 0x0600136D RID: 4973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSMode GetDefaultDLSSMode();

		// Token: 0x0600136E RID: 4974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDLSSRR(bool bEnabled);

		// Token: 0x0600136F RID: 4975
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDLSS(bool bEnabled);

		// Token: 0x06001370 RID: 4976
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDLAA(bool bEnabled);

		// Token: 0x06001371 RID: 4977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedDLSSModes_Internal();

		// Token: 0x06001372 RID: 4978 RVA: 0x0001EB68 File Offset: 0x0001CD68
		static UDLSSLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/DLSSBlueprint.DLSSLibrary");
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0001EB76 File Offset: 0x0001CD76
		protected UDLSSLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000631 RID: 1585
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/DLSSBlueprint.DLSSLibrary";

		// Token: 0x04000632 RID: 1586
		private static IntPtr _ClassPtr;

		// Token: 0x04000633 RID: 1587
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
