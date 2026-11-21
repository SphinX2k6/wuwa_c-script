using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E3 RID: 1251
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePerformanceManager")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroSequencePerformanceManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600760A RID: 30218 RVA: 0x000AC7DD File Offset: 0x000AA9DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequencePerformanceManager._ClassPtr;
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x000AC7EC File Offset: 0x000AA9EC
		public UKuroSequencePerformanceManager() : this(BuiltinUtils.AllocNativeUObject(UKuroSequencePerformanceManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x000AC814 File Offset: 0x000AAA14
		[NullableContext(1)]
		public UKuroSequencePerformanceManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequencePerformanceManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x000AC848 File Offset: 0x000AAA48
		[NullableContext(1)]
		public unsafe static void SimpleExecuteCommand(string Command)
		{
			FString fstring = FString.AllocTemp(Command);
			UKuroSequencePerformanceManager.__SimpleExecuteCommand_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600760E RID: 30222
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPerformanceMode(EKuroPerformanceMode CurrentPerformanceMode);

		// Token: 0x0600760F RID: 30223 RVA: 0x000AC86C File Offset: 0x000AAA6C
		[NullableContext(2)]
		public static void OpenKuroPerformanceModeInPhotographModel(UKuroSequenceConsoleCommandDataAsset PhotographModelDA)
		{
			UKuroSequencePerformanceManager.__OpenKuroPerformanceModeInPhotographModel_Internal((PhotographModelDA != null) ? PhotographModelDA.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x000AC883 File Offset: 0x000AAA83
		public void OpenKuroPerformanceModeInEditor()
		{
			UKuroSequencePerformanceManager.__OpenKuroPerformanceModeInEditor_Internal(base.NativePtr);
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x000AC890 File Offset: 0x000AAA90
		[NullableContext(2)]
		public static void OpenKuroPerformanceMode(ULevelSequence Sequence)
		{
			UKuroSequencePerformanceManager.__OpenKuroPerformanceMode_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007612 RID: 30226
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryDeviceInPerformance();

		// Token: 0x06007613 RID: 30227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalPhysicalMemoryInPerformance();

		// Token: 0x06007614 RID: 30228
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetShadowUpdateCVar();

		// Token: 0x06007615 RID: 30229
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EKuroPerformanceMode> GetPerformanceMode();

		// Token: 0x06007616 RID: 30230
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentFrameTime();

		// Token: 0x06007617 RID: 30231 RVA: 0x000AC8A8 File Offset: 0x000AAAA8
		[NullableContext(1)]
		public unsafe static void ExecuteCommandInPerformance(string Command)
		{
			FString fstring = FString.AllocTemp(Command);
			UKuroSequencePerformanceManager.__ExecuteCommandInPerformance_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x000AC8CC File Offset: 0x000AAACC
		public static void EditPerformanceConfiguration([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> CmdArray)
		{
			UKuroSequencePerformanceManager.__EditPerformanceConfiguration_Internal((CmdArray ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x000AC8E2 File Offset: 0x000AAAE2
		public void CloseKuroPerformanceModeInEditor()
		{
			UKuroSequencePerformanceManager.__CloseKuroPerformanceModeInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0600761A RID: 30234
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseKuroPerformanceMode();

		// Token: 0x0600761B RID: 30235
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AlwaysTriggered();

		// Token: 0x0600761C RID: 30236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleExecuteCommand_Internal(in FString Command);

		// Token: 0x0600761D RID: 30237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenKuroPerformanceModeInPhotographModel_Internal(IntPtr PhotographModelDA);

		// Token: 0x0600761E RID: 30238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenKuroPerformanceModeInEditor_Internal(IntPtr @this);

		// Token: 0x0600761F RID: 30239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenKuroPerformanceMode_Internal(IntPtr Sequence);

		// Token: 0x06007620 RID: 30240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteCommandInPerformance_Internal(in FString Command);

		// Token: 0x06007621 RID: 30241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditPerformanceConfiguration_Internal(IntPtr CmdArray);

		// Token: 0x06007622 RID: 30242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseKuroPerformanceModeInEditor_Internal(IntPtr @this);

		// Token: 0x06007623 RID: 30243 RVA: 0x000AC8EF File Offset: 0x000AAAEF
		static UKuroSequencePerformanceManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePerformanceManager");
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x000AC8FD File Offset: 0x000AAAFD
		protected UKuroSequencePerformanceManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031CA RID: 12746
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePerformanceManager";

		// Token: 0x040031CB RID: 12747
		private static IntPtr _ClassPtr;

		// Token: 0x040031CC RID: 12748
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
