using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001470 RID: 5232
	public sealed class FXRDeviceOnDisconnectDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06013154 RID: 78164 RVA: 0x001C1156 File Offset: 0x001BF356
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FXRDeviceOnDisconnectDelegate.StaticFunctionPtr();
		}

		// Token: 0x06013155 RID: 78165 RVA: 0x001C1162 File Offset: 0x001BF362
		private static IntPtr StaticFunctionPtr()
		{
			if (FXRDeviceOnDisconnectDelegate._FunctionPtr == IntPtr.Zero)
			{
				FXRDeviceOnDisconnectDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/HeadMountedDisplay.XRDeviceOnDisconnectDelegate__DelegateSignature");
			}
			return FXRDeviceOnDisconnectDelegate._FunctionPtr;
		}

		// Token: 0x06013156 RID: 78166 RVA: 0x001C1185 File Offset: 0x001BF385
		public FXRDeviceOnDisconnectDelegate()
		{
		}

		// Token: 0x06013157 RID: 78167 RVA: 0x001C118D File Offset: 0x001BF38D
		[NullableContext(2)]
		public FXRDeviceOnDisconnectDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013158 RID: 78168 RVA: 0x001C1197 File Offset: 0x001BF397
		public FXRDeviceOnDisconnectDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013159 RID: 78169 RVA: 0x001C11A2 File Offset: 0x001BF3A2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601315A RID: 78170 RVA: 0x001C11D4 File Offset: 0x001BF3D4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FXRDeviceOnDisconnectDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FXRDeviceOnDisconnectDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FXRDeviceOnDisconnectDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FXRDeviceOnDisconnectDelegate.OnScriptCallback));
				}
				FXRDeviceOnDisconnectDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FXRDeviceOnDisconnectDelegate.RegisterId);
		}

		// Token: 0x0601315B RID: 78171 RVA: 0x001C1210 File Offset: 0x001BF410
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string OutReason)
		{
			FXRDeviceOnDisconnectDelegate.__FXRDeviceOnDisconnectDelegate_DelegateParams* ptr = stackalloc FXRDeviceOnDisconnectDelegate.__FXRDeviceOnDisconnectDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FXRDeviceOnDisconnectDelegate.__FXRDeviceOnDisconnectDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FXRDeviceOnDisconnectDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OutReason), OutReason);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FXRDeviceOnDisconnectDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601315C RID: 78172 RVA: 0x001C1264 File Offset: 0x001BF464
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
			string obj = FString.ToString((void*)(&((FXRDeviceOnDisconnectDelegate.__FXRDeviceOnDisconnectDelegate_DelegateParams*)__Parameters)->OutReason));
			action(obj);
		}

		// Token: 0x0400A3B3 RID: 41907
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A3B4 RID: 41908
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HeadMountedDisplay.XRDeviceOnDisconnectDelegate__DelegateSignature";

		// Token: 0x0400A3B5 RID: 41909
		private static int RegisterId;

		// Token: 0x02002EAE RID: 11950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FXRDeviceOnDisconnectDelegate_DelegateParams
		{
			// Token: 0x040169A9 RID: 92585
			[FieldOffset(0)]
			public FString OutReason;
		}

		// Token: 0x02002EAF RID: 11951
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169AA RID: 92586
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
