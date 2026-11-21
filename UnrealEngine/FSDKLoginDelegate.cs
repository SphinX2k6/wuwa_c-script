using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200053E RID: 1342
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLoginDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C93 RID: 31891 RVA: 0x000B88A6 File Offset: 0x000B6AA6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLoginDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C94 RID: 31892 RVA: 0x000B88B2 File Offset: 0x000B6AB2
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLoginDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKLoginDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLoginDelegate__DelegateSignature");
			}
			return FSDKLoginDelegate._FunctionPtr;
		}

		// Token: 0x06007C95 RID: 31893 RVA: 0x000B88D5 File Offset: 0x000B6AD5
		public FSDKLoginDelegate()
		{
		}

		// Token: 0x06007C96 RID: 31894 RVA: 0x000B88DD File Offset: 0x000B6ADD
		[NullableContext(2)]
		public FSDKLoginDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C97 RID: 31895 RVA: 0x000B88E7 File Offset: 0x000B6AE7
		public FSDKLoginDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x000B88F2 File Offset: 0x000B6AF2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FLoginStruct>) ?? ((Action<FLoginStruct>)Delegate.CreateDelegate(typeof(Action<FLoginStruct>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x000B8924 File Offset: 0x000B6B24
		[NullableContext(1)]
		public void Add(Action<FLoginStruct> Callback)
		{
			if (FSDKLoginDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKLoginDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKLoginDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKLoginDelegate.OnScriptCallback));
				}
				FSDKLoginDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKLoginDelegate.RegisterId);
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x000B895E File Offset: 0x000B6B5E
		[NullableContext(1)]
		public void Remove(Action<FLoginStruct> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C9B RID: 31899 RVA: 0x000B8968 File Offset: 0x000B6B68
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(FLoginStruct LoginInfo)
		{
			FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams* ptr = stackalloc FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams[(UIntPtr)103] + 15L / (long)sizeof(FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKLoginDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (LoginInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FLoginStruct.StaticStruct(), &ptr->LoginInfo, LoginInfo.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKLoginDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x000B89D0 File Offset: 0x000B6BD0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FLoginStruct> action = target as Action<FLoginStruct>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FLoginStruct obj = new FLoginStruct(&((FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams*)__Parameters)->LoginInfo, true, true);
			action(obj);
		}

		// Token: 0x0400353A RID: 13626
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400353B RID: 13627
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLoginDelegate__DelegateSignature";

		// Token: 0x0400353C RID: 13628
		private static int RegisterId;

		// Token: 0x02000CF1 RID: 3313
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		private ref struct __FSDKLoginDelegate_DelegateParams
		{
			// Token: 0x04005F78 RID: 24440
			[FieldOffset(0)]
			public byte LoginInfo;
		}

		// Token: 0x02000CF2 RID: 3314
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F79 RID: 24441
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
