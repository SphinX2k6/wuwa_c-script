using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200095C RID: 2396
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnInputTouchBeginSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008776 RID: 34678 RVA: 0x000C1CF6 File Offset: 0x000BFEF6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnInputTouchBeginSignature.StaticFunctionPtr();
		}

		// Token: 0x06008777 RID: 34679 RVA: 0x000C1D02 File Offset: 0x000BFF02
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnInputTouchBeginSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnInputTouchBeginSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature");
			}
			return FComponentOnInputTouchBeginSignature._FunctionPtr;
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06008778 RID: 34680 RVA: 0x000C1D25 File Offset: 0x000BFF25
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchBegin;
			}
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x000C1D2C File Offset: 0x000BFF2C
		[NullableContext(2)]
		public FComponentOnInputTouchBeginSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x000C1D36 File Offset: 0x000BFF36
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600877B RID: 34683 RVA: 0x000C1D68 File Offset: 0x000BFF68
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentOnInputTouchBeginSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentOnInputTouchBeginSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentOnInputTouchBeginSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentOnInputTouchBeginSignature.OnScriptCallback));
				}
				FComponentOnInputTouchBeginSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentOnInputTouchBeginSignature.RegisterId);
		}

		// Token: 0x0600877C RID: 34684 RVA: 0x000C1DB8 File Offset: 0x000BFFB8
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

		// Token: 0x0600877D RID: 34685 RVA: 0x000C1DD8 File Offset: 0x000BFFD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams* ptr = stackalloc FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentOnInputTouchBeginSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x000C1E40 File Offset: 0x000C0040
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
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentOnInputTouchBeginSignature.__FComponentOnInputTouchBeginSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400406C RID: 16492
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400406D RID: 16493
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnInputTouchBeginSignature__DelegateSignature";

		// Token: 0x0400406E RID: 16494
		private static int RegisterId;

		// Token: 0x02002CD5 RID: 11477
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FComponentOnInputTouchBeginSignature_DelegateParams
		{
			// Token: 0x0401667E RID: 91774
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0401667F RID: 91775
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02002CD6 RID: 11478
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016680 RID: 91776
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
