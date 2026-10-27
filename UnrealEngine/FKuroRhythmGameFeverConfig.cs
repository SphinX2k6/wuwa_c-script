using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C4E RID: 7246
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameFeverConfig")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroRhythmGameFeverConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C13F RID: 115007 RVA: 0x0029545B File Offset: 0x0029365B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameFeverConfig._ScriptStructPtr != 0) ? FKuroRhythmGameFeverConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameFeverConfig", ref FKuroRhythmGameFeverConfig._ScriptStructPtr);
		}

		// Token: 0x17007189 RID: 29065
		// (get) Token: 0x0601C140 RID: 115008 RVA: 0x0029547F File Offset: 0x0029367F
		// (set) Token: 0x0601C141 RID: 115009 RVA: 0x0029548F File Offset: 0x0029368F
		public unsafe int PerfectFever
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_PerfectFever);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_PerfectFever) = value;
			}
		}

		// Token: 0x1700718A RID: 29066
		// (get) Token: 0x0601C142 RID: 115010 RVA: 0x002954A0 File Offset: 0x002936A0
		// (set) Token: 0x0601C143 RID: 115011 RVA: 0x002954B0 File Offset: 0x002936B0
		public unsafe int GreatFever
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_GreatFever);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_GreatFever) = value;
			}
		}

		// Token: 0x1700718B RID: 29067
		// (get) Token: 0x0601C144 RID: 115012 RVA: 0x002954C1 File Offset: 0x002936C1
		// (set) Token: 0x0601C145 RID: 115013 RVA: 0x002954D1 File Offset: 0x002936D1
		public unsafe int GoodFever
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_GoodFever);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_GoodFever) = value;
			}
		}

		// Token: 0x1700718C RID: 29068
		// (get) Token: 0x0601C146 RID: 115014 RVA: 0x002954E2 File Offset: 0x002936E2
		// (set) Token: 0x0601C147 RID: 115015 RVA: 0x002954F2 File Offset: 0x002936F2
		public unsafe int BadFever
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_BadFever);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_BadFever) = value;
			}
		}

		// Token: 0x1700718D RID: 29069
		// (get) Token: 0x0601C148 RID: 115016 RVA: 0x00295503 File Offset: 0x00293703
		// (set) Token: 0x0601C149 RID: 115017 RVA: 0x00295513 File Offset: 0x00293713
		public unsafe int MissFever
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_MissFever);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameFeverConfig.__PropertyOffset_MissFever) = value;
			}
		}

		// Token: 0x0601C14A RID: 115018 RVA: 0x00295524 File Offset: 0x00293724
		public FKuroRhythmGameFeverConfig()
		{
		}

		// Token: 0x0601C14B RID: 115019 RVA: 0x0029552C File Offset: 0x0029372C
		public FKuroRhythmGameFeverConfig(int PerfectFever, int GreatFever, int GoodFever, int BadFever, int MissFever)
		{
			this.PerfectFever = PerfectFever;
			this.GreatFever = GreatFever;
			this.GoodFever = GoodFever;
			this.BadFever = BadFever;
			this.MissFever = MissFever;
		}

		// Token: 0x0601C14C RID: 115020 RVA: 0x00295559 File Offset: 0x00293759
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameFeverConfig.StaticStruct();
		}

		// Token: 0x0601C14D RID: 115021 RVA: 0x00295565 File Offset: 0x00293765
		[NullableContext(2)]
		public FKuroRhythmGameFeverConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C14E RID: 115022 RVA: 0x0029556F File Offset: 0x0029376F
		public FKuroRhythmGameFeverConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C14F RID: 115023 RVA: 0x0029557A File Offset: 0x0029377A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameFeverConfig(Pointer, false, true);
		}

		// Token: 0x0601C150 RID: 115024 RVA: 0x00295584 File Offset: 0x00293784
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameFeverConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400F196 RID: 61846
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameFeverConfig";

		// Token: 0x0400F197 RID: 61847
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F198 RID: 61848
		internal static int __PropertyOffset_PerfectFever;

		// Token: 0x0400F199 RID: 61849
		internal static int __PropertyOffset_GreatFever;

		// Token: 0x0400F19A RID: 61850
		internal static int __PropertyOffset_GoodFever;

		// Token: 0x0400F19B RID: 61851
		internal static int __PropertyOffset_BadFever;

		// Token: 0x0400F19C RID: 61852
		internal static int __PropertyOffset_MissFever;
	}
}
