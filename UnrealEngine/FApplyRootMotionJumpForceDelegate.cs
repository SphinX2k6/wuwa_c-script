using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001324 RID: 4900
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FApplyRootMotionJumpForceDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060120C4 RID: 73924 RVA: 0x001A805E File Offset: 0x001A625E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FApplyRootMotionJumpForceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060120C5 RID: 73925 RVA: 0x001A806A File Offset: 0x001A626A
		private static IntPtr StaticFunctionPtr()
		{
			if (FApplyRootMotionJumpForceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FApplyRootMotionJumpForceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.ApplyRootMotionJumpForceDelegate__DelegateSignature");
			}
			return FApplyRootMotionJumpForceDelegate._FunctionPtr;
		}

		// Token: 0x060120C6 RID: 73926 RVA: 0x001A808D File Offset: 0x001A628D
		public FApplyRootMotionJumpForceDelegate()
		{
		}

		// Token: 0x060120C7 RID: 73927 RVA: 0x001A8095 File Offset: 0x001A6295
		[NullableContext(2)]
		public FApplyRootMotionJumpForceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120C8 RID: 73928 RVA: 0x001A809F File Offset: 0x001A629F
		public FApplyRootMotionJumpForceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120C9 RID: 73929 RVA: 0x001A80AA File Offset: 0x001A62AA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060120CA RID: 73930 RVA: 0x001A80DC File Offset: 0x001A62DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FApplyRootMotionJumpForceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FApplyRootMotionJumpForceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FApplyRootMotionJumpForceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FApplyRootMotionJumpForceDelegate.OnScriptCallback));
				}
				FApplyRootMotionJumpForceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FApplyRootMotionJumpForceDelegate.RegisterId);
		}

		// Token: 0x060120CB RID: 73931 RVA: 0x001A8116 File Offset: 0x001A6316
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060120CC RID: 73932 RVA: 0x001A811F File Offset: 0x001A631F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060120CD RID: 73933 RVA: 0x001A812C File Offset: 0x001A632C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04009A38 RID: 39480
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009A39 RID: 39481
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ApplyRootMotionJumpForceDelegate__DelegateSignature";

		// Token: 0x04009A3A RID: 39482
		private static int RegisterId;

		// Token: 0x02002E25 RID: 11813
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168BA RID: 92346
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
