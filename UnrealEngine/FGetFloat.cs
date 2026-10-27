using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200296D RID: 10605
	public sealed class FGetFloat : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060273A5 RID: 160677 RVA: 0x003BCFF0 File Offset: 0x003BB1F0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetFloat.StaticFunctionPtr();
		}

		// Token: 0x060273A6 RID: 160678 RVA: 0x003BCFFC File Offset: 0x003BB1FC
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GetFloat__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GetFloat__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GetFloat__DelegateSignature");
			}
			return UWidget.__GetFloat__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060273A7 RID: 160679 RVA: 0x003BD01F File Offset: 0x003BB21F
		public FGetFloat()
		{
		}

		// Token: 0x060273A8 RID: 160680 RVA: 0x003BD027 File Offset: 0x003BB227
		[NullableContext(2)]
		public FGetFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060273A9 RID: 160681 RVA: 0x003BD031 File Offset: 0x003BB231
		public FGetFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060273AA RID: 160682 RVA: 0x003BD03C File Offset: 0x003BB23C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<float>) ?? ((Func<float>)Delegate.CreateDelegate(typeof(Func<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060273AB RID: 160683 RVA: 0x003BD06E File Offset: 0x003BB26E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<float> Callback)
		{
			if (FGetFloat.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetFloat.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetFloat.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetFloat.OnScriptCallback));
				}
				FGetFloat.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetFloat.RegisterId);
		}

		// Token: 0x060273AC RID: 160684 RVA: 0x003BD0A8 File Offset: 0x003BB2A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float Execute()
		{
			FGetFloat.__FGetFloat_DelegateParams* ptr = stackalloc FGetFloat.__FGetFloat_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FGetFloat.__FGetFloat_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetFloat.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060273AD RID: 160685 RVA: 0x003BD0E4 File Offset: 0x003BB2E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<float> func = target as Func<float>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			float _Result = func();
			((FGetFloat.__FGetFloat_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040158F5 RID: 88309
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GetFloat__DelegateSignature";

		// Token: 0x040158F6 RID: 88310
		private static int RegisterId;

		// Token: 0x02003B75 RID: 15221
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FGetFloat_DelegateParams
		{
			// Token: 0x04017D4F RID: 97615
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02003B76 RID: 15222
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D50 RID: 97616
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
