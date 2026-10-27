using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F8F RID: 8079
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeSplineSegment")]
	[UnrealStructLayout(752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class ULandscapeSplineSegment : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EAE5 RID: 125669 RVA: 0x002D9B9A File Offset: 0x002D7D9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeSplineSegment._ClassPtr;
		}

		// Token: 0x0601EAE6 RID: 125670 RVA: 0x002D9BA8 File Offset: 0x002D7DA8
		public ULandscapeSplineSegment() : this(BuiltinUtils.AllocNativeUObject(ULandscapeSplineSegment.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EAE7 RID: 125671 RVA: 0x002D9BD0 File Offset: 0x002D7DD0
		public ULandscapeSplineSegment(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeSplineSegment.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A38 RID: 31288
		// (get) Token: 0x0601EAE8 RID: 125672 RVA: 0x002D9C04 File Offset: 0x002D7E04
		// (set) Token: 0x0601EAE9 RID: 125673 RVA: 0x002D9C3E File Offset: 0x002D7E3E
		public TFixedArray<FLandscapeSplineSegmentConnection> Connections
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FLandscapeSplineSegmentConnection> result;
				if ((result = this._Connections) == null)
				{
					result = (this._Connections = new TFixedArray<FLandscapeSplineSegmentConnection>(base.NativePtr + (IntPtr)ULandscapeSplineSegment.__PropertyOffset_Connections, 2, this));
				}
				return result;
			}
			set
			{
				this.Connections.CopyAssign(value);
			}
		}

		// Token: 0x17007A39 RID: 31289
		// (get) Token: 0x0601EAEA RID: 125674 RVA: 0x002D9C4C File Offset: 0x002D7E4C
		// (set) Token: 0x0601EAEB RID: 125675 RVA: 0x002D9C85 File Offset: 0x002D7E85
		public FInterpCurveVector SplineInfo
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._SplineInfo) == null)
				{
					result = (this._SplineInfo = new FInterpCurveVector(base.NativePtr + (IntPtr)ULandscapeSplineSegment.__PropertyOffset_SplineInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)ULandscapeSplineSegment.__PropertyOffset_SplineInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A3A RID: 31290
		// (get) Token: 0x0601EAEC RID: 125676 RVA: 0x002D9CA8 File Offset: 0x002D7EA8
		// (set) Token: 0x0601EAED RID: 125677 RVA: 0x002D9CE1 File Offset: 0x002D7EE1
		public TArray<FLandscapeSplineInterpPoint> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeSplineInterpPoint> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FLandscapeSplineInterpPoint>(base.NativePtr + (IntPtr)ULandscapeSplineSegment.__PropertyOffset_Points, this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17007A3B RID: 31291
		// (get) Token: 0x0601EAEE RID: 125678 RVA: 0x002D9CEF File Offset: 0x002D7EEF
		// (set) Token: 0x0601EAEF RID: 125679 RVA: 0x002D9D03 File Offset: 0x002D7F03
		public unsafe FBox Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineSegment.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineSegment.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x17007A3C RID: 31292
		// (get) Token: 0x0601EAF0 RID: 125680 RVA: 0x002D9D18 File Offset: 0x002D7F18
		// (set) Token: 0x0601EAF1 RID: 125681 RVA: 0x002D9D51 File Offset: 0x002D7F51
		public TArray<USplineMeshComponent> LocalMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USplineMeshComponent> result;
				if ((result = this._LocalMeshComponents) == null)
				{
					result = (this._LocalMeshComponents = new TArray<USplineMeshComponent>(base.NativePtr + (IntPtr)ULandscapeSplineSegment.__PropertyOffset_LocalMeshComponents, this));
				}
				return result;
			}
			set
			{
				this.LocalMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601EAF2 RID: 125682 RVA: 0x002D9D5F File Offset: 0x002D7F5F
		static ULandscapeSplineSegment()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeSplineSegment");
		}

		// Token: 0x0601EAF3 RID: 125683 RVA: 0x002D9D6D File Offset: 0x002D7F6D
		protected ULandscapeSplineSegment(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010962 RID: 67938
		public new const string __ObjectPath = "/Script/Landscape.LandscapeSplineSegment";

		// Token: 0x04010963 RID: 67939
		private static IntPtr _ClassPtr;

		// Token: 0x04010964 RID: 67940
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010965 RID: 67941
		internal static int __PropertyOffset_Connections;

		// Token: 0x04010966 RID: 67942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FLandscapeSplineSegmentConnection> _Connections;

		// Token: 0x04010967 RID: 67943
		internal static int __PropertyOffset_SplineInfo;

		// Token: 0x04010968 RID: 67944
		[Nullable(2)]
		private FInterpCurveVector _SplineInfo;

		// Token: 0x04010969 RID: 67945
		internal static int __PropertyOffset_Points;

		// Token: 0x0401096A RID: 67946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeSplineInterpPoint> _Points;

		// Token: 0x0401096B RID: 67947
		internal static int __PropertyOffset_Bounds;

		// Token: 0x0401096C RID: 67948
		internal static int __PropertyOffset_LocalMeshComponents;

		// Token: 0x0401096D RID: 67949
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineMeshComponent> _LocalMeshComponents;
	}
}
