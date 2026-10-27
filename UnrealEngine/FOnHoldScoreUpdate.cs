using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C68 RID: 7272
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldScoreUpdate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C33A RID: 115514 RVA: 0x0029926A File Offset: 0x0029746A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldScoreUpdate.StaticFunctionPtr();
		}

		// Token: 0x0601C33B RID: 115515 RVA: 0x00299276 File Offset: 0x00297476
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldScoreUpdate._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldScoreUpdate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldScoreUpdate__DelegateSignature");
			}
			return FOnHoldScoreUpdate._FunctionPtr;
		}

		// Token: 0x0601C33C RID: 115516 RVA: 0x00299299 File Offset: 0x00297499
		public FOnHoldScoreUpdate()
		{
		}

		// Token: 0x0601C33D RID: 115517 RVA: 0x002992A1 File Offset: 0x002974A1
		[NullableContext(2)]
		public FOnHoldScoreUpdate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C33E RID: 115518 RVA: 0x002992AB File Offset: 0x002974AB
		public FOnHoldScoreUpdate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C33F RID: 115519 RVA: 0x002992B6 File Offset: 0x002974B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C340 RID: 115520 RVA: 0x002992E8 File Offset: 0x002974E8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnHoldScoreUpdate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHoldScoreUpdate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHoldScoreUpdate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHoldScoreUpdate.OnScriptCallback));
				}
				FOnHoldScoreUpdate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHoldScoreUpdate.RegisterId);
		}

		// Token: 0x0601C341 RID: 115521 RVA: 0x00299322 File Offset: 0x00297522
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C342 RID: 115522 RVA: 0x0029932C File Offset: 0x0029752C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int ScoreGained, int CurrentBeat)
		{
			FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams* ptr = stackalloc FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHoldScoreUpdate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ScoreGained = ScoreGained;
			ptr->CurrentBeat = CurrentBeat;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C343 RID: 115523 RVA: 0x00299370 File Offset: 0x00297570
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
			action(((FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams*)__Parameters)->ScoreGained, ((FOnHoldScoreUpdate.__FOnHoldScoreUpdate_DelegateParams*)__Parameters)->CurrentBeat);
		}

		// Token: 0x0400F2BC RID: 62140
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2BD RID: 62141
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldScoreUpdate__DelegateSignature";

		// Token: 0x0400F2BE RID: 62142
		private static int RegisterId;

		// Token: 0x020031FE RID: 12798
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnHoldScoreUpdate_DelegateParams
		{
			// Token: 0x0401705A RID: 94298
			[FieldOffset(0)]
			public int ScoreGained;

			// Token: 0x0401705B RID: 94299
			[FieldOffset(4)]
			public int CurrentBeat;
		}

		// Token: 0x020031FF RID: 12799
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401705C RID: 94300
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
