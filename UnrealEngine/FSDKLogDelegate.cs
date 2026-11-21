using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200053D RID: 1341
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLogDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C89 RID: 31881 RVA: 0x000B873E File Offset: 0x000B693E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLogDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x000B874A File Offset: 0x000B694A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLogDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKLogDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLogDelegate__DelegateSignature");
			}
			return FSDKLogDelegate._FunctionPtr;
		}

		// Token: 0x06007C8B RID: 31883 RVA: 0x000B876D File Offset: 0x000B696D
		public FSDKLogDelegate()
		{
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x000B8775 File Offset: 0x000B6975
		[NullableContext(2)]
		public FSDKLogDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x000B877F File Offset: 0x000B697F
		public FSDKLogDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x000B878A File Offset: 0x000B698A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x000B87BC File Offset: 0x000B69BC
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKLogDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKLogDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKLogDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKLogDelegate.OnScriptCallback));
				}
				FSDKLogDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKLogDelegate.RegisterId);
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x000B87F6 File Offset: 0x000B69F6
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x000B8800 File Offset: 0x000B6A00
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string log)
		{
			FSDKLogDelegate.__FSDKLogDelegate_DelegateParams* ptr = stackalloc FSDKLogDelegate.__FSDKLogDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKLogDelegate.__FSDKLogDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKLogDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->log), log);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKLogDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x000B8854 File Offset: 0x000B6A54
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKLogDelegate.__FSDKLogDelegate_DelegateParams*)__Parameters)->log));
			action(obj);
		}

		// Token: 0x04003537 RID: 13623
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003538 RID: 13624
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLogDelegate__DelegateSignature";

		// Token: 0x04003539 RID: 13625
		private static int RegisterId;

		// Token: 0x02000CEF RID: 3311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKLogDelegate_DelegateParams
		{
			// Token: 0x04005F76 RID: 24438
			[FieldOffset(0)]
			public FString log;
		}

		// Token: 0x02000CF0 RID: 3312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F77 RID: 24439
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
