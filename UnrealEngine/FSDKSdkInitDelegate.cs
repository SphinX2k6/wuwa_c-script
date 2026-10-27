using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CAF RID: 7343
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKSdkInitDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C7BA RID: 116666 RVA: 0x002A1CD2 File Offset: 0x0029FED2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKSdkInitDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C7BB RID: 116667 RVA: 0x002A1CDE File Offset: 0x0029FEDE
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKSdkInitDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKSdkInitDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKSdkInitDelegate__DelegateSignature");
			}
			return FSDKSdkInitDelegate._FunctionPtr;
		}

		// Token: 0x0601C7BC RID: 116668 RVA: 0x002A1D01 File Offset: 0x0029FF01
		public FSDKSdkInitDelegate()
		{
		}

		// Token: 0x0601C7BD RID: 116669 RVA: 0x002A1D09 File Offset: 0x0029FF09
		[NullableContext(2)]
		public FSDKSdkInitDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7BE RID: 116670 RVA: 0x002A1D13 File Offset: 0x0029FF13
		public FSDKSdkInitDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7BF RID: 116671 RVA: 0x002A1D1E File Offset: 0x0029FF1E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C7C0 RID: 116672 RVA: 0x002A1D50 File Offset: 0x0029FF50
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C7C1 RID: 116673 RVA: 0x002A1D8A File Offset: 0x0029FF8A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C7C2 RID: 116674 RVA: 0x002A1D94 File Offset: 0x0029FF94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool result)
		{
			FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams* ptr = stackalloc FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKSdkInitDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C7C3 RID: 116675 RVA: 0x002A1DD0 File Offset: 0x0029FFD0
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
			action(((FSDKSdkInitDelegate.__FSDKSdkInitDelegate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x0400F4EE RID: 62702
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4EF RID: 62703
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKSdkInitDelegate__DelegateSignature";

		// Token: 0x0400F4F0 RID: 62704
		private static int RegisterId;

		// Token: 0x0200328F RID: 12943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FSDKSdkInitDelegate_DelegateParams
		{
			// Token: 0x0401711A RID: 94490
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x02003290 RID: 12944
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401711B RID: 94491
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
