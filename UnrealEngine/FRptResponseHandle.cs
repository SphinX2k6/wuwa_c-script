using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048E RID: 1166
	public sealed class FRptResponseHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D88 RID: 28040 RVA: 0x000A0452 File Offset: 0x0009E652
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FRptResponseHandle.StaticFunctionPtr();
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x000A045E File Offset: 0x0009E65E
		private static IntPtr StaticFunctionPtr()
		{
			if (FRptResponseHandle._FunctionPtr == IntPtr.Zero)
			{
				FRptResponseHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.RptResponseHandle__DelegateSignature");
			}
			return FRptResponseHandle._FunctionPtr;
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x000A0481 File Offset: 0x0009E681
		public FRptResponseHandle()
		{
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x000A0489 File Offset: 0x0009E689
		[NullableContext(2)]
		public FRptResponseHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x000A0493 File Offset: 0x0009E693
		public FRptResponseHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x000A049E File Offset: 0x0009E69E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, int, int, int, bool>) ?? ((Action<string, int, int, int, bool>)Delegate.CreateDelegate(typeof(Action<string, int, int, int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x000A04D0 File Offset: 0x0009E6D0
		[NullableContext(1)]
		public void Bind(Action<string, int, int, int, bool> Callback)
		{
			if (FRptResponseHandle.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FRptResponseHandle.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FRptResponseHandle.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FRptResponseHandle.OnScriptCallback));
				}
				FRptResponseHandle.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FRptResponseHandle.RegisterId);
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x000A050C File Offset: 0x0009E70C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Data, int LocalErrorCode, int RemoteErrorCode, int HttpResponseCode, bool bConnectedSuccessfully)
		{
			FRptResponseHandle.__FRptResponseHandle_DelegateParams* ptr = stackalloc FRptResponseHandle.__FRptResponseHandle_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FRptResponseHandle.__FRptResponseHandle_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FRptResponseHandle.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			ptr->LocalErrorCode = LocalErrorCode;
			ptr->RemoteErrorCode = RemoteErrorCode;
			ptr->HttpResponseCode = HttpResponseCode;
			ptr->bConnectedSuccessfully = bConnectedSuccessfully;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FRptResponseHandle._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x000A0580 File Offset: 0x0009E780
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, int, int, int, bool> action = target as Action<string, int, int, int, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->Data));
			action(arg, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->LocalErrorCode, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->RemoteErrorCode, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->HttpResponseCode, ((FRptResponseHandle.__FRptResponseHandle_DelegateParams*)__Parameters)->bConnectedSuccessfully);
		}

		// Token: 0x04002EBB RID: 11963
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EBC RID: 11964
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.RptResponseHandle__DelegateSignature";

		// Token: 0x04002EBD RID: 11965
		private static int RegisterId;

		// Token: 0x02000B9E RID: 2974
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FRptResponseHandle_DelegateParams
		{
			// Token: 0x04005D1F RID: 23839
			[FieldOffset(0)]
			public FString Data;

			// Token: 0x04005D20 RID: 23840
			[FieldOffset(16)]
			public int LocalErrorCode;

			// Token: 0x04005D21 RID: 23841
			[FieldOffset(20)]
			public int RemoteErrorCode;

			// Token: 0x04005D22 RID: 23842
			[FieldOffset(24)]
			public int HttpResponseCode;

			// Token: 0x04005D23 RID: 23843
			[FieldOffset(28)]
			public bool bConnectedSuccessfully;
		}

		// Token: 0x02000B9F RID: 2975
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D24 RID: 23844
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
