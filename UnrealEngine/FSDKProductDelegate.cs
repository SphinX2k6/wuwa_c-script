using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CAC RID: 7340
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKProductDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C79C RID: 116636 RVA: 0x002A18DA File Offset: 0x0029FADA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKProductDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C79D RID: 116637 RVA: 0x002A18E6 File Offset: 0x0029FAE6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKProductDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKProductDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKProductDelegate__DelegateSignature");
			}
			return FSDKProductDelegate._FunctionPtr;
		}

		// Token: 0x0601C79E RID: 116638 RVA: 0x002A1909 File Offset: 0x0029FB09
		public FSDKProductDelegate()
		{
		}

		// Token: 0x0601C79F RID: 116639 RVA: 0x002A1911 File Offset: 0x0029FB11
		[NullableContext(2)]
		public FSDKProductDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7A0 RID: 116640 RVA: 0x002A191B File Offset: 0x0029FB1B
		public FSDKProductDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7A1 RID: 116641 RVA: 0x002A1926 File Offset: 0x0029FB26
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C7A2 RID: 116642 RVA: 0x002A1958 File Offset: 0x0029FB58
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKProductDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKProductDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKProductDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKProductDelegate.OnScriptCallback));
				}
				FSDKProductDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKProductDelegate.RegisterId);
		}

		// Token: 0x0601C7A3 RID: 116643 RVA: 0x002A1992 File Offset: 0x0029FB92
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C7A4 RID: 116644 RVA: 0x002A199C File Offset: 0x0029FB9C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string str)
		{
			FSDKProductDelegate.__FSDKProductDelegate_DelegateParams* ptr = stackalloc FSDKProductDelegate.__FSDKProductDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKProductDelegate.__FSDKProductDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKProductDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->str), str);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKProductDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C7A5 RID: 116645 RVA: 0x002A19F0 File Offset: 0x0029FBF0
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
			string obj = FString.ToString((void*)(&((FSDKProductDelegate.__FSDKProductDelegate_DelegateParams*)__Parameters)->str));
			action(obj);
		}

		// Token: 0x0400F4E5 RID: 62693
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4E6 RID: 62694
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKProductDelegate__DelegateSignature";

		// Token: 0x0400F4E7 RID: 62695
		private static int RegisterId;

		// Token: 0x02003289 RID: 12937
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKProductDelegate_DelegateParams
		{
			// Token: 0x04017114 RID: 94484
			[FieldOffset(0)]
			public FString str;
		}

		// Token: 0x0200328A RID: 12938
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017115 RID: 94485
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
