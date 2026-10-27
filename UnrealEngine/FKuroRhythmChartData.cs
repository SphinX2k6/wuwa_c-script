using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C46 RID: 7238
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmChartData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroRhythmChartData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C0A8 RID: 114856 RVA: 0x002944DE File Offset: 0x002926DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmChartData._ScriptStructPtr != 0) ? FKuroRhythmChartData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmChartData", ref FKuroRhythmChartData._ScriptStructPtr);
		}

		// Token: 0x1700715C RID: 29020
		// (get) Token: 0x0601C0A9 RID: 114857 RVA: 0x00294502 File Offset: 0x00292702
		// (set) Token: 0x0601C0AA RID: 114858 RVA: 0x00294516 File Offset: 0x00292716
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

		// Token: 0x1700715D RID: 29021
		// (get) Token: 0x0601C0AB RID: 114859 RVA: 0x0029452B File Offset: 0x0029272B
		// (set) Token: 0x0601C0AC RID: 114860 RVA: 0x0029453B File Offset: 0x0029273B
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

		// Token: 0x1700715E RID: 29022
		// (get) Token: 0x0601C0AD RID: 114861 RVA: 0x0029454C File Offset: 0x0029274C
		// (set) Token: 0x0601C0AE RID: 114862 RVA: 0x0029455C File Offset: 0x0029275C
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

		// Token: 0x1700715F RID: 29023
		// (get) Token: 0x0601C0AF RID: 114863 RVA: 0x0029456D File Offset: 0x0029276D
		// (set) Token: 0x0601C0B0 RID: 114864 RVA: 0x00294581 File Offset: 0x00292781
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

		// Token: 0x17007160 RID: 29024
		// (get) Token: 0x0601C0B1 RID: 114865 RVA: 0x00294598 File Offset: 0x00292798
		// (set) Token: 0x0601C0B2 RID: 114866 RVA: 0x002945DB File Offset: 0x002927DB
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

		// Token: 0x17007161 RID: 29025
		// (get) Token: 0x0601C0B3 RID: 114867 RVA: 0x002945EC File Offset: 0x002927EC
		// (set) Token: 0x0601C0B4 RID: 114868 RVA: 0x0029462F File Offset: 0x0029282F
		public TArray<FKuroRhythmChartEvent> Events
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRhythmChartEvent> result;
				if ((result = this._Events) == null)
				{
					result = (this._Events = new TArray<FKuroRhythmChartEvent>(base.NativePtr + (IntPtr)FKuroRhythmChartData.__PropertyOffset_Events, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Events.CopyAssign(value);
			}
		}

		// Token: 0x0601C0B5 RID: 114869 RVA: 0x0029463D File Offset: 0x0029283D
		public FKuroRhythmChartData()
		{
		}

		// Token: 0x0601C0B6 RID: 114870 RVA: 0x00294645 File Offset: 0x00292845
		public FKuroRhythmChartData(string ChartName, float BPM, float Duration, string MusicPath, TArray<FKuroRhythmGameNote> Notes, TArray<FKuroRhythmChartEvent> Events)
		{
			this.ChartName = ChartName;
			this.BPM = BPM;
			this.Duration = Duration;
			this.MusicPath = MusicPath;
			this.Notes = Notes;
			this.Events = Events;
		}

		// Token: 0x0601C0B7 RID: 114871 RVA: 0x0029467A File Offset: 0x0029287A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmChartData.StaticStruct();
		}

		// Token: 0x0601C0B8 RID: 114872 RVA: 0x00294686 File Offset: 0x00292886
		[NullableContext(2)]
		public FKuroRhythmChartData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C0B9 RID: 114873 RVA: 0x00294690 File Offset: 0x00292890
		public FKuroRhythmChartData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C0BA RID: 114874 RVA: 0x0029469B File Offset: 0x0029289B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmChartData(Pointer, false, true);
		}

		// Token: 0x0601C0BB RID: 114875 RVA: 0x002946A5 File Offset: 0x002928A5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmChartData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F144 RID: 61764
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmChartData";

		// Token: 0x0400F145 RID: 61765
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F146 RID: 61766
		internal static int __PropertyOffset_ChartName;

		// Token: 0x0400F147 RID: 61767
		internal static int __PropertyOffset_BPM;

		// Token: 0x0400F148 RID: 61768
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400F149 RID: 61769
		internal static int __PropertyOffset_MusicPath;

		// Token: 0x0400F14A RID: 61770
		internal static int __PropertyOffset_Notes;

		// Token: 0x0400F14B RID: 61771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmGameNote> _Notes;

		// Token: 0x0400F14C RID: 61772
		internal static int __PropertyOffset_Events;

		// Token: 0x0400F14D RID: 61773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmChartEvent> _Events;
	}
}
