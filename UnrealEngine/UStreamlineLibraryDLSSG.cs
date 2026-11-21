using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000846 RID: 2118
	[UnrealObjectPath("/Script/StreamlineDLSSGBlueprint.StreamlineLibraryDLSSG")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStreamlineLibraryDLSSG : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B8CC RID: 47308 RVA: 0x00127F4C File Offset: 0x0012614C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineLibraryDLSSG._ClassPtr;
		}

		// Token: 0x0600B8CD RID: 47309 RVA: 0x00127F58 File Offset: 0x00126158
		public UStreamlineLibraryDLSSG() : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryDLSSG.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x00127F80 File Offset: 0x00126180
		[NullableContext(1)]
		public UStreamlineLibraryDLSSG(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryDLSSG.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B8CF RID: 47311
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDLSSGMode(EStreamlineDLSSGMode DLSSGMode);

		// Token: 0x0600B8D0 RID: 47312
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineFeatureSupport QueryDLSSGSupport();

		// Token: 0x0600B8D1 RID: 47313
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSGSupported();

		// Token: 0x0600B8D2 RID: 47314
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSGModeSupported(EStreamlineDLSSGMode DLSSGMode);

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x00127FB3 File Offset: 0x001261B3
		[NullableContext(1)]
		public static TArray<EStreamlineDLSSGMode> GetSupportedDLSSGModes()
		{
			return new TArray<EStreamlineDLSSGMode>(UStreamlineLibraryDLSSG.__GetSupportedDLSSGModes_Internal(), null);
		}

		// Token: 0x0600B8D4 RID: 47316
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineDLSSGMode GetDLSSGMode();

		// Token: 0x0600B8D5 RID: 47317
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSGFrameTiming(ref float FrameRateInHertz, ref int FramesPresented);

		// Token: 0x0600B8D6 RID: 47318
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineDLSSGMode GetDefaultDLSSGMode();

		// Token: 0x0600B8D7 RID: 47319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedDLSSGModes_Internal();

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x00127FC0 File Offset: 0x001261C0
		static UStreamlineLibraryDLSSG()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineDLSSGBlueprint.StreamlineLibraryDLSSG");
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x00127FCE File Offset: 0x001261CE
		protected UStreamlineLibraryDLSSG(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053F2 RID: 21490
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineDLSSGBlueprint.StreamlineLibraryDLSSG";

		// Token: 0x040053F3 RID: 21491
		private static IntPtr _ClassPtr;

		// Token: 0x040053F4 RID: 21492
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
