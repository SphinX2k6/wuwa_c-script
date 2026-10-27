using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C96 RID: 7318
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKAnnounceOpenDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6C0 RID: 116416 RVA: 0x0029FA02 File Offset: 0x0029DC02
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKAnnounceOpenDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6C1 RID: 116417 RVA: 0x0029FA0E File Offset: 0x0029DC0E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKAnnounceOpenDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKAnnounceOpenDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKAnnounceOpenDelegate__DelegateSignature");
			}
			return FSDKAnnounceOpenDelegate._FunctionPtr;
		}

		// Token: 0x0601C6C2 RID: 116418 RVA: 0x0029FA31 File Offset: 0x0029DC31
		public FSDKAnnounceOpenDelegate()
		{
		}

		// Token: 0x0601C6C3 RID: 116419 RVA: 0x0029FA39 File Offset: 0x0029DC39
		[NullableContext(2)]
		public FSDKAnnounceOpenDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6C4 RID: 116420 RVA: 0x0029FA43 File Offset: 0x0029DC43
		public FSDKAnnounceOpenDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6C5 RID: 116421 RVA: 0x0029FA4E File Offset: 0x0029DC4E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6C6 RID: 116422 RVA: 0x0029FA80 File Offset: 0x0029DC80
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKAnnounceOpenDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKAnnounceOpenDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKAnnounceOpenDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKAnnounceOpenDelegate.OnScriptCallback));
				}
				FSDKAnnounceOpenDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKAnnounceOpenDelegate.RegisterId);
		}

		// Token: 0x0601C6C7 RID: 116423 RVA: 0x0029FABA File Offset: 0x0029DCBA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C6C8 RID: 116424 RVA: 0x0029FAC4 File Offset: 0x0029DCC4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string result)
		{
			FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams* ptr = stackalloc FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKAnnounceOpenDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKAnnounceOpenDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C6C9 RID: 116425 RVA: 0x0029FB18 File Offset: 0x0029DD18
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
			string obj = FString.ToString((void*)(&((FSDKAnnounceOpenDelegate.__FSDKAnnounceOpenDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400F4A3 RID: 62627
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4A4 RID: 62628
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKAnnounceOpenDelegate__DelegateSignature";

		// Token: 0x0400F4A5 RID: 62629
		private static int RegisterId;

		// Token: 0x02003260 RID: 12896
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKAnnounceOpenDelegate_DelegateParams
		{
			// Token: 0x040170E1 RID: 94433
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02003261 RID: 12897
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170E2 RID: 94434
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
