using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028CE RID: 10446
	[UnrealObjectPath("/Script/StreamlineDLSSGBlueprint.StreamlineLibraryDLSSG")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStreamlineLibraryDLSSG : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C41 RID: 158785 RVA: 0x003B220B File Offset: 0x003B040B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineLibraryDLSSG._ClassPtr;
		}

		// Token: 0x06026C42 RID: 158786 RVA: 0x003B2218 File Offset: 0x003B0418
		public UStreamlineLibraryDLSSG() : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryDLSSG.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C43 RID: 158787 RVA: 0x003B2240 File Offset: 0x003B0440
		[NullableContext(1)]
		public UStreamlineLibraryDLSSG(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineLibraryDLSSG.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026C44 RID: 158788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDLSSGMode(EStreamlineDLSSGMode DLSSGMode);

		// Token: 0x06026C45 RID: 158789
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineFeatureSupport QueryDLSSGSupport();

		// Token: 0x06026C46 RID: 158790
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSGSupported();

		// Token: 0x06026C47 RID: 158791
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDLSSGModeSupported(EStreamlineDLSSGMode DLSSGMode);

		// Token: 0x06026C48 RID: 158792 RVA: 0x003B2273 File Offset: 0x003B0473
		[NullableContext(1)]
		public static TArray<EStreamlineDLSSGMode> GetSupportedDLSSGModes()
		{
			return new TArray<EStreamlineDLSSGMode>(UStreamlineLibraryDLSSG.__GetSupportedDLSSGModes_Internal(), null);
		}

		// Token: 0x06026C49 RID: 158793
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineDLSSGMode GetDLSSGMode();

		// Token: 0x06026C4A RID: 158794
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDLSSGFrameTiming(ref float FrameRateInHertz, ref int FramesPresented);

		// Token: 0x06026C4B RID: 158795
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EStreamlineDLSSGMode GetDefaultDLSSGMode();

		// Token: 0x06026C4C RID: 158796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedDLSSGModes_Internal();

		// Token: 0x06026C4D RID: 158797 RVA: 0x003B2280 File Offset: 0x003B0480
		static UStreamlineLibraryDLSSG()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineDLSSGBlueprint.StreamlineLibraryDLSSG");
		}

		// Token: 0x06026C4E RID: 158798 RVA: 0x003B228E File Offset: 0x003B048E
		protected UStreamlineLibraryDLSSG(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015477 RID: 87159
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineDLSSGBlueprint.StreamlineLibraryDLSSG";

		// Token: 0x04015478 RID: 87160
		private static IntPtr _ClassPtr;

		// Token: 0x04015479 RID: 87161
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
