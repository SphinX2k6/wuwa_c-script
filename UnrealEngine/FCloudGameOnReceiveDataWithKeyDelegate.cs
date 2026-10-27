using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200173C RID: 5948
	public sealed class FCloudGameOnReceiveDataWithKeyDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06015675 RID: 87669 RVA: 0x001F72FE File Offset: 0x001F54FE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCloudGameOnReceiveDataWithKeyDelegate.StaticFunctionPtr();
		}

		// Token: 0x06015676 RID: 87670 RVA: 0x001F730A File Offset: 0x001F550A
		private static IntPtr StaticFunctionPtr()
		{
			if (FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroCloudGame.CloudGameOnReceiveDataWithKeyDelegate__DelegateSignature");
			}
			return FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr;
		}

		// Token: 0x06015677 RID: 87671 RVA: 0x001F732D File Offset: 0x001F552D
		public FCloudGameOnReceiveDataWithKeyDelegate()
		{
		}

		// Token: 0x06015678 RID: 87672 RVA: 0x001F7335 File Offset: 0x001F5535
		[NullableContext(2)]
		public FCloudGameOnReceiveDataWithKeyDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015679 RID: 87673 RVA: 0x001F733F File Offset: 0x001F553F
		public FCloudGameOnReceiveDataWithKeyDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601567A RID: 87674 RVA: 0x001F734A File Offset: 0x001F554A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601567B RID: 87675 RVA: 0x001F737C File Offset: 0x001F557C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string, string> Callback)
		{
			if (FCloudGameOnReceiveDataWithKeyDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCloudGameOnReceiveDataWithKeyDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCloudGameOnReceiveDataWithKeyDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCloudGameOnReceiveDataWithKeyDelegate.OnScriptCallback));
				}
				FCloudGameOnReceiveDataWithKeyDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCloudGameOnReceiveDataWithKeyDelegate.RegisterId);
		}

		// Token: 0x0601567C RID: 87676 RVA: 0x001F73B8 File Offset: 0x001F55B8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Key, string Data)
		{
			FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams* ptr = stackalloc FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCloudGameOnReceiveDataWithKeyDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601567D RID: 87677 RVA: 0x001F741C File Offset: 0x001F561C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams*)__Parameters)->Key));
			string arg2 = FString.ToString((void*)(&((FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams*)__Parameters)->Data));
			action(arg, arg2);
		}

		// Token: 0x0400BAB8 RID: 47800
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400BAB9 RID: 47801
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCloudGame.CloudGameOnReceiveDataWithKeyDelegate__DelegateSignature";

		// Token: 0x0400BABA RID: 47802
		private static int RegisterId;

		// Token: 0x02002EFE RID: 12030
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams
		{
			// Token: 0x04016A3B RID: 92731
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04016A3C RID: 92732
			[FieldOffset(16)]
			public FString Data;
		}

		// Token: 0x02002EFF RID: 12031
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A3D RID: 92733
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
