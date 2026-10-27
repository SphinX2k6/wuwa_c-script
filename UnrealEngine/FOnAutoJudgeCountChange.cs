using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C61 RID: 7265
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAutoJudgeCountChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C2F4 RID: 115444 RVA: 0x002989C6 File Offset: 0x00296BC6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAutoJudgeCountChange.StaticFunctionPtr();
		}

		// Token: 0x0601C2F5 RID: 115445 RVA: 0x002989D2 File Offset: 0x00296BD2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAutoJudgeCountChange._FunctionPtr == IntPtr.Zero)
			{
				FOnAutoJudgeCountChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnAutoJudgeCountChange__DelegateSignature");
			}
			return FOnAutoJudgeCountChange._FunctionPtr;
		}

		// Token: 0x0601C2F6 RID: 115446 RVA: 0x002989F5 File Offset: 0x00296BF5
		public FOnAutoJudgeCountChange()
		{
		}

		// Token: 0x0601C2F7 RID: 115447 RVA: 0x002989FD File Offset: 0x00296BFD
		[NullableContext(2)]
		public FOnAutoJudgeCountChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C2F8 RID: 115448 RVA: 0x00298A07 File Offset: 0x00296C07
		public FOnAutoJudgeCountChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C2F9 RID: 115449 RVA: 0x00298A12 File Offset: 0x00296C12
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C2FA RID: 115450 RVA: 0x00298A44 File Offset: 0x00296C44
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FOnAutoJudgeCountChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAutoJudgeCountChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAutoJudgeCountChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAutoJudgeCountChange.OnScriptCallback));
				}
				FOnAutoJudgeCountChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAutoJudgeCountChange.RegisterId);
		}

		// Token: 0x0601C2FB RID: 115451 RVA: 0x00298A7E File Offset: 0x00296C7E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C2FC RID: 115452 RVA: 0x00298A88 File Offset: 0x00296C88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int RemainCount)
		{
			FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams* ptr = stackalloc FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAutoJudgeCountChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RemainCount = RemainCount;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C2FD RID: 115453 RVA: 0x00298AC4 File Offset: 0x00296CC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAutoJudgeCountChange.__FOnAutoJudgeCountChange_DelegateParams*)__Parameters)->RemainCount);
		}

		// Token: 0x0400F2A7 RID: 62119
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2A8 RID: 62120
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnAutoJudgeCountChange__DelegateSignature";

		// Token: 0x0400F2A9 RID: 62121
		private static int RegisterId;

		// Token: 0x020031F2 RID: 12786
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnAutoJudgeCountChange_DelegateParams
		{
			// Token: 0x0401704C RID: 94284
			[FieldOffset(0)]
			public int RemainCount;
		}

		// Token: 0x020031F3 RID: 12787
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401704D RID: 94285
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
