using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D74 RID: 3444
	[UnrealObjectPath("/Script/Engine.MarchingCubesParticleProperties")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FMarchingCubesParticleProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BA53 RID: 47699 RVA: 0x00108DFC File Offset: 0x00106FFC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMarchingCubesParticleProperties._ScriptStructPtr != 0) ? FMarchingCubesParticleProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MarchingCubesParticleProperties", ref FMarchingCubesParticleProperties._ScriptStructPtr);
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x00108E20 File Offset: 0x00107020
		// (set) Token: 0x0600BA55 RID: 47701 RVA: 0x00108E30 File Offset: 0x00107030
		public unsafe float MinLifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MinLifetime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MinLifetime) = value;
			}
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x00108E41 File Offset: 0x00107041
		// (set) Token: 0x0600BA57 RID: 47703 RVA: 0x00108E51 File Offset: 0x00107051
		public unsafe float MaxLifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MaxLifetime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MaxLifetime) = value;
			}
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x00108E62 File Offset: 0x00107062
		// (set) Token: 0x0600BA59 RID: 47705 RVA: 0x00108E72 File Offset: 0x00107072
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x0600BA5A RID: 47706 RVA: 0x00108E83 File Offset: 0x00107083
		// (set) Token: 0x0600BA5B RID: 47707 RVA: 0x00108E93 File Offset: 0x00107093
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x00108EA4 File Offset: 0x001070A4
		// (set) Token: 0x0600BA5D RID: 47709 RVA: 0x00108EB4 File Offset: 0x001070B4
		public unsafe float GravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_GravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_GravityZ) = value;
			}
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x00108EC5 File Offset: 0x001070C5
		// (set) Token: 0x0600BA5F RID: 47711 RVA: 0x00108ED5 File Offset: 0x001070D5
		public unsafe float MinPointSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MinPointSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MinPointSize) = value;
			}
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0600BA60 RID: 47712 RVA: 0x00108EE6 File Offset: 0x001070E6
		// (set) Token: 0x0600BA61 RID: 47713 RVA: 0x00108EF6 File Offset: 0x001070F6
		public unsafe float MaxPointSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MaxPointSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MaxPointSize) = value;
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x00108F07 File Offset: 0x00107107
		// (set) Token: 0x0600BA63 RID: 47715 RVA: 0x00108F17 File Offset: 0x00107117
		public unsafe float MistDampingPer60Hz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistDampingPer60Hz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistDampingPer60Hz) = value;
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x0600BA64 RID: 47716 RVA: 0x00108F28 File Offset: 0x00107128
		// (set) Token: 0x0600BA65 RID: 47717 RVA: 0x00108F38 File Offset: 0x00107138
		public unsafe float MistNormalWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistNormalWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistNormalWeight) = value;
			}
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0600BA66 RID: 47718 RVA: 0x00108F49 File Offset: 0x00107149
		// (set) Token: 0x0600BA67 RID: 47719 RVA: 0x00108F59 File Offset: 0x00107159
		public unsafe float MistRandomWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistRandomWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistRandomWeight) = value;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0600BA68 RID: 47720 RVA: 0x00108F6A File Offset: 0x0010716A
		// (set) Token: 0x0600BA69 RID: 47721 RVA: 0x00108F7A File Offset: 0x0010717A
		public unsafe float MistUpwardBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistUpwardBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistUpwardBias) = value;
			}
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x0600BA6A RID: 47722 RVA: 0x00108F8B File Offset: 0x0010718B
		// (set) Token: 0x0600BA6B RID: 47723 RVA: 0x00108F9B File Offset: 0x0010719B
		public unsafe float MistFadeInEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistFadeInEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistFadeInEnd) = value;
			}
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x0600BA6C RID: 47724 RVA: 0x00108FAC File Offset: 0x001071AC
		// (set) Token: 0x0600BA6D RID: 47725 RVA: 0x00108FBC File Offset: 0x001071BC
		public unsafe float MistFadeOutStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistFadeOutStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistFadeOutStart) = value;
			}
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x00108FCD File Offset: 0x001071CD
		// (set) Token: 0x0600BA6F RID: 47727 RVA: 0x00108FDD File Offset: 0x001071DD
		public unsafe float MistSizeStartScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistSizeStartScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistSizeStartScale) = value;
			}
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x0600BA70 RID: 47728 RVA: 0x00108FEE File Offset: 0x001071EE
		// (set) Token: 0x0600BA71 RID: 47729 RVA: 0x00108FFE File Offset: 0x001071FE
		public unsafe float MistSizeEndScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistSizeEndScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubesParticleProperties.__PropertyOffset_MistSizeEndScale) = value;
			}
		}

		// Token: 0x0600BA72 RID: 47730 RVA: 0x0010900F File Offset: 0x0010720F
		public FMarchingCubesParticleProperties()
		{
		}

		// Token: 0x0600BA73 RID: 47731 RVA: 0x00109018 File Offset: 0x00107218
		public FMarchingCubesParticleProperties(float MinLifetime, float MaxLifetime, float MinSpeed, float MaxSpeed, float GravityZ, float MinPointSize, float MaxPointSize, float MistDampingPer60Hz, float MistNormalWeight, float MistRandomWeight, float MistUpwardBias, float MistFadeInEnd, float MistFadeOutStart, float MistSizeStartScale, float MistSizeEndScale)
		{
			this.MinLifetime = MinLifetime;
			this.MaxLifetime = MaxLifetime;
			this.MinSpeed = MinSpeed;
			this.MaxSpeed = MaxSpeed;
			this.GravityZ = GravityZ;
			this.MinPointSize = MinPointSize;
			this.MaxPointSize = MaxPointSize;
			this.MistDampingPer60Hz = MistDampingPer60Hz;
			this.MistNormalWeight = MistNormalWeight;
			this.MistRandomWeight = MistRandomWeight;
			this.MistUpwardBias = MistUpwardBias;
			this.MistFadeInEnd = MistFadeInEnd;
			this.MistFadeOutStart = MistFadeOutStart;
			this.MistSizeStartScale = MistSizeStartScale;
			this.MistSizeEndScale = MistSizeEndScale;
		}

		// Token: 0x0600BA74 RID: 47732 RVA: 0x001090A0 File Offset: 0x001072A0
		protected override IntPtr GetUStructPtr()
		{
			return FMarchingCubesParticleProperties.StaticStruct();
		}

		// Token: 0x0600BA75 RID: 47733 RVA: 0x001090AC File Offset: 0x001072AC
		[NullableContext(2)]
		public FMarchingCubesParticleProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA76 RID: 47734 RVA: 0x001090B6 File Offset: 0x001072B6
		public FMarchingCubesParticleProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA77 RID: 47735 RVA: 0x001090C1 File Offset: 0x001072C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMarchingCubesParticleProperties(Pointer, false, true);
		}

		// Token: 0x0600BA78 RID: 47736 RVA: 0x001090CB File Offset: 0x001072CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMarchingCubesParticleProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04006186 RID: 24966
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MarchingCubesParticleProperties";

		// Token: 0x04006187 RID: 24967
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006188 RID: 24968
		internal static int __PropertyOffset_MinLifetime;

		// Token: 0x04006189 RID: 24969
		internal static int __PropertyOffset_MaxLifetime;

		// Token: 0x0400618A RID: 24970
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x0400618B RID: 24971
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x0400618C RID: 24972
		internal static int __PropertyOffset_GravityZ;

		// Token: 0x0400618D RID: 24973
		internal static int __PropertyOffset_MinPointSize;

		// Token: 0x0400618E RID: 24974
		internal static int __PropertyOffset_MaxPointSize;

		// Token: 0x0400618F RID: 24975
		internal static int __PropertyOffset_MistDampingPer60Hz;

		// Token: 0x04006190 RID: 24976
		internal static int __PropertyOffset_MistNormalWeight;

		// Token: 0x04006191 RID: 24977
		internal static int __PropertyOffset_MistRandomWeight;

		// Token: 0x04006192 RID: 24978
		internal static int __PropertyOffset_MistUpwardBias;

		// Token: 0x04006193 RID: 24979
		internal static int __PropertyOffset_MistFadeInEnd;

		// Token: 0x04006194 RID: 24980
		internal static int __PropertyOffset_MistFadeOutStart;

		// Token: 0x04006195 RID: 24981
		internal static int __PropertyOffset_MistSizeStartScale;

		// Token: 0x04006196 RID: 24982
		internal static int __PropertyOffset_MistSizeEndScale;
	}
}
