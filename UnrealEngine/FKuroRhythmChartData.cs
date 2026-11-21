using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004FD RID: 1277
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmChartData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroRhythmChartData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007776 RID: 30582 RVA: 0x000AE92E File Offset: 0x000ACB2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmChartData._ScriptStructPtr != 0) ? FKuroRhythmChartData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmChartData", ref FKuroRhythmChartData._ScriptStructPtr);
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06007777 RID: 30583 RVA: 0x000AE952 File Offset: 0x000ACB52
		// (set) Token: 0x06007778 RID: 30584 RVA: 0x000AE966 File Offset: 0x000ACB66
		public unsafe string ChartName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRhythmChartData.__PropertyOffset_ChartName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRhythmChartData.__PropertyOffset_ChartName)), value);
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06007779 RID: 30585 RVA: 0x000AE97B File Offset: 0x000ACB7B
		// (set) Token: 0x0600777A RID: 30586 RVA: 0x000AE98B File Offset: 0x000ACB8B
		public unsafe float BPM
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmChartData.__PropertyOffset_BPM);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmChartData.__PropertyOffset_BPM) = value;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x0600777B RID: 30587 RVA: 0x000AE99C File Offset: 0x000ACB9C
		// (set) Token: 0x0600777C RID: 30588 RVA: 0x000AE9AC File Offset: 0x000ACBAC
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmChartData.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmChartData.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x000AE9BD File Offset: 0x000ACBBD
		// (set) Token: 0x0600777E RID: 30590 RVA: 0x000AE9D1 File Offset: 0x000ACBD1
		public unsafe string MusicPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRhythmChartData.__PropertyOffset_MusicPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRhythmChartData.__PropertyOffset_MusicPath)), value);
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x000AE9E8 File Offset: 0x000ACBE8
		// (set) Token: 0x06007780 RID: 30592 RVA: 0x000AEA2B File Offset: 0x000ACC2B
		public TArray<FKuroRhythmGameNote> Notes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRhythmGameNote> result;
				if ((result = this._Notes) == null)
				{
					result = (this._Notes = new TArray<FKuroRhythmGameNote>(base.NativePtr + (IntPtr)FKuroRhythmChartData.__PropertyOffset_Notes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Notes.CopyAssign(value);
			}
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x000AEA39 File Offset: 0x000ACC39
		public FKuroRhythmChartData()
		{
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x000AEA41 File Offset: 0x000ACC41
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmChartData.StaticStruct();
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x000AEA4D File Offset: 0x000ACC4D
		[NullableContext(2)]
		public FKuroRhythmChartData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x000AEA57 File Offset: 0x000ACC57
		public FKuroRhythmChartData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x000AEA62 File Offset: 0x000ACC62
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmChartData(Pointer, false, true);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x000AEA6C File Offset: 0x000ACC6C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmChartData(Pointer, MemoryOwner);
		}

		// Token: 0x04003289 RID: 12937
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmChartData";

		// Token: 0x0400328A RID: 12938
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400328B RID: 12939
		internal static int __PropertyOffset_ChartName;

		// Token: 0x0400328C RID: 12940
		internal static int __PropertyOffset_BPM;

		// Token: 0x0400328D RID: 12941
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400328E RID: 12942
		internal static int __PropertyOffset_MusicPath;

		// Token: 0x0400328F RID: 12943
		internal static int __PropertyOffset_Notes;

		// Token: 0x04003290 RID: 12944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmGameNote> _Notes;
	}
}
