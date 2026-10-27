using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C5E RID: 7262
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmSkillContext")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroRhythmSkillContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C2D2 RID: 115410 RVA: 0x00298706 File Offset: 0x00296906
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmSkillContext._ScriptStructPtr != 0) ? FKuroRhythmSkillContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmSkillContext", ref FKuroRhythmSkillContext._ScriptStructPtr);
		}

		// Token: 0x170071FC RID: 29180
		// (get) Token: 0x0601C2D3 RID: 115411 RVA: 0x0029872A File Offset: 0x0029692A
		// (set) Token: 0x0601C2D4 RID: 115412 RVA: 0x0029873E File Offset: 0x0029693E
		public unsafe UKuroRhythmGameManager GameManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRhythmGameManager>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmSkillContext.__PropertyOffset_GameManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmSkillContext.__PropertyOffset_GameManager, value);
			}
		}

		// Token: 0x170071FD RID: 29181
		// (get) Token: 0x0601C2D5 RID: 115413 RVA: 0x00298753 File Offset: 0x00296953
		// (set) Token: 0x0601C2D6 RID: 115414 RVA: 0x00298767 File Offset: 0x00296967
		public unsafe UKuroRhythmGameJudgement Judgement
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRhythmGameJudgement>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmSkillContext.__PropertyOffset_Judgement);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmSkillContext.__PropertyOffset_Judgement, value);
			}
		}

		// Token: 0x0601C2D7 RID: 115415 RVA: 0x0029877C File Offset: 0x0029697C
		public FKuroRhythmSkillContext()
		{
		}

		// Token: 0x0601C2D8 RID: 115416 RVA: 0x00298784 File Offset: 0x00296984
		[NullableContext(1)]
		public FKuroRhythmSkillContext(UKuroRhythmGameManager GameManager, UKuroRhythmGameJudgement Judgement)
		{
			this.GameManager = GameManager;
			this.Judgement = Judgement;
		}

		// Token: 0x0601C2D9 RID: 115417 RVA: 0x0029879A File Offset: 0x0029699A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmSkillContext.StaticStruct();
		}

		// Token: 0x0601C2DA RID: 115418 RVA: 0x002987A6 File Offset: 0x002969A6
		public FKuroRhythmSkillContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C2DB RID: 115419 RVA: 0x002987B0 File Offset: 0x002969B0
		public FKuroRhythmSkillContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C2DC RID: 115420 RVA: 0x002987BB File Offset: 0x002969BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmSkillContext(Pointer, false, true);
		}

		// Token: 0x0601C2DD RID: 115421 RVA: 0x002987C5 File Offset: 0x002969C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmSkillContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400F29B RID: 62107
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmSkillContext";

		// Token: 0x0400F29C RID: 62108
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F29D RID: 62109
		internal static int __PropertyOffset_GameManager;

		// Token: 0x0400F29E RID: 62110
		internal static int __PropertyOffset_Judgement;
	}
}
