using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DE RID: 734
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_CurveFace")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 456)]
	public class FAnimNode_CurveFace : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002964 RID: 10596 RVA: 0x0003E95F File Offset: 0x0003CB5F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CurveFace._ScriptStructPtr != 0) ? FAnimNode_CurveFace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_CurveFace", ref FAnimNode_CurveFace._ScriptStructPtr);
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x0003E984 File Offset: 0x0003CB84
		// (set) Token: 0x06002966 RID: 10598 RVA: 0x0003E9C7 File Offset: 0x0003CBC7
		public FPoseLink SourcePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._SourcePose) == null)
				{
					result = (this._SourcePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_SourcePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_SourcePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x0003E9E8 File Offset: 0x0003CBE8
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x0003E9F8 File Offset: 0x0003CBF8
		public unsafe bool UseA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_UseA) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_UseA) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x0003EA09 File Offset: 0x0003CC09
		// (set) Token: 0x0600296A RID: 10602 RVA: 0x0003EA19 File Offset: 0x0003CC19
		public unsafe float BlendTimeA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_BlendTimeA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_BlendTimeA) = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x0003EA2A File Offset: 0x0003CC2A
		// (set) Token: 0x0600296C RID: 10604 RVA: 0x0003EA3A File Offset: 0x0003CC3A
		public unsafe float BlendTimeB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_BlendTimeB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_BlendTimeB) = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x0003EA4B File Offset: 0x0003CC4B
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x0003EA5B File Offset: 0x0003CC5B
		public unsafe bool EnableAutoBlink
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_EnableAutoBlink) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_EnableAutoBlink) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x0003EA6C File Offset: 0x0003CC6C
		// (set) Token: 0x06002970 RID: 10608 RVA: 0x0003EA7C File Offset: 0x0003CC7C
		public unsafe float DefaultBlinkTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultBlinkTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultBlinkTime) = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x0003EA8D File Offset: 0x0003CC8D
		// (set) Token: 0x06002972 RID: 10610 RVA: 0x0003EA9D File Offset: 0x0003CC9D
		public unsafe float DefaultBlinkNoiseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultBlinkNoiseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultBlinkNoiseTime) = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x0003EAAE File Offset: 0x0003CCAE
		// (set) Token: 0x06002974 RID: 10612 RVA: 0x0003EAC2 File Offset: 0x0003CCC2
		public unsafe FName AutoBlinkCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_AutoBlinkCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_AutoBlinkCurveName) = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x0003EAD8 File Offset: 0x0003CCD8
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x0003EB1B File Offset: 0x0003CD1B
		public FRuntimeFloatCurve AutoBlinkCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._AutoBlinkCurve) == null)
				{
					result = (this._AutoBlinkCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_AutoBlinkCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_AutoBlinkCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x0003EB3C File Offset: 0x0003CD3C
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x0003EB4C File Offset: 0x0003CD4C
		public unsafe bool EnableAutoPupil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_EnableAutoPupil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_EnableAutoPupil) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x0003EB5D File Offset: 0x0003CD5D
		// (set) Token: 0x0600297A RID: 10618 RVA: 0x0003EB6D File Offset: 0x0003CD6D
		public unsafe float DefaultPupilTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultPupilTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultPupilTime) = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x0003EB7E File Offset: 0x0003CD7E
		// (set) Token: 0x0600297C RID: 10620 RVA: 0x0003EB8E File Offset: 0x0003CD8E
		public unsafe float DefaultPupilNoiseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultPupilNoiseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultPupilNoiseTime) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x0003EB9F File Offset: 0x0003CD9F
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x0003EBAF File Offset: 0x0003CDAF
		public unsafe float DefaultAutoPupilDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultAutoPupilDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_DefaultAutoPupilDis) = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x0003EBC0 File Offset: 0x0003CDC0
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x0003EC03 File Offset: 0x0003CE03
		public TArray<FName> PupilArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PupilArray) == null)
				{
					result = (this._PupilArray = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_PupilArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PupilArray.CopyAssign(value);
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x0003EC11 File Offset: 0x0003CE11
		// (set) Token: 0x06002982 RID: 10626 RVA: 0x0003EC21 File Offset: 0x0003CE21
		public unsafe float Temp_BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_BlendTime) = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x0003EC32 File Offset: 0x0003CE32
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x0003EC42 File Offset: 0x0003CE42
		public unsafe float Temp_BlendAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_BlendAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_BlendAlpha) = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x0003EC53 File Offset: 0x0003CE53
		// (set) Token: 0x06002986 RID: 10630 RVA: 0x0003EC63 File Offset: 0x0003CE63
		public unsafe float Temp_AutoBlinkTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_AutoBlinkTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_AutoBlinkTime) = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x0003EC74 File Offset: 0x0003CE74
		// (set) Token: 0x06002988 RID: 10632 RVA: 0x0003EC84 File Offset: 0x0003CE84
		public unsafe float Temp_AutoPupilTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_AutoPupilTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_Temp_AutoPupilTime) = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x0003EC98 File Offset: 0x0003CE98
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x0003ECDB File Offset: 0x0003CEDB
		public TMap<FName, float> AutoPupilMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._AutoPupilMap) == null)
				{
					result = (this._AutoPupilMap = new TMap<FName, float>(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_AutoPupilMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AutoPupilMap.CopyAssign(value);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x0003ECEC File Offset: 0x0003CEEC
		// (set) Token: 0x0600298C RID: 10636 RVA: 0x0003ED2F File Offset: 0x0003CF2F
		public TMap<FName, float> NamedCurveValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._NamedCurveValues) == null)
				{
					result = (this._NamedCurveValues = new TMap<FName, float>(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_NamedCurveValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NamedCurveValues.CopyAssign(value);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x0003ED40 File Offset: 0x0003CF40
		// (set) Token: 0x0600298E RID: 10638 RVA: 0x0003ED83 File Offset: 0x0003CF83
		public TArray<FNamedCurveValue> NamedCurveValuesA
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedCurveValue> result;
				if ((result = this._NamedCurveValuesA) == null)
				{
					result = (this._NamedCurveValuesA = new TArray<FNamedCurveValue>(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_NamedCurveValuesA, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NamedCurveValuesA.CopyAssign(value);
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x0003ED94 File Offset: 0x0003CF94
		// (set) Token: 0x06002990 RID: 10640 RVA: 0x0003EDD7 File Offset: 0x0003CFD7
		public TArray<FNamedCurveValue> NamedCurveValuesB
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedCurveValue> result;
				if ((result = this._NamedCurveValuesB) == null)
				{
					result = (this._NamedCurveValuesB = new TArray<FNamedCurveValue>(base.NativePtr + (IntPtr)FAnimNode_CurveFace.__PropertyOffset_NamedCurveValuesB, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NamedCurveValuesB.CopyAssign(value);
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0003EDE5 File Offset: 0x0003CFE5
		public FAnimNode_CurveFace()
		{
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x0003EDF0 File Offset: 0x0003CFF0
		public FAnimNode_CurveFace(FPoseLink SourcePose, bool UseA, float BlendTimeA, float BlendTimeB, bool EnableAutoBlink, float DefaultBlinkTime, float DefaultBlinkNoiseTime, FName AutoBlinkCurveName, FRuntimeFloatCurve AutoBlinkCurve, bool EnableAutoPupil, float DefaultPupilTime, float DefaultPupilNoiseTime, float DefaultAutoPupilDis, TArray<FName> PupilArray, float Temp_BlendTime, float Temp_BlendAlpha, float Temp_AutoBlinkTime, float Temp_AutoPupilTime, TMap<FName, float> AutoPupilMap, TMap<FName, float> NamedCurveValues, TArray<FNamedCurveValue> NamedCurveValuesA, TArray<FNamedCurveValue> NamedCurveValuesB)
		{
			this.SourcePose = SourcePose;
			this.UseA = UseA;
			this.BlendTimeA = BlendTimeA;
			this.BlendTimeB = BlendTimeB;
			this.EnableAutoBlink = EnableAutoBlink;
			this.DefaultBlinkTime = DefaultBlinkTime;
			this.DefaultBlinkNoiseTime = DefaultBlinkNoiseTime;
			this.AutoBlinkCurveName = AutoBlinkCurveName;
			this.AutoBlinkCurve = AutoBlinkCurve;
			this.EnableAutoPupil = EnableAutoPupil;
			this.DefaultPupilTime = DefaultPupilTime;
			this.DefaultPupilNoiseTime = DefaultPupilNoiseTime;
			this.DefaultAutoPupilDis = DefaultAutoPupilDis;
			this.PupilArray = PupilArray;
			this.Temp_BlendTime = Temp_BlendTime;
			this.Temp_BlendAlpha = Temp_BlendAlpha;
			this.Temp_AutoBlinkTime = Temp_AutoBlinkTime;
			this.Temp_AutoPupilTime = Temp_AutoPupilTime;
			this.AutoPupilMap = AutoPupilMap;
			this.NamedCurveValues = NamedCurveValues;
			this.NamedCurveValuesA = NamedCurveValuesA;
			this.NamedCurveValuesB = NamedCurveValuesB;
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CurveFace.StaticStruct();
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x0003EEBC File Offset: 0x0003D0BC
		[NullableContext(2)]
		public FAnimNode_CurveFace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x0003EEC6 File Offset: 0x0003D0C6
		public FAnimNode_CurveFace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x0003EED1 File Offset: 0x0003D0D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CurveFace(Pointer, false, true);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x0003EEDB File Offset: 0x0003D0DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CurveFace(Pointer, MemoryOwner);
		}

		// Token: 0x0400109B RID: 4251
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_CurveFace";

		// Token: 0x0400109C RID: 4252
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400109D RID: 4253
		internal static int __PropertyOffset_SourcePose;

		// Token: 0x0400109E RID: 4254
		[Nullable(2)]
		private FPoseLink _SourcePose;

		// Token: 0x0400109F RID: 4255
		internal static int __PropertyOffset_UseA;

		// Token: 0x040010A0 RID: 4256
		internal static int __PropertyOffset_BlendTimeA;

		// Token: 0x040010A1 RID: 4257
		internal static int __PropertyOffset_BlendTimeB;

		// Token: 0x040010A2 RID: 4258
		internal static int __PropertyOffset_EnableAutoBlink;

		// Token: 0x040010A3 RID: 4259
		internal static int __PropertyOffset_DefaultBlinkTime;

		// Token: 0x040010A4 RID: 4260
		internal static int __PropertyOffset_DefaultBlinkNoiseTime;

		// Token: 0x040010A5 RID: 4261
		internal static int __PropertyOffset_AutoBlinkCurveName;

		// Token: 0x040010A6 RID: 4262
		internal static int __PropertyOffset_AutoBlinkCurve;

		// Token: 0x040010A7 RID: 4263
		[Nullable(2)]
		private FRuntimeFloatCurve _AutoBlinkCurve;

		// Token: 0x040010A8 RID: 4264
		internal static int __PropertyOffset_EnableAutoPupil;

		// Token: 0x040010A9 RID: 4265
		internal static int __PropertyOffset_DefaultPupilTime;

		// Token: 0x040010AA RID: 4266
		internal static int __PropertyOffset_DefaultPupilNoiseTime;

		// Token: 0x040010AB RID: 4267
		internal static int __PropertyOffset_DefaultAutoPupilDis;

		// Token: 0x040010AC RID: 4268
		internal static int __PropertyOffset_PupilArray;

		// Token: 0x040010AD RID: 4269
		[Nullable(2)]
		private TArray<FName> _PupilArray;

		// Token: 0x040010AE RID: 4270
		internal static int __PropertyOffset_Temp_BlendTime;

		// Token: 0x040010AF RID: 4271
		internal static int __PropertyOffset_Temp_BlendAlpha;

		// Token: 0x040010B0 RID: 4272
		internal static int __PropertyOffset_Temp_AutoBlinkTime;

		// Token: 0x040010B1 RID: 4273
		internal static int __PropertyOffset_Temp_AutoPupilTime;

		// Token: 0x040010B2 RID: 4274
		internal static int __PropertyOffset_AutoPupilMap;

		// Token: 0x040010B3 RID: 4275
		[Nullable(2)]
		private TMap<FName, float> _AutoPupilMap;

		// Token: 0x040010B4 RID: 4276
		internal static int __PropertyOffset_NamedCurveValues;

		// Token: 0x040010B5 RID: 4277
		[Nullable(2)]
		private TMap<FName, float> _NamedCurveValues;

		// Token: 0x040010B6 RID: 4278
		internal static int __PropertyOffset_NamedCurveValuesA;

		// Token: 0x040010B7 RID: 4279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedCurveValue> _NamedCurveValuesA;

		// Token: 0x040010B8 RID: 4280
		internal static int __PropertyOffset_NamedCurveValuesB;

		// Token: 0x040010B9 RID: 4281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedCurveValue> _NamedCurveValuesB;
	}
}
