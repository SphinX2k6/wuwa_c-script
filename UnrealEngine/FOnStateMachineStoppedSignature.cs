using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002877 RID: 10359
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineStoppedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060265A7 RID: 157095 RVA: 0x003A4606 File Offset: 0x003A2806
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineStoppedSignature.StaticFunctionPtr();
		}

		// Token: 0x060265A8 RID: 157096 RVA: 0x003A4612 File Offset: 0x003A2812
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineStoppedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineStoppedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineStoppedSignature__DelegateSignature");
			}
			return FOnStateMachineStoppedSignature._FunctionPtr;
		}

		// Token: 0x060265A9 RID: 157097 RVA: 0x003A4635 File Offset: 0x003A2835
		public FOnStateMachineStoppedSignature()
		{
		}

		// Token: 0x060265AA RID: 157098 RVA: 0x003A463D File Offset: 0x003A283D
		[NullableContext(2)]
		public FOnStateMachineStoppedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060265AB RID: 157099 RVA: 0x003A4647 File Offset: 0x003A2847
		public FOnStateMachineStoppedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060265AC RID: 157100 RVA: 0x003A4652 File Offset: 0x003A2852
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance>) ?? ((Action<USMInstance>)Delegate.CreateDelegate(typeof(Action<USMInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060265AD RID: 157101 RVA: 0x003A4684 File Offset: 0x003A2884
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			if (FOnStateMachineStoppedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineStoppedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineStoppedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineStoppedSignature.OnScriptCallback));
				}
				FOnStateMachineStoppedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineStoppedSignature.RegisterId);
		}

		// Token: 0x060265AE RID: 157102 RVA: 0x003A46BE File Offset: 0x003A28BE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060265AF RID: 157103 RVA: 0x003A46C8 File Offset: 0x003A28C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMInstance Instance)
		{
			FOnStateMachineStoppedSignature.__FOnStateMachineStoppedSignature_DelegateParams* ptr = stackalloc FOnStateMachineStoppedSignature.__FOnStateMachineStoppedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateMachineStoppedSignature.__FOnStateMachineStoppedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineStoppedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060265B0 RID: 157104 RVA: 0x003A4714 File Offset: 0x003A2914
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
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineStoppedSignature.__FOnStateMachineStoppedSignature_DelegateParams*)__Parameters)->Instance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015098 RID: 86168
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015099 RID: 86169
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineStoppedSignature__DelegateSignature";

		// Token: 0x0401509A RID: 86170
		private static int RegisterId;

		// Token: 0x02003A71 RID: 14961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnStateMachineStoppedSignature_DelegateParams
		{
			// Token: 0x04017BD1 RID: 97233
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x02003A72 RID: 14962
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BD2 RID: 97234
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
