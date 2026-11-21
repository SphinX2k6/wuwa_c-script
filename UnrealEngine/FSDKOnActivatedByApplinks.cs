using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000541 RID: 1345
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKOnActivatedByApplinks : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CB1 RID: 31921 RVA: 0x000B8C9E File Offset: 0x000B6E9E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKOnActivatedByApplinks.StaticFunctionPtr();
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x000B8CAA File Offset: 0x000B6EAA
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKOnActivatedByApplinks._FunctionPtr == IntPtr.Zero)
			{
				FSDKOnActivatedByApplinks._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKOnActivatedByApplinks__DelegateSignature");
			}
			return FSDKOnActivatedByApplinks._FunctionPtr;
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x000B8CCD File Offset: 0x000B6ECD
		public FSDKOnActivatedByApplinks()
		{
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x000B8CD5 File Offset: 0x000B6ED5
		[NullableContext(2)]
		public FSDKOnActivatedByApplinks(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x000B8CDF File Offset: 0x000B6EDF
		public FSDKOnActivatedByApplinks(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CB6 RID: 31926 RVA: 0x000B8CEA File Offset: 0x000B6EEA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string, string>) ?? ((Action<string, string, string>)Delegate.CreateDelegate(typeof(Action<string, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x000B8D1C File Offset: 0x000B6F1C
		[NullableContext(1)]
		public void Add(Action<string, string, string> Callback)
		{
			if (FSDKOnActivatedByApplinks.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKOnActivatedByApplinks.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKOnActivatedByApplinks.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKOnActivatedByApplinks.OnScriptCallback));
				}
				FSDKOnActivatedByApplinks.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKOnActivatedByApplinks.RegisterId);
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x000B8D56 File Offset: 0x000B6F56
		[NullableContext(1)]
		public void Remove(Action<string, string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x000B8D60 File Offset: 0x000B6F60
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string Host, string DeepValue, string Source)
		{
			FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams* ptr = stackalloc FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKOnActivatedByApplinks.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Host), Host);
			FString.CopyFrom((void*)(&ptr->DeepValue), DeepValue);
			FString.CopyFrom((void*)(&ptr->Source), Source);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKOnActivatedByApplinks._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x000B8DD0 File Offset: 0x000B6FD0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string, string> action = target as Action<string, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams*)__Parameters)->Host));
			string arg2 = FString.ToString((void*)(&((FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams*)__Parameters)->DeepValue));
			string arg3 = FString.ToString((void*)(&((FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams*)__Parameters)->Source));
			action(arg, arg2, arg3);
		}

		// Token: 0x04003543 RID: 13635
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003544 RID: 13636
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKOnActivatedByApplinks__DelegateSignature";

		// Token: 0x04003545 RID: 13637
		private static int RegisterId;

		// Token: 0x02000CF6 RID: 3318
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FSDKOnActivatedByApplinks_DelegateParams
		{
			// Token: 0x04005F7D RID: 24445
			[FieldOffset(0)]
			public FString Host;

			// Token: 0x04005F7E RID: 24446
			[FieldOffset(16)]
			public FString DeepValue;

			// Token: 0x04005F7F RID: 24447
			[FieldOffset(32)]
			public FString Source;
		}

		// Token: 0x02000CF7 RID: 3319
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F80 RID: 24448
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
