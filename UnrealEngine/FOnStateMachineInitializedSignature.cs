using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082B RID: 2091
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineInitializedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B62E RID: 46638 RVA: 0x00121D5D File Offset: 0x0011FF5D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineInitializedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B62F RID: 46639 RVA: 0x00121D69 File Offset: 0x0011FF69
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineInitializedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineInitializedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineInitializedSignature__DelegateSignature");
			}
			return FOnStateMachineInitializedSignature._FunctionPtr;
		}

		// Token: 0x0600B630 RID: 46640 RVA: 0x00121D8C File Offset: 0x0011FF8C
		public FOnStateMachineInitializedSignature()
		{
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x00121D94 File Offset: 0x0011FF94
		[NullableContext(2)]
		public FOnStateMachineInitializedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B632 RID: 46642 RVA: 0x00121D9E File Offset: 0x0011FF9E
		public FOnStateMachineInitializedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B633 RID: 46643 RVA: 0x00121DA9 File Offset: 0x0011FFA9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance>) ?? ((Action<USMInstance>)Delegate.CreateDelegate(typeof(Action<USMInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x00121DDB File Offset: 0x0011FFDB
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

		// Token: 0x0600B635 RID: 46645 RVA: 0x00121E15 File Offset: 0x00120015
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B636 RID: 46646 RVA: 0x00121E20 File Offset: 0x00120020
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMInstance Instance)
		{
			FOnStateMachineInitializedSignature.__FOnStateMachineInitializedSignature_DelegateParams* ptr = stackalloc FOnStateMachineInitializedSignature.__FOnStateMachineInitializedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateMachineInitializedSignature.__FOnStateMachineInitializedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineInitializedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x00121E6C File Offset: 0x0012006C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04005262 RID: 21090
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005263 RID: 21091
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineInitializedSignature__DelegateSignature";

		// Token: 0x04005264 RID: 21092
		private static int RegisterId;

		// Token: 0x0200133C RID: 4924
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnStateMachineInitializedSignature_DelegateParams
		{
			// Token: 0x0400677A RID: 26490
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x0200133D RID: 4925
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400677B RID: 26491
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
