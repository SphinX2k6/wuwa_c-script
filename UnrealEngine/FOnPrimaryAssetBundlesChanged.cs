using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F20 RID: 3872
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPrimaryAssetBundlesChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D121 RID: 53537 RVA: 0x00131E57 File Offset: 0x00130057
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPrimaryAssetBundlesChanged.StaticFunctionPtr();
		}

		// Token: 0x0600D122 RID: 53538 RVA: 0x00131E63 File Offset: 0x00130063
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPrimaryAssetBundlesChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnPrimaryAssetBundlesChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnPrimaryAssetBundlesChanged__DelegateSignature");
			}
			return FOnPrimaryAssetBundlesChanged._FunctionPtr;
		}

		// Token: 0x0600D123 RID: 53539 RVA: 0x00131E86 File Offset: 0x00130086
		public FOnPrimaryAssetBundlesChanged()
		{
		}

		// Token: 0x0600D124 RID: 53540 RVA: 0x00131E8E File Offset: 0x0013008E
		[NullableContext(2)]
		public FOnPrimaryAssetBundlesChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D125 RID: 53541 RVA: 0x00131E98 File Offset: 0x00130098
		public FOnPrimaryAssetBundlesChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D126 RID: 53542 RVA: 0x00131EA3 File Offset: 0x001300A3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D127 RID: 53543 RVA: 0x00131ED5 File Offset: 0x001300D5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnPrimaryAssetBundlesChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPrimaryAssetBundlesChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPrimaryAssetBundlesChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPrimaryAssetBundlesChanged.OnScriptCallback));
				}
				FOnPrimaryAssetBundlesChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPrimaryAssetBundlesChanged.RegisterId);
		}

		// Token: 0x0600D128 RID: 53544 RVA: 0x00131F0F File Offset: 0x0013010F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D129 RID: 53545 RVA: 0x00131F18 File Offset: 0x00130118
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600D12A RID: 53546 RVA: 0x00131F24 File Offset: 0x00130124
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

		// Token: 0x0400706E RID: 28782
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400706F RID: 28783
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnPrimaryAssetBundlesChanged__DelegateSignature";

		// Token: 0x04007070 RID: 28784
		private static int RegisterId;

		// Token: 0x02002D88 RID: 11656
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167AC RID: 92076
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
