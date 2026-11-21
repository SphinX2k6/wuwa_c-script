using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A1 RID: 1441
	public sealed class FOnShape2DSkillStateChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600822F RID: 33327 RVA: 0x000C071E File Offset: 0x000BE91E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnShape2DSkillStateChange.StaticFunctionPtr();
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x000C072A File Offset: 0x000BE92A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnShape2DSkillStateChange._FunctionPtr == IntPtr.Zero)
			{
				FOnShape2DSkillStateChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnShape2DSkillStateChange__DelegateSignature");
			}
			return FOnShape2DSkillStateChange._FunctionPtr;
		}

		// Token: 0x06008231 RID: 33329 RVA: 0x000C074D File Offset: 0x000BE94D
		public FOnShape2DSkillStateChange()
		{
		}

		// Token: 0x06008232 RID: 33330 RVA: 0x000C0755 File Offset: 0x000BE955
		[NullableContext(2)]
		public FOnShape2DSkillStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x000C075F File Offset: 0x000BE95F
		public FOnShape2DSkillStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x000C076A File Offset: 0x000BE96A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, EKSC_Skill_State>) ?? ((Action<int, EKSC_Skill_State>)Delegate.CreateDelegate(typeof(Action<int, EKSC_Skill_State>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x000C079C File Offset: 0x000BE99C
		[NullableContext(1)]
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

		// Token: 0x06008236 RID: 33334 RVA: 0x000C07D8 File Offset: 0x000BE9D8
		[SkipLocalsInit]
		public unsafe void Execute(int SkillIndex, EKSC_Skill_State State)
		{
			FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams* ptr = stackalloc FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnShape2DSkillStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkillIndex = SkillIndex;
			ptr->State = State;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008237 RID: 33335 RVA: 0x000C081C File Offset: 0x000BEA1C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, EKSC_Skill_State> action = target as Action<int, EKSC_Skill_State>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams*)__Parameters)->SkillIndex, ((FOnShape2DSkillStateChange.__FOnShape2DSkillStateChange_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x040038C0 RID: 14528
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038C1 RID: 14529
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnShape2DSkillStateChange__DelegateSignature";

		// Token: 0x040038C2 RID: 14530
		private static int RegisterId;

		// Token: 0x02000D22 RID: 3362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnShape2DSkillStateChange_DelegateParams
		{
			// Token: 0x04005FB3 RID: 24499
			[FieldOffset(0)]
			public int SkillIndex;

			// Token: 0x04005FB4 RID: 24500
			[FieldOffset(4)]
			public EKSC_Skill_State State;
		}

		// Token: 0x02000D23 RID: 3363
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FB5 RID: 24501
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
