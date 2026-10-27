using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200296E RID: 10606
	public sealed class FGetLinearColor : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273AE RID: 160686 RVA: 0x003BD130 File Offset: 0x003BB330
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetLinearColor.StaticFunctionPtr();
		}

		// Token: 0x060273AF RID: 160687 RVA: 0x003BD13C File Offset: 0x003BB33C
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetLinearColor__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetLinearColor__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetLinearColor__DelegateSignature");
			}
			return UWidget.__GetLinearColor__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273B0 RID: 160688 RVA: 0x003BD15F File Offset: 0x003BB35F
		public FGetLinearColor()
		{
		}

		// Token: 0x060273B1 RID: 160689 RVA: 0x003BD167 File Offset: 0x003BB367
		[NullableContext(2)]
		public FGetLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273B2 RID: 160690 RVA: 0x003BD171 File Offset: 0x003BB371
		public FGetLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273B3 RID: 160691 RVA: 0x003BD17C File Offset: 0x003BB37C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FLinearColor>) ?? ((Func<FLinearColor>)Delegate.CreateDelegate(typeof(Func<FLinearColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273B4 RID: 160692 RVA: 0x003BD1AE File Offset: 0x003BB3AE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060273B5 RID: 160693 RVA: 0x003BD1E8 File Offset: 0x003BB3E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FLinearColor Execute()
		{
			FGetLinearColor.__FGetLinearColor_DelegateParams* ptr = stackalloc FGetLinearColor.__FGetLinearColor_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FGetLinearColor.__FGetLinearColor_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetLinearColor.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060273B6 RID: 160694 RVA: 0x003BD224 File Offset: 0x003BB424
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040158F7 RID: 88311
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetLinearColor__DelegateSignature";

		// Token: 0x040158F8 RID: 88312
		private static int RegisterId;

		// Token: 0x02003B77 RID: 15223
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FGetLinearColor_DelegateParams
		{
			// Token: 0x04017D51 RID: 97617
			[FieldOffset(0)]
			public FLinearColor __Result;
		}

		// Token: 0x02003B78 RID: 15224
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D52 RID: 97618
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
