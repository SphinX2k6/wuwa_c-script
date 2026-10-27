using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001387 RID: 4999
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectCustomExecutionOutput")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameplayEffectCustomExecutionOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060125A3 RID: 75171 RVA: 0x001AF53D File Offset: 0x001AD73D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectCustomExecutionOutput._ScriptStructPtr != 0) ? FGameplayEffectCustomExecutionOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectCustomExecutionOutput", ref FGameplayEffectCustomExecutionOutput._ScriptStructPtr);
		}

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x060125A4 RID: 75172 RVA: 0x001AF564 File Offset: 0x001AD764
		// (set) Token: 0x060125A5 RID: 75173 RVA: 0x001AF5A7 File Offset: 0x001AD7A7
		public TArray<FGameplayModifierEvaluatedData> OutputModifiers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayModifierEvaluatedData> result;
				if ((result = this._OutputModifiers) == null)
				{
					result = (this._OutputModifiers = new TArray<FGameplayModifierEvaluatedData>(base.NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_OutputModifiers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OutputModifiers.CopyAssign(value);
			}
		}

		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x060125A6 RID: 75174 RVA: 0x001AF5B5 File Offset: 0x001AD7B5
		// (set) Token: 0x060125A7 RID: 75175 RVA: 0x001AF5CE File Offset: 0x001AD7CE
		public unsafe bool bTriggerConditionalGameplayEffects
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bTriggerConditionalGameplayEffects) & FGameplayEffectCustomExecutionOutput.__PropertyMask_bTriggerConditionalGameplayEffects) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bTriggerConditionalGameplayEffects) = ((*(base.NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bTriggerConditionalGameplayEffects) & ~FGameplayEffectCustomExecutionOutput.__PropertyMask_bTriggerConditionalGameplayEffects) | (value ? FGameplayEffectCustomExecutionOutput.__PropertyMask_bTriggerConditionalGameplayEffects : 0));
			}
		}

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x060125A8 RID: 75176 RVA: 0x001AF5FE File Offset: 0x001AD7FE
		// (set) Token: 0x060125A9 RID: 75177 RVA: 0x001AF617 File Offset: 0x001AD817
		public unsafe bool bHandledStackCountManually
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bHandledStackCountManually) & FGameplayEffectCustomExecutionOutput.__PropertyMask_bHandledStackCountManually) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bHandledStackCountManually) = ((*(base.NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bHandledStackCountManually) & ~FGameplayEffectCustomExecutionOutput.__PropertyMask_bHandledStackCountManually) | (value ? FGameplayEffectCustomExecutionOutput.__PropertyMask_bHandledStackCountManually : 0));
			}
		}

		// Token: 0x17004786 RID: 18310
		// (get) Token: 0x060125AA RID: 75178 RVA: 0x001AF647 File Offset: 0x001AD847
		// (set) Token: 0x060125AB RID: 75179 RVA: 0x001AF660 File Offset: 0x001AD860
		public unsafe bool bHandledGameplayCuesManually
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bHandledGameplayCuesManually) & FGameplayEffectCustomExecutionOutput.__PropertyMask_bHandledGameplayCuesManually) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bHandledGameplayCuesManually) = ((*(base.NativePtr + (IntPtr)FGameplayEffectCustomExecutionOutput.__PropertyOffset_bHandledGameplayCuesManually) & ~FGameplayEffectCustomExecutionOutput.__PropertyMask_bHandledGameplayCuesManually) | (value ? FGameplayEffectCustomExecutionOutput.__PropertyMask_bHandledGameplayCuesManually : 0));
			}
		}

		// Token: 0x060125AC RID: 75180 RVA: 0x001AF690 File Offset: 0x001AD890
		public FGameplayEffectCustomExecutionOutput()
		{
		}

		// Token: 0x060125AD RID: 75181 RVA: 0x001AF698 File Offset: 0x001AD898
		public FGameplayEffectCustomExecutionOutput(TArray<FGameplayModifierEvaluatedData> OutputModifiers, bool bTriggerConditionalGameplayEffects, bool bHandledStackCountManually, bool bHandledGameplayCuesManually)
		{
			this.OutputModifiers = OutputModifiers;
			this.bTriggerConditionalGameplayEffects = bTriggerConditionalGameplayEffects;
			this.bHandledStackCountManually = bHandledStackCountManually;
			this.bHandledGameplayCuesManually = bHandledGameplayCuesManually;
		}

		// Token: 0x060125AE RID: 75182 RVA: 0x001AF6BD File Offset: 0x001AD8BD
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectCustomExecutionOutput.StaticStruct();
		}

		// Token: 0x060125AF RID: 75183 RVA: 0x001AF6C9 File Offset: 0x001AD8C9
		[NullableContext(2)]
		public FGameplayEffectCustomExecutionOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060125B0 RID: 75184 RVA: 0x001AF6D3 File Offset: 0x001AD8D3
		public FGameplayEffectCustomExecutionOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060125B1 RID: 75185 RVA: 0x001AF6DE File Offset: 0x001AD8DE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectCustomExecutionOutput(Pointer, false, true);
		}

		// Token: 0x060125B2 RID: 75186 RVA: 0x001AF6E8 File Offset: 0x001AD8E8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectCustomExecutionOutput(Pointer, MemoryOwner);
		}

		// Token: 0x04009D32 RID: 40242
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectCustomExecutionOutput";

		// Token: 0x04009D33 RID: 40243
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D34 RID: 40244
		internal static int __PropertyOffset_OutputModifiers;

		// Token: 0x04009D35 RID: 40245
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayModifierEvaluatedData> _OutputModifiers;

		// Token: 0x04009D36 RID: 40246
		internal static int __PropertyOffset_bTriggerConditionalGameplayEffects;

		// Token: 0x04009D37 RID: 40247
		internal static byte __PropertyMask_bTriggerConditionalGameplayEffects;

		// Token: 0x04009D38 RID: 40248
		internal static int __PropertyOffset_bHandledStackCountManually;

		// Token: 0x04009D39 RID: 40249
		internal static byte __PropertyMask_bHandledStackCountManually;

		// Token: 0x04009D3A RID: 40250
		internal static int __PropertyOffset_bHandledGameplayCuesManually;

		// Token: 0x04009D3B RID: 40251
		internal static byte __PropertyMask_bHandledGameplayCuesManually;
	}
}
