using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D40 RID: 3392
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLevelStreamingVisibilityStatus : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B5C5 RID: 46533 RVA: 0x00103543 File Offset: 0x00101743
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLevelStreamingVisibilityStatus.StaticFunctionPtr();
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x0010354F File Offset: 0x0010174F
		private static IntPtr StaticFunctionPtr()
		{
			if (FLevelStreamingVisibilityStatus._FunctionPtr == IntPtr.Zero)
			{
				FLevelStreamingVisibilityStatus._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature");
			}
			return FLevelStreamingVisibilityStatus._FunctionPtr;
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x00103572 File Offset: 0x00101772
		public FLevelStreamingVisibilityStatus()
		{
		}

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x0010357A File Offset: 0x0010177A
		[NullableContext(2)]
		public FLevelStreamingVisibilityStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x00103584 File Offset: 0x00101784
		public FLevelStreamingVisibilityStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5CA RID: 46538 RVA: 0x0010358F File Offset: 0x0010178F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B5CB RID: 46539 RVA: 0x001035C1 File Offset: 0x001017C1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FLevelStreamingVisibilityStatus.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLevelStreamingVisibilityStatus.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLevelStreamingVisibilityStatus.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLevelStreamingVisibilityStatus.OnScriptCallback));
				}
				FLevelStreamingVisibilityStatus.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FLevelStreamingVisibilityStatus.RegisterId);
		}

		// Token: 0x0600B5CC RID: 46540 RVA: 0x001035FB File Offset: 0x001017FB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B5CD RID: 46541 RVA: 0x00103604 File Offset: 0x00101804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x00103610 File Offset: 0x00101810
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

		// Token: 0x04005F87 RID: 24455
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005F88 RID: 24456
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature";

		// Token: 0x04005F89 RID: 24457
		private static int RegisterId;

		// Token: 0x02002D3F RID: 11583
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016743 RID: 91971
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
