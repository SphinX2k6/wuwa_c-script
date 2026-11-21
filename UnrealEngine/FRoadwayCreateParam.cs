using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200041A RID: 1050
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.RoadwayCreateParam")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRoadwayCreateParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065AF RID: 26031 RVA: 0x00091A26 File Offset: 0x0008FC26
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRoadwayCreateParam._ScriptStructPtr != 0) ? FRoadwayCreateParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.RoadwayCreateParam", ref FRoadwayCreateParam._ScriptStructPtr);
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x060065B0 RID: 26032 RVA: 0x00091A4A File Offset: 0x0008FC4A
		// (set) Token: 0x060065B1 RID: 26033 RVA: 0x00091A5E File Offset: 0x0008FC5E
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x060065B2 RID: 26034 RVA: 0x00091A73 File Offset: 0x0008FC73
		// (set) Token: 0x060065B3 RID: 26035 RVA: 0x00091A87 File Offset: 0x0008FC87
		public unsafe FRotator Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x00091A9C File Offset: 0x0008FC9C
		// (set) Token: 0x060065B5 RID: 26037 RVA: 0x00091ADF File Offset: 0x0008FCDF
		public TArray<FSplinePoint> SplineData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSplinePoint> result;
				if ((result = this._SplineData) == null)
				{
					result = (this._SplineData = new TArray<FSplinePoint>(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_SplineData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SplineData.CopyAssign(value);
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x00091AED File Offset: 0x0008FCED
		// (set) Token: 0x060065B7 RID: 26039 RVA: 0x00091AFD File Offset: 0x0008FCFD
		public unsafe int RoadwayId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_RoadwayId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_RoadwayId) = value;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x060065B8 RID: 26040 RVA: 0x00091B0E File Offset: 0x0008FD0E
		// (set) Token: 0x060065B9 RID: 26041 RVA: 0x00091B1E File Offset: 0x0008FD1E
		public unsafe int RoadwayWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_RoadwayWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_RoadwayWidth) = value;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x060065BA RID: 26042 RVA: 0x00091B2F File Offset: 0x0008FD2F
		// (set) Token: 0x060065BB RID: 26043 RVA: 0x00091B3F File Offset: 0x0008FD3F
		public unsafe bool bAffectTerrain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_bAffectTerrain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_bAffectTerrain) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x00091B50 File Offset: 0x0008FD50
		// (set) Token: 0x060065BD RID: 26045 RVA: 0x00091B60 File Offset: 0x0008FD60
		public unsafe int OpposingRoadId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_OpposingRoadId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_OpposingRoadId) = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x060065BE RID: 26046 RVA: 0x00091B71 File Offset: 0x0008FD71
		// (set) Token: 0x060065BF RID: 26047 RVA: 0x00091B81 File Offset: 0x0008FD81
		public unsafe int LastRoadId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_LastRoadId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_LastRoadId) = value;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x060065C0 RID: 26048 RVA: 0x00091B92 File Offset: 0x0008FD92
		// (set) Token: 0x060065C1 RID: 26049 RVA: 0x00091BA2 File Offset: 0x0008FDA2
		public unsafe int NextRoadId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_NextRoadId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_NextRoadId) = value;
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x060065C2 RID: 26050 RVA: 0x00091BB3 File Offset: 0x0008FDB3
		// (set) Token: 0x060065C3 RID: 26051 RVA: 0x00091BC3 File Offset: 0x0008FDC3
		public unsafe int PavedRoadConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_PavedRoadConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_PavedRoadConfig) = value;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x060065C4 RID: 26052 RVA: 0x00091BD4 File Offset: 0x0008FDD4
		// (set) Token: 0x060065C5 RID: 26053 RVA: 0x00091C17 File Offset: 0x0008FE17
		public TArray<FVector> IntersectCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._IntersectCells) == null)
				{
					result = (this._IntersectCells = new TArray<FVector>(base.NativePtr + (IntPtr)FRoadwayCreateParam.__PropertyOffset_IntersectCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IntersectCells.CopyAssign(value);
			}
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00091C25 File Offset: 0x0008FE25
		public FRoadwayCreateParam()
		{
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00091C2D File Offset: 0x0008FE2D
		protected override IntPtr GetUStructPtr()
		{
			return FRoadwayCreateParam.StaticStruct();
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00091C39 File Offset: 0x0008FE39
		[NullableContext(2)]
		public FRoadwayCreateParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x00091C43 File Offset: 0x0008FE43
		public FRoadwayCreateParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x00091C4E File Offset: 0x0008FE4E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRoadwayCreateParam(Pointer, false, true);
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x00091C58 File Offset: 0x0008FE58
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRoadwayCreateParam(Pointer, MemoryOwner);
		}

		// Token: 0x04002AC5 RID: 10949
		public const string __ObjectPath = "/Script/KuroGameplay.RoadwayCreateParam";

		// Token: 0x04002AC6 RID: 10950
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AC7 RID: 10951
		internal static int __PropertyOffset_Position;

		// Token: 0x04002AC8 RID: 10952
		internal static int __PropertyOffset_Rotator;

		// Token: 0x04002AC9 RID: 10953
		internal static int __PropertyOffset_SplineData;

		// Token: 0x04002ACA RID: 10954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSplinePoint> _SplineData;

		// Token: 0x04002ACB RID: 10955
		internal static int __PropertyOffset_RoadwayId;

		// Token: 0x04002ACC RID: 10956
		internal static int __PropertyOffset_RoadwayWidth;

		// Token: 0x04002ACD RID: 10957
		internal static int __PropertyOffset_bAffectTerrain;

		// Token: 0x04002ACE RID: 10958
		internal static int __PropertyOffset_OpposingRoadId;

		// Token: 0x04002ACF RID: 10959
		internal static int __PropertyOffset_LastRoadId;

		// Token: 0x04002AD0 RID: 10960
		internal static int __PropertyOffset_NextRoadId;

		// Token: 0x04002AD1 RID: 10961
		internal static int __PropertyOffset_PavedRoadConfig;

		// Token: 0x04002AD2 RID: 10962
		internal static int __PropertyOffset_IntersectCells;

		// Token: 0x04002AD3 RID: 10963
		[Nullable(2)]
		private TArray<FVector> _IntersectCells;
	}
}
