using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CE5 RID: 3301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroCellLayerVolumeData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuroCellLayerVolumeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF1B RID: 44827 RVA: 0x000F85F8 File Offset: 0x000F67F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCellLayerVolumeData._ScriptStructPtr != 0) ? FKuroCellLayerVolumeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroCellLayerVolumeData", ref FKuroCellLayerVolumeData._ScriptStructPtr);
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x0600AF1C RID: 44828 RVA: 0x000F861C File Offset: 0x000F681C
		// (set) Token: 0x0600AF1D RID: 44829 RVA: 0x000F8630 File Offset: 0x000F6830
		public unsafe FBox BoundingBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_BoundingBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_BoundingBox) = value;
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x0600AF1E RID: 44830 RVA: 0x000F8648 File Offset: 0x000F6848
		// (set) Token: 0x0600AF1F RID: 44831 RVA: 0x000F868B File Offset: 0x000F688B
		public FKuroCellLayer CellLayerType
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCellLayer result;
				if ((result = this._CellLayerType) == null)
				{
					result = (this._CellLayerType = new FKuroCellLayer(base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_CellLayerType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCellLayer.StaticStruct(), base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_CellLayerType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x0600AF20 RID: 44832 RVA: 0x000F86AC File Offset: 0x000F68AC
		// (set) Token: 0x0600AF21 RID: 44833 RVA: 0x000F86EF File Offset: 0x000F68EF
		public TArray<FName> IncludeDataLayerLabels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._IncludeDataLayerLabels) == null)
				{
					result = (this._IncludeDataLayerLabels = new TArray<FName>(base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_IncludeDataLayerLabels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IncludeDataLayerLabels.CopyAssign(value);
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x0600AF22 RID: 44834 RVA: 0x000F8700 File Offset: 0x000F6900
		// (set) Token: 0x0600AF23 RID: 44835 RVA: 0x000F8743 File Offset: 0x000F6943
		public TArray<FName> IncludeDataLayerNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._IncludeDataLayerNames) == null)
				{
					result = (this._IncludeDataLayerNames = new TArray<FName>(base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_IncludeDataLayerNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IncludeDataLayerNames.CopyAssign(value);
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x0600AF24 RID: 44836 RVA: 0x000F8754 File Offset: 0x000F6954
		// (set) Token: 0x0600AF25 RID: 44837 RVA: 0x000F8797 File Offset: 0x000F6997
		public TArray<FName> ExcludeDataLayerLabels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ExcludeDataLayerLabels) == null)
				{
					result = (this._ExcludeDataLayerLabels = new TArray<FName>(base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_ExcludeDataLayerLabels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExcludeDataLayerLabels.CopyAssign(value);
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x000F87A8 File Offset: 0x000F69A8
		// (set) Token: 0x0600AF27 RID: 44839 RVA: 0x000F87EB File Offset: 0x000F69EB
		public TArray<FName> ExcludeDataLayerNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ExcludeDataLayerNames) == null)
				{
					result = (this._ExcludeDataLayerNames = new TArray<FName>(base.NativePtr + (IntPtr)FKuroCellLayerVolumeData.__PropertyOffset_ExcludeDataLayerNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExcludeDataLayerNames.CopyAssign(value);
			}
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x000F87F9 File Offset: 0x000F69F9
		public FKuroCellLayerVolumeData()
		{
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x000F8801 File Offset: 0x000F6A01
		public FKuroCellLayerVolumeData(FBox BoundingBox, FKuroCellLayer CellLayerType, TArray<FName> IncludeDataLayerLabels, TArray<FName> IncludeDataLayerNames, TArray<FName> ExcludeDataLayerLabels, TArray<FName> ExcludeDataLayerNames)
		{
			this.BoundingBox = BoundingBox;
			this.CellLayerType = CellLayerType;
			this.IncludeDataLayerLabels = IncludeDataLayerLabels;
			this.IncludeDataLayerNames = IncludeDataLayerNames;
			this.ExcludeDataLayerLabels = ExcludeDataLayerLabels;
			this.ExcludeDataLayerNames = ExcludeDataLayerNames;
		}

		// Token: 0x0600AF2A RID: 44842 RVA: 0x000F8836 File Offset: 0x000F6A36
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCellLayerVolumeData.StaticStruct();
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x000F8842 File Offset: 0x000F6A42
		[NullableContext(2)]
		public FKuroCellLayerVolumeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x000F884C File Offset: 0x000F6A4C
		public FKuroCellLayerVolumeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x000F8857 File Offset: 0x000F6A57
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCellLayerVolumeData(Pointer, false, true);
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x000F8861 File Offset: 0x000F6A61
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCellLayerVolumeData(Pointer, MemoryOwner);
		}

		// Token: 0x04005BB3 RID: 23475
		public const string __ObjectPath = "/Script/Engine.KuroCellLayerVolumeData";

		// Token: 0x04005BB4 RID: 23476
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BB5 RID: 23477
		internal static int __PropertyOffset_BoundingBox;

		// Token: 0x04005BB6 RID: 23478
		internal static int __PropertyOffset_CellLayerType;

		// Token: 0x04005BB7 RID: 23479
		[Nullable(2)]
		private FKuroCellLayer _CellLayerType;

		// Token: 0x04005BB8 RID: 23480
		internal static int __PropertyOffset_IncludeDataLayerLabels;

		// Token: 0x04005BB9 RID: 23481
		[Nullable(2)]
		private TArray<FName> _IncludeDataLayerLabels;

		// Token: 0x04005BBA RID: 23482
		internal static int __PropertyOffset_IncludeDataLayerNames;

		// Token: 0x04005BBB RID: 23483
		[Nullable(2)]
		private TArray<FName> _IncludeDataLayerNames;

		// Token: 0x04005BBC RID: 23484
		internal static int __PropertyOffset_ExcludeDataLayerLabels;

		// Token: 0x04005BBD RID: 23485
		[Nullable(2)]
		private TArray<FName> _ExcludeDataLayerLabels;

		// Token: 0x04005BBE RID: 23486
		internal static int __PropertyOffset_ExcludeDataLayerNames;

		// Token: 0x04005BBF RID: 23487
		[Nullable(2)]
		private TArray<FName> _ExcludeDataLayerNames;
	}
}
