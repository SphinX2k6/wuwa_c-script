using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009CE RID: 2510
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DistributionLookupTable")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FDistributionLookupTable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008DFE RID: 36350 RVA: 0x000CAF99 File Offset: 0x000C9199
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDistributionLookupTable._ScriptStructPtr != 0) ? FDistributionLookupTable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DistributionLookupTable", ref FDistributionLookupTable._ScriptStructPtr);
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x000CAFBD File Offset: 0x000C91BD
		// (set) Token: 0x06008E00 RID: 36352 RVA: 0x000CAFCD File Offset: 0x000C91CD
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_TimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_TimeScale) = value;
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06008E01 RID: 36353 RVA: 0x000CAFDE File Offset: 0x000C91DE
		// (set) Token: 0x06008E02 RID: 36354 RVA: 0x000CAFEE File Offset: 0x000C91EE
		public unsafe float TimeBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_TimeBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_TimeBias) = value;
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06008E03 RID: 36355 RVA: 0x000CB000 File Offset: 0x000C9200
		// (set) Token: 0x06008E04 RID: 36356 RVA: 0x000CB043 File Offset: 0x000C9243
		public TArray<float> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<float>(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06008E05 RID: 36357 RVA: 0x000CB051 File Offset: 0x000C9251
		// (set) Token: 0x06008E06 RID: 36358 RVA: 0x000CB061 File Offset: 0x000C9261
		public unsafe byte Op
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_Op);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_Op) = value;
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06008E07 RID: 36359 RVA: 0x000CB072 File Offset: 0x000C9272
		// (set) Token: 0x06008E08 RID: 36360 RVA: 0x000CB082 File Offset: 0x000C9282
		public unsafe byte EntryCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_EntryCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_EntryCount) = value;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06008E09 RID: 36361 RVA: 0x000CB093 File Offset: 0x000C9293
		// (set) Token: 0x06008E0A RID: 36362 RVA: 0x000CB0A3 File Offset: 0x000C92A3
		public unsafe byte EntryStride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_EntryStride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_EntryStride) = value;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06008E0B RID: 36363 RVA: 0x000CB0B4 File Offset: 0x000C92B4
		// (set) Token: 0x06008E0C RID: 36364 RVA: 0x000CB0C4 File Offset: 0x000C92C4
		public unsafe byte SubEntryStride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_SubEntryStride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_SubEntryStride) = value;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06008E0D RID: 36365 RVA: 0x000CB0D5 File Offset: 0x000C92D5
		// (set) Token: 0x06008E0E RID: 36366 RVA: 0x000CB0E5 File Offset: 0x000C92E5
		public unsafe byte LockFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_LockFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistributionLookupTable.__PropertyOffset_LockFlag) = value;
			}
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x000CB0F6 File Offset: 0x000C92F6
		public FDistributionLookupTable()
		{
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x000CB100 File Offset: 0x000C9300
		public FDistributionLookupTable(float TimeScale, float TimeBias, TArray<float> Values, byte Op, byte EntryCount, byte EntryStride, byte SubEntryStride, byte LockFlag)
		{
			this.TimeScale = TimeScale;
			this.TimeBias = TimeBias;
			this.Values = Values;
			this.Op = Op;
			this.EntryCount = EntryCount;
			this.EntryStride = EntryStride;
			this.SubEntryStride = SubEntryStride;
			this.LockFlag = LockFlag;
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x000CB150 File Offset: 0x000C9350
		protected override IntPtr GetUStructPtr()
		{
			return FDistributionLookupTable.StaticStruct();
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x000CB15C File Offset: 0x000C935C
		[NullableContext(2)]
		public FDistributionLookupTable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x000CB166 File Offset: 0x000C9366
		public FDistributionLookupTable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008E14 RID: 36372 RVA: 0x000CB171 File Offset: 0x000C9371
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDistributionLookupTable(Pointer, false, true);
		}

		// Token: 0x06008E15 RID: 36373 RVA: 0x000CB17B File Offset: 0x000C937B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDistributionLookupTable(Pointer, MemoryOwner);
		}

		// Token: 0x0400436E RID: 17262
		public const string __ObjectPath = "/Script/Engine.DistributionLookupTable";

		// Token: 0x0400436F RID: 17263
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004370 RID: 17264
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x04004371 RID: 17265
		internal static int __PropertyOffset_TimeBias;

		// Token: 0x04004372 RID: 17266
		internal static int __PropertyOffset_Values;

		// Token: 0x04004373 RID: 17267
		[Nullable(2)]
		private TArray<float> _Values;

		// Token: 0x04004374 RID: 17268
		internal static int __PropertyOffset_Op;

		// Token: 0x04004375 RID: 17269
		internal static int __PropertyOffset_EntryCount;

		// Token: 0x04004376 RID: 17270
		internal static int __PropertyOffset_EntryStride;

		// Token: 0x04004377 RID: 17271
		internal static int __PropertyOffset_SubEntryStride;

		// Token: 0x04004378 RID: 17272
		internal static int __PropertyOffset_LockFlag;
	}
}
