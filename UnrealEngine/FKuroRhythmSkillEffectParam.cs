using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000505 RID: 1285
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmSkillEffectParam")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroRhythmSkillEffectParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078DB RID: 30939 RVA: 0x000B11BF File Offset: 0x000AF3BF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmSkillEffectParam._ScriptStructPtr != 0) ? FKuroRhythmSkillEffectParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmSkillEffectParam", ref FKuroRhythmSkillEffectParam._ScriptStructPtr);
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x000B11E3 File Offset: 0x000AF3E3
		// (set) Token: 0x060078DD RID: 30941 RVA: 0x000B11F3 File Offset: 0x000AF3F3
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

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x000B1204 File Offset: 0x000AF404
		// (set) Token: 0x060078DF RID: 30943 RVA: 0x000B1247 File Offset: 0x000AF447
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

		// Token: 0x060078E0 RID: 30944 RVA: 0x000B1255 File Offset: 0x000AF455
		public FKuroRhythmSkillEffectParam()
		{
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x000B125D File Offset: 0x000AF45D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmSkillEffectParam.StaticStruct();
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x000B1269 File Offset: 0x000AF469
		[NullableContext(2)]
		public FKuroRhythmSkillEffectParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x000B1273 File Offset: 0x000AF473
		public FKuroRhythmSkillEffectParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x000B127E File Offset: 0x000AF47E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmSkillEffectParam(Pointer, false, true);
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x000B1288 File Offset: 0x000AF488
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmSkillEffectParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400336A RID: 13162
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmSkillEffectParam";

		// Token: 0x0400336B RID: 13163
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400336C RID: 13164
		internal static int __PropertyOffset_EffectType;

		// Token: 0x0400336D RID: 13165
		internal static int __PropertyOffset_EffectParams;

		// Token: 0x0400336E RID: 13166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EffectParams;
	}
}
