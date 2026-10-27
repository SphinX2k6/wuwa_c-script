using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002873 RID: 10355
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineInitializedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602657F RID: 157055 RVA: 0x003A3FC1 File Offset: 0x003A21C1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineInitializedSignature.StaticFunctionPtr();
		}

		// Token: 0x06026580 RID: 157056 RVA: 0x003A3FCD File Offset: 0x003A21CD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineInitializedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineInitializedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineInitializedSignature__DelegateSignature");
			}
			return FOnStateMachineInitializedSignature._FunctionPtr;
		}

		// Token: 0x06026581 RID: 157057 RVA: 0x003A3FF0 File Offset: 0x003A21F0
		public FOnStateMachineInitializedSignature()
		{
		}

		// Token: 0x06026582 RID: 157058 RVA: 0x003A3FF8 File Offset: 0x003A21F8
		[NullableContext(2)]
		public FOnStateMachineInitializedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026583 RID: 157059 RVA: 0x003A4002 File Offset: 0x003A2202
		public FOnStateMachineInitializedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026584 RID: 157060 RVA: 0x003A400D File Offset: 0x003A220D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance>) ?? ((Action<USMInstance>)Delegate.CreateDelegate(typeof(Action<USMInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026585 RID: 157061 RVA: 0x003A403F File Offset: 0x003A223F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			if (FOnStateMachineInitializedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineInitializedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineInitializedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineInitializedSignature.OnScriptCallback));
				}
				FOnStateMachineInitializedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineInitializedSignature.RegisterId);
		}

		// Token: 0x06026586 RID: 157062 RVA: 0x003A4079 File Offset: 0x003A2279
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026587 RID: 157063 RVA: 0x003A4084 File Offset: 0x003A2284
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMInstance Instance)
		{
			FOnStateMachineInitializedSignature.__FOnStateMachineInitializedSignature_DelegateParams* ptr = stackalloc FOnStateMachineInitializedSignature.__FOnStateMachineInitializedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateMachineInitializedSignature.__FOnStateMachineInitializedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineInitializedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026588 RID: 157064 RVA: 0x003A40D0 File Offset: 0x003A22D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMInstance> action = target as Action<USMInstance>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineInitializedSignature.__FOnStateMachineInitializedSignature_DelegateParams*)__Parameters)->Instance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401508C RID: 86156
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401508D RID: 86157
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineInitializedSignature__DelegateSignature";

		// Token: 0x0401508E RID: 86158
		private static int RegisterId;

		// Token: 0x02003A69 RID: 14953
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnStateMachineInitializedSignature_DelegateParams
		{
			// Token: 0x04017BC6 RID: 97222
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x02003A6A RID: 14954
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BC7 RID: 97223
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
