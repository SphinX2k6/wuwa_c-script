using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F2 RID: 6642
	public sealed class FHttpResponseHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060189F6 RID: 100854 RVA: 0x00244928 File Offset: 0x00242B28
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHttpResponseHandle.StaticFunctionPtr();
		}

		// Token: 0x060189F7 RID: 100855 RVA: 0x00244934 File Offset: 0x00242B34
		private static IntPtr StaticFunctionPtr()
		{
			if (FHttpResponseHandle._FunctionPtr == IntPtr.Zero)
			{
				FHttpResponseHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.HttpResponseHandle__DelegateSignature");
			}
			return FHttpResponseHandle._FunctionPtr;
		}

		// Token: 0x060189F8 RID: 100856 RVA: 0x00244957 File Offset: 0x00242B57
		public FHttpResponseHandle()
		{
		}

		// Token: 0x060189F9 RID: 100857 RVA: 0x0024495F File Offset: 0x00242B5F
		[NullableContext(2)]
		public FHttpResponseHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060189FA RID: 100858 RVA: 0x00244969 File Offset: 0x00242B69
		public FHttpResponseHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060189FB RID: 100859 RVA: 0x00244974 File Offset: 0x00242B74
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, int, string>) ?? ((Action<bool, int, string>)Delegate.CreateDelegate(typeof(Action<bool, int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060189FC RID: 100860 RVA: 0x002449A6 File Offset: 0x00242BA6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060189FD RID: 100861 RVA: 0x002449E0 File Offset: 0x00242BE0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060189FE RID: 100862 RVA: 0x00244A44 File Offset: 0x00242C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400D4F4 RID: 54516
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D4F5 RID: 54517
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.HttpResponseHandle__DelegateSignature";

		// Token: 0x0400D4F6 RID: 54518
		private static int RegisterId;

		// Token: 0x0200309D RID: 12445
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FHttpResponseHandle_DelegateParams
		{
			// Token: 0x04016DC4 RID: 93636
			[FieldOffset(0)]
			public bool bConnectedSuccessfully;

			// Token: 0x04016DC5 RID: 93637
			[FieldOffset(4)]
			public int HttpResponseCode;

			// Token: 0x04016DC6 RID: 93638
			[FieldOffset(8)]
			public FString Data;
		}

		// Token: 0x0200309E RID: 12446
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016DC7 RID: 93639
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
