using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AF RID: 943
	public sealed class FActorSystemPutRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D1F RID: 23839 RVA: 0x00083213 File Offset: 0x00081413
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorSystemPutRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x0008321F File Offset: 0x0008141F
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorSystemPutRetVal._FunctionPtr == IntPtr.Zero)
			{
				FActorSystemPutRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.ActorSystemPutRetVal__DelegateSignature");
			}
			return FActorSystemPutRetVal._FunctionPtr;
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x00083242 File Offset: 0x00081442
		public FActorSystemPutRetVal()
		{
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x0008324A File Offset: 0x0008144A
		[NullableContext(2)]
		public FActorSystemPutRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x00083254 File Offset: 0x00081454
		public FActorSystemPutRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x0008325F File Offset: 0x0008145F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, AActor, bool>) ?? ((Func<string, AActor, bool>)Delegate.CreateDelegate(typeof(Func<string, AActor, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x00083291 File Offset: 0x00081491
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Func<string, AActor, bool> Callback)
		{
			if (FActorSystemPutRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorSystemPutRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorSystemPutRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorSystemPutRetVal.OnScriptCallback));
				}
				FActorSystemPutRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FActorSystemPutRetVal.RegisterId);
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x000832CC File Offset: 0x000814CC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe bool Execute(string Reason, [Nullable(2)] AActor Actor)
		{
			FActorSystemPutRetVal.__FActorSystemPutRetVal_DelegateParams* ptr = stackalloc FActorSystemPutRetVal.__FActorSystemPutRetVal_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FActorSystemPutRetVal.__FActorSystemPutRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorSystemPutRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FActorSystemPutRetVal._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x0008333C File Offset: 0x0008153C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, AActor, bool> func = target as Func<string, AActor, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FActorSystemPutRetVal.__FActorSystemPutRetVal_DelegateParams*)__Parameters)->Reason));
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorSystemPutRetVal.__FActorSystemPutRetVal_DelegateParams*)__Parameters)->Actor);
			bool _Result = func(arg, orCreateUObjectByNativePointer);
			((FActorSystemPutRetVal.__FActorSystemPutRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040026D2 RID: 9938
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026D3 RID: 9939
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.ActorSystemPutRetVal__DelegateSignature";

		// Token: 0x040026D4 RID: 9940
		private static int RegisterId;

		// Token: 0x02000AAA RID: 2730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FActorSystemPutRetVal_DelegateParams
		{
			// Token: 0x04005B05 RID: 23301
			[FieldOffset(0)]
			public FString Reason;

			// Token: 0x04005B06 RID: 23302
			[FieldOffset(16)]
			public IntPtr Actor;

			// Token: 0x04005B07 RID: 23303
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000AAB RID: 2731
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B08 RID: 23304
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
