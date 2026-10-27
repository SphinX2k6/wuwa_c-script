using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027B2 RID: 10162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.GeometryCullingSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGeometryCullingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025DFF RID: 155135 RVA: 0x00396BC8 File Offset: 0x00394DC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCullingSettings._ScriptStructPtr != 0) ? FGeometryCullingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.GeometryCullingSettings", ref FGeometryCullingSettings._ScriptStructPtr);
		}

		// Token: 0x170091F8 RID: 37368
		// (get) Token: 0x06025E00 RID: 155136 RVA: 0x00396BEC File Offset: 0x00394DEC
		// (set) Token: 0x06025E01 RID: 155137 RVA: 0x00396C05 File Offset: 0x00394E05
		public unsafe bool UseClippingPlanes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_UseClippingPlanes) & FGeometryCullingSettings.__PropertyMask_UseClippingPlanes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_UseClippingPlanes) = ((*(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_UseClippingPlanes) & ~FGeometryCullingSettings.__PropertyMask_UseClippingPlanes) | (value ? FGeometryCullingSettings.__PropertyMask_UseClippingPlanes : 0));
			}
		}

		// Token: 0x170091F9 RID: 37369
		// (get) Token: 0x06025E02 RID: 155138 RVA: 0x00396C35 File Offset: 0x00394E35
		// (set) Token: 0x06025E03 RID: 155139 RVA: 0x00396C45 File Offset: 0x00394E45
		public unsafe int ClippingPlaneSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingPlaneSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingPlaneSelectionSetID) = value;
			}
		}

		// Token: 0x170091FA RID: 37370
		// (get) Token: 0x06025E04 RID: 155140 RVA: 0x00396C56 File Offset: 0x00394E56
		// (set) Token: 0x06025E05 RID: 155141 RVA: 0x00396C6A File Offset: 0x00394E6A
		public unsafe string ClippingPlaneSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingPlaneSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingPlaneSelectionSetName)), value);
			}
		}

		// Token: 0x170091FB RID: 37371
		// (get) Token: 0x06025E06 RID: 155142 RVA: 0x00396C7F File Offset: 0x00394E7F
		// (set) Token: 0x06025E07 RID: 155143 RVA: 0x00396C98 File Offset: 0x00394E98
		public unsafe bool UseClippingGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_UseClippingGeometry) & FGeometryCullingSettings.__PropertyMask_UseClippingGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_UseClippingGeometry) = ((*(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_UseClippingGeometry) & ~FGeometryCullingSettings.__PropertyMask_UseClippingGeometry) | (value ? FGeometryCullingSettings.__PropertyMask_UseClippingGeometry : 0));
			}
		}

		// Token: 0x170091FC RID: 37372
		// (get) Token: 0x06025E08 RID: 155144 RVA: 0x00396CC8 File Offset: 0x00394EC8
		// (set) Token: 0x06025E09 RID: 155145 RVA: 0x00396CD8 File Offset: 0x00394ED8
		public unsafe int ClippingGeometrySelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingGeometrySelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingGeometrySelectionSetID) = value;
			}
		}

		// Token: 0x170091FD RID: 37373
		// (get) Token: 0x06025E0A RID: 155146 RVA: 0x00396CE9 File Offset: 0x00394EE9
		// (set) Token: 0x06025E0B RID: 155147 RVA: 0x00396CFD File Offset: 0x00394EFD
		public unsafe string ClippingGeometrySelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingGeometrySelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGeometryCullingSettings.__PropertyOffset_ClippingGeometrySelectionSetName)), value);
			}
		}

		// Token: 0x06025E0C RID: 155148 RVA: 0x00396D12 File Offset: 0x00394F12
		public FGeometryCullingSettings()
		{
		}

		// Token: 0x06025E0D RID: 155149 RVA: 0x00396D1A File Offset: 0x00394F1A
		public FGeometryCullingSettings(bool UseClippingPlanes, int ClippingPlaneSelectionSetID, string ClippingPlaneSelectionSetName, bool UseClippingGeometry, int ClippingGeometrySelectionSetID, string ClippingGeometrySelectionSetName)
		{
			this.UseClippingPlanes = UseClippingPlanes;
			this.ClippingPlaneSelectionSetID = ClippingPlaneSelectionSetID;
			this.ClippingPlaneSelectionSetName = ClippingPlaneSelectionSetName;
			this.UseClippingGeometry = UseClippingGeometry;
			this.ClippingGeometrySelectionSetID = ClippingGeometrySelectionSetID;
			this.ClippingGeometrySelectionSetName = ClippingGeometrySelectionSetName;
		}

		// Token: 0x06025E0E RID: 155150 RVA: 0x00396D4F File Offset: 0x00394F4F
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryCullingSettings.StaticStruct();
		}

		// Token: 0x06025E0F RID: 155151 RVA: 0x00396D5B File Offset: 0x00394F5B
		[NullableContext(2)]
		public FGeometryCullingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025E10 RID: 155152 RVA: 0x00396D65 File Offset: 0x00394F65
		public FGeometryCullingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025E11 RID: 155153 RVA: 0x00396D70 File Offset: 0x00394F70
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryCullingSettings(Pointer, false, true);
		}

		// Token: 0x06025E12 RID: 155154 RVA: 0x00396D7A File Offset: 0x00394F7A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryCullingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014ABF RID: 84671
		public const string __ObjectPath = "/Script/SimplygonUObjects.GeometryCullingSettings";

		// Token: 0x04014AC0 RID: 84672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AC1 RID: 84673
		internal static int __PropertyOffset_UseClippingPlanes;

		// Token: 0x04014AC2 RID: 84674
		internal static byte __PropertyMask_UseClippingPlanes;

		// Token: 0x04014AC3 RID: 84675
		internal static int __PropertyOffset_ClippingPlaneSelectionSetID;

		// Token: 0x04014AC4 RID: 84676
		internal static int __PropertyOffset_ClippingPlaneSelectionSetName;

		// Token: 0x04014AC5 RID: 84677
		internal static int __PropertyOffset_UseClippingGeometry;

		// Token: 0x04014AC6 RID: 84678
		internal static byte __PropertyMask_UseClippingGeometry;

		// Token: 0x04014AC7 RID: 84679
		internal static int __PropertyOffset_ClippingGeometrySelectionSetID;

		// Token: 0x04014AC8 RID: 84680
		internal static int __PropertyOffset_ClippingGeometrySelectionSetName;
	}
}
