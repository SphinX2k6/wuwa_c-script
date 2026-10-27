using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200185E RID: 6238
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetAllocator")]
	[UnrealStructLayout(2048, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2048)]
	public class UGameBudgetAllocator : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016F2B RID: 93995 RVA: 0x00217C0E File Offset: 0x00215E0E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameBudgetAllocator._ClassPtr;
		}

		// Token: 0x06016F2C RID: 93996 RVA: 0x00217C1C File Offset: 0x00215E1C
		public UGameBudgetAllocator() : this(BuiltinUtils.AllocNativeUObject(UGameBudgetAllocator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016F2D RID: 93997 RVA: 0x00217C44 File Offset: 0x00215E44
		[NullableContext(1)]
		public UGameBudgetAllocator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameBudgetAllocator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016F2E RID: 93998 RVA: 0x00217C77 File Offset: 0x00215E77
		public void UpdateMinUpdateFIFOBudgetTime(float Time)
		{
			UGameBudgetAllocator.__UpdateMinUpdateFIFOBudgetTime_Internal(base.NativePtr, Time);
		}

		// Token: 0x06016F2F RID: 93999 RVA: 0x00217C85 File Offset: 0x00215E85
		public void TickOutside(float DeltaSeconds)
		{
			UGameBudgetAllocator.__TickOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06016F30 RID: 94000 RVA: 0x00217C93 File Offset: 0x00215E93
		public void SetTickIntervalDetailScreenRadiusConfig(ref FGameBudgetAllocatorGroupConfig Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorMode, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio)
		{
			UGameBudgetAllocator.__SetTickIntervalDetailScreenRadiusConfig_Internal(base.NativePtr, (Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, GlobalMode, ActorMode, TickReductionStartScreenRatio, TickReductionIntervalScreenRatio);
		}

		// Token: 0x06016F31 RID: 94001 RVA: 0x00217CB6 File Offset: 0x00215EB6
		public void SetTickIntervalDetailConfig(ref FGameBudgetAllocatorGroupConfig Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorMode, uint MaxTickInterval, ushort TickReductionStartSize, ushort TickReductionIntervalSize)
		{
			UGameBudgetAllocator.__SetTickIntervalDetailConfig_Internal(base.NativePtr, (Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, GlobalMode, ActorMode, MaxTickInterval, TickReductionStartSize, TickReductionIntervalSize);
		}

		// Token: 0x06016F32 RID: 94002 RVA: 0x00217CDB File Offset: 0x00215EDB
		public void SetPauseFrame(ulong Frame)
		{
			UGameBudgetAllocator.__SetPauseFrame_Internal(base.NativePtr, Frame);
		}

		// Token: 0x06016F33 RID: 94003 RVA: 0x00217CE9 File Offset: 0x00215EE9
		public void SetMaximumFrameRate(uint MaxFPS)
		{
			UGameBudgetAllocator.__SetMaximumFrameRate_Internal(base.NativePtr, MaxFPS);
		}

		// Token: 0x06016F34 RID: 94004 RVA: 0x00217CF7 File Offset: 0x00215EF7
		public void SetGroupConfig(FName GroupName, in FGameBudgetAllocatorGroupConfig Config)
		{
			UGameBudgetAllocator.__SetGroupConfig_Internal(base.NativePtr, GroupName, (Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr);
		}

		// Token: 0x06016F35 RID: 94005 RVA: 0x00217D15 File Offset: 0x00215F15
		public void SetGlobalMode(EGameBudgetAllocatorGlobalMode Mode)
		{
			UGameBudgetAllocator.__SetGlobalMode_Internal(base.NativePtr, Mode);
		}

		// Token: 0x06016F36 RID: 94006 RVA: 0x00217D23 File Offset: 0x00215F23
		public void SetDefaultTickIntervalDetailScreenRadiusConfig(ref FGameBudgetAllocatorGroupConfig Config, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio)
		{
			UGameBudgetAllocator.__SetDefaultTickIntervalDetailScreenRadiusConfig_Internal(base.NativePtr, (Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, TickReductionStartScreenRatio, TickReductionIntervalScreenRatio);
		}

		// Token: 0x06016F37 RID: 94007 RVA: 0x00217D42 File Offset: 0x00215F42
		public void SetDefaultTickIntervalDetailConfig(ref FGameBudgetAllocatorGroupConfig Config, uint MaxTickInterval, ushort TickReductionStartSize, ushort TickReductionIntervalSize)
		{
			UGameBudgetAllocator.__SetDefaultTickIntervalDetailConfig_Internal(base.NativePtr, (Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, MaxTickInterval, TickReductionStartSize, TickReductionIntervalSize);
		}

		// Token: 0x06016F38 RID: 94008 RVA: 0x00217D63 File Offset: 0x00215F63
		public void SetCenterActor(AActor CenterActor)
		{
			UGameBudgetAllocator.__SetCenterActor_Internal(base.NativePtr, (CenterActor != null) ? CenterActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016F39 RID: 94009 RVA: 0x00217D80 File Offset: 0x00215F80
		public void AfterTickOutside(float DeltaSeconds)
		{
			UGameBudgetAllocator.__AfterTickOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06016F3A RID: 94010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMinUpdateFIFOBudgetTime_Internal(IntPtr @this, float Time);

		// Token: 0x06016F3B RID: 94011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06016F3C RID: 94012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickIntervalDetailScreenRadiusConfig_Internal(IntPtr @this, IntPtr Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorMode, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio);

		// Token: 0x06016F3D RID: 94013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickIntervalDetailConfig_Internal(IntPtr @this, IntPtr Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorMode, uint MaxTickInterval, ushort TickReductionStartSize, ushort TickReductionIntervalSize);

		// Token: 0x06016F3E RID: 94014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPauseFrame_Internal(IntPtr @this, ulong Frame);

		// Token: 0x06016F3F RID: 94015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaximumFrameRate_Internal(IntPtr @this, uint MaxFPS);

		// Token: 0x06016F40 RID: 94016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupConfig_Internal(IntPtr @this, FName GroupName, IntPtr Config);

		// Token: 0x06016F41 RID: 94017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalMode_Internal(IntPtr @this, EGameBudgetAllocatorGlobalMode Mode);

		// Token: 0x06016F42 RID: 94018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultTickIntervalDetailScreenRadiusConfig_Internal(IntPtr @this, IntPtr Config, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio);

		// Token: 0x06016F43 RID: 94019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultTickIntervalDetailConfig_Internal(IntPtr @this, IntPtr Config, uint MaxTickInterval, ushort TickReductionStartSize, ushort TickReductionIntervalSize);

		// Token: 0x06016F44 RID: 94020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenterActor_Internal(IntPtr @this, IntPtr CenterActor);

		// Token: 0x06016F45 RID: 94021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AfterTickOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06016F46 RID: 94022 RVA: 0x00217D8E File Offset: 0x00215F8E
		static UGameBudgetAllocator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.GameBudgetAllocator");
		}

		// Token: 0x06016F47 RID: 94023 RVA: 0x00217D9C File Offset: 0x00215F9C
		protected UGameBudgetAllocator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C7A0 RID: 51104
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetAllocator";

		// Token: 0x0400C7A1 RID: 51105
		private static IntPtr _ClassPtr;

		// Token: 0x0400C7A2 RID: 51106
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
