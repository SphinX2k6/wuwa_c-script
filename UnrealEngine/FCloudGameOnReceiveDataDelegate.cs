using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200173B RID: 5947
	public sealed class FCloudGameOnReceiveDataDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601566C RID: 87660 RVA: 0x001F71A0 File Offset: 0x001F53A0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCloudGameOnReceiveDataDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601566D RID: 87661 RVA: 0x001F71AC File Offset: 0x001F53AC
		private static IntPtr StaticFunctionPtr()
		{
			if (FCloudGameOnReceiveDataDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCloudGameOnReceiveDataDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroCloudGame.CloudGameOnReceiveDataDelegate__DelegateSignature");
			}
			return FCloudGameOnReceiveDataDelegate._FunctionPtr;
		}

		// Token: 0x0601566E RID: 87662 RVA: 0x001F71CF File Offset: 0x001F53CF
		public FCloudGameOnReceiveDataDelegate()
		{
		}

		// Token: 0x0601566F RID: 87663 RVA: 0x001F71D7 File Offset: 0x001F53D7
		[NullableContext(2)]
		public FCloudGameOnReceiveDataDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015670 RID: 87664 RVA: 0x001F71E1 File Offset: 0x001F53E1
		public FCloudGameOnReceiveDataDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015671 RID: 87665 RVA: 0x001F71EC File Offset: 0x001F53EC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06015672 RID: 87666 RVA: 0x001F721E File Offset: 0x001F541E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FCloudGameOnReceiveDataDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCloudGameOnReceiveDataDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCloudGameOnReceiveDataDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCloudGameOnReceiveDataDelegate.OnScriptCallback));
				}
				FCloudGameOnReceiveDataDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCloudGameOnReceiveDataDelegate.RegisterId);
		}

		// Token: 0x06015673 RID: 87667 RVA: 0x001F7258 File Offset: 0x001F5458
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Data)
		{
			FCloudGameOnReceiveDataDelegate.__FCloudGameOnReceiveDataDelegate_DelegateParams* ptr = stackalloc FCloudGameOnReceiveDataDelegate.__FCloudGameOnReceiveDataDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FCloudGameOnReceiveDataDelegate.__FCloudGameOnReceiveDataDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCloudGameOnReceiveDataDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FCloudGameOnReceiveDataDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06015674 RID: 87668 RVA: 0x001F72AC File Offset: 0x001F54AC
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
			string obj = FString.ToString((void*)(&((FCloudGameOnReceiveDataDelegate.__FCloudGameOnReceiveDataDelegate_DelegateParams*)__Parameters)->Data));
			action(obj);
		}

		// Token: 0x0400BAB5 RID: 47797
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400BAB6 RID: 47798
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCloudGame.CloudGameOnReceiveDataDelegate__DelegateSignature";

		// Token: 0x0400BAB7 RID: 47799
		private static int RegisterId;

		// Token: 0x02002EFC RID: 12028
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FCloudGameOnReceiveDataDelegate_DelegateParams
		{
			// Token: 0x04016A39 RID: 92729
			[FieldOffset(0)]
			public FString Data;
		}

		// Token: 0x02002EFD RID: 12029
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A3A RID: 92730
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
