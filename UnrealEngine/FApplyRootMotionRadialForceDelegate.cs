using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001327 RID: 4903
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FApplyRootMotionRadialForceDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060120E2 RID: 73954 RVA: 0x001A83E2 File Offset: 0x001A65E2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FApplyRootMotionRadialForceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060120E3 RID: 73955 RVA: 0x001A83EE File Offset: 0x001A65EE
		private static IntPtr StaticFunctionPtr()
		{
			if (FApplyRootMotionRadialForceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FApplyRootMotionRadialForceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.ApplyRootMotionRadialForceDelegate__DelegateSignature");
			}
			return FApplyRootMotionRadialForceDelegate._FunctionPtr;
		}

		// Token: 0x060120E4 RID: 73956 RVA: 0x001A8411 File Offset: 0x001A6611
		public FApplyRootMotionRadialForceDelegate()
		{
		}

		// Token: 0x060120E5 RID: 73957 RVA: 0x001A8419 File Offset: 0x001A6619
		[NullableContext(2)]
		public FApplyRootMotionRadialForceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120E6 RID: 73958 RVA: 0x001A8423 File Offset: 0x001A6623
		public FApplyRootMotionRadialForceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120E7 RID: 73959 RVA: 0x001A842E File Offset: 0x001A662E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060120E8 RID: 73960 RVA: 0x001A8460 File Offset: 0x001A6660
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FApplyRootMotionRadialForceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FApplyRootMotionRadialForceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FApplyRootMotionRadialForceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FApplyRootMotionRadialForceDelegate.OnScriptCallback));
				}
				FApplyRootMotionRadialForceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FApplyRootMotionRadialForceDelegate.RegisterId);
		}

		// Token: 0x060120E9 RID: 73961 RVA: 0x001A849A File Offset: 0x001A669A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060120EA RID: 73962 RVA: 0x001A84A3 File Offset: 0x001A66A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060120EB RID: 73963 RVA: 0x001A84B0 File Offset: 0x001A66B0
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

		// Token: 0x04009A41 RID: 39489
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009A42 RID: 39490
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ApplyRootMotionRadialForceDelegate__DelegateSignature";

		// Token: 0x04009A43 RID: 39491
		private static int RegisterId;

		// Token: 0x02002E29 RID: 11817
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168C0 RID: 92352
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
