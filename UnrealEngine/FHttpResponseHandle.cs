using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000478 RID: 1144
	public sealed class FHttpResponseHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006C73 RID: 27763 RVA: 0x0009E12A File Offset: 0x0009C32A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHttpResponseHandle.StaticFunctionPtr();
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x0009E136 File Offset: 0x0009C336
		private static IntPtr StaticFunctionPtr()
		{
			if (FHttpResponseHandle._FunctionPtr == IntPtr.Zero)
			{
				FHttpResponseHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.HttpResponseHandle__DelegateSignature");
			}
			return FHttpResponseHandle._FunctionPtr;
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x0009E159 File Offset: 0x0009C359
		public FHttpResponseHandle()
		{
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x0009E161 File Offset: 0x0009C361
		[NullableContext(2)]
		public FHttpResponseHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x0009E16B File Offset: 0x0009C36B
		public FHttpResponseHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x0009E176 File Offset: 0x0009C376
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, int, string>) ?? ((Action<bool, int, string>)Delegate.CreateDelegate(typeof(Action<bool, int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x0009E1A8 File Offset: 0x0009C3A8
		[NullableContext(1)]
		public void Bind(Action<bool, int, string> Callback)
		{
			if (FHttpResponseHandle.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FHttpResponseHandle.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FHttpResponseHandle.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FHttpResponseHandle.OnScriptCallback));
				}
				FHttpResponseHandle.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FHttpResponseHandle.RegisterId);
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x0009E1E4 File Offset: 0x0009C3E4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(bool bConnectedSuccessfully, int HttpResponseCode, string Data)
		{
			FHttpResponseHandle.__FHttpResponseHandle_DelegateParams* ptr = stackalloc FHttpResponseHandle.__FHttpResponseHandle_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FHttpResponseHandle.__FHttpResponseHandle_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FHttpResponseHandle.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bConnectedSuccessfully = bConnectedSuccessfully;
			ptr->HttpResponseCode = HttpResponseCode;
			FString.CopyFrom((void*)(&ptr->Data), Data);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FHttpResponseHandle._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x0009E248 File Offset: 0x0009C448
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int, string> action = target as Action<bool, int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FHttpResponseHandle.__FHttpResponseHandle_DelegateParams*)__Parameters)->Data));
			action(((FHttpResponseHandle.__FHttpResponseHandle_DelegateParams*)__Parameters)->bConnectedSuccessfully, ((FHttpResponseHandle.__FHttpResponseHandle_DelegateParams*)__Parameters)->HttpResponseCode, arg);
		}

		// Token: 0x04002E56 RID: 11862
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002E57 RID: 11863
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.HttpResponseHandle__DelegateSignature";

		// Token: 0x04002E58 RID: 11864
		private static int RegisterId;

		// Token: 0x02000B7D RID: 2941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FHttpResponseHandle_DelegateParams
		{
			// Token: 0x04005CD5 RID: 23765
			[FieldOffset(0)]
			public bool bConnectedSuccessfully;

			// Token: 0x04005CD6 RID: 23766
			[FieldOffset(4)]
			public int HttpResponseCode;

			// Token: 0x04005CD7 RID: 23767
			[FieldOffset(8)]
			public FString Data;
		}

		// Token: 0x02000B7E RID: 2942
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005CD8 RID: 23768
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
