using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000409 RID: 1033
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnARTransformUpdated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003782 RID: 14210 RVA: 0x0005466A File Offset: 0x0005286A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnARTransformUpdated.StaticFunctionPtr();
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00054676 File Offset: 0x00052876
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnARTransformUpdated._FunctionPtr == IntPtr.Zero)
			{
				FOnARTransformUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.OnARTransformUpdated__DelegateSignature");
			}
			return FOnARTransformUpdated._FunctionPtr;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00054699 File Offset: 0x00052899
		public FOnARTransformUpdated()
		{
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x000546A1 File Offset: 0x000528A1
		[NullableContext(2)]
		public FOnARTransformUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x000546AB File Offset: 0x000528AB
		public FOnARTransformUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x000546B6 File Offset: 0x000528B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FTransform>) ?? ((Action<FTransform>)Delegate.CreateDelegate(typeof(Action<FTransform>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000546E8 File Offset: 0x000528E8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FTransform> Callback)
		{
			if (FOnARTransformUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnARTransformUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnARTransformUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnARTransformUpdated.OnScriptCallback));
				}
				FOnARTransformUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnARTransformUpdated.RegisterId);
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00054722 File Offset: 0x00052922
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FTransform> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x0005472C File Offset: 0x0005292C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FTransform OldToNewTransform)
		{
			FOnARTransformUpdated.__FOnARTransformUpdated_DelegateParams* ptr = stackalloc FOnARTransformUpdated.__FOnARTransformUpdated_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FOnARTransformUpdated.__FOnARTransformUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnARTransformUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OldToNewTransform = OldToNewTransform;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00054770 File Offset: 0x00052970
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FTransform> action = target as Action<FTransform>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnARTransformUpdated.__FOnARTransformUpdated_DelegateParams*)__Parameters)->OldToNewTransform);
		}

		// Token: 0x04001939 RID: 6457
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400193A RID: 6458
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.OnARTransformUpdated__DelegateSignature";

		// Token: 0x0400193B RID: 6459
		private static int RegisterId;

		// Token: 0x02002C29 RID: 11305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FOnARTransformUpdated_DelegateParams
		{
			// Token: 0x04016532 RID: 91442
			[FieldOffset(0)]
			public FTransform OldToNewTransform;
		}

		// Token: 0x02002C2A RID: 11306
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016533 RID: 91443
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
