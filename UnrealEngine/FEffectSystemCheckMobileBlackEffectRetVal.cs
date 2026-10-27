using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018B2 RID: 6322
	public sealed class FEffectSystemCheckMobileBlackEffectRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017649 RID: 95817 RVA: 0x002232DA File Offset: 0x002214DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSystemCheckMobileBlackEffectRetVal.StaticFunctionPtr();
		}

		// Token: 0x0601764A RID: 95818 RVA: 0x002232E6 File Offset: 0x002214E6
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSystemCheckMobileBlackEffectRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectSystemCheckMobileBlackEffectRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSystemCheckMobileBlackEffectRetVal__DelegateSignature");
			}
			return FEffectSystemCheckMobileBlackEffectRetVal._FunctionPtr;
		}

		// Token: 0x0601764B RID: 95819 RVA: 0x00223309 File Offset: 0x00221509
		public FEffectSystemCheckMobileBlackEffectRetVal()
		{
		}

		// Token: 0x0601764C RID: 95820 RVA: 0x00223311 File Offset: 0x00221511
		[NullableContext(2)]
		public FEffectSystemCheckMobileBlackEffectRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601764D RID: 95821 RVA: 0x0022331B File Offset: 0x0022151B
		public FEffectSystemCheckMobileBlackEffectRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601764E RID: 95822 RVA: 0x00223326 File Offset: 0x00221526
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601764F RID: 95823 RVA: 0x00223358 File Offset: 0x00221558
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<string, bool> Callback)
		{
			if (FEffectSystemCheckMobileBlackEffectRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectSystemCheckMobileBlackEffectRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectSystemCheckMobileBlackEffectRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectSystemCheckMobileBlackEffectRetVal.OnScriptCallback));
				}
				FEffectSystemCheckMobileBlackEffectRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectSystemCheckMobileBlackEffectRetVal.RegisterId);
		}

		// Token: 0x06017650 RID: 95824 RVA: 0x00223394 File Offset: 0x00221594
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(string Path)
		{
			FEffectSystemCheckMobileBlackEffectRetVal.__FEffectSystemCheckMobileBlackEffectRetVal_DelegateParams* ptr = stackalloc FEffectSystemCheckMobileBlackEffectRetVal.__FEffectSystemCheckMobileBlackEffectRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FEffectSystemCheckMobileBlackEffectRetVal.__FEffectSystemCheckMobileBlackEffectRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectSystemCheckMobileBlackEffectRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Path), Path);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FEffectSystemCheckMobileBlackEffectRetVal._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06017651 RID: 95825 RVA: 0x002233F0 File Offset: 0x002215F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, bool> func = target as Func<string, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FEffectSystemCheckMobileBlackEffectRetVal.__FEffectSystemCheckMobileBlackEffectRetVal_DelegateParams*)__Parameters)->Path));
			bool _Result = func(arg);
			((FEffectSystemCheckMobileBlackEffectRetVal.__FEffectSystemCheckMobileBlackEffectRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400CB7C RID: 52092
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CB7D RID: 52093
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSystemCheckMobileBlackEffectRetVal__DelegateSignature";

		// Token: 0x0400CB7E RID: 52094
		private static int RegisterId;

		// Token: 0x02002FA9 RID: 12201
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FEffectSystemCheckMobileBlackEffectRetVal_DelegateParams
		{
			// Token: 0x04016B8A RID: 93066
			[FieldOffset(0)]
			public FString Path;

			// Token: 0x04016B8B RID: 93067
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002FAA RID: 12202
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B8C RID: 93068
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
