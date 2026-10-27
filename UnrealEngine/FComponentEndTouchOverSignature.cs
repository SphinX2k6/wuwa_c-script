using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000957 RID: 2391
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentEndTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008741 RID: 34625 RVA: 0x000C15A4 File Offset: 0x000BF7A4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentEndTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x000C15B0 File Offset: 0x000BF7B0
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentEndTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentEndTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature");
			}
			return FComponentEndTouchOverSignature._FunctionPtr;
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06008743 RID: 34627 RVA: 0x000C15D3 File Offset: 0x000BF7D3
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchLeave;
			}
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x000C15DA File Offset: 0x000BF7DA
		[NullableContext(2)]
		public FComponentEndTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x000C15E4 File Offset: 0x000BF7E4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x000C1618 File Offset: 0x000BF818
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentEndTouchOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentEndTouchOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentEndTouchOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentEndTouchOverSignature.OnScriptCallback));
				}
				FComponentEndTouchOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentEndTouchOverSignature.RegisterId);
		}

		// Token: 0x06008747 RID: 34631 RVA: 0x000C1668 File Offset: 0x000BF868
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

		// Token: 0x06008748 RID: 34632 RVA: 0x000C1688 File Offset: 0x000BF888
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams* ptr = stackalloc FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentEndTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x000C16F0 File Offset: 0x000BF8F0
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
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentEndTouchOverSignature.__FComponentEndTouchOverSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400405A RID: 16474
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400405B RID: 16475
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentEndTouchOverSignature__DelegateSignature";

		// Token: 0x0400405C RID: 16476
		private static int RegisterId;

		// Token: 0x02002CCF RID: 11471
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FComponentEndTouchOverSignature_DelegateParams
		{
			// Token: 0x04016672 RID: 91762
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04016673 RID: 91763
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02002CD0 RID: 11472
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016674 RID: 91764
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
