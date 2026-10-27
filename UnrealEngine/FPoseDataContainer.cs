using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200101E RID: 4126
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PoseDataContainer")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FPoseDataContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E1C0 RID: 57792 RVA: 0x0014BC34 File Offset: 0x00149E34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPoseDataContainer._ScriptStructPtr != 0) ? FPoseDataContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PoseDataContainer", ref FPoseDataContainer._ScriptStructPtr);
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600E1C1 RID: 57793 RVA: 0x0014BC58 File Offset: 0x00149E58
		// (set) Token: 0x0600E1C2 RID: 57794 RVA: 0x0014BC9B File Offset: 0x00149E9B
		public TArray<FSmartName> PoseNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSmartName> result;
				if ((result = this._PoseNames) == null)
				{
					result = (this._PoseNames = new TArray<FSmartName>(base.NativePtr + (IntPtr)FPoseDataContainer.__PropertyOffset_PoseNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PoseNames.CopyAssign(value);
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600E1C3 RID: 57795 RVA: 0x0014BCAC File Offset: 0x00149EAC
		// (set) Token: 0x0600E1C4 RID: 57796 RVA: 0x0014BCEF File Offset: 0x00149EEF
		public TArray<FName> Tracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tracks) == null)
				{
					result = (this._Tracks = new TArray<FName>(base.NativePtr + (IntPtr)FPoseDataContainer.__PropertyOffset_Tracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tracks.CopyAssign(value);
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600E1C5 RID: 57797 RVA: 0x0014BD00 File Offset: 0x00149F00
		// (set) Token: 0x0600E1C6 RID: 57798 RVA: 0x0014BD43 File Offset: 0x00149F43
		public TMap<FName, int> TrackMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._TrackMap) == null)
				{
					result = (this._TrackMap = new TMap<FName, int>(base.NativePtr + (IntPtr)FPoseDataContainer.__PropertyOffset_TrackMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackMap.CopyAssign(value);
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600E1C7 RID: 57799 RVA: 0x0014BD54 File Offset: 0x00149F54
		// (set) Token: 0x0600E1C8 RID: 57800 RVA: 0x0014BD97 File Offset: 0x00149F97
		public TArray<FPoseData> Poses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPoseData> result;
				if ((result = this._Poses) == null)
				{
					result = (this._Poses = new TArray<FPoseData>(base.NativePtr + (IntPtr)FPoseDataContainer.__PropertyOffset_Poses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Poses.CopyAssign(value);
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600E1C9 RID: 57801 RVA: 0x0014BDA8 File Offset: 0x00149FA8
		// (set) Token: 0x0600E1CA RID: 57802 RVA: 0x0014BDEB File Offset: 0x00149FEB
		public TArray<FAnimCurveBase> Curves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimCurveBase> result;
				if ((result = this._Curves) == null)
				{
					result = (this._Curves = new TArray<FAnimCurveBase>(base.NativePtr + (IntPtr)FPoseDataContainer.__PropertyOffset_Curves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Curves.CopyAssign(value);
			}
		}

		// Token: 0x0600E1CB RID: 57803 RVA: 0x0014BDF9 File Offset: 0x00149FF9
		public FPoseDataContainer()
		{
		}

		// Token: 0x0600E1CC RID: 57804 RVA: 0x0014BE01 File Offset: 0x0014A001
		public FPoseDataContainer(TArray<FSmartName> PoseNames, TArray<FName> Tracks, TMap<FName, int> TrackMap, TArray<FPoseData> Poses, TArray<FAnimCurveBase> Curves)
		{
			this.PoseNames = PoseNames;
			this.Tracks = Tracks;
			this.TrackMap = TrackMap;
			this.Poses = Poses;
			this.Curves = Curves;
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x0014BE2E File Offset: 0x0014A02E
		protected override IntPtr GetUStructPtr()
		{
			return FPoseDataContainer.StaticStruct();
		}

		// Token: 0x0600E1CE RID: 57806 RVA: 0x0014BE3A File Offset: 0x0014A03A
		[NullableContext(2)]
		public FPoseDataContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E1CF RID: 57807 RVA: 0x0014BE44 File Offset: 0x0014A044
		public FPoseDataContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E1D0 RID: 57808 RVA: 0x0014BE4F File Offset: 0x0014A04F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPoseDataContainer(Pointer, false, true);
		}

		// Token: 0x0600E1D1 RID: 57809 RVA: 0x0014BE59 File Offset: 0x0014A059
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPoseDataContainer(Pointer, MemoryOwner);
		}

		// Token: 0x0400792D RID: 31021
		public const string __ObjectPath = "/Script/Engine.PoseDataContainer";

		// Token: 0x0400792E RID: 31022
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400792F RID: 31023
		internal static int __PropertyOffset_PoseNames;

		// Token: 0x04007930 RID: 31024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSmartName> _PoseNames;

		// Token: 0x04007931 RID: 31025
		internal static int __PropertyOffset_Tracks;

		// Token: 0x04007932 RID: 31026
		[Nullable(2)]
		private TArray<FName> _Tracks;

		// Token: 0x04007933 RID: 31027
		internal static int __PropertyOffset_TrackMap;

		// Token: 0x04007934 RID: 31028
		[Nullable(2)]
		private TMap<FName, int> _TrackMap;

		// Token: 0x04007935 RID: 31029
		internal static int __PropertyOffset_Poses;

		// Token: 0x04007936 RID: 31030
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPoseData> _Poses;

		// Token: 0x04007937 RID: 31031
		internal static int __PropertyOffset_Curves;

		// Token: 0x04007938 RID: 31032
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimCurveBase> _Curves;
	}
}
