using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082E RID: 2094
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineUpdatedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B64C RID: 46668 RVA: 0x0012217D File Offset: 0x0012037D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineUpdatedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x00122189 File Offset: 0x00120389
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineUpdatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineUpdatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineUpdatedSignature__DelegateSignature");
			}
			return FOnStateMachineUpdatedSignature._FunctionPtr;
		}

		// Token: 0x0600B64E RID: 46670 RVA: 0x001221AC File Offset: 0x001203AC
		public FOnStateMachineUpdatedSignature()
		{
		}

		// Token: 0x0600B64F RID: 46671 RVA: 0x001221B4 File Offset: 0x001203B4
		[NullableContext(2)]
		public FOnStateMachineUpdatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B650 RID: 46672 RVA: 0x001221BE File Offset: 0x001203BE
		public FOnStateMachineUpdatedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B651 RID: 46673 RVA: 0x001221C9 File Offset: 0x001203C9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance, float>) ?? ((Action<USMInstance, float>)Delegate.CreateDelegate(typeof(Action<USMInstance, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B652 RID: 46674 RVA: 0x001221FB File Offset: 0x001203FB
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance, float> Callback)
		{
			if (FOnStateMachineUpdatedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateMachineUpdatedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateMachineUpdatedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateMachineUpdatedSignature.OnScriptCallback));
				}
				FOnStateMachineUpdatedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateMachineUpdatedSignature.RegisterId);
		}

		// Token: 0x0600B653 RID: 46675 RVA: 0x00122235 File Offset: 0x00120435
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B654 RID: 46676 RVA: 0x00122240 File Offset: 0x00120440
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMInstance Instance, float DeltaSeconds)
		{
			FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams* ptr = stackalloc FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineUpdatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			ptr->DeltaSeconds = DeltaSeconds;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x00122294 File Offset: 0x00120494
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMInstance, float> action = target as Action<USMInstance, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(((FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams*)__Parameters)->Instance);
			action(orCreateUObjectByNativePointer, ((FOnStateMachineUpdatedSignature.__FOnStateMachineUpdatedSignature_DelegateParams*)__Parameters)->DeltaSeconds);
		}

		// Token: 0x0400526B RID: 21099
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400526C RID: 21100
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineUpdatedSignature__DelegateSignature";

		// Token: 0x0400526D RID: 21101
		private static int RegisterId;

		// Token: 0x02001342 RID: 4930
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnStateMachineUpdatedSignature_DelegateParams
		{
			// Token: 0x04006780 RID: 26496
			[FieldOffset(0)]
			public IntPtr Instance;

			// Token: 0x04006781 RID: 26497
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02001343 RID: 4931
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006782 RID: 26498
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
