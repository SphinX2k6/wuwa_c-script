using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C64 RID: 7268
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C312 RID: 115474 RVA: 0x00298DAE File Offset: 0x00296FAE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameEvent.StaticFunctionPtr();
		}

		// Token: 0x0601C313 RID: 115475 RVA: 0x00298DBA File Offset: 0x00296FBA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnGameEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnGameEvent__DelegateSignature");
			}
			return FOnGameEvent._FunctionPtr;
		}

		// Token: 0x0601C314 RID: 115476 RVA: 0x00298DDD File Offset: 0x00296FDD
		public FOnGameEvent()
		{
		}

		// Token: 0x0601C315 RID: 115477 RVA: 0x00298DE5 File Offset: 0x00296FE5
		[NullableContext(2)]
		public FOnGameEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C316 RID: 115478 RVA: 0x00298DEF File Offset: 0x00296FEF
		public FOnGameEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C317 RID: 115479 RVA: 0x00298DFA File Offset: 0x00296FFA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EKuroRhythmChartEventType>) ?? ((Action<EKuroRhythmChartEventType>)Delegate.CreateDelegate(typeof(Action<EKuroRhythmChartEventType>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C318 RID: 115480 RVA: 0x00298E2C File Offset: 0x0029702C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EKuroRhythmChartEventType> Callback)
		{
			if (FOnGameEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameEvent.OnScriptCallback));
				}
				FOnGameEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameEvent.RegisterId);
		}

		// Token: 0x0601C319 RID: 115481 RVA: 0x00298E66 File Offset: 0x00297066
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EKuroRhythmChartEventType> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C31A RID: 115482 RVA: 0x00298E70 File Offset: 0x00297070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EKuroRhythmChartEventType EventType)
		{
			FOnGameEvent.__FOnGameEvent_DelegateParams* ptr = stackalloc FOnGameEvent.__FOnGameEvent_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnGameEvent.__FOnGameEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventType = EventType;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C31B RID: 115483 RVA: 0x00298EAC File Offset: 0x002970AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKuroRhythmChartEventType> action = target as Action<EKuroRhythmChartEventType>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnGameEvent.__FOnGameEvent_DelegateParams*)__Parameters)->EventType);
		}

		// Token: 0x0400F2B0 RID: 62128
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2B1 RID: 62129
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnGameEvent__DelegateSignature";

		// Token: 0x0400F2B2 RID: 62130
		private static int RegisterId;

		// Token: 0x020031F8 RID: 12792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnGameEvent_DelegateParams
		{
			// Token: 0x04017053 RID: 94291
			[FieldOffset(0)]
			public EKuroRhythmChartEventType EventType;
		}

		// Token: 0x020031F9 RID: 12793
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017054 RID: 94292
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
