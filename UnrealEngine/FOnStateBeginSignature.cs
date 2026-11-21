using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000829 RID: 2089
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateBeginSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B61A RID: 46618 RVA: 0x00121A9D File Offset: 0x0011FC9D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateBeginSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B61B RID: 46619 RVA: 0x00121AA9 File Offset: 0x0011FCA9
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateBeginSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateBeginSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateBeginSignature__DelegateSignature");
			}
			return FOnStateBeginSignature._FunctionPtr;
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x00121ACC File Offset: 0x0011FCCC
		public FOnStateBeginSignature()
		{
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x00121AD4 File Offset: 0x0011FCD4
		[NullableContext(2)]
		public FOnStateBeginSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x00121ADE File Offset: 0x0011FCDE
		public FOnStateBeginSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x00121AE9 File Offset: 0x0011FCE9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMStateInstance_Base>) ?? ((Action<USMStateInstance_Base>)Delegate.CreateDelegate(typeof(Action<USMStateInstance_Base>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x00121B1B File Offset: 0x0011FD1B
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			if (FOnStateBeginSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateBeginSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateBeginSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateBeginSignature.OnScriptCallback));
				}
				FOnStateBeginSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateBeginSignature.RegisterId);
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x00121B55 File Offset: 0x0011FD55
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B622 RID: 46626 RVA: 0x00121B60 File Offset: 0x0011FD60
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMStateInstance_Base StateInstance)
		{
			FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams* ptr = stackalloc FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateBeginSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateInstance = ((StateInstance != null) ? StateInstance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B623 RID: 46627 RVA: 0x00121BAC File Offset: 0x0011FDAC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMStateInstance_Base> action = target as Action<USMStateInstance_Base>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(((FOnStateBeginSignature.__FOnStateBeginSignature_DelegateParams*)__Parameters)->StateInstance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400525C RID: 21084
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400525D RID: 21085
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateBeginSignature__DelegateSignature";

		// Token: 0x0400525E RID: 21086
		private static int RegisterId;

		// Token: 0x02001338 RID: 4920
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnStateBeginSignature_DelegateParams
		{
			// Token: 0x04006776 RID: 26486
			[FieldOffset(0)]
			public IntPtr StateInstance;
		}

		// Token: 0x02001339 RID: 4921
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006777 RID: 26487
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
