using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085A RID: 2138
	public sealed class FGetBool : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA18 RID: 47640 RVA: 0x00129F96 File Offset: 0x00128196
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetBool.StaticFunctionPtr();
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x00129FA2 File Offset: 0x001281A2
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetBool__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetBool__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetBool__DelegateSignature");
			}
			return UWidget.__GetBool__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BA1A RID: 47642 RVA: 0x00129FC5 File Offset: 0x001281C5
		public FGetBool()
		{
		}

		// Token: 0x0600BA1B RID: 47643 RVA: 0x00129FCD File Offset: 0x001281CD
		[NullableContext(2)]
		public FGetBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x00129FD7 File Offset: 0x001281D7
		public FGetBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA1D RID: 47645 RVA: 0x00129FE2 File Offset: 0x001281E2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<bool>) ?? ((Func<bool>)Delegate.CreateDelegate(typeof(Func<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x0012A014 File Offset: 0x00128214
		[NullableContext(1)]
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

		// Token: 0x0600BA1F RID: 47647 RVA: 0x0012A050 File Offset: 0x00128250
		[SkipLocalsInit]
		public unsafe bool Execute()
		{
			FGetBool.__FGetBool_DelegateParams* ptr = stackalloc FGetBool.__FGetBool_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FGetBool.__FGetBool_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetBool.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x0012A08C File Offset: 0x0012828C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04005480 RID: 21632
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetBool__DelegateSignature";

		// Token: 0x04005481 RID: 21633
		private static int RegisterId;

		// Token: 0x020013F1 RID: 5105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FGetBool_DelegateParams
		{
			// Token: 0x0400689B RID: 26779
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020013F2 RID: 5106
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400689C RID: 26780
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
