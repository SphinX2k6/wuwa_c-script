using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200053A RID: 1338
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGetSharePlatformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007C6B RID: 31851 RVA: 0x000B8355 File Offset: 0x000B6555
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGetSharePlatformDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x000B8361 File Offset: 0x000B6561
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGetSharePlatformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGetSharePlatformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGetSharePlatformDelegate__DelegateSignature");
			}
			return FSDKGetSharePlatformDelegate._FunctionPtr;
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x000B8384 File Offset: 0x000B6584
		public FSDKGetSharePlatformDelegate()
		{
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x000B838C File Offset: 0x000B658C
		[NullableContext(2)]
		public FSDKGetSharePlatformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x000B8396 File Offset: 0x000B6596
		public FSDKGetSharePlatformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x000B83A1 File Offset: 0x000B65A1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, string, string>) ?? ((Action<int, string, string>)Delegate.CreateDelegate(typeof(Action<int, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x000B83D3 File Offset: 0x000B65D3
		[NullableContext(1)]
		public void Add(Action<int, string, string> Callback)
		{
			if (FSDKGetSharePlatformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKGetSharePlatformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKGetSharePlatformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKGetSharePlatformDelegate.OnScriptCallback));
				}
				FSDKGetSharePlatformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKGetSharePlatformDelegate.RegisterId);
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x000B840D File Offset: 0x000B660D
		[NullableContext(1)]
		public void Remove(Action<int, string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x000B8418 File Offset: 0x000B6618
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(int code, string value, string msg)
		{
			FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams* ptr = stackalloc FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGetSharePlatformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->code = code;
			FString.CopyFrom((void*)(&ptr->value), value);
			FString.CopyFrom((void*)(&ptr->msg), msg);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGetSharePlatformDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x000B8480 File Offset: 0x000B6680
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string, string> action = target as Action<int, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams*)__Parameters)->value));
			string arg2 = FString.ToString((void*)(&((FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams*)__Parameters)->msg));
			action(((FSDKGetSharePlatformDelegate.__FSDKGetSharePlatformDelegate_DelegateParams*)__Parameters)->code, arg, arg2);
		}

		// Token: 0x0400352E RID: 13614
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400352F RID: 13615
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGetSharePlatformDelegate__DelegateSignature";

		// Token: 0x04003530 RID: 13616
		private static int RegisterId;

		// Token: 0x02000CEA RID: 3306
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FSDKGetSharePlatformDelegate_DelegateParams
		{
			// Token: 0x04005F6F RID: 24431
			[FieldOffset(0)]
			public int code;

			// Token: 0x04005F70 RID: 24432
			[FieldOffset(8)]
			public FString value;

			// Token: 0x04005F71 RID: 24433
			[FieldOffset(24)]
			public FString msg;
		}

		// Token: 0x02000CEB RID: 3307
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F72 RID: 24434
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
