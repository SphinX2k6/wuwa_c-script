using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200053F RID: 1343
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLoginSuccessType : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C9D RID: 31901 RVA: 0x000B8A24 File Offset: 0x000B6C24
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLoginSuccessType.StaticFunctionPtr();
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x000B8A30 File Offset: 0x000B6C30
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLoginSuccessType._FunctionPtr == IntPtr.Zero)
			{
				FSDKLoginSuccessType._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLoginSuccessType__DelegateSignature");
			}
			return FSDKLoginSuccessType._FunctionPtr;
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x000B8A53 File Offset: 0x000B6C53
		public FSDKLoginSuccessType()
		{
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x000B8A5B File Offset: 0x000B6C5B
		[NullableContext(2)]
		public FSDKLoginSuccessType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x000B8A65 File Offset: 0x000B6C65
		public FSDKLoginSuccessType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x000B8A70 File Offset: 0x000B6C70
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x000B8AA2 File Offset: 0x000B6CA2
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKLoginSuccessType.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKLoginSuccessType.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKLoginSuccessType.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKLoginSuccessType.OnScriptCallback));
				}
				FSDKLoginSuccessType.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKLoginSuccessType.RegisterId);
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x000B8ADC File Offset: 0x000B6CDC
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x000B8AE8 File Offset: 0x000B6CE8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string result)
		{
			FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams* ptr = stackalloc FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKLoginSuccessType.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKLoginSuccessType._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x000B8B3C File Offset: 0x000B6D3C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400353D RID: 13629
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400353E RID: 13630
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLoginSuccessType__DelegateSignature";

		// Token: 0x0400353F RID: 13631
		private static int RegisterId;

		// Token: 0x02000CF3 RID: 3315
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKLoginSuccessType_DelegateParams
		{
			// Token: 0x04005F7A RID: 24442
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02000CF4 RID: 3316
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F7B RID: 24443
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
