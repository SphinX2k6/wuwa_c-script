using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000548 RID: 1352
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKSdkInitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CF7 RID: 31991 RVA: 0x000B9686 File Offset: 0x000B7886
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKSdkInitDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x000B9692 File Offset: 0x000B7892
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKSdkInitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKSdkInitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKSdkInitDelegate__DelegateSignature");
			}
			return FSDKSdkInitDelegate._FunctionPtr;
		}

		// Token: 0x06007CF9 RID: 31993 RVA: 0x000B96B5 File Offset: 0x000B78B5
		public FSDKSdkInitDelegate()
		{
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x000B96BD File Offset: 0x000B78BD
		[NullableContext(2)]
		public FSDKSdkInitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x000B96C7 File Offset: 0x000B78C7
		public FSDKSdkInitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x000B96D2 File Offset: 0x000B78D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x000B9704 File Offset: 0x000B7904
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FSDKSdkInitDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKSdkInitDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKSdkInitDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKSdkInitDelegate.OnScriptCallback));
				}
				FSDKSdkInitDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKSdkInitDelegate.RegisterId);
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x000B973E File Offset: 0x000B793E
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x000B9748 File Offset: 0x000B7948
		[SkipLocalsInit]
		public unsafe void Broadcast(bool result)
		{
			FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams* ptr = stackalloc FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKSdkInitDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007D00 RID: 32000 RVA: 0x000B9784 File Offset: 0x000B7984
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x04003558 RID: 13656
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003559 RID: 13657
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKSdkInitDelegate__DelegateSignature";

		// Token: 0x0400355A RID: 13658
		private static int RegisterId;

		// Token: 0x02000D04 RID: 3332
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FSDKSdkInitDelegate_DelegateParams
		{
			// Token: 0x04005F8E RID: 24462
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x02000D05 RID: 3333
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F8F RID: 24463
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
