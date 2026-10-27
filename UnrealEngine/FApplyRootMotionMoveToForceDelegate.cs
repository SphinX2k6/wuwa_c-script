using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001326 RID: 4902
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FApplyRootMotionMoveToForceDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060120D8 RID: 73944 RVA: 0x001A82D2 File Offset: 0x001A64D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FApplyRootMotionMoveToForceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060120D9 RID: 73945 RVA: 0x001A82DE File Offset: 0x001A64DE
		private static IntPtr StaticFunctionPtr()
		{
			if (FApplyRootMotionMoveToForceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FApplyRootMotionMoveToForceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.ApplyRootMotionMoveToForceDelegate__DelegateSignature");
			}
			return FApplyRootMotionMoveToForceDelegate._FunctionPtr;
		}

		// Token: 0x060120DA RID: 73946 RVA: 0x001A8301 File Offset: 0x001A6501
		public FApplyRootMotionMoveToForceDelegate()
		{
		}

		// Token: 0x060120DB RID: 73947 RVA: 0x001A8309 File Offset: 0x001A6509
		[NullableContext(2)]
		public FApplyRootMotionMoveToForceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120DC RID: 73948 RVA: 0x001A8313 File Offset: 0x001A6513
		public FApplyRootMotionMoveToForceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120DD RID: 73949 RVA: 0x001A831E File Offset: 0x001A651E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060120DE RID: 73950 RVA: 0x001A8350 File Offset: 0x001A6550
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FApplyRootMotionMoveToForceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FApplyRootMotionMoveToForceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FApplyRootMotionMoveToForceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FApplyRootMotionMoveToForceDelegate.OnScriptCallback));
				}
				FApplyRootMotionMoveToForceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FApplyRootMotionMoveToForceDelegate.RegisterId);
		}

		// Token: 0x060120DF RID: 73951 RVA: 0x001A838A File Offset: 0x001A658A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060120E0 RID: 73952 RVA: 0x001A8393 File Offset: 0x001A6593
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060120E1 RID: 73953 RVA: 0x001A83A0 File Offset: 0x001A65A0
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

		// Token: 0x04009A3E RID: 39486
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009A3F RID: 39487
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ApplyRootMotionMoveToForceDelegate__DelegateSignature";

		// Token: 0x04009A40 RID: 39488
		private static int RegisterId;

		// Token: 0x02002E28 RID: 11816
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168BF RID: 92351
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
