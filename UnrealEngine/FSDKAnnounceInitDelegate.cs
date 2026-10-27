using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C95 RID: 7317
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKAnnounceInitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6B6 RID: 116406 RVA: 0x0029F89A File Offset: 0x0029DA9A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKAnnounceInitDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6B7 RID: 116407 RVA: 0x0029F8A6 File Offset: 0x0029DAA6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKAnnounceInitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKAnnounceInitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKAnnounceInitDelegate__DelegateSignature");
			}
			return FSDKAnnounceInitDelegate._FunctionPtr;
		}

		// Token: 0x0601C6B8 RID: 116408 RVA: 0x0029F8C9 File Offset: 0x0029DAC9
		public FSDKAnnounceInitDelegate()
		{
		}

		// Token: 0x0601C6B9 RID: 116409 RVA: 0x0029F8D1 File Offset: 0x0029DAD1
		[NullableContext(2)]
		public FSDKAnnounceInitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6BA RID: 116410 RVA: 0x0029F8DB File Offset: 0x0029DADB
		public FSDKAnnounceInitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6BB RID: 116411 RVA: 0x0029F8E6 File Offset: 0x0029DAE6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6BC RID: 116412 RVA: 0x0029F918 File Offset: 0x0029DB18
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKAnnounceInitDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKAnnounceInitDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKAnnounceInitDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKAnnounceInitDelegate.OnScriptCallback));
				}
				FSDKAnnounceInitDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKAnnounceInitDelegate.RegisterId);
		}

		// Token: 0x0601C6BD RID: 116413 RVA: 0x0029F952 File Offset: 0x0029DB52
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C6BE RID: 116414 RVA: 0x0029F95C File Offset: 0x0029DB5C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string result)
		{
			FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams* ptr = stackalloc FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKAnnounceInitDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKAnnounceInitDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C6BF RID: 116415 RVA: 0x0029F9B0 File Offset: 0x0029DBB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKAnnounceInitDelegate.__FSDKAnnounceInitDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400F4A0 RID: 62624
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4A1 RID: 62625
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKAnnounceInitDelegate__DelegateSignature";

		// Token: 0x0400F4A2 RID: 62626
		private static int RegisterId;

		// Token: 0x0200325E RID: 12894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKAnnounceInitDelegate_DelegateParams
		{
			// Token: 0x040170DF RID: 94431
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x0200325F RID: 12895
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170E0 RID: 94432
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
