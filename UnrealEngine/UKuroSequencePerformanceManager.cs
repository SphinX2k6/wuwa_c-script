using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BB9 RID: 7097
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePerformanceManager")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroSequencePerformanceManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B28B RID: 111243 RVA: 0x00280596 File Offset: 0x0027E796
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequencePerformanceManager._ClassPtr;
		}

		// Token: 0x0601B28C RID: 111244 RVA: 0x002805A4 File Offset: 0x0027E7A4
		public UKuroSequencePerformanceManager() : this(BuiltinUtils.AllocNativeUObject(UKuroSequencePerformanceManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B28D RID: 111245 RVA: 0x002805CC File Offset: 0x0027E7CC
		[NullableContext(1)]
		public UKuroSequencePerformanceManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequencePerformanceManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B28E RID: 111246 RVA: 0x00280600 File Offset: 0x0027E800
		[NullableContext(1)]
		public unsafe static void SimpleExecuteCommand(string Command)
		{
			FString fstring = FString.AllocTemp(Command);
			UKuroSequencePerformanceManager.__SimpleExecuteCommand_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601B28F RID: 111247
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPerformanceMode(EKuroPerformanceMode CurrentPerformanceMode);

		// Token: 0x0601B290 RID: 111248 RVA: 0x00280624 File Offset: 0x0027E824
		[NullableContext(2)]
		public static void OpenKuroPerformanceModeInPhotographModel(UKuroSequenceConsoleCommandDataAsset PhotographModelDA)
		{
			UKuroSequencePerformanceManager.__OpenKuroPerformanceModeInPhotographModel_Internal((PhotographModelDA != null) ? PhotographModelDA.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B291 RID: 111249 RVA: 0x0028063B File Offset: 0x0027E83B
		public void OpenKuroPerformanceModeInEditor()
		{
			UKuroSequencePerformanceManager.__OpenKuroPerformanceModeInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0601B292 RID: 111250 RVA: 0x00280648 File Offset: 0x0027E848
		[NullableContext(2)]
		public static void OpenKuroPerformanceMode(ULevelSequence Sequence)
		{
			UKuroSequencePerformanceManager.__OpenKuroPerformanceMode_Internal((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B293 RID: 111251
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLowMemoryDeviceInPerformance();

		// Token: 0x0601B294 RID: 111252
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalPhysicalMemoryInPerformance();

		// Token: 0x0601B295 RID: 111253
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetShadowUpdateCVar();

		// Token: 0x0601B296 RID: 111254
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EKuroPerformanceMode> GetPerformanceMode();

		// Token: 0x0601B297 RID: 111255
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentFrameTime();

		// Token: 0x0601B298 RID: 111256 RVA: 0x00280660 File Offset: 0x0027E860
		[NullableContext(1)]
		public unsafe static void ExecuteCommandInPerformance(string Command)
		{
			FString fstring = FString.AllocTemp(Command);
			UKuroSequencePerformanceManager.__ExecuteCommandInPerformance_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601B299 RID: 111257 RVA: 0x00280684 File Offset: 0x0027E884
		public static void EditPerformanceConfiguration([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> CmdArray)
		{
			UKuroSequencePerformanceManager.__EditPerformanceConfiguration_Internal((CmdArray ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0601B29A RID: 111258 RVA: 0x0028069A File Offset: 0x0027E89A
		public void CloseKuroPerformanceModeInEditor()
		{
			UKuroSequencePerformanceManager.__CloseKuroPerformanceModeInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0601B29B RID: 111259
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseKuroPerformanceMode();

		// Token: 0x0601B29C RID: 111260 RVA: 0x002806A7 File Offset: 0x0027E8A7
		[NullableContext(2)]
		public static void ApplyVolumetricFogHighQualityMode(UObject WorldContextObject, UExponentialHeightFogComponent HeightFog)
		{
			UKuroSequencePerformanceManager.__ApplyVolumetricFogHighQualityMode_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (HeightFog != null) ? HeightFog.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B29D RID: 111261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AlwaysTriggered();

		// Token: 0x0601B29E RID: 111262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleExecuteCommand_Internal(in FString Command);

		// Token: 0x0601B29F RID: 111263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenKuroPerformanceModeInPhotographModel_Internal(IntPtr PhotographModelDA);

		// Token: 0x0601B2A0 RID: 111264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenKuroPerformanceModeInEditor_Internal(IntPtr @this);

		// Token: 0x0601B2A1 RID: 111265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenKuroPerformanceMode_Internal(IntPtr Sequence);

		// Token: 0x0601B2A2 RID: 111266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteCommandInPerformance_Internal(in FString Command);

		// Token: 0x0601B2A3 RID: 111267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditPerformanceConfiguration_Internal(IntPtr CmdArray);

		// Token: 0x0601B2A4 RID: 111268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseKuroPerformanceModeInEditor_Internal(IntPtr @this);

		// Token: 0x0601B2A5 RID: 111269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyVolumetricFogHighQualityMode_Internal(IntPtr WorldContextObject, IntPtr HeightFog);

		// Token: 0x0601B2A6 RID: 111270 RVA: 0x002806CE File Offset: 0x0027E8CE
		static UKuroSequencePerformanceManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePerformanceManager");
		}

		// Token: 0x0601B2A7 RID: 111271 RVA: 0x002806DC File Offset: 0x0027E8DC
		protected UKuroSequencePerformanceManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EA07 RID: 59911
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSequencePerformanceManager";

		// Token: 0x0400EA08 RID: 59912
		private static IntPtr _ClassPtr;

		// Token: 0x0400EA09 RID: 59913
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
