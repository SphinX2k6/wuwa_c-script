using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024B5 RID: 9397
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.WaterBasinThresholdRows")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FWaterBasinThresholdRows : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602330B RID: 144139 RVA: 0x00340D50 File Offset: 0x0033EF50
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWaterBasinThresholdRows._ScriptStructPtr != 0) ? FWaterBasinThresholdRows._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.WaterBasinThresholdRows", ref FWaterBasinThresholdRows._ScriptStructPtr);
		}

		// Token: 0x17008756 RID: 34646
		// (get) Token: 0x0602330C RID: 144140 RVA: 0x00340D74 File Offset: 0x0033EF74
		// (set) Token: 0x0602330D RID: 144141 RVA: 0x00340DB7 File Offset: 0x0033EFB7
		public TArray<int> BasinIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BasinIds) == null)
				{
					result = (this._BasinIds = new TArray<int>(base.NativePtr + (IntPtr)FWaterBasinThresholdRows.__PropertyOffset_BasinIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BasinIds.CopyAssign(value);
			}
		}

		// Token: 0x17008757 RID: 34647
		// (get) Token: 0x0602330E RID: 144142 RVA: 0x00340DC8 File Offset: 0x0033EFC8
		// (set) Token: 0x0602330F RID: 144143 RVA: 0x00340E0B File Offset: 0x0033F00B
		public TArray<int> RowOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RowOffsets) == null)
				{
					result = (this._RowOffsets = new TArray<int>(base.NativePtr + (IntPtr)FWaterBasinThresholdRows.__PropertyOffset_RowOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RowOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008758 RID: 34648
		// (get) Token: 0x06023310 RID: 144144 RVA: 0x00340E1C File Offset: 0x0033F01C
		// (set) Token: 0x06023311 RID: 144145 RVA: 0x00340E5F File Offset: 0x0033F05F
		public TArray<int> BodyIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BodyIds) == null)
				{
					result = (this._BodyIds = new TArray<int>(base.NativePtr + (IntPtr)FWaterBasinThresholdRows.__PropertyOffset_BodyIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BodyIds.CopyAssign(value);
			}
		}

		// Token: 0x17008759 RID: 34649
		// (get) Token: 0x06023312 RID: 144146 RVA: 0x00340E70 File Offset: 0x0033F070
		// (set) Token: 0x06023313 RID: 144147 RVA: 0x00340EB3 File Offset: 0x0033F0B3
		public TArray<float> Thresholds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Thresholds) == null)
				{
					result = (this._Thresholds = new TArray<float>(base.NativePtr + (IntPtr)FWaterBasinThresholdRows.__PropertyOffset_Thresholds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Thresholds.CopyAssign(value);
			}
		}

		// Token: 0x06023314 RID: 144148 RVA: 0x00340EC1 File Offset: 0x0033F0C1
		public FWaterBasinThresholdRows()
		{
		}

		// Token: 0x06023315 RID: 144149 RVA: 0x00340EC9 File Offset: 0x0033F0C9
		public FWaterBasinThresholdRows(TArray<int> BasinIds, TArray<int> RowOffsets, TArray<int> BodyIds, TArray<float> Thresholds)
		{
			this.BasinIds = BasinIds;
			this.RowOffsets = RowOffsets;
			this.BodyIds = BodyIds;
			this.Thresholds = Thresholds;
		}

		// Token: 0x06023316 RID: 144150 RVA: 0x00340EEE File Offset: 0x0033F0EE
		protected override IntPtr GetUStructPtr()
		{
			return FWaterBasinThresholdRows.StaticStruct();
		}

		// Token: 0x06023317 RID: 144151 RVA: 0x00340EFA File Offset: 0x0033F0FA
		[NullableContext(2)]
		public FWaterBasinThresholdRows(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023318 RID: 144152 RVA: 0x00340F04 File Offset: 0x0033F104
		public FWaterBasinThresholdRows(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023319 RID: 144153 RVA: 0x00340F0F File Offset: 0x0033F10F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWaterBasinThresholdRows(Pointer, false, true);
		}

		// Token: 0x0602331A RID: 144154 RVA: 0x00340F19 File Offset: 0x0033F119
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWaterBasinThresholdRows(Pointer, MemoryOwner);
		}

		// Token: 0x04012CB3 RID: 76979
		public const string __ObjectPath = "/Script/NavigationSystem.WaterBasinThresholdRows";

		// Token: 0x04012CB4 RID: 76980
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012CB5 RID: 76981
		internal static int __PropertyOffset_BasinIds;

		// Token: 0x04012CB6 RID: 76982
		[Nullable(2)]
		private TArray<int> _BasinIds;

		// Token: 0x04012CB7 RID: 76983
		internal static int __PropertyOffset_RowOffsets;

		// Token: 0x04012CB8 RID: 76984
		[Nullable(2)]
		private TArray<int> _RowOffsets;

		// Token: 0x04012CB9 RID: 76985
		internal static int __PropertyOffset_BodyIds;

		// Token: 0x04012CBA RID: 76986
		[Nullable(2)]
		private TArray<int> _BodyIds;

		// Token: 0x04012CBB RID: 76987
		internal static int __PropertyOffset_Thresholds;

		// Token: 0x04012CBC RID: 76988
		[Nullable(2)]
		private TArray<float> _Thresholds;
	}
}
