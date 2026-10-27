using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002970 RID: 10608
	public sealed class FGetSlateColor : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273C0 RID: 160704 RVA: 0x003BD3E7 File Offset: 0x003BB5E7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetSlateColor.StaticFunctionPtr();
		}

		// Token: 0x060273C1 RID: 160705 RVA: 0x003BD3F3 File Offset: 0x003BB5F3
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetSlateColor__DelegateSignature");
			}
			return UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273C2 RID: 160706 RVA: 0x003BD416 File Offset: 0x003BB616
		public FGetSlateColor()
		{
		}

		// Token: 0x060273C3 RID: 160707 RVA: 0x003BD41E File Offset: 0x003BB61E
		[NullableContext(2)]
		public FGetSlateColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273C4 RID: 160708 RVA: 0x003BD428 File Offset: 0x003BB628
		public FGetSlateColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273C5 RID: 160709 RVA: 0x003BD433 File Offset: 0x003BB633
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FSlateColor>) ?? ((Func<FSlateColor>)Delegate.CreateDelegate(typeof(Func<FSlateColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273C6 RID: 160710 RVA: 0x003BD465 File Offset: 0x003BB665
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060273C7 RID: 160711 RVA: 0x003BD4A0 File Offset: 0x003BB6A0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSlateColor Execute()
		{
			FGetSlateColor.__FGetSlateColor_DelegateParams* ptr = stackalloc FGetSlateColor.__FGetSlateColor_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FGetSlateColor.__FGetSlateColor_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetSlateColor.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			FSlateColor result = new FSlateColor(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UWidget.__GetSlateColor__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060273C8 RID: 160712 RVA: 0x003BD4F8 File Offset: 0x003BB6F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040158FB RID: 88315
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetSlateColor__DelegateSignature";

		// Token: 0x040158FC RID: 88316
		private static int RegisterId;

		// Token: 0x02003B7B RID: 15227
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FGetSlateColor_DelegateParams
		{
			// Token: 0x04017D55 RID: 97621
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003B7C RID: 15228
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D56 RID: 97622
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
