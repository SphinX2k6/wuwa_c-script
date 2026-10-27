using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E6E RID: 7790
	public sealed class FOnShape2DSkillStateChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DAC5 RID: 121541 RVA: 0x002BD442 File Offset: 0x002BB642
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnShape2DSkillStateChange.StaticFunctionPtr();
		}

		// Token: 0x0601DAC6 RID: 121542 RVA: 0x002BD44E File Offset: 0x002BB64E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnShape2DSkillStateChange._FunctionPtr == IntPtr.Zero)
			{
				FOnShape2DSkillStateChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnShape2DSkillStateChange__DelegateSignature");
			}
			return FOnShape2DSkillStateChange._FunctionPtr;
		}

		// Token: 0x0601DAC7 RID: 121543 RVA: 0x002BD471 File Offset: 0x002BB671
		public FOnShape2DSkillStateChange()
		{
		}

		// Token: 0x0601DAC8 RID: 121544 RVA: 0x002BD479 File Offset: 0x002BB679
		[NullableContext(2)]
		public FOnShape2DSkillStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAC9 RID: 121545 RVA: 0x002BD483 File Offset: 0x002BB683
		public FOnShape2DSkillStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DACA RID: 121546 RVA: 0x002BD48E File Offset: 0x002BB68E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, EKSC_Skill_State>) ?? ((Action<int, EKSC_Skill_State>)Delegate.CreateDelegate(typeof(Action<int, EKSC_Skill_State>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DACB RID: 121547 RVA: 0x002BD4C0 File Offset: 0x002BB6C0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, EKSC_Skill_State> Callback)
		{
			if (FOnShape2DSkillStateChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnShape2DSkillStateChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnShape2DSkillStateChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnShape2DSkillStateChange.OnScriptCallback));
				}
				FOnShape2DSkillStateChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnShape2DSkillStateChange.RegisterId);
		}

		// Token: 0x0601DACC RID: 121548 RVA: 0x002BD4FC File Offset: 0x002BB6FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int SkillIndex, EKSC_Skill_State State)
		{
			FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams* ptr = stackalloc FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnShape2DSkillStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkillIndex = SkillIndex;
			ptr->State = State;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601DACD RID: 121549 RVA: 0x002BD540 File Offset: 0x002BB740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, EKSC_Skill_State> action = target as Action<int, EKSC_Skill_State>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams*)__Parameters)->SkillIndex, ((FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x0401012B RID: 65835
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401012C RID: 65836
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnShape2DSkillStateChange__DelegateSignature";

		// Token: 0x0401012D RID: 65837
		private static int RegisterId;

		// Token: 0x020032C3 RID: 12995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnShape2DSkillStateChange_DelegateParams
		{
			// Token: 0x04017167 RID: 94567
			[FieldOffset(0)]
			public int SkillIndex;

			// Token: 0x04017168 RID: 94568
			[FieldOffset(4)]
			public EKSC_Skill_State State;
		}

		// Token: 0x020032C4 RID: 12996
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017169 RID: 94569
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
