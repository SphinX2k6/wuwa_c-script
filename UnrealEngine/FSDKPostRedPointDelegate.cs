using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CAB RID: 7339
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKPostRedPointDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C792 RID: 116626 RVA: 0x002A1793 File Offset: 0x0029F993
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKPostRedPointDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C793 RID: 116627 RVA: 0x002A179F File Offset: 0x0029F99F
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKPostRedPointDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKPostRedPointDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKPostRedPointDelegate__DelegateSignature");
			}
			return FSDKPostRedPointDelegate._FunctionPtr;
		}

		// Token: 0x0601C794 RID: 116628 RVA: 0x002A17C2 File Offset: 0x0029F9C2
		public FSDKPostRedPointDelegate()
		{
		}

		// Token: 0x0601C795 RID: 116629 RVA: 0x002A17CA File Offset: 0x0029F9CA
		[NullableContext(2)]
		public FSDKPostRedPointDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C796 RID: 116630 RVA: 0x002A17D4 File Offset: 0x0029F9D4
		public FSDKPostRedPointDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C797 RID: 116631 RVA: 0x002A17DF File Offset: 0x0029F9DF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C798 RID: 116632 RVA: 0x002A1811 File Offset: 0x0029FA11
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<byte> Callback)
		{
			if (FSDKPostRedPointDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKPostRedPointDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKPostRedPointDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKPostRedPointDelegate.OnScriptCallback));
				}
				FSDKPostRedPointDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKPostRedPointDelegate.RegisterId);
		}

		// Token: 0x0601C799 RID: 116633 RVA: 0x002A184B File Offset: 0x0029FA4B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C79A RID: 116634 RVA: 0x002A1854 File Offset: 0x0029FA54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(byte flagId)
		{
			FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams* ptr = stackalloc FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKPostRedPointDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->flagId = flagId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C79B RID: 116635 RVA: 0x002A1890 File Offset: 0x0029FA90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKPostRedPointDelegate.__FSDKPostRedPointDelegate_DelegateParams*)__Parameters)->flagId);
		}

		// Token: 0x0400F4E2 RID: 62690
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4E3 RID: 62691
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKPostRedPointDelegate__DelegateSignature";

		// Token: 0x0400F4E4 RID: 62692
		private static int RegisterId;

		// Token: 0x02003287 RID: 12935
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FSDKPostRedPointDelegate_DelegateParams
		{
			// Token: 0x04017112 RID: 94482
			[FieldOffset(0)]
			public byte flagId;
		}

		// Token: 0x02003288 RID: 12936
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017113 RID: 94483
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
