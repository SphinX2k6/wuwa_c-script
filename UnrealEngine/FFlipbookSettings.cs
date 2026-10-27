using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027AF RID: 10159
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.FlipbookSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FFlipbookSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025DB5 RID: 155061 RVA: 0x0039659A File Offset: 0x0039479A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFlipbookSettings._ScriptStructPtr != 0) ? FFlipbookSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.FlipbookSettings", ref FFlipbookSettings._ScriptStructPtr);
		}

		// Token: 0x170091DF RID: 37343
		// (get) Token: 0x06025DB6 RID: 155062 RVA: 0x003965BE File Offset: 0x003947BE
		// (set) Token: 0x06025DB7 RID: 155063 RVA: 0x003965CE File Offset: 0x003947CE
		public unsafe int CustomCameraSelectionSetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_CustomCameraSelectionSetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_CustomCameraSelectionSetId) = value;
			}
		}

		// Token: 0x170091E0 RID: 37344
		// (get) Token: 0x06025DB8 RID: 155064 RVA: 0x003965DF File Offset: 0x003947DF
		// (set) Token: 0x06025DB9 RID: 155065 RVA: 0x003965F3 File Offset: 0x003947F3
		public unsafe string CustomCameraSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFlipbookSettings.__PropertyOffset_CustomCameraSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFlipbookSettings.__PropertyOffset_CustomCameraSelectionSetName)), value);
			}
		}

		// Token: 0x170091E1 RID: 37345
		// (get) Token: 0x06025DBA RID: 155066 RVA: 0x00396608 File Offset: 0x00394808
		// (set) Token: 0x06025DBB RID: 155067 RVA: 0x00396621 File Offset: 0x00394821
		public unsafe bool PivotAroundOrigin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_PivotAroundOrigin) & FFlipbookSettings.__PropertyMask_PivotAroundOrigin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_PivotAroundOrigin) = ((*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_PivotAroundOrigin) & ~FFlipbookSettings.__PropertyMask_PivotAroundOrigin) | (value ? FFlipbookSettings.__PropertyMask_PivotAroundOrigin : 0));
			}
		}

		// Token: 0x170091E2 RID: 37346
		// (get) Token: 0x06025DBC RID: 155068 RVA: 0x00396651 File Offset: 0x00394851
		// (set) Token: 0x06025DBD RID: 155069 RVA: 0x00396661 File Offset: 0x00394861
		public unsafe int OverrideFlipbookTextureWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_OverrideFlipbookTextureWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_OverrideFlipbookTextureWidth) = value;
			}
		}

		// Token: 0x170091E3 RID: 37347
		// (get) Token: 0x06025DBE RID: 155070 RVA: 0x00396672 File Offset: 0x00394872
		// (set) Token: 0x06025DBF RID: 155071 RVA: 0x0039668B File Offset: 0x0039488B
		public unsafe bool FlipRowColumnOrder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_FlipRowColumnOrder) & FFlipbookSettings.__PropertyMask_FlipRowColumnOrder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_FlipRowColumnOrder) = ((*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_FlipRowColumnOrder) & ~FFlipbookSettings.__PropertyMask_FlipRowColumnOrder) | (value ? FFlipbookSettings.__PropertyMask_FlipRowColumnOrder : 0));
			}
		}

		// Token: 0x170091E4 RID: 37348
		// (get) Token: 0x06025DC0 RID: 155072 RVA: 0x003966BB File Offset: 0x003948BB
		// (set) Token: 0x06025DC1 RID: 155073 RVA: 0x003966CB File Offset: 0x003948CB
		public unsafe int NumberOfRows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_NumberOfRows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_NumberOfRows) = value;
			}
		}

		// Token: 0x170091E5 RID: 37349
		// (get) Token: 0x06025DC2 RID: 155074 RVA: 0x003966DC File Offset: 0x003948DC
		// (set) Token: 0x06025DC3 RID: 155075 RVA: 0x003966EC File Offset: 0x003948EC
		public unsafe int NumberOfColumns
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_NumberOfColumns);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_NumberOfColumns) = value;
			}
		}

		// Token: 0x170091E6 RID: 37350
		// (get) Token: 0x06025DC4 RID: 155076 RVA: 0x003966FD File Offset: 0x003948FD
		// (set) Token: 0x06025DC5 RID: 155077 RVA: 0x00396711 File Offset: 0x00394911
		public unsafe FVector UpVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_UpVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_UpVector) = value;
			}
		}

		// Token: 0x170091E7 RID: 37351
		// (get) Token: 0x06025DC6 RID: 155078 RVA: 0x00396726 File Offset: 0x00394926
		// (set) Token: 0x06025DC7 RID: 155079 RVA: 0x0039673A File Offset: 0x0039493A
		public unsafe FVector ViewDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_ViewDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_ViewDirection) = value;
			}
		}

		// Token: 0x170091E8 RID: 37352
		// (get) Token: 0x06025DC8 RID: 155080 RVA: 0x0039674F File Offset: 0x0039494F
		// (set) Token: 0x06025DC9 RID: 155081 RVA: 0x0039675F File Offset: 0x0039495F
		public unsafe int NumberOfViews
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_NumberOfViews);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlipbookSettings.__PropertyOffset_NumberOfViews) = value;
			}
		}

		// Token: 0x06025DCA RID: 155082 RVA: 0x00396770 File Offset: 0x00394970
		public FFlipbookSettings()
		{
		}

		// Token: 0x06025DCB RID: 155083 RVA: 0x00396778 File Offset: 0x00394978
		public FFlipbookSettings(int CustomCameraSelectionSetId, string CustomCameraSelectionSetName, bool PivotAroundOrigin, int OverrideFlipbookTextureWidth, bool FlipRowColumnOrder, int NumberOfRows, int NumberOfColumns, FVector UpVector, FVector ViewDirection, int NumberOfViews)
		{
			this.CustomCameraSelectionSetId = CustomCameraSelectionSetId;
			this.CustomCameraSelectionSetName = CustomCameraSelectionSetName;
			this.PivotAroundOrigin = PivotAroundOrigin;
			this.OverrideFlipbookTextureWidth = OverrideFlipbookTextureWidth;
			this.FlipRowColumnOrder = FlipRowColumnOrder;
			this.NumberOfRows = NumberOfRows;
			this.NumberOfColumns = NumberOfColumns;
			this.UpVector = UpVector;
			this.ViewDirection = ViewDirection;
			this.NumberOfViews = NumberOfViews;
		}

		// Token: 0x06025DCC RID: 155084 RVA: 0x003967D8 File Offset: 0x003949D8
		protected override IntPtr GetUStructPtr()
		{
			return FFlipbookSettings.StaticStruct();
		}

		// Token: 0x06025DCD RID: 155085 RVA: 0x003967E4 File Offset: 0x003949E4
		[NullableContext(2)]
		public FFlipbookSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025DCE RID: 155086 RVA: 0x003967EE File Offset: 0x003949EE
		public FFlipbookSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025DCF RID: 155087 RVA: 0x003967F9 File Offset: 0x003949F9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFlipbookSettings(Pointer, false, true);
		}

		// Token: 0x06025DD0 RID: 155088 RVA: 0x00396803 File Offset: 0x00394A03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFlipbookSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014A9B RID: 84635
		public const string __ObjectPath = "/Script/SimplygonUObjects.FlipbookSettings";

		// Token: 0x04014A9C RID: 84636
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014A9D RID: 84637
		internal static int __PropertyOffset_CustomCameraSelectionSetId;

		// Token: 0x04014A9E RID: 84638
		internal static int __PropertyOffset_CustomCameraSelectionSetName;

		// Token: 0x04014A9F RID: 84639
		internal static int __PropertyOffset_PivotAroundOrigin;

		// Token: 0x04014AA0 RID: 84640
		internal static byte __PropertyMask_PivotAroundOrigin;

		// Token: 0x04014AA1 RID: 84641
		internal static int __PropertyOffset_OverrideFlipbookTextureWidth;

		// Token: 0x04014AA2 RID: 84642
		internal static int __PropertyOffset_FlipRowColumnOrder;

		// Token: 0x04014AA3 RID: 84643
		internal static byte __PropertyMask_FlipRowColumnOrder;

		// Token: 0x04014AA4 RID: 84644
		internal static int __PropertyOffset_NumberOfRows;

		// Token: 0x04014AA5 RID: 84645
		internal static int __PropertyOffset_NumberOfColumns;

		// Token: 0x04014AA6 RID: 84646
		internal static int __PropertyOffset_UpVector;

		// Token: 0x04014AA7 RID: 84647
		internal static int __PropertyOffset_ViewDirection;

		// Token: 0x04014AA8 RID: 84648
		internal static int __PropertyOffset_NumberOfViews;
	}
}
