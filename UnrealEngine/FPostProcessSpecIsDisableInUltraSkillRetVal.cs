using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001930 RID: 6448
	public sealed class FPostProcessSpecIsDisableInUltraSkillRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017E86 RID: 97926 RVA: 0x002308A9 File Offset: 0x0022EAA9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPostProcessSpecIsDisableInUltraSkillRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017E87 RID: 97927 RVA: 0x002308B5 File Offset: 0x0022EAB5
		private static IntPtr StaticFunctionPtr()
		{
			if (FPostProcessSpecIsDisableInUltraSkillRetVal._FunctionPtr == IntPtr.Zero)
			{
				FPostProcessSpecIsDisableInUltraSkillRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.PostProcessSpecIsDisableInUltraSkillRetVal__DelegateSignature");
			}
			return FPostProcessSpecIsDisableInUltraSkillRetVal._FunctionPtr;
		}

		// Token: 0x06017E88 RID: 97928 RVA: 0x002308D8 File Offset: 0x0022EAD8
		public FPostProcessSpecIsDisableInUltraSkillRetVal()
		{
		}

		// Token: 0x06017E89 RID: 97929 RVA: 0x002308E0 File Offset: 0x0022EAE0
		[NullableContext(2)]
		public FPostProcessSpecIsDisableInUltraSkillRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E8A RID: 97930 RVA: 0x002308EA File Offset: 0x0022EAEA
		public FPostProcessSpecIsDisableInUltraSkillRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E8B RID: 97931 RVA: 0x002308F5 File Offset: 0x0022EAF5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, bool>) ?? ((Func<int, bool>)Delegate.CreateDelegate(typeof(Func<int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017E8C RID: 97932 RVA: 0x00230927 File Offset: 0x0022EB27
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<int, bool> Callback)
		{
			if (FPostProcessSpecIsDisableInUltraSkillRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPostProcessSpecIsDisableInUltraSkillRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPostProcessSpecIsDisableInUltraSkillRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPostProcessSpecIsDisableInUltraSkillRetVal.OnScriptCallback));
				}
				FPostProcessSpecIsDisableInUltraSkillRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPostProcessSpecIsDisableInUltraSkillRetVal.RegisterId);
		}

		// Token: 0x06017E8D RID: 97933 RVA: 0x00230964 File Offset: 0x0022EB64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(int EntityId)
		{
			FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams* ptr = stackalloc FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPostProcessSpecIsDisableInUltraSkillRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06017E8E RID: 97934 RVA: 0x002309A8 File Offset: 0x0022EBA8
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
			bool _Result = func(((FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams*)__Parameters)->EntityId);
			((FPostProcessSpecIsDisableInUltraSkillRetVal.__FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400CF21 RID: 53025
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF22 RID: 53026
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.PostProcessSpecIsDisableInUltraSkillRetVal__DelegateSignature";

		// Token: 0x0400CF23 RID: 53027
		private static int RegisterId;

		// Token: 0x02002FF9 RID: 12281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FPostProcessSpecIsDisableInUltraSkillRetVal_DelegateParams
		{
			// Token: 0x04016C03 RID: 93187
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016C04 RID: 93188
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002FFA RID: 12282
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C05 RID: 93189
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
