using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C1E RID: 7198
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FParameterChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BC65 RID: 113765 RVA: 0x0028E324 File Offset: 0x0028C524
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FParameterChanged.StaticFunctionPtr();
		}

		// Token: 0x0601BC66 RID: 113766 RVA: 0x0028E330 File Offset: 0x0028C530
		private static IntPtr StaticFunctionPtr()
		{
			if (FParameterChanged._FunctionPtr == IntPtr.Zero)
			{
				FParameterChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.ParameterChanged__DelegateSignature");
			}
			return FParameterChanged._FunctionPtr;
		}

		// Token: 0x0601BC67 RID: 113767 RVA: 0x0028E353 File Offset: 0x0028C553
		public FParameterChanged()
		{
		}

		// Token: 0x0601BC68 RID: 113768 RVA: 0x0028E35B File Offset: 0x0028C55B
		[NullableContext(2)]
		public FParameterChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BC69 RID: 113769 RVA: 0x0028E365 File Offset: 0x0028C565
		public FParameterChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BC6A RID: 113770 RVA: 0x0028E370 File Offset: 0x0028C570
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BC6B RID: 113771 RVA: 0x0028E3A2 File Offset: 0x0028C5A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FParameterChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FParameterChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FParameterChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FParameterChanged.OnScriptCallback));
				}
				FParameterChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FParameterChanged.RegisterId);
		}

		// Token: 0x0601BC6C RID: 113772 RVA: 0x0028E3DC File Offset: 0x0028C5DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BC6D RID: 113773 RVA: 0x0028E3E5 File Offset: 0x0028C5E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601BC6E RID: 113774 RVA: 0x0028E3F0 File Offset: 0x0028C5F0
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

		// Token: 0x0400EEE4 RID: 61156
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EEE5 RID: 61157
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.ParameterChanged__DelegateSignature";

		// Token: 0x0400EEE6 RID: 61158
		private static int RegisterId;

		// Token: 0x020031A5 RID: 12709
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FE4 RID: 94180
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
