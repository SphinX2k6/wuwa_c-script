using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018B3 RID: 6323
	public sealed class FEffectSystemSetEffectView : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017652 RID: 95826 RVA: 0x0022344B File Offset: 0x0022164B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSystemSetEffectView.StaticFunctionPtr();
		}

		// Token: 0x06017653 RID: 95827 RVA: 0x00223457 File Offset: 0x00221657
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSystemSetEffectView._FunctionPtr == IntPtr.Zero)
			{
				FEffectSystemSetEffectView._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSystemSetEffectView__DelegateSignature");
			}
			return FEffectSystemSetEffectView._FunctionPtr;
		}

		// Token: 0x06017654 RID: 95828 RVA: 0x0022347A File Offset: 0x0022167A
		public FEffectSystemSetEffectView()
		{
		}

		// Token: 0x06017655 RID: 95829 RVA: 0x00223482 File Offset: 0x00221682
		[NullableContext(2)]
		public FEffectSystemSetEffectView(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017656 RID: 95830 RVA: 0x0022348C File Offset: 0x0022168C
		public FEffectSystemSetEffectView(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017657 RID: 95831 RVA: 0x00223497 File Offset: 0x00221697
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<AActor, int>) ?? ((Action<AActor, int>)Delegate.CreateDelegate(typeof(Action<AActor, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017658 RID: 95832 RVA: 0x002234C9 File Offset: 0x002216C9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, int> Callback)
		{
			if (FEffectSystemSetEffectView.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectSystemSetEffectView.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectSystemSetEffectView.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectSystemSetEffectView.OnScriptCallback));
				}
				FEffectSystemSetEffectView.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectSystemSetEffectView.RegisterId);
		}

		// Token: 0x06017659 RID: 95833 RVA: 0x00223504 File Offset: 0x00221704
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(AActor Actor, int EffectId)
		{
			FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams* ptr = stackalloc FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectSystemSetEffectView.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->EffectId = EffectId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601765A RID: 95834 RVA: 0x00223558 File Offset: 0x00221758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, int> action = target as Action<AActor, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer, ((FEffectSystemSetEffectView.__FEffectSystemSetEffectView_DelegateParams*)__Parameters)->EffectId);
		}

		// Token: 0x0400CB7F RID: 52095
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CB80 RID: 52096
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSystemSetEffectView__DelegateSignature";

		// Token: 0x0400CB81 RID: 52097
		private static int RegisterId;

		// Token: 0x02002FAB RID: 12203
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FEffectSystemSetEffectView_DelegateParams
		{
			// Token: 0x04016B8D RID: 93069
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04016B8E RID: 93070
			[FieldOffset(8)]
			public int EffectId;
		}

		// Token: 0x02002FAC RID: 12204
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B8F RID: 93071
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
