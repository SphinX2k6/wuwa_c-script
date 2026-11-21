using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000531 RID: 1329
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKCustomerServiceResultDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C11 RID: 31761 RVA: 0x000B7686 File Offset: 0x000B5886
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKCustomerServiceResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x000B7692 File Offset: 0x000B5892
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKCustomerServiceResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKCustomerServiceResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKCustomerServiceResultDelegate__DelegateSignature");
			}
			return FSDKCustomerServiceResultDelegate._FunctionPtr;
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x000B76B5 File Offset: 0x000B58B5
		public FSDKCustomerServiceResultDelegate()
		{
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x000B76BD File Offset: 0x000B58BD
		[NullableContext(2)]
		public FSDKCustomerServiceResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x000B76C7 File Offset: 0x000B58C7
		public FSDKCustomerServiceResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x000B76D2 File Offset: 0x000B58D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x000B7704 File Offset: 0x000B5904
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKCustomerServiceResultDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKCustomerServiceResultDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKCustomerServiceResultDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKCustomerServiceResultDelegate.OnScriptCallback));
				}
				FSDKCustomerServiceResultDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKCustomerServiceResultDelegate.RegisterId);
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x000B773E File Offset: 0x000B593E
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x000B7748 File Offset: 0x000B5948
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string result)
		{
			FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams* ptr = stackalloc FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKCustomerServiceResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKCustomerServiceResultDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x000B779C File Offset: 0x000B599C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x04003513 RID: 13587
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003514 RID: 13588
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKCustomerServiceResultDelegate__DelegateSignature";

		// Token: 0x04003515 RID: 13589
		private static int RegisterId;

		// Token: 0x02000CD9 RID: 3289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKCustomerServiceResultDelegate_DelegateParams
		{
			// Token: 0x04005F59 RID: 24409
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02000CDA RID: 3290
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F5A RID: 24410
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
