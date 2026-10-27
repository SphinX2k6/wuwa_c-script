using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002AA0 RID: 10912
	[UnrealObjectPath("/Script/XeLLBlueprint.XeLLBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UXeLLBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028376 RID: 164726 RVA: 0x003D2CCB File Offset: 0x003D0ECB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXeLLBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06028377 RID: 164727 RVA: 0x003D2CD8 File Offset: 0x003D0ED8
		public UXeLLBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UXeLLBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028378 RID: 164728 RVA: 0x003D2D00 File Offset: 0x003D0F00
		[NullableContext(1)]
		public UXeLLBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXeLLBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06028379 RID: 164729
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetXeLLMode(EXeLLMode Mode);

		// Token: 0x0602837A RID: 164730
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFlashIndicatorEnabled(bool bEnabled);

		// Token: 0x0602837B RID: 164731
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsXeLLSupported();

		// Token: 0x0602837C RID: 164732
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsXeLLAvailable();

		// Token: 0x0602837D RID: 164733
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EXeLLMode GetXeLLMode();

		// Token: 0x0602837E RID: 164734 RVA: 0x003D2D33 File Offset: 0x003D0F33
		[NullableContext(1)]
		public static TArray<EXeLLMode> GetSupportedXeLLModes()
		{
			return new TArray<EXeLLMode>(UXeLLBlueprintLibrary.__GetSupportedXeLLModes_Internal(), null);
		}

		// Token: 0x0602837F RID: 164735
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetSimulationLatencyInMs();

		// Token: 0x06028380 RID: 164736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRenderSubmitLatencyInMs();

		// Token: 0x06028381 RID: 164737
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetRenderLatencyInMs();

		// Token: 0x06028382 RID: 164738
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPresentLatencyInMs();

		// Token: 0x06028383 RID: 164739
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetLatencyMarkEnabled();

		// Token: 0x06028384 RID: 164740
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetInputLatencyInMs();

		// Token: 0x06028385 RID: 164741
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameToRenderLatencyInMs();

		// Token: 0x06028386 RID: 164742
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetGameLatencyInMs();

		// Token: 0x06028387 RID: 164743
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetFlashIndicatorEnabled();

		// Token: 0x06028388 RID: 164744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedXeLLModes_Internal();

		// Token: 0x06028389 RID: 164745 RVA: 0x003D2D40 File Offset: 0x003D0F40
		static UXeLLBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XeLLBlueprint.XeLLBlueprintLibrary");
		}

		// Token: 0x0602838A RID: 164746 RVA: 0x003D2D4E File Offset: 0x003D0F4E
		protected UXeLLBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160E2 RID: 90338
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/XeLLBlueprint.XeLLBlueprintLibrary";

		// Token: 0x040160E3 RID: 90339
		private static IntPtr _ClassPtr;

		// Token: 0x040160E4 RID: 90340
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
