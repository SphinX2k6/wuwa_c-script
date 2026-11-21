using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082C RID: 2092
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineStartedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B638 RID: 46648 RVA: 0x00121EBD File Offset: 0x001200BD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineStartedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B639 RID: 46649 RVA: 0x00121EC9 File Offset: 0x001200C9
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineStartedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineStartedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineStartedSignature__DelegateSignature");
			}
			return FOnStateMachineStartedSignature._FunctionPtr;
		}

		// Token: 0x0600B63A RID: 46650 RVA: 0x00121EEC File Offset: 0x001200EC
		public FOnStateMachineStartedSignature()
		{
		}

		// Token: 0x0600B63B RID: 46651 RVA: 0x00121EF4 File Offset: 0x001200F4
		[NullableContext(2)]
		public FOnStateMachineStartedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B63C RID: 46652 RVA: 0x00121EFE File Offset: 0x001200FE
		public FOnStateMachineStartedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x00121F09 File Offset: 0x00120109
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance>) ?? ((Action<USMInstance>)Delegate.CreateDelegate(typeof(Action<USMInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x00121F3B File Offset: 0x0012013B
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

		// Token: 0x0600B63F RID: 46655 RVA: 0x00121F75 File Offset: 0x00120175
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x00121F80 File Offset: 0x00120180
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMInstance Instance)
		{
			FOnStateMachineStartedSignature.__FOnStateMachineStartedSignature_DelegateParams* ptr = stackalloc FOnStateMachineStartedSignature.__FOnStateMachineStartedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateMachineStartedSignature.__FOnStateMachineStartedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineStartedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x00121FCC File Offset: 0x001201CC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04005265 RID: 21093
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005266 RID: 21094
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineStartedSignature__DelegateSignature";

		// Token: 0x04005267 RID: 21095
		private static int RegisterId;

		// Token: 0x0200133E RID: 4926
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnStateMachineStartedSignature_DelegateParams
		{
			// Token: 0x0400677C RID: 26492
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x0200133F RID: 4927
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400677D RID: 26493
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
