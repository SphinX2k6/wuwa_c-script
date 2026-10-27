using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002876 RID: 10358
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineStateStartedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602659D RID: 157085 RVA: 0x003A445C File Offset: 0x003A265C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineStateStartedSignature.StaticFunctionPtr();
		}

		// Token: 0x0602659E RID: 157086 RVA: 0x003A4468 File Offset: 0x003A2668
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineStateStartedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineStateStartedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineStateStartedSignature__DelegateSignature");
			}
			return FOnStateMachineStateStartedSignature._FunctionPtr;
		}

		// Token: 0x0602659F RID: 157087 RVA: 0x003A448B File Offset: 0x003A268B
		public FOnStateMachineStateStartedSignature()
		{
		}

		// Token: 0x060265A0 RID: 157088 RVA: 0x003A4493 File Offset: 0x003A2693
		[NullableContext(2)]
		public FOnStateMachineStateStartedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060265A1 RID: 157089 RVA: 0x003A449D File Offset: 0x003A269D
		public FOnStateMachineStateStartedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060265A2 RID: 157090 RVA: 0x003A44A8 File Offset: 0x003A26A8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance, FSMStateInfo>) ?? ((Action<USMInstance, FSMStateInfo>)Delegate.CreateDelegate(typeof(Action<USMInstance, FSMStateInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060265A3 RID: 157091 RVA: 0x003A44DA File Offset: 0x003A26DA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<USMInstance, FSMStateInfo> Callback)
		{
			if (FOnStateMachineStateStartedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineStateStartedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineStateStartedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineStateStartedSignature.OnScriptCallback));
				}
				FOnStateMachineStateStartedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineStateStartedSignature.RegisterId);
		}

		// Token: 0x060265A4 RID: 157092 RVA: 0x003A4514 File Offset: 0x003A2714
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<USMInstance, FSMStateInfo> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060265A5 RID: 157093 RVA: 0x003A4520 File Offset: 0x003A2720
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMInstance Instance, FSMStateInfo State)
		{
			FOnStateMachineStateStartedSignature.__FOnStateMachineStateStartedSignature_DelegateParams* ptr = stackalloc FOnStateMachineStateStartedSignature.__FOnStateMachineStateStartedSignature_DelegateParams[(UIntPtr)151] + 15L / (long)sizeof(FOnStateMachineStateStartedSignature.__FOnStateMachineStateStartedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineStateStartedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			if (State != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMStateInfo.StaticStruct(), &ptr->State, State.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnStateMachineStateStartedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060265A6 RID: 157094 RVA: 0x003A45A4 File Offset: 0x003A27A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMInstance, FSMStateInfo> action = target as Action<USMInstance, FSMStateInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineStateStartedSignature.__FOnStateMachineStateStartedSignature_DelegateParams*)__Parameters)->Instance);
			FSMStateInfo arg = new FSMStateInfo(&((FOnStateMachineStateStartedSignature.__FOnStateMachineStateStartedSignature_DelegateParams*)__Parameters)->State, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04015095 RID: 86165
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015096 RID: 86166
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineStateStartedSignature__DelegateSignature";

		// Token: 0x04015097 RID: 86167
		private static int RegisterId;

		// Token: 0x02003A6F RID: 14959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __FOnStateMachineStateStartedSignature_DelegateParams
		{
			// Token: 0x04017BCE RID: 97230
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017BCF RID: 97231
			[FieldOffset(8)]
			public byte State;
		}

		// Token: 0x02003A70 RID: 14960
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BD0 RID: 97232
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
