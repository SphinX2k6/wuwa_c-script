using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001925 RID: 6437
	public sealed class FNiagaraSpecIsNeedQualityBiasRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DF6 RID: 97782 RVA: 0x0022FB02 File Offset: 0x0022DD02
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FNiagaraSpecIsNeedQualityBiasRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017DF7 RID: 97783 RVA: 0x0022FB0E File Offset: 0x0022DD0E
		private static IntPtr StaticFunctionPtr()
		{
			if (FNiagaraSpecIsNeedQualityBiasRetVal._FunctionPtr == IntPtr.Zero)
			{
				FNiagaraSpecIsNeedQualityBiasRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.NiagaraSpecIsNeedQualityBiasRetVal__DelegateSignature");
			}
			return FNiagaraSpecIsNeedQualityBiasRetVal._FunctionPtr;
		}

		// Token: 0x06017DF8 RID: 97784 RVA: 0x0022FB31 File Offset: 0x0022DD31
		public FNiagaraSpecIsNeedQualityBiasRetVal()
		{
		}

		// Token: 0x06017DF9 RID: 97785 RVA: 0x0022FB39 File Offset: 0x0022DD39
		[NullableContext(2)]
		public FNiagaraSpecIsNeedQualityBiasRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DFA RID: 97786 RVA: 0x0022FB43 File Offset: 0x0022DD43
		public FNiagaraSpecIsNeedQualityBiasRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DFB RID: 97787 RVA: 0x0022FB4E File Offset: 0x0022DD4E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DFC RID: 97788 RVA: 0x0022FB80 File Offset: 0x0022DD80
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<int, bool> Callback)
		{
			if (FNiagaraSpecIsNeedQualityBiasRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FNiagaraSpecIsNeedQualityBiasRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FNiagaraSpecIsNeedQualityBiasRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FNiagaraSpecIsNeedQualityBiasRetVal.OnScriptCallback));
				}
				FNiagaraSpecIsNeedQualityBiasRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FNiagaraSpecIsNeedQualityBiasRetVal.RegisterId);
		}

		// Token: 0x06017DFD RID: 97789 RVA: 0x0022FBBC File Offset: 0x0022DDBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(int EntityId)
		{
			FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams* ptr = stackalloc FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FNiagaraSpecIsNeedQualityBiasRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06017DFE RID: 97790 RVA: 0x0022FC00 File Offset: 0x0022DE00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, bool> func = target as Func<int, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			bool _Result = func(((FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams*)__Parameters)->EntityId);
			((FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400CEE4 RID: 52964
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CEE5 RID: 52965
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.NiagaraSpecIsNeedQualityBiasRetVal__DelegateSignature";

		// Token: 0x0400CEE6 RID: 52966
		private static int RegisterId;

		// Token: 0x02002FF1 RID: 12273
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams
		{
			// Token: 0x04016BF4 RID: 93172
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BF5 RID: 93173
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002FF2 RID: 12274
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BF6 RID: 93174
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
