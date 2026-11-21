using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085D RID: 2141
	public sealed class FGetSlateVisibility : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA33 RID: 47667 RVA: 0x0012A38F File Offset: 0x0012858F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetSlateVisibility.StaticFunctionPtr();
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x0012A39B File Offset: 0x0012859B
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetSlateVisibility__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetSlateVisibility__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetSlateVisibility__DelegateSignature");
			}
			return UWidget.__GetSlateVisibility__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x0012A3BE File Offset: 0x001285BE
		public FGetSlateVisibility()
		{
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x0012A3C6 File Offset: 0x001285C6
		[NullableContext(2)]
		public FGetSlateVisibility(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x0012A3D0 File Offset: 0x001285D0
		public FGetSlateVisibility(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x0012A3DB File Offset: 0x001285DB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ESlateVisibility>) ?? ((Func<ESlateVisibility>)Delegate.CreateDelegate(typeof(Func<ESlateVisibility>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x0012A40D File Offset: 0x0012860D
		[NullableContext(1)]
		public void Bind(Func<ESlateVisibility> Callback)
		{
			if (FGetSlateVisibility.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetSlateVisibility.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetSlateVisibility.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetSlateVisibility.OnScriptCallback));
				}
				FGetSlateVisibility.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetSlateVisibility.RegisterId);
		}

		// Token: 0x0600BA3A RID: 47674 RVA: 0x0012A448 File Offset: 0x00128648
		[SkipLocalsInit]
		public unsafe ESlateVisibility Execute()
		{
			FGetSlateVisibility.__FGetSlateVisibility_DelegateParams* ptr = stackalloc FGetSlateVisibility.__FGetSlateVisibility_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FGetSlateVisibility.__FGetSlateVisibility_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetSlateVisibility.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x0012A484 File Offset: 0x00128684
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<ESlateVisibility> func = target as Func<ESlateVisibility>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ESlateVisibility _Result = func();
			((FGetSlateVisibility.__FGetSlateVisibility_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04005486 RID: 21638
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetSlateVisibility__DelegateSignature";

		// Token: 0x04005487 RID: 21639
		private static int RegisterId;

		// Token: 0x020013F7 RID: 5111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FGetSlateVisibility_DelegateParams
		{
			// Token: 0x040068A1 RID: 26785
			[FieldOffset(0)]
			public ESlateVisibility __Result;
		}

		// Token: 0x020013F8 RID: 5112
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068A2 RID: 26786
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
