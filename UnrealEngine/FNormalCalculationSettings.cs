using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027BF RID: 10175
	[UnrealObjectPath("/Script/SimplygonUObjects.NormalCalculationSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FNormalCalculationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025EF8 RID: 155384 RVA: 0x00398436 File Offset: 0x00396636
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNormalCalculationSettings._ScriptStructPtr != 0) ? FNormalCalculationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.NormalCalculationSettings", ref FNormalCalculationSettings._ScriptStructPtr);
		}

		// Token: 0x17009245 RID: 37445
		// (get) Token: 0x06025EF9 RID: 155385 RVA: 0x0039845A File Offset: 0x0039665A
		// (set) Token: 0x06025EFA RID: 155386 RVA: 0x00398473 File Offset: 0x00396673
		public unsafe bool ReplaceNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReplaceNormals) & FNormalCalculationSettings.__PropertyMask_ReplaceNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReplaceNormals) = ((*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReplaceNormals) & ~FNormalCalculationSettings.__PropertyMask_ReplaceNormals) | (value ? FNormalCalculationSettings.__PropertyMask_ReplaceNormals : 0));
			}
		}

		// Token: 0x17009246 RID: 37446
		// (get) Token: 0x06025EFB RID: 155387 RVA: 0x003984A3 File Offset: 0x003966A3
		// (set) Token: 0x06025EFC RID: 155388 RVA: 0x003984BC File Offset: 0x003966BC
		public unsafe bool RepairInvalidNormals
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_RepairInvalidNormals) & FNormalCalculationSettings.__PropertyMask_RepairInvalidNormals) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_RepairInvalidNormals) = ((*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_RepairInvalidNormals) & ~FNormalCalculationSettings.__PropertyMask_RepairInvalidNormals) | (value ? FNormalCalculationSettings.__PropertyMask_RepairInvalidNormals : 0));
			}
		}

		// Token: 0x17009247 RID: 37447
		// (get) Token: 0x06025EFD RID: 155389 RVA: 0x003984EC File Offset: 0x003966EC
		// (set) Token: 0x06025EFE RID: 155390 RVA: 0x003984FC File Offset: 0x003966FC
		public unsafe float HardEdgeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_HardEdgeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_HardEdgeAngle) = value;
			}
		}

		// Token: 0x17009248 RID: 37448
		// (get) Token: 0x06025EFF RID: 155391 RVA: 0x0039850D File Offset: 0x0039670D
		// (set) Token: 0x06025F00 RID: 155392 RVA: 0x00398526 File Offset: 0x00396726
		public unsafe bool ReplaceTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReplaceTangents) & FNormalCalculationSettings.__PropertyMask_ReplaceTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReplaceTangents) = ((*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReplaceTangents) & ~FNormalCalculationSettings.__PropertyMask_ReplaceTangents) | (value ? FNormalCalculationSettings.__PropertyMask_ReplaceTangents : 0));
			}
		}

		// Token: 0x17009249 RID: 37449
		// (get) Token: 0x06025F01 RID: 155393 RVA: 0x00398556 File Offset: 0x00396756
		// (set) Token: 0x06025F02 RID: 155394 RVA: 0x0039856F File Offset: 0x0039676F
		public unsafe bool ReorthogonalizeTangentSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReorthogonalizeTangentSpace) & FNormalCalculationSettings.__PropertyMask_ReorthogonalizeTangentSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReorthogonalizeTangentSpace) = ((*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ReorthogonalizeTangentSpace) & ~FNormalCalculationSettings.__PropertyMask_ReorthogonalizeTangentSpace) | (value ? FNormalCalculationSettings.__PropertyMask_ReorthogonalizeTangentSpace : 0));
			}
		}

		// Token: 0x1700924A RID: 37450
		// (get) Token: 0x06025F03 RID: 155395 RVA: 0x0039859F File Offset: 0x0039679F
		// (set) Token: 0x06025F04 RID: 155396 RVA: 0x003985B8 File Offset: 0x003967B8
		public unsafe bool ScaleByArea
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ScaleByArea) & FNormalCalculationSettings.__PropertyMask_ScaleByArea) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ScaleByArea) = ((*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ScaleByArea) & ~FNormalCalculationSettings.__PropertyMask_ScaleByArea) | (value ? FNormalCalculationSettings.__PropertyMask_ScaleByArea : 0));
			}
		}

		// Token: 0x1700924B RID: 37451
		// (get) Token: 0x06025F05 RID: 155397 RVA: 0x003985E8 File Offset: 0x003967E8
		// (set) Token: 0x06025F06 RID: 155398 RVA: 0x00398601 File Offset: 0x00396801
		public unsafe bool ScaleByAngle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ScaleByAngle) & FNormalCalculationSettings.__PropertyMask_ScaleByAngle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ScaleByAngle) = ((*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_ScaleByAngle) & ~FNormalCalculationSettings.__PropertyMask_ScaleByAngle) | (value ? FNormalCalculationSettings.__PropertyMask_ScaleByAngle : 0));
			}
		}

		// Token: 0x1700924C RID: 37452
		// (get) Token: 0x06025F07 RID: 155399 RVA: 0x00398631 File Offset: 0x00396831
		// (set) Token: 0x06025F08 RID: 155400 RVA: 0x0039864A File Offset: 0x0039684A
		public unsafe bool SnapNormalsToFlatSurfaces
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_SnapNormalsToFlatSurfaces) & FNormalCalculationSettings.__PropertyMask_SnapNormalsToFlatSurfaces) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_SnapNormalsToFlatSurfaces) = ((*(base.NativePtr + (IntPtr)FNormalCalculationSettings.__PropertyOffset_SnapNormalsToFlatSurfaces) & ~FNormalCalculationSettings.__PropertyMask_SnapNormalsToFlatSurfaces) | (value ? FNormalCalculationSettings.__PropertyMask_SnapNormalsToFlatSurfaces : 0));
			}
		}

		// Token: 0x06025F09 RID: 155401 RVA: 0x0039867A File Offset: 0x0039687A
		public FNormalCalculationSettings()
		{
		}

		// Token: 0x06025F0A RID: 155402 RVA: 0x00398684 File Offset: 0x00396884
		public FNormalCalculationSettings(bool ReplaceNormals, bool RepairInvalidNormals, float HardEdgeAngle, bool ReplaceTangents, bool ReorthogonalizeTangentSpace, bool ScaleByArea, bool ScaleByAngle, bool SnapNormalsToFlatSurfaces)
		{
			this.ReplaceNormals = ReplaceNormals;
			this.RepairInvalidNormals = RepairInvalidNormals;
			this.HardEdgeAngle = HardEdgeAngle;
			this.ReplaceTangents = ReplaceTangents;
			this.ReorthogonalizeTangentSpace = ReorthogonalizeTangentSpace;
			this.ScaleByArea = ScaleByArea;
			this.ScaleByAngle = ScaleByAngle;
			this.SnapNormalsToFlatSurfaces = SnapNormalsToFlatSurfaces;
		}

		// Token: 0x06025F0B RID: 155403 RVA: 0x003986D4 File Offset: 0x003968D4
		protected override IntPtr GetUStructPtr()
		{
			return FNormalCalculationSettings.StaticStruct();
		}

		// Token: 0x06025F0C RID: 155404 RVA: 0x003986E0 File Offset: 0x003968E0
		[NullableContext(2)]
		public FNormalCalculationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025F0D RID: 155405 RVA: 0x003986EA File Offset: 0x003968EA
		public FNormalCalculationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025F0E RID: 155406 RVA: 0x003986F5 File Offset: 0x003968F5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNormalCalculationSettings(Pointer, false, true);
		}

		// Token: 0x06025F0F RID: 155407 RVA: 0x003986FF File Offset: 0x003968FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNormalCalculationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B4A RID: 84810
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.NormalCalculationSettings";

		// Token: 0x04014B4B RID: 84811
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B4C RID: 84812
		internal static int __PropertyOffset_ReplaceNormals;

		// Token: 0x04014B4D RID: 84813
		internal static byte __PropertyMask_ReplaceNormals;

		// Token: 0x04014B4E RID: 84814
		internal static int __PropertyOffset_RepairInvalidNormals;

		// Token: 0x04014B4F RID: 84815
		internal static byte __PropertyMask_RepairInvalidNormals;

		// Token: 0x04014B50 RID: 84816
		internal static int __PropertyOffset_HardEdgeAngle;

		// Token: 0x04014B51 RID: 84817
		internal static int __PropertyOffset_ReplaceTangents;

		// Token: 0x04014B52 RID: 84818
		internal static byte __PropertyMask_ReplaceTangents;

		// Token: 0x04014B53 RID: 84819
		internal static int __PropertyOffset_ReorthogonalizeTangentSpace;

		// Token: 0x04014B54 RID: 84820
		internal static byte __PropertyMask_ReorthogonalizeTangentSpace;

		// Token: 0x04014B55 RID: 84821
		internal static int __PropertyOffset_ScaleByArea;

		// Token: 0x04014B56 RID: 84822
		internal static byte __PropertyMask_ScaleByArea;

		// Token: 0x04014B57 RID: 84823
		internal static int __PropertyOffset_ScaleByAngle;

		// Token: 0x04014B58 RID: 84824
		internal static byte __PropertyMask_ScaleByAngle;

		// Token: 0x04014B59 RID: 84825
		internal static int __PropertyOffset_SnapNormalsToFlatSurfaces;

		// Token: 0x04014B5A RID: 84826
		internal static byte __PropertyMask_SnapNormalsToFlatSurfaces;
	}
}
