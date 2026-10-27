using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200095B RID: 2395
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnClickedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600876D RID: 34669 RVA: 0x000C1B22 File Offset: 0x000BFD22
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnClickedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x000C1B2E File Offset: 0x000BFD2E
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnClickedSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnClickedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnClickedSignature__DelegateSignature");
			}
			return FComponentOnClickedSignature._FunctionPtr;
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x0600876F RID: 34671 RVA: 0x000C1B51 File Offset: 0x000BFD51
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnClicked;
			}
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x000C1B58 File Offset: 0x000BFD58
		[NullableContext(2)]
		public FComponentOnClickedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x000C1B62 File Offset: 0x000BFD62
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FKey>) ?? ((Action<UPrimitiveComponent, FKey>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008772 RID: 34674 RVA: 0x000C1B94 File Offset: 0x000BFD94
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UPrimitiveComponent, FKey> Callback)
		{
			if (FComponentOnClickedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentOnClickedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentOnClickedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentOnClickedSignature.OnScriptCallback));
				}
				FComponentOnClickedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentOnClickedSignature.RegisterId);
		}

		// Token: 0x06008773 RID: 34675 RVA: 0x000C1BE4 File Offset: 0x000BFDE4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UPrimitiveComponent, FKey> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x000C1C04 File Offset: 0x000BFE04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent TouchedComponent, FKey ButtonPressed)
		{
			FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams* ptr = stackalloc FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentOnClickedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			if (ButtonPressed != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonPressed, ButtonPressed.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FComponentOnClickedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x000C1C94 File Offset: 0x000BFE94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, FKey> action = target as Action<UPrimitiveComponent, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams*)__Parameters)->TouchedComponent);
			FKey arg = new FKey(&((FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams*)__Parameters)->ButtonPressed, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04004069 RID: 16489
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400406A RID: 16490
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnClickedSignature__DelegateSignature";

		// Token: 0x0400406B RID: 16491
		private static int RegisterId;

		// Token: 0x02002CD3 RID: 11475
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FComponentOnClickedSignature_DelegateParams
		{
			// Token: 0x0401667B RID: 91771
			[FieldOffset(0)]
			public IntPtr TouchedComponent;

			// Token: 0x0401667C RID: 91772
			[FieldOffset(8)]
			public byte ButtonPressed;
		}

		// Token: 0x02002CD4 RID: 11476
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401667D RID: 91773
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
