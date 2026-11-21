using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A2 RID: 1442
	public sealed class FOnSkillCD : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008238 RID: 33336 RVA: 0x000C086C File Offset: 0x000BEA6C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSkillCD.StaticFunctionPtr();
		}

		// Token: 0x06008239 RID: 33337 RVA: 0x000C0878 File Offset: 0x000BEA78
		private static IntPtr StaticFunctionPtr()
		{
			if (AKSC_Entity_AssistMachine.__OnSkillCD__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKSC_Entity_AssistMachine.__OnSkillCD__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillCD__DelegateSignature");
			}
			return AKSC_Entity_AssistMachine.__OnSkillCD__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600823A RID: 33338 RVA: 0x000C089B File Offset: 0x000BEA9B
		public FOnSkillCD()
		{
		}

		// Token: 0x0600823B RID: 33339 RVA: 0x000C08A3 File Offset: 0x000BEAA3
		[NullableContext(2)]
		public FOnSkillCD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600823C RID: 33340 RVA: 0x000C08AD File Offset: 0x000BEAAD
		public FOnSkillCD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x000C08B8 File Offset: 0x000BEAB8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, float>) ?? ((Action<int, float>)Delegate.CreateDelegate(typeof(Action<int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x000C08EA File Offset: 0x000BEAEA
		[NullableContext(1)]
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

		// Token: 0x0600823F RID: 33343 RVA: 0x000C0924 File Offset: 0x000BEB24
		[SkipLocalsInit]
		public unsafe void Execute(int skillIndex, float cd)
		{
			FOnSkillCD.__FOnSkillCD_DelegateParams* ptr = stackalloc FOnSkillCD.__FOnSkillCD_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnSkillCD.__FOnSkillCD_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSkillCD.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skillIndex = skillIndex;
			ptr->cd = cd;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008240 RID: 33344 RVA: 0x000C0968 File Offset: 0x000BEB68
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float> action = target as Action<int, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnSkillCD.__FOnSkillCD_DelegateParams*)__Parameters)->skillIndex, ((FOnSkillCD.__FOnSkillCD_DelegateParams*)__Parameters)->cd);
		}

		// Token: 0x040038C3 RID: 14531
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillCD__DelegateSignature";

		// Token: 0x040038C4 RID: 14532
		private static int RegisterId;

		// Token: 0x02000D24 RID: 3364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnSkillCD_DelegateParams
		{
			// Token: 0x04005FB6 RID: 24502
			[FieldOffset(0)]
			public int skillIndex;

			// Token: 0x04005FB7 RID: 24503
			[FieldOffset(4)]
			public float cd;
		}

		// Token: 0x02000D25 RID: 3365
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FB8 RID: 24504
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
