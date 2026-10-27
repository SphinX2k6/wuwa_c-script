using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020F7 RID: 8439
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnUndeterminedClicked : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FC3B RID: 130107 RVA: 0x002F3CEA File Offset: 0x002F1EEA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnUndeterminedClicked.StaticFunctionPtr();
		}

		// Token: 0x0601FC3C RID: 130108 RVA: 0x002F3CF6 File Offset: 0x002F1EF6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnUndeterminedClicked._FunctionPtr == IntPtr.Zero)
			{
				FOnUndeterminedClicked._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnUndeterminedClicked__DelegateSignature");
			}
			return FOnUndeterminedClicked._FunctionPtr;
		}

		// Token: 0x0601FC3D RID: 130109 RVA: 0x002F3D19 File Offset: 0x002F1F19
		public FOnUndeterminedClicked()
		{
		}

		// Token: 0x0601FC3E RID: 130110 RVA: 0x002F3D21 File Offset: 0x002F1F21
		[NullableContext(2)]
		public FOnUndeterminedClicked(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC3F RID: 130111 RVA: 0x002F3D2B File Offset: 0x002F1F2B
		public FOnUndeterminedClicked(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC40 RID: 130112 RVA: 0x002F3D36 File Offset: 0x002F1F36
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FC41 RID: 130113 RVA: 0x002F3D68 File Offset: 0x002F1F68
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnUndeterminedClicked.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnUndeterminedClicked.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnUndeterminedClicked.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnUndeterminedClicked.OnScriptCallback));
				}
				FOnUndeterminedClicked.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnUndeterminedClicked.RegisterId);
		}

		// Token: 0x0601FC42 RID: 130114 RVA: 0x002F3DA2 File Offset: 0x002F1FA2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601FC43 RID: 130115 RVA: 0x002F3DAB File Offset: 0x002F1FAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601FC44 RID: 130116 RVA: 0x002F3DB8 File Offset: 0x002F1FB8
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

		// Token: 0x040111F2 RID: 70130
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111F3 RID: 70131
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnUndeterminedClicked__DelegateSignature";

		// Token: 0x040111F4 RID: 70132
		private static int RegisterId;

		// Token: 0x020034DF RID: 13535
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174F3 RID: 95475
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
