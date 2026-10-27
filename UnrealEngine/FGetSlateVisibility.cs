using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002971 RID: 10609
	public sealed class FGetSlateVisibility : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273C9 RID: 160713 RVA: 0x003BD55F File Offset: 0x003BB75F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetSlateVisibility.StaticFunctionPtr();
		}

		// Token: 0x060273CA RID: 160714 RVA: 0x003BD56B File Offset: 0x003BB76B
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetSlateVisibility__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetSlateVisibility__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetSlateVisibility__DelegateSignature");
			}
			return UWidget.__GetSlateVisibility__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273CB RID: 160715 RVA: 0x003BD58E File Offset: 0x003BB78E
		public FGetSlateVisibility()
		{
		}

		// Token: 0x060273CC RID: 160716 RVA: 0x003BD596 File Offset: 0x003BB796
		[NullableContext(2)]
		public FGetSlateVisibility(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273CD RID: 160717 RVA: 0x003BD5A0 File Offset: 0x003BB7A0
		public FGetSlateVisibility(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273CE RID: 160718 RVA: 0x003BD5AB File Offset: 0x003BB7AB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ESlateVisibility>) ?? ((Func<ESlateVisibility>)Delegate.CreateDelegate(typeof(Func<ESlateVisibility>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273CF RID: 160719 RVA: 0x003BD5DD File Offset: 0x003BB7DD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060273D0 RID: 160720 RVA: 0x003BD618 File Offset: 0x003BB818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ESlateVisibility Execute()
		{
			FGetSlateVisibility.__FGetSlateVisibility_DelegateParams* ptr = stackalloc FGetSlateVisibility.__FGetSlateVisibility_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FGetSlateVisibility.__FGetSlateVisibility_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetSlateVisibility.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060273D1 RID: 160721 RVA: 0x003BD654 File Offset: 0x003BB854
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040158FD RID: 88317
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetSlateVisibility__DelegateSignature";

		// Token: 0x040158FE RID: 88318
		private static int RegisterId;

		// Token: 0x02003B7D RID: 15229
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FGetSlateVisibility_DelegateParams
		{
			// Token: 0x04017D57 RID: 97623
			[FieldOffset(0)]
			public ESlateVisibility __Result;
		}

		// Token: 0x02003B7E RID: 15230
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D58 RID: 97624
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
