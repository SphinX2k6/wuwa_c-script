using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001323 RID: 4899
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FApplyRootMotionConstantForceDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060120BA RID: 73914 RVA: 0x001A7F4E File Offset: 0x001A614E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FApplyRootMotionConstantForceDelegate.StaticFunctionPtr();
		}

		// Token: 0x060120BB RID: 73915 RVA: 0x001A7F5A File Offset: 0x001A615A
		private static IntPtr StaticFunctionPtr()
		{
			if (FApplyRootMotionConstantForceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FApplyRootMotionConstantForceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.ApplyRootMotionConstantForceDelegate__DelegateSignature");
			}
			return FApplyRootMotionConstantForceDelegate._FunctionPtr;
		}

		// Token: 0x060120BC RID: 73916 RVA: 0x001A7F7D File Offset: 0x001A617D
		public FApplyRootMotionConstantForceDelegate()
		{
		}

		// Token: 0x060120BD RID: 73917 RVA: 0x001A7F85 File Offset: 0x001A6185
		[NullableContext(2)]
		public FApplyRootMotionConstantForceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120BE RID: 73918 RVA: 0x001A7F8F File Offset: 0x001A618F
		public FApplyRootMotionConstantForceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120BF RID: 73919 RVA: 0x001A7F9A File Offset: 0x001A619A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060120C0 RID: 73920 RVA: 0x001A7FCC File Offset: 0x001A61CC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FApplyRootMotionConstantForceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FApplyRootMotionConstantForceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FApplyRootMotionConstantForceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FApplyRootMotionConstantForceDelegate.OnScriptCallback));
				}
				FApplyRootMotionConstantForceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FApplyRootMotionConstantForceDelegate.RegisterId);
		}

		// Token: 0x060120C1 RID: 73921 RVA: 0x001A8006 File Offset: 0x001A6206
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060120C2 RID: 73922 RVA: 0x001A800F File Offset: 0x001A620F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060120C3 RID: 73923 RVA: 0x001A801C File Offset: 0x001A621C
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

		// Token: 0x04009A35 RID: 39477
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009A36 RID: 39478
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ApplyRootMotionConstantForceDelegate__DelegateSignature";

		// Token: 0x04009A37 RID: 39479
		private static int RegisterId;

		// Token: 0x02002E24 RID: 11812
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168B9 RID: 92345
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
