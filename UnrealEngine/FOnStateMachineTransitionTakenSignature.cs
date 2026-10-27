using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002878 RID: 10360
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineTransitionTakenSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060265B1 RID: 157105 RVA: 0x003A4765 File Offset: 0x003A2965
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineTransitionTakenSignature.StaticFunctionPtr();
		}

		// Token: 0x060265B2 RID: 157106 RVA: 0x003A4771 File Offset: 0x003A2971
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineTransitionTakenSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineTransitionTakenSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineTransitionTakenSignature__DelegateSignature");
			}
			return FOnStateMachineTransitionTakenSignature._FunctionPtr;
		}

		// Token: 0x060265B3 RID: 157107 RVA: 0x003A4794 File Offset: 0x003A2994
		public FOnStateMachineTransitionTakenSignature()
		{
		}

		// Token: 0x060265B4 RID: 157108 RVA: 0x003A479C File Offset: 0x003A299C
		[NullableContext(2)]
		public FOnStateMachineTransitionTakenSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060265B5 RID: 157109 RVA: 0x003A47A6 File Offset: 0x003A29A6
		public FOnStateMachineTransitionTakenSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060265B6 RID: 157110 RVA: 0x003A47B1 File Offset: 0x003A29B1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance, FSMTransitionInfo>) ?? ((Action<USMInstance, FSMTransitionInfo>)Delegate.CreateDelegate(typeof(Action<USMInstance, FSMTransitionInfo>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060265B7 RID: 157111 RVA: 0x003A47E3 File Offset: 0x003A29E3
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<USMInstance, FSMTransitionInfo> Callback)
		{
			if (FOnStateMachineTransitionTakenSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineTransitionTakenSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineTransitionTakenSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineTransitionTakenSignature.OnScriptCallback));
				}
				FOnStateMachineTransitionTakenSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineTransitionTakenSignature.RegisterId);
		}

		// Token: 0x060265B8 RID: 157112 RVA: 0x003A481D File Offset: 0x003A2A1D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<USMInstance, FSMTransitionInfo> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060265B9 RID: 157113 RVA: 0x003A4828 File Offset: 0x003A2A28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMInstance Instance, FSMTransitionInfo Transition)
		{
			FOnStateMachineTransitionTakenSignature.__FOnStateMachineTransitionTakenSignature_DelegateParams* ptr = stackalloc FOnStateMachineTransitionTakenSignature.__FOnStateMachineTransitionTakenSignature_DelegateParams[(UIntPtr)175] + 15L / (long)sizeof(FOnStateMachineTransitionTakenSignature.__FOnStateMachineTransitionTakenSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineTransitionTakenSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			if (Transition != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSMTransitionInfo.StaticStruct(), &ptr->Transition, Transition.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnStateMachineTransitionTakenSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060265BA RID: 157114 RVA: 0x003A48AC File Offset: 0x003A2AAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMInstance, FSMTransitionInfo> action = target as Action<USMInstance, FSMTransitionInfo>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineTransitionTakenSignature.__FOnStateMachineTransitionTakenSignature_DelegateParams*)__Parameters)->Instance);
			FSMTransitionInfo arg = new FSMTransitionInfo(&((FOnStateMachineTransitionTakenSignature.__FOnStateMachineTransitionTakenSignature_DelegateParams*)__Parameters)->Transition, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x0401509B RID: 86171
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401509C RID: 86172
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineTransitionTakenSignature__DelegateSignature";

		// Token: 0x0401509D RID: 86173
		private static int RegisterId;

		// Token: 0x02003A73 RID: 14963
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __FOnStateMachineTransitionTakenSignature_DelegateParams
		{
			// Token: 0x04017BD3 RID: 97235
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04017BD4 RID: 97236
			[FieldOffset(8)]
			public byte Transition;
		}

		// Token: 0x02003A74 RID: 14964
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BD5 RID: 97237
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
