using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082D RID: 2093
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateMachineStoppedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B642 RID: 46658 RVA: 0x0012201D File Offset: 0x0012021D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateMachineStoppedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B643 RID: 46659 RVA: 0x00122029 File Offset: 0x00120229
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateMachineStoppedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateMachineStoppedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateMachineStoppedSignature__DelegateSignature");
			}
			return FOnStateMachineStoppedSignature._FunctionPtr;
		}

		// Token: 0x0600B644 RID: 46660 RVA: 0x0012204C File Offset: 0x0012024C
		public FOnStateMachineStoppedSignature()
		{
		}

		// Token: 0x0600B645 RID: 46661 RVA: 0x00122054 File Offset: 0x00120254
		[NullableContext(2)]
		public FOnStateMachineStoppedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B646 RID: 46662 RVA: 0x0012205E File Offset: 0x0012025E
		public FOnStateMachineStoppedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B647 RID: 46663 RVA: 0x00122069 File Offset: 0x00120269
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMInstance>) ?? ((Action<USMInstance>)Delegate.CreateDelegate(typeof(Action<USMInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B648 RID: 46664 RVA: 0x0012209B File Offset: 0x0012029B
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

		// Token: 0x0600B649 RID: 46665 RVA: 0x001220D5 File Offset: 0x001202D5
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B64A RID: 46666 RVA: 0x001220E0 File Offset: 0x001202E0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMInstance Instance)
		{
			FOnStateMachineStoppedSignature.__FOnStateMachineStoppedSignature_DelegateParams* ptr = stackalloc FOnStateMachineStoppedSignature.__FOnStateMachineStoppedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateMachineStoppedSignature.__FOnStateMachineStoppedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateMachineStoppedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Instance = ((Instance != null) ? Instance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x0012212C File Offset: 0x0012032C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04005268 RID: 21096
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005269 RID: 21097
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateMachineStoppedSignature__DelegateSignature";

		// Token: 0x0400526A RID: 21098
		private static int RegisterId;

		// Token: 0x02001340 RID: 4928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnStateMachineStoppedSignature_DelegateParams
		{
			// Token: 0x0400677E RID: 26494
			[FieldOffset(0)]
			public IntPtr Instance;
		}

		// Token: 0x02001341 RID: 4929
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400677F RID: 26495
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
