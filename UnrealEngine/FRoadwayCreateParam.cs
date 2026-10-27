using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001933 RID: 6451
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.RoadwayCreateParam")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRoadwayCreateParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017EA4 RID: 97956 RVA: 0x00230C18 File Offset: 0x0022EE18
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRoadwayCreateParam._ScriptStructPtr != 0) ? FRoadwayCreateParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.RoadwayCreateParam", ref FRoadwayCreateParam._ScriptStructPtr);
		}

		// Token: 0x17005FF2 RID: 24562
		// (get) Token: 0x06017EA5 RID: 97957 RVA: 0x00230C3C File Offset: 0x0022EE3C
		// (set) Token: 0x06017EA6 RID: 97958 RVA: 0x00230C50 File Offset: 0x0022EE50
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

		// Token: 0x17005FF3 RID: 24563
		// (get) Token: 0x06017EA7 RID: 97959 RVA: 0x00230C65 File Offset: 0x0022EE65
		// (set) Token: 0x06017EA8 RID: 97960 RVA: 0x00230C79 File Offset: 0x0022EE79
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

		// Token: 0x17005FF4 RID: 24564
		// (get) Token: 0x06017EA9 RID: 97961 RVA: 0x00230C90 File Offset: 0x0022EE90
		// (set) Token: 0x06017EAA RID: 97962 RVA: 0x00230CD3 File Offset: 0x0022EED3
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

		// Token: 0x17005FF5 RID: 24565
		// (get) Token: 0x06017EAB RID: 97963 RVA: 0x00230CE1 File Offset: 0x0022EEE1
		// (set) Token: 0x06017EAC RID: 97964 RVA: 0x00230CF1 File Offset: 0x0022EEF1
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

		// Token: 0x17005FF6 RID: 24566
		// (get) Token: 0x06017EAD RID: 97965 RVA: 0x00230D02 File Offset: 0x0022EF02
		// (set) Token: 0x06017EAE RID: 97966 RVA: 0x00230D12 File Offset: 0x0022EF12
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

		// Token: 0x17005FF7 RID: 24567
		// (get) Token: 0x06017EAF RID: 97967 RVA: 0x00230D23 File Offset: 0x0022EF23
		// (set) Token: 0x06017EB0 RID: 97968 RVA: 0x00230D33 File Offset: 0x0022EF33
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

		// Token: 0x17005FF8 RID: 24568
		// (get) Token: 0x06017EB1 RID: 97969 RVA: 0x00230D44 File Offset: 0x0022EF44
		// (set) Token: 0x06017EB2 RID: 97970 RVA: 0x00230D54 File Offset: 0x0022EF54
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

		// Token: 0x17005FF9 RID: 24569
		// (get) Token: 0x06017EB3 RID: 97971 RVA: 0x00230D65 File Offset: 0x0022EF65
		// (set) Token: 0x06017EB4 RID: 97972 RVA: 0x00230D75 File Offset: 0x0022EF75
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

		// Token: 0x17005FFA RID: 24570
		// (get) Token: 0x06017EB5 RID: 97973 RVA: 0x00230D86 File Offset: 0x0022EF86
		// (set) Token: 0x06017EB6 RID: 97974 RVA: 0x00230D96 File Offset: 0x0022EF96
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

		// Token: 0x17005FFB RID: 24571
		// (get) Token: 0x06017EB7 RID: 97975 RVA: 0x00230DA7 File Offset: 0x0022EFA7
		// (set) Token: 0x06017EB8 RID: 97976 RVA: 0x00230DB7 File Offset: 0x0022EFB7
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

		// Token: 0x17005FFC RID: 24572
		// (get) Token: 0x06017EB9 RID: 97977 RVA: 0x00230DC8 File Offset: 0x0022EFC8
		// (set) Token: 0x06017EBA RID: 97978 RVA: 0x00230E0B File Offset: 0x0022F00B
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

		// Token: 0x06017EBB RID: 97979 RVA: 0x00230E19 File Offset: 0x0022F019
		public FRoadwayCreateParam()
		{
		}

		// Token: 0x06017EBC RID: 97980 RVA: 0x00230E24 File Offset: 0x0022F024
		public FRoadwayCreateParam(FVector Position, FRotator Rotator, TArray<FSplinePoint> SplineData, int RoadwayId, int RoadwayWidth, bool bAffectTerrain, int OpposingRoadId, int LastRoadId, int NextRoadId, int PavedRoadConfig, TArray<FVector> IntersectCells)
		{
			this.Position = Position;
			this.Rotator = Rotator;
			this.SplineData = SplineData;
			this.RoadwayId = RoadwayId;
			this.RoadwayWidth = RoadwayWidth;
			this.bAffectTerrain = bAffectTerrain;
			this.OpposingRoadId = OpposingRoadId;
			this.LastRoadId = LastRoadId;
			this.NextRoadId = NextRoadId;
			this.PavedRoadConfig = PavedRoadConfig;
			this.IntersectCells = IntersectCells;
		}

		// Token: 0x06017EBD RID: 97981 RVA: 0x00230E8C File Offset: 0x0022F08C
		protected override IntPtr GetUStructPtr()
		{
			return FRoadwayCreateParam.StaticStruct();
		}

		// Token: 0x06017EBE RID: 97982 RVA: 0x00230E98 File Offset: 0x0022F098
		[NullableContext(2)]
		public FRoadwayCreateParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017EBF RID: 97983 RVA: 0x00230EA2 File Offset: 0x0022F0A2
		public FRoadwayCreateParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017EC0 RID: 97984 RVA: 0x00230EAD File Offset: 0x0022F0AD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRoadwayCreateParam(Pointer, false, true);
		}

		// Token: 0x06017EC1 RID: 97985 RVA: 0x00230EB7 File Offset: 0x0022F0B7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRoadwayCreateParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF2B RID: 53035
		public const string __ObjectPath = "/Script/KuroGameplay.RoadwayCreateParam";

		// Token: 0x0400CF2C RID: 53036
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF2D RID: 53037
		internal static int __PropertyOffset_Position;

		// Token: 0x0400CF2E RID: 53038
		internal static int __PropertyOffset_Rotator;

		// Token: 0x0400CF2F RID: 53039
		internal static int __PropertyOffset_SplineData;

		// Token: 0x0400CF30 RID: 53040
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSplinePoint> _SplineData;

		// Token: 0x0400CF31 RID: 53041
		internal static int __PropertyOffset_RoadwayId;

		// Token: 0x0400CF32 RID: 53042
		internal static int __PropertyOffset_RoadwayWidth;

		// Token: 0x0400CF33 RID: 53043
		internal static int __PropertyOffset_bAffectTerrain;

		// Token: 0x0400CF34 RID: 53044
		internal static int __PropertyOffset_OpposingRoadId;

		// Token: 0x0400CF35 RID: 53045
		internal static int __PropertyOffset_LastRoadId;

		// Token: 0x0400CF36 RID: 53046
		internal static int __PropertyOffset_NextRoadId;

		// Token: 0x0400CF37 RID: 53047
		internal static int __PropertyOffset_PavedRoadConfig;

		// Token: 0x0400CF38 RID: 53048
		internal static int __PropertyOffset_IntersectCells;

		// Token: 0x0400CF39 RID: 53049
		[Nullable(2)]
		private TArray<FVector> _IntersectCells;
	}
}
