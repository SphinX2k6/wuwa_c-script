using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085C RID: 2140
	public sealed class FGetSlateColor : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA2A RID: 47658 RVA: 0x0012A218 File Offset: 0x00128418
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetSlateColor.StaticFunctionPtr();
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x0012A224 File Offset: 0x00128424
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetSlateColor__DelegateSignature");
			}
			return UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BA2C RID: 47660 RVA: 0x0012A247 File Offset: 0x00128447
		public FGetSlateColor()
		{
		}

		// Token: 0x0600BA2D RID: 47661 RVA: 0x0012A24F File Offset: 0x0012844F
		[NullableContext(2)]
		public FGetSlateColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x0012A259 File Offset: 0x00128459
		public FGetSlateColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x0012A264 File Offset: 0x00128464
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FSlateColor>) ?? ((Func<FSlateColor>)Delegate.CreateDelegate(typeof(Func<FSlateColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x0012A296 File Offset: 0x00128496
		[NullableContext(1)]
		public void Bind(Func<FSlateColor> Callback)
		{
			if (FGetSlateColor.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetSlateColor.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetSlateColor.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetSlateColor.OnScriptCallback));
				}
				FGetSlateColor.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetSlateColor.RegisterId);
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x0012A2D0 File Offset: 0x001284D0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FSlateColor Execute()
		{
			FGetSlateColor.__FGetSlateColor_DelegateParams* ptr = stackalloc FGetSlateColor.__FGetSlateColor_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FGetSlateColor.__FGetSlateColor_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetSlateColor.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			FSlateColor result = new FSlateColor(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x0012A328 File Offset: 0x00128528
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FSlateColor> func = target as Func<FSlateColor>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FSlateColor fslateColor = func();
			if (fslateColor != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), &((FGetSlateColor.__FGetSlateColor_DelegateParams*)__Parameters)->__Result, fslateColor.NativePtr, 1, false);
			}
		}

		// Token: 0x04005484 RID: 21636
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetSlateColor__DelegateSignature";

		// Token: 0x04005485 RID: 21637
		private static int RegisterId;

		// Token: 0x020013F5 RID: 5109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FGetSlateColor_DelegateParams
		{
			// Token: 0x0400689F RID: 26783
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020013F6 RID: 5110
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068A0 RID: 26784
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
