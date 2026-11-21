using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082A RID: 2090
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateEndSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B624 RID: 46628 RVA: 0x00121BFD File Offset: 0x0011FDFD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateEndSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B625 RID: 46629 RVA: 0x00121C09 File Offset: 0x0011FE09
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateEndSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateEndSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateEndSignature__DelegateSignature");
			}
			return FOnStateEndSignature._FunctionPtr;
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x00121C2C File Offset: 0x0011FE2C
		public FOnStateEndSignature()
		{
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x00121C34 File Offset: 0x0011FE34
		[NullableContext(2)]
		public FOnStateEndSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B628 RID: 46632 RVA: 0x00121C3E File Offset: 0x0011FE3E
		public FOnStateEndSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x00121C49 File Offset: 0x0011FE49
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMStateInstance_Base>) ?? ((Action<USMStateInstance_Base>)Delegate.CreateDelegate(typeof(Action<USMStateInstance_Base>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x00121C7B File Offset: 0x0011FE7B
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			if (FOnStateEndSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateEndSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateEndSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateEndSignature.OnScriptCallback));
				}
				FOnStateEndSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateEndSignature.RegisterId);
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x00121CB5 File Offset: 0x0011FEB5
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x00121CC0 File Offset: 0x0011FEC0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMStateInstance_Base StateInstance)
		{
			FOnStateEndSignature.__FOnStateEndSignature_DelegateParams* ptr = stackalloc FOnStateEndSignature.__FOnStateEndSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateEndSignature.__FOnStateEndSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateEndSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateInstance = ((StateInstance != null) ? StateInstance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x00121D0C File Offset: 0x0011FF0C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMStateInstance_Base> action = target as Action<USMStateInstance_Base>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(((FOnStateEndSignature.__FOnStateEndSignature_DelegateParams*)__Parameters)->StateInstance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400525F RID: 21087
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005260 RID: 21088
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateEndSignature__DelegateSignature";

		// Token: 0x04005261 RID: 21089
		private static int RegisterId;

		// Token: 0x0200133A RID: 4922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnStateEndSignature_DelegateParams
		{
			// Token: 0x04006778 RID: 26488
			[FieldOffset(0)]
			public IntPtr StateInstance;
		}

		// Token: 0x0200133B RID: 4923
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006779 RID: 26489
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
