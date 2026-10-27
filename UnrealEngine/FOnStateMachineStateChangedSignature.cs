using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002875 RID: 10357
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineStateChangedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026593 RID: 157075 RVA: 0x003A4281 File Offset: 0x003A2481
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineStateChangedSignature.StaticFunctionPtr();
		}

		// Token: 0x06026594 RID: 157076 RVA: 0x003A428D File Offset: 0x003A248D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineStateChangedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineStateChangedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineStateChangedSignature__DelegateSignature");
			}
			return FOnStateMachineStateChangedSignature._FunctionPtr;
		}

		// Token: 0x06026595 RID: 157077 RVA: 0x003A42B0 File Offset: 0x003A24B0
		public FOnStateMachineStateChangedSignature()
		{
		}

		// Token: 0x06026596 RID: 157078 RVA: 0x003A42B8 File Offset: 0x003A24B8
		[NullableContext(2)]
		public FOnStateMachineStateChangedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026597 RID: 157079 RVA: 0x003A42C2 File Offset: 0x003A24C2
		public FOnStateMachineStateChangedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026598 RID: 157080 RVA: 0x003A42CD File Offset: 0x003A24CD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance, FSMStateInfo, FSMStateInfo>) ?? ((Action<USMInstance, FSMStateInfo, FSMStateInfo>)Delegate.CreateDelegate(typeof(Action<USMInstance, FSMStateInfo, FSMStateInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026599 RID: 157081 RVA: 0x003A42FF File Offset: 0x003A24FF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<USMInstance, FSMStateInfo, FSMStateInfo> Callback)
		{
			if (FOnStateMachineStateChangedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineStateChangedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineStateChangedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineStateChangedSignature.OnScriptCallback));
				}
				FOnStateMachineStateChangedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineStateChangedSignature.RegisterId);
		}

		// Token: 0x0602659A RID: 157082 RVA: 0x003A4339 File Offset: 0x003A2539
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<USMInstance, FSMStateInfo, FSMStateInfo> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602659B RID: 157083 RVA: 0x003A4344 File Offset: 0x003A2544
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMInstance Instance, FSMStateInfo NewState, FSMStateInfo PreviousState)
		{
			FOnStateMachineStateChangedSignature.__FOnStateMachineStateChangedSignature_DelegateParams* ptr = stackalloc FOnStateMachineStateChangedSignature.__FOnStateMachineStateChangedSignature_DelegateParams[(UIntPtr)279] + 15L / (long)sizeof(FOnStateMachineStateChangedSignature.__FOnStateMachineStateChangedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineStateChangedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			if (NewState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->NewState, NewState.NativePtr, 1, false);
			}
			if (PreviousState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->PreviousState, PreviousState.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnStateMachineStateChangedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602659C RID: 157084 RVA: 0x003A43E8 File Offset: 0x003A25E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMInstance, FSMStateInfo, FSMStateInfo> action = target as Action<USMInstance, FSMStateInfo, FSMStateInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineStateChangedSignature.__FOnStateMachineStateChangedSignature_DelegateParams*)__Parameters)->Instance);
			FSMStateInfo arg = new FSMStateInfo(&((FOnStateMachineStateChangedSignature.__FOnStateMachineStateChangedSignature_DelegateParams*)__Parameters)->NewState, true, true);
			FSMStateInfo arg2 = new FSMStateInfo(&((FOnStateMachineStateChangedSignature.__FOnStateMachineStateChangedSignature_DelegateParams*)__Parameters)->PreviousState, true, true);
			action(orCreateUObjectByNativePointer, arg, arg2);
		}

		// Token: 0x04015092 RID: 86162
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015093 RID: 86163
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineStateChangedSignature__DelegateSignature";

		// Token: 0x04015094 RID: 86164
		private static int RegisterId;

		// Token: 0x02003A6D RID: 14957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected ref struct __FOnStateMachineStateChangedSignature_DelegateParams
		{
			// Token: 0x04017BCA RID: 97226
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017BCB RID: 97227
			[FieldOffset(8)]
			public byte NewState;

			// Token: 0x04017BCC RID: 97228
			[FieldOffset(136)]
			public byte PreviousState;
		}

		// Token: 0x02003A6E RID: 14958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BCD RID: 97229
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
