using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E6F RID: 7791
	public sealed class FOnSkillCD : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DACE RID: 121550 RVA: 0x002BD590 File Offset: 0x002BB790
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSkillCD.StaticFunctionPtr();
		}

		// Token: 0x0601DACF RID: 121551 RVA: 0x002BD59C File Offset: 0x002BB79C
		private static IntPtr StaticFunctionPtr()
		{
			if (AKSC_Entity_AssistMachine.__OnSkillCD__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKSC_Entity_AssistMachine.__OnSkillCD__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillCD__DelegateSignature");
			}
			return AKSC_Entity_AssistMachine.__OnSkillCD__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DAD0 RID: 121552 RVA: 0x002BD5BF File Offset: 0x002BB7BF
		public FOnSkillCD()
		{
		}

		// Token: 0x0601DAD1 RID: 121553 RVA: 0x002BD5C7 File Offset: 0x002BB7C7
		[NullableContext(2)]
		public FOnSkillCD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAD2 RID: 121554 RVA: 0x002BD5D1 File Offset: 0x002BB7D1
		public FOnSkillCD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DAD3 RID: 121555 RVA: 0x002BD5DC File Offset: 0x002BB7DC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, float>) ?? ((Action<int, float>)Delegate.CreateDelegate(typeof(Action<int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DAD4 RID: 121556 RVA: 0x002BD60E File Offset: 0x002BB80E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, float> Callback)
		{
			if (FOnSkillCD.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSkillCD.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSkillCD.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSkillCD.OnScriptCallback));
				}
				FOnSkillCD.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSkillCD.RegisterId);
		}

		// Token: 0x0601DAD5 RID: 121557 RVA: 0x002BD648 File Offset: 0x002BB848
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int skillIndex, float cd)
		{
			FOnSkillCD.__FOnSkillCD_DelegateParams* ptr = stackalloc FOnSkillCD.__FOnSkillCD_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnSkillCD.__FOnSkillCD_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSkillCD.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skillIndex = skillIndex;
			ptr->cd = cd;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601DAD6 RID: 121558 RVA: 0x002BD68C File Offset: 0x002BB88C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float> action = target as Action<int, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnSkillCD.__FOnSkillCD_DelegateParams*)__Parameters)->skillIndex, ((FOnSkillCD.__FOnSkillCD_DelegateParams*)__Parameters)->cd);
		}

		// Token: 0x0401012E RID: 65838
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillCD__DelegateSignature";

		// Token: 0x0401012F RID: 65839
		private static int RegisterId;

		// Token: 0x020032C5 RID: 12997
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnSkillCD_DelegateParams
		{
			// Token: 0x0401716A RID: 94570
			[FieldOffset(0)]
			public int skillIndex;

			// Token: 0x0401716B RID: 94571
			[FieldOffset(4)]
			public float cd;
		}

		// Token: 0x020032C6 RID: 12998
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401716C RID: 94572
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
