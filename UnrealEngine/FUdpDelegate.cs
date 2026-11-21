using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000491 RID: 1169
	public sealed class FUdpDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006DA3 RID: 28067 RVA: 0x000A087A File Offset: 0x0009EA7A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUdpDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x000A0886 File Offset: 0x0009EA86
		private static IntPtr StaticFunctionPtr()
		{
			if (FUdpDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUdpDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.UdpDelegate__DelegateSignature");
			}
			return FUdpDelegate._FunctionPtr;
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x000A08A9 File Offset: 0x0009EAA9
		public FUdpDelegate()
		{
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x000A08B1 File Offset: 0x0009EAB1
		[NullableContext(2)]
		public FUdpDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x000A08BB File Offset: 0x0009EABB
		public FUdpDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x000A08C6 File Offset: 0x0009EAC6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x000A08F8 File Offset: 0x0009EAF8
		[NullableContext(1)]
		public void Bind(Action<bool, string> Callback)
		{
			if (FUdpDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUdpDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUdpDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUdpDelegate.OnScriptCallback));
				}
				FUdpDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUdpDelegate.RegisterId);
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x000A0934 File Offset: 0x0009EB34
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(bool IsSuccess, string Response)
		{
			FUdpDelegate.__FUdpDelegate_DelegateParams* ptr = stackalloc FUdpDelegate.__FUdpDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FUdpDelegate.__FUdpDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUdpDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsSuccess = IsSuccess;
			FString.CopyFrom((void*)(&ptr->Response), Response);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FUdpDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x000A0990 File Offset: 0x0009EB90
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string> action = target as Action<bool, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FUdpDelegate.__FUdpDelegate_DelegateParams*)__Parameters)->Response));
			action(((FUdpDelegate.__FUdpDelegate_DelegateParams*)__Parameters)->IsSuccess, arg);
		}

		// Token: 0x04002EC4 RID: 11972
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EC5 RID: 11973
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.UdpDelegate__DelegateSignature";

		// Token: 0x04002EC6 RID: 11974
		private static int RegisterId;

		// Token: 0x02000BA4 RID: 2980
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FUdpDelegate_DelegateParams
		{
			// Token: 0x04005D2A RID: 23850
			[FieldOffset(0)]
			public bool IsSuccess;

			// Token: 0x04005D2B RID: 23851
			[FieldOffset(8)]
			public FString Response;
		}

		// Token: 0x02000BA5 RID: 2981
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D2C RID: 23852
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
