using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D4 RID: 980
	public sealed class FEffectSystemCheckMobileBlackEffectRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060060DC RID: 24796 RVA: 0x0008A4BA File Offset: 0x000886BA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectSystemCheckMobileBlackEffectRetVal.StaticFunctionPtr();
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x0008A4C6 File Offset: 0x000886C6
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectSystemCheckMobileBlackEffectRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectSystemCheckMobileBlackEffectRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectSystemCheckMobileBlackEffectRetVal__DelegateSignature");
			}
			return FEffectSystemCheckMobileBlackEffectRetVal._FunctionPtr;
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x0008A4E9 File Offset: 0x000886E9
		public FEffectSystemCheckMobileBlackEffectRetVal()
		{
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x0008A4F1 File Offset: 0x000886F1
		[NullableContext(2)]
		public FEffectSystemCheckMobileBlackEffectRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x0008A4FB File Offset: 0x000886FB
		public FEffectSystemCheckMobileBlackEffectRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x0008A506 File Offset: 0x00088706
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x0008A538 File Offset: 0x00088738
		[NullableContext(1)]
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

		// Token: 0x060060E3 RID: 24803 RVA: 0x0008A574 File Offset: 0x00088774
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x060060E4 RID: 24804 RVA: 0x0008A5D0 File Offset: 0x000887D0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400293B RID: 10555
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400293C RID: 10556
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectSystemCheckMobileBlackEffectRetVal__DelegateSignature";

		// Token: 0x0400293D RID: 10557
		private static int RegisterId;

		// Token: 0x02000ACC RID: 2764
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FEffectSystemCheckMobileBlackEffectRetVal_DelegateParams
		{
			// Token: 0x04005B47 RID: 23367
			[FieldOffset(0)]
			public FString Path;

			// Token: 0x04005B48 RID: 23368
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000ACD RID: 2765
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B49 RID: 23369
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
