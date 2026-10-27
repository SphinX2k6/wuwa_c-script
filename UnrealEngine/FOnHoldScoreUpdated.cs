using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C69 RID: 7273
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldScoreUpdated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C344 RID: 115524 RVA: 0x002993C0 File Offset: 0x002975C0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldScoreUpdated.StaticFunctionPtr();
		}

		// Token: 0x0601C345 RID: 115525 RVA: 0x002993CC File Offset: 0x002975CC
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldScoreUpdated._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldScoreUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldScoreUpdated__DelegateSignature");
			}
			return FOnHoldScoreUpdated._FunctionPtr;
		}

		// Token: 0x0601C346 RID: 115526 RVA: 0x002993EF File Offset: 0x002975EF
		public FOnHoldScoreUpdated()
		{
		}

		// Token: 0x0601C347 RID: 115527 RVA: 0x002993F7 File Offset: 0x002975F7
		[NullableContext(2)]
		public FOnHoldScoreUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C348 RID: 115528 RVA: 0x00299401 File Offset: 0x00297601
		public FOnHoldScoreUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C349 RID: 115529 RVA: 0x0029940C File Offset: 0x0029760C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C34A RID: 115530 RVA: 0x0029943E File Offset: 0x0029763E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnHoldScoreUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHoldScoreUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHoldScoreUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHoldScoreUpdated.OnScriptCallback));
				}
				FOnHoldScoreUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHoldScoreUpdated.RegisterId);
		}

		// Token: 0x0601C34B RID: 115531 RVA: 0x00299478 File Offset: 0x00297678
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C34C RID: 115532 RVA: 0x00299484 File Offset: 0x00297684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int ScoreGained, int CurrentBeat)
		{
			FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams* ptr = stackalloc FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHoldScoreUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ScoreGained = ScoreGained;
			ptr->CurrentBeat = CurrentBeat;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C34D RID: 115533 RVA: 0x002994C8 File Offset: 0x002976C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams*)__Parameters)->ScoreGained, ((FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams*)__Parameters)->CurrentBeat);
		}

		// Token: 0x0400F2BF RID: 62143
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2C0 RID: 62144
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldScoreUpdated__DelegateSignature";

		// Token: 0x0400F2C1 RID: 62145
		private static int RegisterId;

		// Token: 0x02003200 RID: 12800
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnHoldScoreUpdated_DelegateParams
		{
			// Token: 0x0401705D RID: 94301
			[FieldOffset(0)]
			public int ScoreGained;

			// Token: 0x0401705E RID: 94302
			[FieldOffset(4)]
			public int CurrentBeat;
		}

		// Token: 0x02003201 RID: 12801
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401705F RID: 94303
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
