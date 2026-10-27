using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200296B RID: 10603
	public sealed class FGetBool : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027393 RID: 160659 RVA: 0x003BCD6E File Offset: 0x003BAF6E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetBool.StaticFunctionPtr();
		}

		// Token: 0x06027394 RID: 160660 RVA: 0x003BCD7A File Offset: 0x003BAF7A
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetBool__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetBool__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetBool__DelegateSignature");
			}
			return UWidget.__GetBool__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06027395 RID: 160661 RVA: 0x003BCD9D File Offset: 0x003BAF9D
		public FGetBool()
		{
		}

		// Token: 0x06027396 RID: 160662 RVA: 0x003BCDA5 File Offset: 0x003BAFA5
		[NullableContext(2)]
		public FGetBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027397 RID: 160663 RVA: 0x003BCDAF File Offset: 0x003BAFAF
		public FGetBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027398 RID: 160664 RVA: 0x003BCDBA File Offset: 0x003BAFBA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<bool>) ?? ((Func<bool>)Delegate.CreateDelegate(typeof(Func<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027399 RID: 160665 RVA: 0x003BCDEC File Offset: 0x003BAFEC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<bool> Callback)
		{
			if (FGetBool.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetBool.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetBool.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetBool.OnScriptCallback));
				}
				FGetBool.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetBool.RegisterId);
		}

		// Token: 0x0602739A RID: 160666 RVA: 0x003BCE28 File Offset: 0x003BB028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute()
		{
			FGetBool.__FGetBool_DelegateParams* ptr = stackalloc FGetBool.__FGetBool_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FGetBool.__FGetBool_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetBool.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602739B RID: 160667 RVA: 0x003BCE64 File Offset: 0x003BB064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<bool> func = target as Func<bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			bool _Result = func();
			((FGetBool.__FGetBool_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040158F1 RID: 88305
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetBool__DelegateSignature";

		// Token: 0x040158F2 RID: 88306
		private static int RegisterId;

		// Token: 0x02003B71 RID: 15217
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FGetBool_DelegateParams
		{
			// Token: 0x04017D4B RID: 97611
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003B72 RID: 15218
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D4C RID: 97612
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
