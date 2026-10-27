using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C5F RID: 7263
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmSkillEffectParam")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroRhythmSkillEffectParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C2DE RID: 115422 RVA: 0x002987CE File Offset: 0x002969CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmSkillEffectParam._ScriptStructPtr != 0) ? FKuroRhythmSkillEffectParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmSkillEffectParam", ref FKuroRhythmSkillEffectParam._ScriptStructPtr);
		}

		// Token: 0x170071FE RID: 29182
		// (get) Token: 0x0601C2DF RID: 115423 RVA: 0x002987F2 File Offset: 0x002969F2
		// (set) Token: 0x0601C2E0 RID: 115424 RVA: 0x00298802 File Offset: 0x00296A02
		public unsafe int EffectType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmSkillEffectParam.__PropertyOffset_EffectType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmSkillEffectParam.__PropertyOffset_EffectType) = value;
			}
		}

		// Token: 0x170071FF RID: 29183
		// (get) Token: 0x0601C2E1 RID: 115425 RVA: 0x00298814 File Offset: 0x00296A14
		// (set) Token: 0x0601C2E2 RID: 115426 RVA: 0x00298857 File Offset: 0x00296A57
		public TArray<string> EffectParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EffectParams) == null)
				{
					result = (this._EffectParams = new TArray<string>(base.NativePtr + (IntPtr)FKuroRhythmSkillEffectParam.__PropertyOffset_EffectParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectParams.CopyAssign(value);
			}
		}

		// Token: 0x0601C2E3 RID: 115427 RVA: 0x00298865 File Offset: 0x00296A65
		public FKuroRhythmSkillEffectParam()
		{
		}

		// Token: 0x0601C2E4 RID: 115428 RVA: 0x0029886D File Offset: 0x00296A6D
		public FKuroRhythmSkillEffectParam(int EffectType, TArray<string> EffectParams)
		{
			this.EffectType = EffectType;
			this.EffectParams = EffectParams;
		}

		// Token: 0x0601C2E5 RID: 115429 RVA: 0x00298883 File Offset: 0x00296A83
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmSkillEffectParam.StaticStruct();
		}

		// Token: 0x0601C2E6 RID: 115430 RVA: 0x0029888F File Offset: 0x00296A8F
		[NullableContext(2)]
		public FKuroRhythmSkillEffectParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C2E7 RID: 115431 RVA: 0x00298899 File Offset: 0x00296A99
		public FKuroRhythmSkillEffectParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C2E8 RID: 115432 RVA: 0x002988A4 File Offset: 0x00296AA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmSkillEffectParam(Pointer, false, true);
		}

		// Token: 0x0601C2E9 RID: 115433 RVA: 0x002988AE File Offset: 0x00296AAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmSkillEffectParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400F29F RID: 62111
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmSkillEffectParam";

		// Token: 0x0400F2A0 RID: 62112
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F2A1 RID: 62113
		internal static int __PropertyOffset_EffectType;

		// Token: 0x0400F2A2 RID: 62114
		internal static int __PropertyOffset_EffectParams;

		// Token: 0x0400F2A3 RID: 62115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EffectParams;
	}
}
