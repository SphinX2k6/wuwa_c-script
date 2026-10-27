using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B01 RID: 6913
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingSettings")]
	[UnrealStructLayout(136, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FKuroFlockingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019D81 RID: 105857 RVA: 0x00262966 File Offset: 0x00260B66
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFlockingSettings._ScriptStructPtr != 0) ? FKuroFlockingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingSettings", ref FKuroFlockingSettings._ScriptStructPtr);
		}

		// Token: 0x17006779 RID: 26489
		// (get) Token: 0x06019D82 RID: 105858 RVA: 0x0026298A File Offset: 0x00260B8A
		// (set) Token: 0x06019D83 RID: 105859 RVA: 0x0026299A File Offset: 0x00260B9A
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x1700677A RID: 26490
		// (get) Token: 0x06019D84 RID: 105860 RVA: 0x002629AB File Offset: 0x00260BAB
		// (set) Token: 0x06019D85 RID: 105861 RVA: 0x002629BB File Offset: 0x00260BBB
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x1700677B RID: 26491
		// (get) Token: 0x06019D86 RID: 105862 RVA: 0x002629CC File Offset: 0x00260BCC
		// (set) Token: 0x06019D87 RID: 105863 RVA: 0x002629DC File Offset: 0x00260BDC
		public unsafe float PerceptionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_PerceptionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_PerceptionRadius) = value;
			}
		}

		// Token: 0x1700677C RID: 26492
		// (get) Token: 0x06019D88 RID: 105864 RVA: 0x002629ED File Offset: 0x00260BED
		// (set) Token: 0x06019D89 RID: 105865 RVA: 0x002629FD File Offset: 0x00260BFD
		public unsafe float AvoidanceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_AvoidanceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_AvoidanceRadius) = value;
			}
		}

		// Token: 0x1700677D RID: 26493
		// (get) Token: 0x06019D8A RID: 105866 RVA: 0x00262A0E File Offset: 0x00260C0E
		// (set) Token: 0x06019D8B RID: 105867 RVA: 0x00262A1E File Offset: 0x00260C1E
		public unsafe float MaxSteerForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_MaxSteerForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_MaxSteerForce) = value;
			}
		}

		// Token: 0x1700677E RID: 26494
		// (get) Token: 0x06019D8C RID: 105868 RVA: 0x00262A2F File Offset: 0x00260C2F
		// (set) Token: 0x06019D8D RID: 105869 RVA: 0x00262A3F File Offset: 0x00260C3F
		public unsafe float AlignWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_AlignWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_AlignWeight) = value;
			}
		}

		// Token: 0x1700677F RID: 26495
		// (get) Token: 0x06019D8E RID: 105870 RVA: 0x00262A50 File Offset: 0x00260C50
		// (set) Token: 0x06019D8F RID: 105871 RVA: 0x00262A60 File Offset: 0x00260C60
		public unsafe float CohesionWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_CohesionWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_CohesionWeight) = value;
			}
		}

		// Token: 0x17006780 RID: 26496
		// (get) Token: 0x06019D90 RID: 105872 RVA: 0x00262A71 File Offset: 0x00260C71
		// (set) Token: 0x06019D91 RID: 105873 RVA: 0x00262A81 File Offset: 0x00260C81
		public unsafe float SeparateWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_SeparateWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_SeparateWeight) = value;
			}
		}

		// Token: 0x17006781 RID: 26497
		// (get) Token: 0x06019D92 RID: 105874 RVA: 0x00262A92 File Offset: 0x00260C92
		// (set) Token: 0x06019D93 RID: 105875 RVA: 0x00262AA2 File Offset: 0x00260CA2
		public unsafe float TargetWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_TargetWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_TargetWeight) = value;
			}
		}

		// Token: 0x17006782 RID: 26498
		// (get) Token: 0x06019D94 RID: 105876 RVA: 0x00262AB3 File Offset: 0x00260CB3
		// (set) Token: 0x06019D95 RID: 105877 RVA: 0x00262AC3 File Offset: 0x00260CC3
		public unsafe float BoundsRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoundsRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoundsRadius) = value;
			}
		}

		// Token: 0x17006783 RID: 26499
		// (get) Token: 0x06019D96 RID: 105878 RVA: 0x00262AD4 File Offset: 0x00260CD4
		// (set) Token: 0x06019D97 RID: 105879 RVA: 0x00262AE4 File Offset: 0x00260CE4
		public unsafe float AvoidCollisionWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_AvoidCollisionWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_AvoidCollisionWeight) = value;
			}
		}

		// Token: 0x17006784 RID: 26500
		// (get) Token: 0x06019D98 RID: 105880 RVA: 0x00262AF5 File Offset: 0x00260CF5
		// (set) Token: 0x06019D99 RID: 105881 RVA: 0x00262B05 File Offset: 0x00260D05
		public unsafe float CollisionAvoidDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_CollisionAvoidDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_CollisionAvoidDistance) = value;
			}
		}

		// Token: 0x17006785 RID: 26501
		// (get) Token: 0x06019D9A RID: 105882 RVA: 0x00262B16 File Offset: 0x00260D16
		// (set) Token: 0x06019D9B RID: 105883 RVA: 0x00262B26 File Offset: 0x00260D26
		public unsafe float CollisionAvoidSphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_CollisionAvoidSphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_CollisionAvoidSphereRadius) = value;
			}
		}

		// Token: 0x17006786 RID: 26502
		// (get) Token: 0x06019D9C RID: 105884 RVA: 0x00262B37 File Offset: 0x00260D37
		// (set) Token: 0x06019D9D RID: 105885 RVA: 0x00262B4B File Offset: 0x00260D4B
		public unsafe FVector BoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxSize) = value;
			}
		}

		// Token: 0x17006787 RID: 26503
		// (get) Token: 0x06019D9E RID: 105886 RVA: 0x00262B60 File Offset: 0x00260D60
		// (set) Token: 0x06019D9F RID: 105887 RVA: 0x00262B70 File Offset: 0x00260D70
		public unsafe float BoxBoundaryMarginRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxBoundaryMarginRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxBoundaryMarginRatio) = value;
			}
		}

		// Token: 0x17006788 RID: 26504
		// (get) Token: 0x06019DA0 RID: 105888 RVA: 0x00262B81 File Offset: 0x00260D81
		// (set) Token: 0x06019DA1 RID: 105889 RVA: 0x00262B91 File Offset: 0x00260D91
		public unsafe float BoxBoundaryMinMarginWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxBoundaryMinMarginWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxBoundaryMinMarginWorld) = value;
			}
		}

		// Token: 0x17006789 RID: 26505
		// (get) Token: 0x06019DA2 RID: 105890 RVA: 0x00262BA2 File Offset: 0x00260DA2
		// (set) Token: 0x06019DA3 RID: 105891 RVA: 0x00262BB2 File Offset: 0x00260DB2
		public unsafe float BoxBoundaryTangentialStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxBoundaryTangentialStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_BoxBoundaryTangentialStrength) = value;
			}
		}

		// Token: 0x1700678A RID: 26506
		// (get) Token: 0x06019DA4 RID: 105892 RVA: 0x00262BC3 File Offset: 0x00260DC3
		// (set) Token: 0x06019DA5 RID: 105893 RVA: 0x00262BD3 File Offset: 0x00260DD3
		public unsafe int RayNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_RayNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_RayNum) = value;
			}
		}

		// Token: 0x1700678B RID: 26507
		// (get) Token: 0x06019DA6 RID: 105894 RVA: 0x00262BE4 File Offset: 0x00260DE4
		// (set) Token: 0x06019DA7 RID: 105895 RVA: 0x00262BF4 File Offset: 0x00260DF4
		public unsafe float ScatterInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterInterval) = value;
			}
		}

		// Token: 0x1700678C RID: 26508
		// (get) Token: 0x06019DA8 RID: 105896 RVA: 0x00262C05 File Offset: 0x00260E05
		// (set) Token: 0x06019DA9 RID: 105897 RVA: 0x00262C15 File Offset: 0x00260E15
		public unsafe float ScatterDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterDuration) = value;
			}
		}

		// Token: 0x1700678D RID: 26509
		// (get) Token: 0x06019DAA RID: 105898 RVA: 0x00262C26 File Offset: 0x00260E26
		// (set) Token: 0x06019DAB RID: 105899 RVA: 0x00262C36 File Offset: 0x00260E36
		public unsafe float ScatterFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterFraction) = value;
			}
		}

		// Token: 0x1700678E RID: 26510
		// (get) Token: 0x06019DAC RID: 105900 RVA: 0x00262C47 File Offset: 0x00260E47
		// (set) Token: 0x06019DAD RID: 105901 RVA: 0x00262C57 File Offset: 0x00260E57
		public unsafe float ScatterStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterStrength) = value;
			}
		}

		// Token: 0x1700678F RID: 26511
		// (get) Token: 0x06019DAE RID: 105902 RVA: 0x00262C68 File Offset: 0x00260E68
		// (set) Token: 0x06019DAF RID: 105903 RVA: 0x00262C78 File Offset: 0x00260E78
		public unsafe float ScatterYawReachThresholdDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterYawReachThresholdDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterYawReachThresholdDegrees) = value;
			}
		}

		// Token: 0x17006790 RID: 26512
		// (get) Token: 0x06019DB0 RID: 105904 RVA: 0x00262C89 File Offset: 0x00260E89
		// (set) Token: 0x06019DB1 RID: 105905 RVA: 0x00262C99 File Offset: 0x00260E99
		public unsafe float ScatterAlignScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterAlignScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterAlignScale) = value;
			}
		}

		// Token: 0x17006791 RID: 26513
		// (get) Token: 0x06019DB2 RID: 105906 RVA: 0x00262CAA File Offset: 0x00260EAA
		// (set) Token: 0x06019DB3 RID: 105907 RVA: 0x00262CBA File Offset: 0x00260EBA
		public unsafe float ScatterCohesionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterCohesionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterCohesionScale) = value;
			}
		}

		// Token: 0x17006792 RID: 26514
		// (get) Token: 0x06019DB4 RID: 105908 RVA: 0x00262CCB File Offset: 0x00260ECB
		// (set) Token: 0x06019DB5 RID: 105909 RVA: 0x00262CDB File Offset: 0x00260EDB
		public unsafe float ScatterSeparateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterSeparateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_ScatterSeparateScale) = value;
			}
		}

		// Token: 0x17006793 RID: 26515
		// (get) Token: 0x06019DB6 RID: 105910 RVA: 0x00262CEC File Offset: 0x00260EEC
		// (set) Token: 0x06019DB7 RID: 105911 RVA: 0x00262CFC File Offset: 0x00260EFC
		public unsafe float WanderWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderWeight) = value;
			}
		}

		// Token: 0x17006794 RID: 26516
		// (get) Token: 0x06019DB8 RID: 105912 RVA: 0x00262D0D File Offset: 0x00260F0D
		// (set) Token: 0x06019DB9 RID: 105913 RVA: 0x00262D1D File Offset: 0x00260F1D
		public unsafe float WanderYawAmplitudeDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderYawAmplitudeDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderYawAmplitudeDegrees) = value;
			}
		}

		// Token: 0x17006795 RID: 26517
		// (get) Token: 0x06019DBA RID: 105914 RVA: 0x00262D2E File Offset: 0x00260F2E
		// (set) Token: 0x06019DBB RID: 105915 RVA: 0x00262D3E File Offset: 0x00260F3E
		public unsafe float WanderFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderFrequency) = value;
			}
		}

		// Token: 0x17006796 RID: 26518
		// (get) Token: 0x06019DBC RID: 105916 RVA: 0x00262D4F File Offset: 0x00260F4F
		// (set) Token: 0x06019DBD RID: 105917 RVA: 0x00262D5F File Offset: 0x00260F5F
		public unsafe float WanderSecondaryScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderSecondaryScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderSecondaryScale) = value;
			}
		}

		// Token: 0x17006797 RID: 26519
		// (get) Token: 0x06019DBE RID: 105918 RVA: 0x00262D70 File Offset: 0x00260F70
		// (set) Token: 0x06019DBF RID: 105919 RVA: 0x00262D80 File Offset: 0x00260F80
		public unsafe float WanderScatterScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderScatterScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_WanderScatterScale) = value;
			}
		}

		// Token: 0x17006798 RID: 26520
		// (get) Token: 0x06019DC0 RID: 105920 RVA: 0x00262D91 File Offset: 0x00260F91
		// (set) Token: 0x06019DC1 RID: 105921 RVA: 0x00262DA1 File Offset: 0x00260FA1
		public unsafe bool bUseDistanceFieldAvoidance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_bUseDistanceFieldAvoidance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingSettings.__PropertyOffset_bUseDistanceFieldAvoidance) = (value ? 1 : 0);
			}
		}

		// Token: 0x06019DC2 RID: 105922 RVA: 0x00262DB2 File Offset: 0x00260FB2
		public FKuroFlockingSettings()
		{
		}

		// Token: 0x06019DC3 RID: 105923 RVA: 0x00262DBC File Offset: 0x00260FBC
		public FKuroFlockingSettings(float MinSpeed, float MaxSpeed, float PerceptionRadius, float AvoidanceRadius, float MaxSteerForce, float AlignWeight, float CohesionWeight, float SeparateWeight, float TargetWeight, float BoundsRadius, float AvoidCollisionWeight, float CollisionAvoidDistance, float CollisionAvoidSphereRadius, FVector BoxSize, float BoxBoundaryMarginRatio, float BoxBoundaryMinMarginWorld, float BoxBoundaryTangentialStrength, int RayNum, float ScatterInterval, float ScatterDuration, float ScatterFraction, float ScatterStrength, float ScatterYawReachThresholdDegrees, float ScatterAlignScale, float ScatterCohesionScale, float ScatterSeparateScale, float WanderWeight, float WanderYawAmplitudeDegrees, float WanderFrequency, float WanderSecondaryScale, float WanderScatterScale, bool bUseDistanceFieldAvoidance)
		{
			this.MinSpeed = MinSpeed;
			this.MaxSpeed = MaxSpeed;
			this.PerceptionRadius = PerceptionRadius;
			this.AvoidanceRadius = AvoidanceRadius;
			this.MaxSteerForce = MaxSteerForce;
			this.AlignWeight = AlignWeight;
			this.CohesionWeight = CohesionWeight;
			this.SeparateWeight = SeparateWeight;
			this.TargetWeight = TargetWeight;
			this.BoundsRadius = BoundsRadius;
			this.AvoidCollisionWeight = AvoidCollisionWeight;
			this.CollisionAvoidDistance = CollisionAvoidDistance;
			this.CollisionAvoidSphereRadius = CollisionAvoidSphereRadius;
			this.BoxSize = BoxSize;
			this.BoxBoundaryMarginRatio = BoxBoundaryMarginRatio;
			this.BoxBoundaryMinMarginWorld = BoxBoundaryMinMarginWorld;
			this.BoxBoundaryTangentialStrength = BoxBoundaryTangentialStrength;
			this.RayNum = RayNum;
			this.ScatterInterval = ScatterInterval;
			this.ScatterDuration = ScatterDuration;
			this.ScatterFraction = ScatterFraction;
			this.ScatterStrength = ScatterStrength;
			this.ScatterYawReachThresholdDegrees = ScatterYawReachThresholdDegrees;
			this.ScatterAlignScale = ScatterAlignScale;
			this.ScatterCohesionScale = ScatterCohesionScale;
			this.ScatterSeparateScale = ScatterSeparateScale;
			this.WanderWeight = WanderWeight;
			this.WanderYawAmplitudeDegrees = WanderYawAmplitudeDegrees;
			this.WanderFrequency = WanderFrequency;
			this.WanderSecondaryScale = WanderSecondaryScale;
			this.WanderScatterScale = WanderScatterScale;
			this.bUseDistanceFieldAvoidance = bUseDistanceFieldAvoidance;
		}

		// Token: 0x06019DC4 RID: 105924 RVA: 0x00262ECC File Offset: 0x002610CC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFlockingSettings.StaticStruct();
		}

		// Token: 0x06019DC5 RID: 105925 RVA: 0x00262ED8 File Offset: 0x002610D8
		[NullableContext(2)]
		public FKuroFlockingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019DC6 RID: 105926 RVA: 0x00262EE2 File Offset: 0x002610E2
		public FKuroFlockingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019DC7 RID: 105927 RVA: 0x00262EED File Offset: 0x002610ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFlockingSettings(Pointer, false, true);
		}

		// Token: 0x06019DC8 RID: 105928 RVA: 0x00262EF7 File Offset: 0x002610F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFlockingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400E0D9 RID: 57561
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingSettings";

		// Token: 0x0400E0DA RID: 57562
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E0DB RID: 57563
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x0400E0DC RID: 57564
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x0400E0DD RID: 57565
		internal static int __PropertyOffset_PerceptionRadius;

		// Token: 0x0400E0DE RID: 57566
		internal static int __PropertyOffset_AvoidanceRadius;

		// Token: 0x0400E0DF RID: 57567
		internal static int __PropertyOffset_MaxSteerForce;

		// Token: 0x0400E0E0 RID: 57568
		internal static int __PropertyOffset_AlignWeight;

		// Token: 0x0400E0E1 RID: 57569
		internal static int __PropertyOffset_CohesionWeight;

		// Token: 0x0400E0E2 RID: 57570
		internal static int __PropertyOffset_SeparateWeight;

		// Token: 0x0400E0E3 RID: 57571
		internal static int __PropertyOffset_TargetWeight;

		// Token: 0x0400E0E4 RID: 57572
		internal static int __PropertyOffset_BoundsRadius;

		// Token: 0x0400E0E5 RID: 57573
		internal static int __PropertyOffset_AvoidCollisionWeight;

		// Token: 0x0400E0E6 RID: 57574
		internal static int __PropertyOffset_CollisionAvoidDistance;

		// Token: 0x0400E0E7 RID: 57575
		internal static int __PropertyOffset_CollisionAvoidSphereRadius;

		// Token: 0x0400E0E8 RID: 57576
		internal static int __PropertyOffset_BoxSize;

		// Token: 0x0400E0E9 RID: 57577
		internal static int __PropertyOffset_BoxBoundaryMarginRatio;

		// Token: 0x0400E0EA RID: 57578
		internal static int __PropertyOffset_BoxBoundaryMinMarginWorld;

		// Token: 0x0400E0EB RID: 57579
		internal static int __PropertyOffset_BoxBoundaryTangentialStrength;

		// Token: 0x0400E0EC RID: 57580
		internal static int __PropertyOffset_RayNum;

		// Token: 0x0400E0ED RID: 57581
		internal static int __PropertyOffset_ScatterInterval;

		// Token: 0x0400E0EE RID: 57582
		internal static int __PropertyOffset_ScatterDuration;

		// Token: 0x0400E0EF RID: 57583
		internal static int __PropertyOffset_ScatterFraction;

		// Token: 0x0400E0F0 RID: 57584
		internal static int __PropertyOffset_ScatterStrength;

		// Token: 0x0400E0F1 RID: 57585
		internal static int __PropertyOffset_ScatterYawReachThresholdDegrees;

		// Token: 0x0400E0F2 RID: 57586
		internal static int __PropertyOffset_ScatterAlignScale;

		// Token: 0x0400E0F3 RID: 57587
		internal static int __PropertyOffset_ScatterCohesionScale;

		// Token: 0x0400E0F4 RID: 57588
		internal static int __PropertyOffset_ScatterSeparateScale;

		// Token: 0x0400E0F5 RID: 57589
		internal static int __PropertyOffset_WanderWeight;

		// Token: 0x0400E0F6 RID: 57590
		internal static int __PropertyOffset_WanderYawAmplitudeDegrees;

		// Token: 0x0400E0F7 RID: 57591
		internal static int __PropertyOffset_WanderFrequency;

		// Token: 0x0400E0F8 RID: 57592
		internal static int __PropertyOffset_WanderSecondaryScale;

		// Token: 0x0400E0F9 RID: 57593
		internal static int __PropertyOffset_WanderScatterScale;

		// Token: 0x0400E0FA RID: 57594
		internal static int __PropertyOffset_bUseDistanceFieldAvoidance;
	}
}
