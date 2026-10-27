using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002874 RID: 10356
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineStartedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026589 RID: 157065 RVA: 0x003A4121 File Offset: 0x003A2321
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineStartedSignature.StaticFunctionPtr();
		}

		// Token: 0x0602658A RID: 157066 RVA: 0x003A412D File Offset: 0x003A232D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineStartedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineStartedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineStartedSignature__DelegateSignature");
			}
			return FOnStateMachineStartedSignature._FunctionPtr;
		}

		// Token: 0x0602658B RID: 157067 RVA: 0x003A4150 File Offset: 0x003A2350
		public FOnStateMachineStartedSignature()
		{
		}

		// Token: 0x0602658C RID: 157068 RVA: 0x003A4158 File Offset: 0x003A2358
		[NullableContext(2)]
		public FOnStateMachineStartedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602658D RID: 157069 RVA: 0x003A4162 File Offset: 0x003A2362
		public FOnStateMachineStartedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602658E RID: 157070 RVA: 0x003A416D File Offset: 0x003A236D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance>) ?? ((Action<USMInstance>)Delegate.CreateDelegate(typeof(Action<USMInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602658F RID: 157071 RVA: 0x003A419F File Offset: 0x003A239F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			if (FOnStateMachineStartedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineStartedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineStartedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineStartedSignature.OnScriptCallback));
				}
				FOnStateMachineStartedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineStartedSignature.RegisterId);
		}

		// Token: 0x06026590 RID: 157072 RVA: 0x003A41D9 File Offset: 0x003A23D9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026591 RID: 157073 RVA: 0x003A41E4 File Offset: 0x003A23E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMInstance Instance)
		{
			FOnStateMachineStartedSignature.__FOnStateMachineStartedSignature_DelegateParams* ptr = stackalloc FOnStateMachineStartedSignature.__FOnStateMachineStartedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateMachineStartedSignature.__FOnStateMachineStartedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineStartedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026592 RID: 157074 RVA: 0x003A4230 File Offset: 0x003A2430
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
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineStartedSignature.__FOnStateMachineStartedSignature_DelegateParams*)__Parameters)->Instance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401508F RID: 86159
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015090 RID: 86160
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineStartedSignature__DelegateSignature";

		// Token: 0x04015091 RID: 86161
		private static int RegisterId;

		// Token: 0x02003A6B RID: 14955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnStateMachineStartedSignature_DelegateParams
		{
			// Token: 0x04017BC8 RID: 97224
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x02003A6C RID: 14956
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BC9 RID: 97225
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
