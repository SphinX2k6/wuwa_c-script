using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085B RID: 2139
	public sealed class FGetLinearColor : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA21 RID: 47649 RVA: 0x0012A0D8 File Offset: 0x001282D8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetLinearColor.StaticFunctionPtr();
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x0012A0E4 File Offset: 0x001282E4
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetLinearColor__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetLinearColor__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetLinearColor__DelegateSignature");
			}
			return UWidget.__GetLinearColor__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BA23 RID: 47651 RVA: 0x0012A107 File Offset: 0x00128307
		public FGetLinearColor()
		{
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x0012A10F File Offset: 0x0012830F
		[NullableContext(2)]
		public FGetLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x0012A119 File Offset: 0x00128319
		public FGetLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA26 RID: 47654 RVA: 0x0012A124 File Offset: 0x00128324
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FLinearColor>) ?? ((Func<FLinearColor>)Delegate.CreateDelegate(typeof(Func<FLinearColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA27 RID: 47655 RVA: 0x0012A156 File Offset: 0x00128356
		[NullableContext(1)]
		public void Bind(Func<FLinearColor> Callback)
		{
			if (FGetLinearColor.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetLinearColor.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetLinearColor.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetLinearColor.OnScriptCallback));
				}
				FGetLinearColor.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetLinearColor.RegisterId);
		}

		// Token: 0x0600BA28 RID: 47656 RVA: 0x0012A190 File Offset: 0x00128390
		[SkipLocalsInit]
		public unsafe FLinearColor Execute()
		{
			FGetLinearColor.__FGetLinearColor_DelegateParams* ptr = stackalloc FGetLinearColor.__FGetLinearColor_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FGetLinearColor.__FGetLinearColor_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetLinearColor.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600BA29 RID: 47657 RVA: 0x0012A1CC File Offset: 0x001283CC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FLinearColor> func = target as Func<FLinearColor>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FLinearColor _Result = func();
			((FGetLinearColor.__FGetLinearColor_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04005482 RID: 21634
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetLinearColor__DelegateSignature";

		// Token: 0x04005483 RID: 21635
		private static int RegisterId;

		// Token: 0x020013F3 RID: 5107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FGetLinearColor_DelegateParams
		{
			// Token: 0x0400689D RID: 26781
			[FieldOffset(0)]
			public FLinearColor __Result;
		}

		// Token: 0x020013F4 RID: 5108
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400689E RID: 26782
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
