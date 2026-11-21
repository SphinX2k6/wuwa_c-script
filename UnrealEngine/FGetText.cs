using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085E RID: 2142
	public sealed class FGetText : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA3C RID: 47676 RVA: 0x0012A4D0 File Offset: 0x001286D0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetText.StaticFunctionPtr();
		}

		// Token: 0x0600BA3D RID: 47677 RVA: 0x0012A4DC File Offset: 0x001286DC
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetText__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetText__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetText__DelegateSignature");
			}
			return UWidget.__GetText__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x0012A4FF File Offset: 0x001286FF
		public FGetText()
		{
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x0012A507 File Offset: 0x00128707
		[NullableContext(2)]
		public FGetText(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x0012A511 File Offset: 0x00128711
		public FGetText(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x0012A51C File Offset: 0x0012871C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FText>) ?? ((Func<FText>)Delegate.CreateDelegate(typeof(Func<FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x0012A54E File Offset: 0x0012874E
		[NullableContext(1)]
		public void Bind(Func<FText> Callback)
		{
			if (FGetText.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetText.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetText.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetText.OnScriptCallback));
				}
				FGetText.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetText.RegisterId);
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x0012A588 File Offset: 0x00128788
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FText Execute()
		{
			FGetText.__FGetText_DelegateParams* ptr = stackalloc FGetText.__FGetText_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FGetText.__FGetText_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetText.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			FText result = new FText(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UWidget.__GetText__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600BA44 RID: 47684 RVA: 0x0012A5E0 File Offset: 0x001287E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FText> func = target as Func<FText>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText ftext = func();
			FText.NativeCopy((void*)(&((FGetText.__FGetText_DelegateParams*)__Parameters)->__Result), ftext.NativePtr, 1);
		}

		// Token: 0x04005488 RID: 21640
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetText__DelegateSignature";

		// Token: 0x04005489 RID: 21641
		private static int RegisterId;

		// Token: 0x020013F9 RID: 5113
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FGetText_DelegateParams
		{
			// Token: 0x040068A3 RID: 26787
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020013FA RID: 5114
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068A4 RID: 26788
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
