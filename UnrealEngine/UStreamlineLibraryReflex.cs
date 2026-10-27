using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028D0 RID: 10448
	[UnrealObjectPath("/Script/StreamlineReflexBlueprint.StreamlineLibraryReflex")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStreamlineLibraryReflex : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C4F RID: 158799 RVA: 0x003B2297 File Offset: 0x003B0497
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineLibraryReflex._ClassPtr;
		}

		// Token: 0x06026C50 RID: 158800 RVA: 0x003B22A4 File Offset: 0x003B04A4
		public UStreamlineLibraryReflex() : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryReflex.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C51 RID: 158801 RVA: 0x003B22CC File Offset: 0x003B04CC
		[NullableContext(1)]
		public UStreamlineLibraryReflex(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryReflex.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026C52 RID: 158802
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetReflexMode(EStreamlineReflexMode Mode);

		// Token: 0x06026C53 RID: 158803
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineFeatureSupport QueryReflexSupport();

		// Token: 0x06026C54 RID: 158804
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsReflexSupported();

		// Token: 0x06026C55 RID: 158805
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsReflexModeSupported(EStreamlineReflexMode ReflexMode);

		// Token: 0x06026C56 RID: 158806 RVA: 0x003B22FF File Offset: 0x003B04FF
		[NullableContext(1)]
		public static TArray<EStreamlineReflexMode> GetSupportedReflexModes()
		{
			return new TArray<EStreamlineReflexMode>(UStreamlineLibraryReflex.__GetSupportedReflexModes_Internal(), null);
		}

		// Token: 0x06026C57 RID: 158807
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRenderLatencyInMs();

		// Token: 0x06026C58 RID: 158808
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineReflexMode GetReflexMode();

		// Token: 0x06026C59 RID: 158809
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameToRenderLatencyInMs();

		// Token: 0x06026C5A RID: 158810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameLatencyInMs();

		// Token: 0x06026C5B RID: 158811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineReflexMode GetDefaultReflexMode();

		// Token: 0x06026C5C RID: 158812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedReflexModes_Internal();

		// Token: 0x06026C5D RID: 158813 RVA: 0x003B230C File Offset: 0x003B050C
		static UStreamlineLibraryReflex()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineReflexBlueprint.StreamlineLibraryReflex");
		}

		// Token: 0x06026C5E RID: 158814 RVA: 0x003B231A File Offset: 0x003B051A
		protected UStreamlineLibraryReflex(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401547F RID: 87167
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineReflexBlueprint.StreamlineLibraryReflex";

		// Token: 0x04015480 RID: 87168
		private static IntPtr _ClassPtr;

		// Token: 0x04015481 RID: 87169
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
