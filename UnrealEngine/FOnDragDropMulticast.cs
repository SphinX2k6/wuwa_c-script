using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200299A RID: 10650
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDragDropMulticast : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027691 RID: 161425 RVA: 0x003C16FA File Offset: 0x003BF8FA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDragDropMulticast.StaticFunctionPtr();
		}

		// Token: 0x06027692 RID: 161426 RVA: 0x003C1706 File Offset: 0x003BF906
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDragDropMulticast._FunctionPtr == IntPtr.Zero)
			{
				FOnDragDropMulticast._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnDragDropMulticast__DelegateSignature");
			}
			return FOnDragDropMulticast._FunctionPtr;
		}

		// Token: 0x06027693 RID: 161427 RVA: 0x003C1729 File Offset: 0x003BF929
		public FOnDragDropMulticast()
		{
		}

		// Token: 0x06027694 RID: 161428 RVA: 0x003C1731 File Offset: 0x003BF931
		[NullableContext(2)]
		public FOnDragDropMulticast(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027695 RID: 161429 RVA: 0x003C173B File Offset: 0x003BF93B
		public FOnDragDropMulticast(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027696 RID: 161430 RVA: 0x003C1746 File Offset: 0x003BF946
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UDragDropOperation>) ?? ((Action<UDragDropOperation>)Delegate.CreateDelegate(typeof(Action<UDragDropOperation>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027697 RID: 161431 RVA: 0x003C1778 File Offset: 0x003BF978
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UDragDropOperation> Callback)
		{
			if (FOnDragDropMulticast.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDragDropMulticast.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDragDropMulticast.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDragDropMulticast.OnScriptCallback));
				}
				FOnDragDropMulticast.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnDragDropMulticast.RegisterId);
		}

		// Token: 0x06027698 RID: 161432 RVA: 0x003C17B2 File Offset: 0x003BF9B2
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UDragDropOperation> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027699 RID: 161433 RVA: 0x003C17BC File Offset: 0x003BF9BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UDragDropOperation Operation)
		{
			FOnDragDropMulticast.__FOnDragDropMulticast_DelegateParams* ptr = stackalloc FOnDragDropMulticast.__FOnDragDropMulticast_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnDragDropMulticast.__FOnDragDropMulticast_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnDragDropMulticast.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Operation = ((Operation != null) ? Operation.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602769A RID: 161434 RVA: 0x003C1808 File Offset: 0x003BFA08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UDragDropOperation> action = target as Action<UDragDropOperation>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UDragDropOperation orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDragDropOperation>(((FOnDragDropMulticast.__FOnDragDropMulticast_DelegateParams*)__Parameters)->Operation);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015A33 RID: 88627
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A34 RID: 88628
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnDragDropMulticast__DelegateSignature";

		// Token: 0x04015A35 RID: 88629
		private static int RegisterId;

		// Token: 0x02003B8D RID: 15245
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnDragDropMulticast_DelegateParams
		{
			// Token: 0x04017D67 RID: 97639
			[FieldOffset(0)]
			public IntPtr Operation;
		}

		// Token: 0x02003B8E RID: 15246
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D68 RID: 97640
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
