using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200077F RID: 1919
	[UnrealObjectPath("/Script/DLSSBlueprint.DLSSLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDLSSLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006419 RID: 25625 RVA: 0x0008FDF9 File Offset: 0x0008DFF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDLSSLibrary._ClassPtr;
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x0008FE08 File Offset: 0x0008E008
		public UDLSSLibrary() : this(BuiltinUtils.AllocNativeUObject(UDLSSLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x0008FE30 File Offset: 0x0008E030
		[NullableContext(1)]
		public UDLSSLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDLSSLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600641C RID: 25628
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDLSSSharpness(float Sharpness);

		// Token: 0x0600641D RID: 25629
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDLSSMode(UDLSSMode DLSSMode);

		// Token: 0x0600641E RID: 25630
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSSupport QueryDLSSSupport();

		// Token: 0x0600641F RID: 25631
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSSupport QueryDLSSRRSupport();

		// Token: 0x06006420 RID: 25632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSSupported();

		// Token: 0x06006421 RID: 25633
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSRRSupported();

		// Token: 0x06006422 RID: 25634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSRREnabled();

		// Token: 0x06006423 RID: 25635
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSModeSupported(UDLSSMode DLSSMode);

		// Token: 0x06006424 RID: 25636
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSEnabled();

		// Token: 0x06006425 RID: 25637
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLAAEnabled();

		// Token: 0x06006426 RID: 25638 RVA: 0x0008FE63 File Offset: 0x0008E063
		[NullableContext(1)]
		public static TArray<UDLSSMode> GetSupportedDLSSModes()
		{
			return new TArray<UDLSSMode>(UDLSSLibrary.__GetSupportedDLSSModes_Internal(), null);
		}

		// Token: 0x06006427 RID: 25639
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDLSSSharpness();

		// Token: 0x06006428 RID: 25640
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSScreenPercentageRange(ref float MinScreenPercentage, ref float MaxScreenPercentage);

		// Token: 0x06006429 RID: 25641
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSRRMinimumDriverVersion(ref int MinDriverVersionMajor, ref int MinDriverVersionMinor);

		// Token: 0x0600642A RID: 25642
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSModeInformation(UDLSSMode DLSSMode, FVector2D ScreenResolution, ref bool bIsSupported, ref float OptimalScreenPercentage, ref bool bIsFixedScreenPercentage, ref float MinScreenPercentage, ref float MaxScreenPercentage, ref float OptimalSharpness);

		// Token: 0x0600642B RID: 25643
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSMode GetDLSSMode();

		// Token: 0x0600642C RID: 25644
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSMinimumDriverVersion(ref int MinDriverVersionMajor, ref int MinDriverVersionMinor);

		// Token: 0x0600642D RID: 25645
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UDLSSMode GetDefaultDLSSMode();

		// Token: 0x0600642E RID: 25646
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDLSSRR(bool bEnabled);

		// Token: 0x0600642F RID: 25647
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDLSS(bool bEnabled);

		// Token: 0x06006430 RID: 25648
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDLAA(bool bEnabled);

		// Token: 0x06006431 RID: 25649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedDLSSModes_Internal();

		// Token: 0x06006432 RID: 25650 RVA: 0x0008FE70 File Offset: 0x0008E070
		static UDLSSLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/DLSSBlueprint.DLSSLibrary");
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x0008FE7E File Offset: 0x0008E07E
		protected UDLSSLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003036 RID: 12342
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/DLSSBlueprint.DLSSLibrary";

		// Token: 0x04003037 RID: 12343
		private static IntPtr _ClassPtr;

		// Token: 0x04003038 RID: 12344
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
