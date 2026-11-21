using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000413 RID: 1043
	public sealed class FNiagaraSpecIsNeedQualityBiasRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600656C RID: 25964 RVA: 0x00091102 File Offset: 0x0008F302
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FNiagaraSpecIsNeedQualityBiasRetVal.StaticFunctionPtr();
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x0009110E File Offset: 0x0008F30E
		private static IntPtr StaticFunctionPtr()
		{
			if (FNiagaraSpecIsNeedQualityBiasRetVal._FunctionPtr == IntPtr.Zero)
			{
				FNiagaraSpecIsNeedQualityBiasRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.NiagaraSpecIsNeedQualityBiasRetVal__DelegateSignature");
			}
			return FNiagaraSpecIsNeedQualityBiasRetVal._FunctionPtr;
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x00091131 File Offset: 0x0008F331
		public FNiagaraSpecIsNeedQualityBiasRetVal()
		{
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00091139 File Offset: 0x0008F339
		[NullableContext(2)]
		public FNiagaraSpecIsNeedQualityBiasRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x00091143 File Offset: 0x0008F343
		public FNiagaraSpecIsNeedQualityBiasRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x0009114E File Offset: 0x0008F34E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x00091180 File Offset: 0x0008F380
		[NullableContext(1)]
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

		// Token: 0x06006573 RID: 25971 RVA: 0x000911BC File Offset: 0x0008F3BC
		[SkipLocalsInit]
		public unsafe bool Execute(int EntityId)
		{
			FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams* ptr = stackalloc FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FNiagaraSpecIsNeedQualityBiasRetVal.__FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FNiagaraSpecIsNeedQualityBiasRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00091200 File Offset: 0x0008F400
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002AA9 RID: 10921
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AAA RID: 10922
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.NiagaraSpecIsNeedQualityBiasRetVal__DelegateSignature";

		// Token: 0x04002AAB RID: 10923
		private static int RegisterId;

		// Token: 0x02000B05 RID: 2821
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FNiagaraSpecIsNeedQualityBiasRetVal_DelegateParams
		{
			// Token: 0x04005B9D RID: 23453
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B9E RID: 23454
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000B06 RID: 2822
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B9F RID: 23455
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
