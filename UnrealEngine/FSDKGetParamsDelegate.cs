using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000539 RID: 1337
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGetParamsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C61 RID: 31841 RVA: 0x000B81D1 File Offset: 0x000B63D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGetParamsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x000B81DD File Offset: 0x000B63DD
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGetParamsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGetParamsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGetParamsDelegate__DelegateSignature");
			}
			return FSDKGetParamsDelegate._FunctionPtr;
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x000B8200 File Offset: 0x000B6400
		public FSDKGetParamsDelegate()
		{
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x000B8208 File Offset: 0x000B6408
		[NullableContext(2)]
		public FSDKGetParamsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x000B8212 File Offset: 0x000B6412
		public FSDKGetParamsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x000B821D File Offset: 0x000B641D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x000B824F File Offset: 0x000B644F
		[NullableContext(1)]
		public void Add(Action<string, string> Callback)
		{
			if (FSDKGetParamsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKGetParamsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKGetParamsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKGetParamsDelegate.OnScriptCallback));
				}
				FSDKGetParamsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKGetParamsDelegate.RegisterId);
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x000B8289 File Offset: 0x000B6489
		[NullableContext(1)]
		public void Remove(Action<string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x000B8294 File Offset: 0x000B6494
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string source, string result)
		{
			FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams* ptr = stackalloc FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGetParamsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->source), source);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGetParamsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x000B82F4 File Offset: 0x000B64F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams*)__Parameters)->source));
			string arg2 = FString.ToString((void*)(&((FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams*)__Parameters)->result));
			action(arg, arg2);
		}

		// Token: 0x0400352B RID: 13611
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400352C RID: 13612
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGetParamsDelegate__DelegateSignature";

		// Token: 0x0400352D RID: 13613
		private static int RegisterId;

		// Token: 0x02000CE8 RID: 3304
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FSDKGetParamsDelegate_DelegateParams
		{
			// Token: 0x04005F6C RID: 24428
			[FieldOffset(0)]
			public FString source;

			// Token: 0x04005F6D RID: 24429
			[FieldOffset(16)]
			public FString result;
		}

		// Token: 0x02000CE9 RID: 3305
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F6E RID: 24430
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
