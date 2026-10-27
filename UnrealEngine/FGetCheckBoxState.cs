using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200296C RID: 10604
	public sealed class FGetCheckBoxState : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602739C RID: 160668 RVA: 0x003BCEB0 File Offset: 0x003BB0B0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetCheckBoxState.StaticFunctionPtr();
		}

		// Token: 0x0602739D RID: 160669 RVA: 0x003BCEBC File Offset: 0x003BB0BC
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetCheckBoxState__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetCheckBoxState__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetCheckBoxState__DelegateSignature");
			}
			return UWidget.__GetCheckBoxState__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602739E RID: 160670 RVA: 0x003BCEDF File Offset: 0x003BB0DF
		public FGetCheckBoxState()
		{
		}

		// Token: 0x0602739F RID: 160671 RVA: 0x003BCEE7 File Offset: 0x003BB0E7
		[NullableContext(2)]
		public FGetCheckBoxState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273A0 RID: 160672 RVA: 0x003BCEF1 File Offset: 0x003BB0F1
		public FGetCheckBoxState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273A1 RID: 160673 RVA: 0x003BCEFC File Offset: 0x003BB0FC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ECheckBoxState>) ?? ((Func<ECheckBoxState>)Delegate.CreateDelegate(typeof(Func<ECheckBoxState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273A2 RID: 160674 RVA: 0x003BCF2E File Offset: 0x003BB12E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<ECheckBoxState> Callback)
		{
			if (FGetCheckBoxState.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetCheckBoxState.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetCheckBoxState.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetCheckBoxState.OnScriptCallback));
				}
				FGetCheckBoxState.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetCheckBoxState.RegisterId);
		}

		// Token: 0x060273A3 RID: 160675 RVA: 0x003BCF68 File Offset: 0x003BB168
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ECheckBoxState Execute()
		{
			FGetCheckBoxState.__FGetCheckBoxState_DelegateParams* ptr = stackalloc FGetCheckBoxState.__FGetCheckBoxState_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FGetCheckBoxState.__FGetCheckBoxState_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetCheckBoxState.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060273A4 RID: 160676 RVA: 0x003BCFA4 File Offset: 0x003BB1A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<ECheckBoxState> func = target as Func<ECheckBoxState>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ECheckBoxState _Result = func();
			((FGetCheckBoxState.__FGetCheckBoxState_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040158F3 RID: 88307
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetCheckBoxState__DelegateSignature";

		// Token: 0x040158F4 RID: 88308
		private static int RegisterId;

		// Token: 0x02003B73 RID: 15219
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FGetCheckBoxState_DelegateParams
		{
			// Token: 0x04017D4D RID: 97613
			[FieldOffset(0)]
			public ECheckBoxState __Result;
		}

		// Token: 0x02003B74 RID: 15220
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D4E RID: 97614
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
