using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200188B RID: 6283
	public sealed class FActorSystemPutRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017274 RID: 94836 RVA: 0x0021BD73 File Offset: 0x00219F73
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorSystemPutRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017275 RID: 94837 RVA: 0x0021BD7F File Offset: 0x00219F7F
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorSystemPutRetVal._FunctionPtr == IntPtr.Zero)
			{
				FActorSystemPutRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.ActorSystemPutRetVal__DelegateSignature");
			}
			return FActorSystemPutRetVal._FunctionPtr;
		}

		// Token: 0x06017276 RID: 94838 RVA: 0x0021BDA2 File Offset: 0x00219FA2
		public FActorSystemPutRetVal()
		{
		}

		// Token: 0x06017277 RID: 94839 RVA: 0x0021BDAA File Offset: 0x00219FAA
		[NullableContext(2)]
		public FActorSystemPutRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017278 RID: 94840 RVA: 0x0021BDB4 File Offset: 0x00219FB4
		public FActorSystemPutRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017279 RID: 94841 RVA: 0x0021BDBF File Offset: 0x00219FBF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, AActor, bool>) ?? ((Func<string, AActor, bool>)Delegate.CreateDelegate(typeof(Func<string, AActor, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601727A RID: 94842 RVA: 0x0021BDF1 File Offset: 0x00219FF1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601727B RID: 94843 RVA: 0x0021BE2C File Offset: 0x0021A02C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601727C RID: 94844 RVA: 0x0021BE9C File Offset: 0x0021A09C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400C8E9 RID: 51433
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8EA RID: 51434
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.ActorSystemPutRetVal__DelegateSignature";

		// Token: 0x0400C8EB RID: 51435
		private static int RegisterId;

		// Token: 0x02002F87 RID: 12167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FActorSystemPutRetVal_DelegateParams
		{
			// Token: 0x04016B48 RID: 93000
			[FieldOffset(0)]
			public FString Reason;

			// Token: 0x04016B49 RID: 93001
			[FieldOffset(16)]
			public IntPtr Actor;

			// Token: 0x04016B4A RID: 93002
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02002F88 RID: 12168
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B4B RID: 93003
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
