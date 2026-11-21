using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000537 RID: 1335
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGameStateChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C4D RID: 31821 RVA: 0x000B7EE6 File Offset: 0x000B60E6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGameStateChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C4E RID: 31822 RVA: 0x000B7EF2 File Offset: 0x000B60F2
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGameStateChangeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGameStateChangeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGameStateChangeDelegate__DelegateSignature");
			}
			return FSDKGameStateChangeDelegate._FunctionPtr;
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x000B7F15 File Offset: 0x000B6115
		public FSDKGameStateChangeDelegate()
		{
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x000B7F1D File Offset: 0x000B611D
		[NullableContext(2)]
		public FSDKGameStateChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x000B7F27 File Offset: 0x000B6127
		public FSDKGameStateChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x000B7F32 File Offset: 0x000B6132
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x000B7F64 File Offset: 0x000B6164
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKGameStateChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKGameStateChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKGameStateChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKGameStateChangeDelegate.OnScriptCallback));
				}
				FSDKGameStateChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKGameStateChangeDelegate.RegisterId);
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x000B7F9E File Offset: 0x000B619E
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x000B7FA8 File Offset: 0x000B61A8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string data)
		{
			FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams* ptr = stackalloc FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGameStateChangeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGameStateChangeDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x000B7FFC File Offset: 0x000B61FC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams*)__Parameters)->data));
			action(obj);
		}

		// Token: 0x04003525 RID: 13605
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003526 RID: 13606
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGameStateChangeDelegate__DelegateSignature";

		// Token: 0x04003527 RID: 13607
		private static int RegisterId;

		// Token: 0x02000CE4 RID: 3300
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKGameStateChangeDelegate_DelegateParams
		{
			// Token: 0x04005F67 RID: 24423
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CE5 RID: 3301
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F68 RID: 24424
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
