using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033B RID: 827
	public sealed class FCloudGameOnReceiveDataWithKeyDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060055B2 RID: 21938 RVA: 0x00077E42 File Offset: 0x00076042
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCloudGameOnReceiveDataWithKeyDelegate.StaticFunctionPtr();
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00077E4E File Offset: 0x0007604E
		private static IntPtr StaticFunctionPtr()
		{
			if (FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroCloudGame.CloudGameOnReceiveDataWithKeyDelegate__DelegateSignature");
			}
			return FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr;
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00077E71 File Offset: 0x00076071
		public FCloudGameOnReceiveDataWithKeyDelegate()
		{
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00077E79 File Offset: 0x00076079
		[NullableContext(2)]
		public FCloudGameOnReceiveDataWithKeyDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00077E83 File Offset: 0x00076083
		public FCloudGameOnReceiveDataWithKeyDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x00077E8E File Offset: 0x0007608E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00077EC0 File Offset: 0x000760C0
		[NullableContext(1)]
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

		// Token: 0x060055B9 RID: 21945 RVA: 0x00077EFC File Offset: 0x000760FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Key, string Data)
		{
			FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams* ptr = stackalloc FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FCloudGameOnReceiveDataWithKeyDelegate.__FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCloudGameOnReceiveDataWithKeyDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FCloudGameOnReceiveDataWithKeyDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00077F60 File Offset: 0x00076160
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002306 RID: 8966
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002307 RID: 8967
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCloudGame.CloudGameOnReceiveDataWithKeyDelegate__DelegateSignature";

		// Token: 0x04002308 RID: 8968
		private static int RegisterId;

		// Token: 0x02000A33 RID: 2611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FCloudGameOnReceiveDataWithKeyDelegate_DelegateParams
		{
			// Token: 0x04005A0F RID: 23055
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04005A10 RID: 23056
			[FieldOffset(16)]
			public FString Data;
		}

		// Token: 0x02000A34 RID: 2612
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005A11 RID: 23057
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
