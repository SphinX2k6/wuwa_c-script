using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033A RID: 826
	public sealed class FCloudGameOnReceiveDataDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060055A9 RID: 21929 RVA: 0x00077CE4 File Offset: 0x00075EE4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCloudGameOnReceiveDataDelegate.StaticFunctionPtr();
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x00077CF0 File Offset: 0x00075EF0
		private static IntPtr StaticFunctionPtr()
		{
			if (FCloudGameOnReceiveDataDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCloudGameOnReceiveDataDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroCloudGame.CloudGameOnReceiveDataDelegate__DelegateSignature");
			}
			return FCloudGameOnReceiveDataDelegate._FunctionPtr;
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00077D13 File Offset: 0x00075F13
		public FCloudGameOnReceiveDataDelegate()
		{
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x00077D1B File Offset: 0x00075F1B
		[NullableContext(2)]
		public FCloudGameOnReceiveDataDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00077D25 File Offset: 0x00075F25
		public FCloudGameOnReceiveDataDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00077D30 File Offset: 0x00075F30
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x00077D62 File Offset: 0x00075F62
		[NullableContext(1)]
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

		// Token: 0x060055B0 RID: 21936 RVA: 0x00077D9C File Offset: 0x00075F9C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Data)
		{
			FCloudGameOnReceiveDataDelegate.__FCloudGameOnReceiveDataDelegate_DelegateParams* ptr = stackalloc FCloudGameOnReceiveDataDelegate.__FCloudGameOnReceiveDataDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FCloudGameOnReceiveDataDelegate.__FCloudGameOnReceiveDataDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCloudGameOnReceiveDataDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FCloudGameOnReceiveDataDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00077DF0 File Offset: 0x00075FF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002303 RID: 8963
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002304 RID: 8964
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCloudGame.CloudGameOnReceiveDataDelegate__DelegateSignature";

		// Token: 0x04002305 RID: 8965
		private static int RegisterId;

		// Token: 0x02000A31 RID: 2609
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FCloudGameOnReceiveDataDelegate_DelegateParams
		{
			// Token: 0x04005A0D RID: 23053
			[FieldOffset(0)]
			public FString Data;
		}

		// Token: 0x02000A32 RID: 2610
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005A0E RID: 23054
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
