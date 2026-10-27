using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C97 RID: 7319
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKAnnounceRedPointDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6CA RID: 116426 RVA: 0x0029FB6A File Offset: 0x0029DD6A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKAnnounceRedPointDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6CB RID: 116427 RVA: 0x0029FB76 File Offset: 0x0029DD76
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKAnnounceRedPointDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKAnnounceRedPointDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKAnnounceRedPointDelegate__DelegateSignature");
			}
			return FSDKAnnounceRedPointDelegate._FunctionPtr;
		}

		// Token: 0x0601C6CC RID: 116428 RVA: 0x0029FB99 File Offset: 0x0029DD99
		public FSDKAnnounceRedPointDelegate()
		{
		}

		// Token: 0x0601C6CD RID: 116429 RVA: 0x0029FBA1 File Offset: 0x0029DDA1
		[NullableContext(2)]
		public FSDKAnnounceRedPointDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6CE RID: 116430 RVA: 0x0029FBAB File Offset: 0x0029DDAB
		public FSDKAnnounceRedPointDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6CF RID: 116431 RVA: 0x0029FBB6 File Offset: 0x0029DDB6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6D0 RID: 116432 RVA: 0x0029FBE8 File Offset: 0x0029DDE8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKAnnounceRedPointDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKAnnounceRedPointDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKAnnounceRedPointDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKAnnounceRedPointDelegate.OnScriptCallback));
				}
				FSDKAnnounceRedPointDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKAnnounceRedPointDelegate.RegisterId);
		}

		// Token: 0x0601C6D1 RID: 116433 RVA: 0x0029FC22 File Offset: 0x0029DE22
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C6D2 RID: 116434 RVA: 0x0029FC2C File Offset: 0x0029DE2C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string result)
		{
			FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams* ptr = stackalloc FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKAnnounceRedPointDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKAnnounceRedPointDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C6D3 RID: 116435 RVA: 0x0029FC80 File Offset: 0x0029DE80
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
			string obj = FString.ToString((void*)(&((FSDKAnnounceRedPointDelegate.__FSDKAnnounceRedPointDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400F4A6 RID: 62630
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4A7 RID: 62631
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKAnnounceRedPointDelegate__DelegateSignature";

		// Token: 0x0400F4A8 RID: 62632
		private static int RegisterId;

		// Token: 0x02003262 RID: 12898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKAnnounceRedPointDelegate_DelegateParams
		{
			// Token: 0x040170E3 RID: 94435
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02003263 RID: 12899
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170E4 RID: 94436
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
