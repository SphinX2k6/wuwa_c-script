using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000830 RID: 2096
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTransitionEnteredSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B660 RID: 46688 RVA: 0x00122457 File Offset: 0x00120657
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTransitionEnteredSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x00122463 File Offset: 0x00120663
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTransitionEnteredSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnTransitionEnteredSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnTransitionEnteredSignature__DelegateSignature");
			}
			return FOnTransitionEnteredSignature._FunctionPtr;
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x00122486 File Offset: 0x00120686
		public FOnTransitionEnteredSignature()
		{
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x0012248E File Offset: 0x0012068E
		[NullableContext(2)]
		public FOnTransitionEnteredSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B664 RID: 46692 RVA: 0x00122498 File Offset: 0x00120698
		public FOnTransitionEnteredSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B665 RID: 46693 RVA: 0x001224A3 File Offset: 0x001206A3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMTransitionInstance>) ?? ((Action<USMTransitionInstance>)Delegate.CreateDelegate(typeof(Action<USMTransitionInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B666 RID: 46694 RVA: 0x001224D5 File Offset: 0x001206D5
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMTransitionInstance> Callback)
		{
			if (FOnTransitionEnteredSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTransitionEnteredSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTransitionEnteredSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTransitionEnteredSignature.OnScriptCallback));
				}
				FOnTransitionEnteredSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTransitionEnteredSignature.RegisterId);
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x0012250F File Offset: 0x0012070F
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMTransitionInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B668 RID: 46696 RVA: 0x00122518 File Offset: 0x00120718
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMTransitionInstance TransitionInstance)
		{
			FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams* ptr = stackalloc FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTransitionEnteredSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TransitionInstance = ((TransitionInstance != null) ? TransitionInstance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B669 RID: 46697 RVA: 0x00122564 File Offset: 0x00120764
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMTransitionInstance> action = target as Action<USMTransitionInstance>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMTransitionInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(((FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams*)__Parameters)->TransitionInstance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04005271 RID: 21105
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005272 RID: 21106
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnTransitionEnteredSignature__DelegateSignature";

		// Token: 0x04005273 RID: 21107
		private static int RegisterId;

		// Token: 0x02001346 RID: 4934
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnTransitionEnteredSignature_DelegateParams
		{
			// Token: 0x04006786 RID: 26502
			[FieldOffset(0)]
			public IntPtr TransitionInstance;
		}

		// Token: 0x02001347 RID: 4935
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006787 RID: 26503
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
