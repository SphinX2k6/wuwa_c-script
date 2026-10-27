using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C9E RID: 7326
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKGameStateChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C710 RID: 116496 RVA: 0x002A0532 File Offset: 0x0029E732
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKGameStateChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C711 RID: 116497 RVA: 0x002A053E File Offset: 0x0029E73E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKGameStateChangeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKGameStateChangeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKGameStateChangeDelegate__DelegateSignature");
			}
			return FSDKGameStateChangeDelegate._FunctionPtr;
		}

		// Token: 0x0601C712 RID: 116498 RVA: 0x002A0561 File Offset: 0x0029E761
		public FSDKGameStateChangeDelegate()
		{
		}

		// Token: 0x0601C713 RID: 116499 RVA: 0x002A0569 File Offset: 0x0029E769
		[NullableContext(2)]
		public FSDKGameStateChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C714 RID: 116500 RVA: 0x002A0573 File Offset: 0x0029E773
		public FSDKGameStateChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C715 RID: 116501 RVA: 0x002A057E File Offset: 0x0029E77E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C716 RID: 116502 RVA: 0x002A05B0 File Offset: 0x0029E7B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKGameStateChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKGameStateChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKGameStateChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKGameStateChangeDelegate.OnScriptCallback));
				}
				FSDKGameStateChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKGameStateChangeDelegate.RegisterId);
		}

		// Token: 0x0601C717 RID: 116503 RVA: 0x002A05EA File Offset: 0x0029E7EA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C718 RID: 116504 RVA: 0x002A05F4 File Offset: 0x0029E7F4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string data)
		{
			FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams* ptr = stackalloc FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKGameStateChangeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKGameStateChangeDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C719 RID: 116505 RVA: 0x002A0648 File Offset: 0x0029E848
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKGameStateChangeDelegate.__FSDKGameStateChangeDelegate_DelegateParams*)__Parameters)->data));
			action(obj);
		}

		// Token: 0x0400F4BB RID: 62651
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4BC RID: 62652
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKGameStateChangeDelegate__DelegateSignature";

		// Token: 0x0400F4BD RID: 62653
		private static int RegisterId;

		// Token: 0x0200326F RID: 12911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKGameStateChangeDelegate_DelegateParams
		{
			// Token: 0x040170F3 RID: 94451
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003270 RID: 12912
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170F4 RID: 94452
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
