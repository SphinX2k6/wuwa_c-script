using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000848 RID: 2120
	[UnrealObjectPath("/Script/StreamlineReflexBlueprint.StreamlineLibraryReflex")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStreamlineLibraryReflex : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B8DA RID: 47322 RVA: 0x00127FD7 File Offset: 0x001261D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineLibraryReflex._ClassPtr;
		}

		// Token: 0x0600B8DB RID: 47323 RVA: 0x00127FE4 File Offset: 0x001261E4
		public UStreamlineLibraryReflex() : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryReflex.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B8DC RID: 47324 RVA: 0x0012800C File Offset: 0x0012620C
		[NullableContext(1)]
		public UStreamlineLibraryReflex(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryReflex.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B8DD RID: 47325
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetReflexMode(EStreamlineReflexMode Mode);

		// Token: 0x0600B8DE RID: 47326
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineFeatureSupport QueryReflexSupport();

		// Token: 0x0600B8DF RID: 47327
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsReflexSupported();

		// Token: 0x0600B8E0 RID: 47328
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsReflexModeSupported(EStreamlineReflexMode ReflexMode);

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x0012803F File Offset: 0x0012623F
		[NullableContext(1)]
		public static TArray<EStreamlineReflexMode> GetSupportedReflexModes()
		{
			return new TArray<EStreamlineReflexMode>(UStreamlineLibraryReflex.__GetSupportedReflexModes_Internal(), null);
		}

		// Token: 0x0600B8E2 RID: 47330
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRenderLatencyInMs();

		// Token: 0x0600B8E3 RID: 47331
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineReflexMode GetReflexMode();

		// Token: 0x0600B8E4 RID: 47332
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameToRenderLatencyInMs();

		// Token: 0x0600B8E5 RID: 47333
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameLatencyInMs();

		// Token: 0x0600B8E6 RID: 47334
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineReflexMode GetDefaultReflexMode();

		// Token: 0x0600B8E7 RID: 47335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedReflexModes_Internal();

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x0012804C File Offset: 0x0012624C
		static UStreamlineLibraryReflex()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineReflexBlueprint.StreamlineLibraryReflex");
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x0012805A File Offset: 0x0012625A
		protected UStreamlineLibraryReflex(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053FA RID: 21498
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineReflexBlueprint.StreamlineLibraryReflex";

		// Token: 0x040053FB RID: 21499
		private static IntPtr _ClassPtr;

		// Token: 0x040053FC RID: 21500
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
