using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200095D RID: 2397
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnInputTouchEndSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600877F RID: 34687 RVA: 0x000C1E97 File Offset: 0x000C0097
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnInputTouchEndSignature.StaticFunctionPtr();
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x000C1EA3 File Offset: 0x000C00A3
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnInputTouchEndSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnInputTouchEndSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature");
			}
			return FComponentOnInputTouchEndSignature._FunctionPtr;
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06008781 RID: 34689 RVA: 0x000C1EC6 File Offset: 0x000C00C6
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnd;
			}
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x000C1ECD File Offset: 0x000C00CD
		[NullableContext(2)]
		public FComponentOnInputTouchEndSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x000C1ED7 File Offset: 0x000C00D7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x000C1F0C File Offset: 0x000C010C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentOnInputTouchEndSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentOnInputTouchEndSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentOnInputTouchEndSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentOnInputTouchEndSignature.OnScriptCallback));
				}
				FComponentOnInputTouchEndSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentOnInputTouchEndSignature.RegisterId);
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x000C1F5C File Offset: 0x000C015C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x000C1F7C File Offset: 0x000C017C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams* ptr = stackalloc FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentOnInputTouchEndSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x000C1FE4 File Offset: 0x000C01E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> action = target as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentOnInputTouchEndSignature.__FComponentOnInputTouchEndSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400406F RID: 16495
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004070 RID: 16496
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnInputTouchEndSignature__DelegateSignature";

		// Token: 0x04004071 RID: 16497
		private static int RegisterId;

		// Token: 0x02002CD7 RID: 11479
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FComponentOnInputTouchEndSignature_DelegateParams
		{
			// Token: 0x04016681 RID: 91777
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04016682 RID: 91778
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02002CD8 RID: 11480
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016683 RID: 91779
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
