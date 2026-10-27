using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CAE RID: 7342
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKRequestPermissionResultDelagate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C7B0 RID: 116656 RVA: 0x002A1B8A File Offset: 0x0029FD8A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKRequestPermissionResultDelagate.StaticFunctionPtr();
		}

		// Token: 0x0601C7B1 RID: 116657 RVA: 0x002A1B96 File Offset: 0x0029FD96
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKRequestPermissionResultDelagate._FunctionPtr == IntPtr.Zero)
			{
				FSDKRequestPermissionResultDelagate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKRequestPermissionResultDelagate__DelegateSignature");
			}
			return FSDKRequestPermissionResultDelagate._FunctionPtr;
		}

		// Token: 0x0601C7B2 RID: 116658 RVA: 0x002A1BB9 File Offset: 0x0029FDB9
		public FSDKRequestPermissionResultDelagate()
		{
		}

		// Token: 0x0601C7B3 RID: 116659 RVA: 0x002A1BC1 File Offset: 0x0029FDC1
		[NullableContext(2)]
		public FSDKRequestPermissionResultDelagate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7B4 RID: 116660 RVA: 0x002A1BCB File Offset: 0x0029FDCB
		public FSDKRequestPermissionResultDelagate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7B5 RID: 116661 RVA: 0x002A1BD6 File Offset: 0x0029FDD6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C7B6 RID: 116662 RVA: 0x002A1C08 File Offset: 0x0029FE08
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FSDKRequestPermissionResultDelagate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKRequestPermissionResultDelagate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKRequestPermissionResultDelagate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKRequestPermissionResultDelagate.OnScriptCallback));
				}
				FSDKRequestPermissionResultDelagate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKRequestPermissionResultDelagate.RegisterId);
		}

		// Token: 0x0601C7B7 RID: 116663 RVA: 0x002A1C42 File Offset: 0x0029FE42
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C7B8 RID: 116664 RVA: 0x002A1C4C File Offset: 0x0029FE4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool result)
		{
			FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams* ptr = stackalloc FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKRequestPermissionResultDelagate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C7B9 RID: 116665 RVA: 0x002A1C88 File Offset: 0x0029FE88
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
			action(((FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x0400F4EB RID: 62699
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4EC RID: 62700
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKRequestPermissionResultDelagate__DelegateSignature";

		// Token: 0x0400F4ED RID: 62701
		private static int RegisterId;

		// Token: 0x0200328D RID: 12941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FSDKRequestPermissionResultDelagate_DelegateParams
		{
			// Token: 0x04017118 RID: 94488
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x0200328E RID: 12942
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017119 RID: 94489
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
