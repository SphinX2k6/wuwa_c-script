using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CAD RID: 7341
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKProtocolDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C7A6 RID: 116646 RVA: 0x002A1A42 File Offset: 0x0029FC42
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKProtocolDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C7A7 RID: 116647 RVA: 0x002A1A4E File Offset: 0x0029FC4E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKProtocolDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKProtocolDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKProtocolDelegate__DelegateSignature");
			}
			return FSDKProtocolDelegate._FunctionPtr;
		}

		// Token: 0x0601C7A8 RID: 116648 RVA: 0x002A1A71 File Offset: 0x0029FC71
		public FSDKProtocolDelegate()
		{
		}

		// Token: 0x0601C7A9 RID: 116649 RVA: 0x002A1A79 File Offset: 0x0029FC79
		[NullableContext(2)]
		public FSDKProtocolDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7AA RID: 116650 RVA: 0x002A1A83 File Offset: 0x0029FC83
		public FSDKProtocolDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7AB RID: 116651 RVA: 0x002A1A8E File Offset: 0x0029FC8E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C7AC RID: 116652 RVA: 0x002A1AC0 File Offset: 0x0029FCC0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FSDKProtocolDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKProtocolDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKProtocolDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKProtocolDelegate.OnScriptCallback));
				}
				FSDKProtocolDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKProtocolDelegate.RegisterId);
		}

		// Token: 0x0601C7AD RID: 116653 RVA: 0x002A1AFA File Offset: 0x0029FCFA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C7AE RID: 116654 RVA: 0x002A1B04 File Offset: 0x0029FD04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool result)
		{
			FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams* ptr = stackalloc FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKProtocolDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C7AF RID: 116655 RVA: 0x002A1B40 File Offset: 0x0029FD40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKProtocolDelegate.__FSDKProtocolDelegate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x0400F4E8 RID: 62696
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4E9 RID: 62697
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKProtocolDelegate__DelegateSignature";

		// Token: 0x0400F4EA RID: 62698
		private static int RegisterId;

		// Token: 0x0200328B RID: 12939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FSDKProtocolDelegate_DelegateParams
		{
			// Token: 0x04017116 RID: 94486
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x0200328C RID: 12940
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017117 RID: 94487
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
