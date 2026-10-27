using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA0 RID: 7328
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGetParamsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C724 RID: 116516 RVA: 0x002A081D File Offset: 0x0029EA1D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGetParamsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C725 RID: 116517 RVA: 0x002A0829 File Offset: 0x0029EA29
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGetParamsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGetParamsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGetParamsDelegate__DelegateSignature");
			}
			return FSDKGetParamsDelegate._FunctionPtr;
		}

		// Token: 0x0601C726 RID: 116518 RVA: 0x002A084C File Offset: 0x0029EA4C
		public FSDKGetParamsDelegate()
		{
		}

		// Token: 0x0601C727 RID: 116519 RVA: 0x002A0854 File Offset: 0x0029EA54
		[NullableContext(2)]
		public FSDKGetParamsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C728 RID: 116520 RVA: 0x002A085E File Offset: 0x0029EA5E
		public FSDKGetParamsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C729 RID: 116521 RVA: 0x002A0869 File Offset: 0x0029EA69
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C72A RID: 116522 RVA: 0x002A089B File Offset: 0x0029EA9B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C72B RID: 116523 RVA: 0x002A08D5 File Offset: 0x0029EAD5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C72C RID: 116524 RVA: 0x002A08E0 File Offset: 0x0029EAE0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string source, string result)
		{
			FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams* ptr = stackalloc FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FSDKGetParamsDelegate.__FSDKGetParamsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGetParamsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->source), source);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGetParamsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C72D RID: 116525 RVA: 0x002A0940 File Offset: 0x0029EB40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F4C1 RID: 62657
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4C2 RID: 62658
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGetParamsDelegate__DelegateSignature";

		// Token: 0x0400F4C3 RID: 62659
		private static int RegisterId;

		// Token: 0x02003273 RID: 12915
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FSDKGetParamsDelegate_DelegateParams
		{
			// Token: 0x040170F8 RID: 94456
			[FieldOffset(0)]
			public FString source;

			// Token: 0x040170F9 RID: 94457
			[FieldOffset(16)]
			public FString result;
		}

		// Token: 0x02003274 RID: 12916
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170FA RID: 94458
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
