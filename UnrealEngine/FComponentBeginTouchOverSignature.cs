using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000952 RID: 2386
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008716 RID: 34582 RVA: 0x000C0E16 File Offset: 0x000BF016
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x000C0E22 File Offset: 0x000BF022
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature");
			}
			return FComponentBeginTouchOverSignature._FunctionPtr;
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06008718 RID: 34584 RVA: 0x000C0E45 File Offset: 0x000BF045
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnter;
			}
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x000C0E4C File Offset: 0x000BF04C
		[NullableContext(2)]
		public FComponentBeginTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x000C0E56 File Offset: 0x000BF056
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x000C0E88 File Offset: 0x000BF088
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentBeginTouchOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentBeginTouchOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentBeginTouchOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentBeginTouchOverSignature.OnScriptCallback));
				}
				FComponentBeginTouchOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentBeginTouchOverSignature.RegisterId);
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x000C0ED8 File Offset: 0x000BF0D8
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

		// Token: 0x0600871D RID: 34589 RVA: 0x000C0EF8 File Offset: 0x000BF0F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams* ptr = stackalloc FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x000C0F60 File Offset: 0x000BF160
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
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04004049 RID: 16457
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400404A RID: 16458
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature";

		// Token: 0x0400404B RID: 16459
		private static int RegisterId;

		// Token: 0x02002CC7 RID: 11463
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FComponentBeginTouchOverSignature_DelegateParams
		{
			// Token: 0x04016664 RID: 91748
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04016665 RID: 91749
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02002CC8 RID: 11464
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016666 RID: 91750
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
