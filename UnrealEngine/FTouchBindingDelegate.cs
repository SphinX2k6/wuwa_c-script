using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001941 RID: 6465
	public sealed class FTouchBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F66 RID: 98150 RVA: 0x002321BC File Offset: 0x002303BC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTouchBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x06017F67 RID: 98151 RVA: 0x002321C8 File Offset: 0x002303C8
		private static IntPtr StaticFunctionPtr()
		{
			if (FTouchBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTouchBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.TouchBindingDelegate__DelegateSignature");
			}
			return FTouchBindingDelegate._FunctionPtr;
		}

		// Token: 0x06017F68 RID: 98152 RVA: 0x002321EB File Offset: 0x002303EB
		public FTouchBindingDelegate()
		{
		}

		// Token: 0x06017F69 RID: 98153 RVA: 0x002321F3 File Offset: 0x002303F3
		[NullableContext(2)]
		public FTouchBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F6A RID: 98154 RVA: 0x002321FD File Offset: 0x002303FD
		public FTouchBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F6B RID: 98155 RVA: 0x00232208 File Offset: 0x00230408
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<TEnumAsByte<ETouchIndex>, FVector>) ?? ((Action<TEnumAsByte<ETouchIndex>, FVector>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F6C RID: 98156 RVA: 0x0023223A File Offset: 0x0023043A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<ETouchIndex>, FVector> Callback)
		{
			if (FTouchBindingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTouchBindingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTouchBindingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTouchBindingDelegate.OnScriptCallback));
				}
				FTouchBindingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTouchBindingDelegate.RegisterId);
		}

		// Token: 0x06017F6D RID: 98157 RVA: 0x00232274 File Offset: 0x00230474
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ETouchIndex TouchIndex, FVector Position)
		{
			FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams* ptr = stackalloc FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTouchBindingDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchIndex = TouchIndex;
			ptr->Position = Position;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017F6E RID: 98158 RVA: 0x002322C0 File Offset: 0x002304C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, FVector> action = target as Action<TEnumAsByte<ETouchIndex>, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams*)__Parameters)->TouchIndex, ((FTouchBindingDelegate.__FTouchBindingDelegate_DelegateParams*)__Parameters)->Position);
		}

		// Token: 0x0400CF6C RID: 53100
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF6D RID: 53101
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.TouchBindingDelegate__DelegateSignature";

		// Token: 0x0400CF6E RID: 53102
		private static int RegisterId;

		// Token: 0x0200300B RID: 12299
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FTouchBindingDelegate_DelegateParams
		{
			// Token: 0x04016C29 RID: 93225
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> TouchIndex;

			// Token: 0x04016C2A RID: 93226
			[FieldOffset(4)]
			public FVector Position;
		}

		// Token: 0x0200300C RID: 12300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C2B RID: 93227
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
