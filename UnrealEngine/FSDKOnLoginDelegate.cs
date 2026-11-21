using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000542 RID: 1346
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKOnLoginDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CBB RID: 31931 RVA: 0x000B8E41 File Offset: 0x000B7041
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKOnLoginDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x000B8E4D File Offset: 0x000B704D
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKOnLoginDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKOnLoginDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKOnLoginDelegate__DelegateSignature");
			}
			return FSDKOnLoginDelegate._FunctionPtr;
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x000B8E70 File Offset: 0x000B7070
		public FSDKOnLoginDelegate()
		{
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x000B8E78 File Offset: 0x000B7078
		[NullableContext(2)]
		public FSDKOnLoginDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x000B8E82 File Offset: 0x000B7082
		public FSDKOnLoginDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x000B8E8D File Offset: 0x000B708D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CC1 RID: 31937 RVA: 0x000B8EBF File Offset: 0x000B70BF
		[NullableContext(1)]
		public void Add(Action<string> Callback)
		{
			if (FSDKOnLoginDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKOnLoginDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKOnLoginDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKOnLoginDelegate.OnScriptCallback));
				}
				FSDKOnLoginDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKOnLoginDelegate.RegisterId);
		}

		// Token: 0x06007CC2 RID: 31938 RVA: 0x000B8EF9 File Offset: 0x000B70F9
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CC3 RID: 31939 RVA: 0x000B8F04 File Offset: 0x000B7104
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string result)
		{
			FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams* ptr = stackalloc FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKOnLoginDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKOnLoginDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007CC4 RID: 31940 RVA: 0x000B8F58 File Offset: 0x000B7158
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x04003546 RID: 13638
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003547 RID: 13639
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKOnLoginDelegate__DelegateSignature";

		// Token: 0x04003548 RID: 13640
		private static int RegisterId;

		// Token: 0x02000CF8 RID: 3320
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSDKOnLoginDelegate_DelegateParams
		{
			// Token: 0x04005F81 RID: 24449
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02000CF9 RID: 3321
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F82 RID: 24450
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
