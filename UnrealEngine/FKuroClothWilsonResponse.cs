using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200179E RID: 6046
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothWilsonResponse")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FKuroClothWilsonResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015CBD RID: 89277 RVA: 0x00200368 File Offset: 0x001FE568
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroClothWilsonResponse._ScriptStructPtr != 0) ? FKuroClothWilsonResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroClothWilsonResponse", ref FKuroClothWilsonResponse._ScriptStructPtr);
		}

		// Token: 0x17005657 RID: 22103
		// (get) Token: 0x06015CBE RID: 89278 RVA: 0x0020038C File Offset: 0x001FE58C
		// (set) Token: 0x06015CBF RID: 89279 RVA: 0x0020039C File Offset: 0x001FE59C
		public unsafe float WindFieldRTScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_WindFieldRTScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_WindFieldRTScale) = value;
			}
		}

		// Token: 0x17005658 RID: 22104
		// (get) Token: 0x06015CC0 RID: 89280 RVA: 0x002003AD File Offset: 0x001FE5AD
		// (set) Token: 0x06015CC1 RID: 89281 RVA: 0x002003C1 File Offset: 0x001FE5C1
		public unsafe FVector WindDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_WindDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_WindDirection) = value;
			}
		}

		// Token: 0x17005659 RID: 22105
		// (get) Token: 0x06015CC2 RID: 89282 RVA: 0x002003D6 File Offset: 0x001FE5D6
		// (set) Token: 0x06015CC3 RID: 89283 RVA: 0x002003E6 File Offset: 0x001FE5E6
		public unsafe float BaseWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_BaseWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_BaseWindStrength) = value;
			}
		}

		// Token: 0x1700565A RID: 22106
		// (get) Token: 0x06015CC4 RID: 89284 RVA: 0x002003F7 File Offset: 0x001FE5F7
		// (set) Token: 0x06015CC5 RID: 89285 RVA: 0x00200407 File Offset: 0x001FE607
		public unsafe float Rho
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_Rho);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_Rho) = value;
			}
		}

		// Token: 0x1700565B RID: 22107
		// (get) Token: 0x06015CC6 RID: 89286 RVA: 0x00200418 File Offset: 0x001FE618
		// (set) Token: 0x06015CC7 RID: 89287 RVA: 0x00200428 File Offset: 0x001FE628
		public unsafe float DragCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_DragCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_DragCoefficient) = value;
			}
		}

		// Token: 0x1700565C RID: 22108
		// (get) Token: 0x06015CC8 RID: 89288 RVA: 0x00200439 File Offset: 0x001FE639
		// (set) Token: 0x06015CC9 RID: 89289 RVA: 0x00200449 File Offset: 0x001FE649
		public unsafe float LiftCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_LiftCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_LiftCoefficient) = value;
			}
		}

		// Token: 0x1700565D RID: 22109
		// (get) Token: 0x06015CCA RID: 89290 RVA: 0x0020045A File Offset: 0x001FE65A
		// (set) Token: 0x06015CCB RID: 89291 RVA: 0x0020046A File Offset: 0x001FE66A
		public unsafe float GustAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_GustAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_GustAmplitude) = value;
			}
		}

		// Token: 0x1700565E RID: 22110
		// (get) Token: 0x06015CCC RID: 89292 RVA: 0x0020047B File Offset: 0x001FE67B
		// (set) Token: 0x06015CCD RID: 89293 RVA: 0x0020048B File Offset: 0x001FE68B
		public unsafe float GustTimeFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_GustTimeFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_GustTimeFrequency) = value;
			}
		}

		// Token: 0x1700565F RID: 22111
		// (get) Token: 0x06015CCE RID: 89294 RVA: 0x0020049C File Offset: 0x001FE69C
		// (set) Token: 0x06015CCF RID: 89295 RVA: 0x002004AC File Offset: 0x001FE6AC
		public unsafe float GustSpaceFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_GustSpaceFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_GustSpaceFrequency) = value;
			}
		}

		// Token: 0x17005660 RID: 22112
		// (get) Token: 0x06015CD0 RID: 89296 RVA: 0x002004BD File Offset: 0x001FE6BD
		// (set) Token: 0x06015CD1 RID: 89297 RVA: 0x002004CD File Offset: 0x001FE6CD
		public unsafe float DirectionSwayAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_DirectionSwayAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_DirectionSwayAmplitude) = value;
			}
		}

		// Token: 0x17005661 RID: 22113
		// (get) Token: 0x06015CD2 RID: 89298 RVA: 0x002004DE File Offset: 0x001FE6DE
		// (set) Token: 0x06015CD3 RID: 89299 RVA: 0x002004EE File Offset: 0x001FE6EE
		public unsafe float DirectionSwayFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_DirectionSwayFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_DirectionSwayFrequency) = value;
			}
		}

		// Token: 0x17005662 RID: 22114
		// (get) Token: 0x06015CD4 RID: 89300 RVA: 0x002004FF File Offset: 0x001FE6FF
		// (set) Token: 0x06015CD5 RID: 89301 RVA: 0x0020050F File Offset: 0x001FE70F
		public unsafe float MaxDeltaVelocityPerStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_MaxDeltaVelocityPerStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_MaxDeltaVelocityPerStep) = value;
			}
		}

		// Token: 0x17005663 RID: 22115
		// (get) Token: 0x06015CD6 RID: 89302 RVA: 0x00200520 File Offset: 0x001FE720
		// (set) Token: 0x06015CD7 RID: 89303 RVA: 0x00200530 File Offset: 0x001FE730
		public unsafe int ContactCooldownFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_ContactCooldownFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothWilsonResponse.__PropertyOffset_ContactCooldownFrames) = value;
			}
		}

		// Token: 0x06015CD8 RID: 89304 RVA: 0x00200541 File Offset: 0x001FE741
		public FKuroClothWilsonResponse()
		{
		}

		// Token: 0x06015CD9 RID: 89305 RVA: 0x0020054C File Offset: 0x001FE74C
		public FKuroClothWilsonResponse(float WindFieldRTScale, FVector WindDirection, float BaseWindStrength, float Rho, float DragCoefficient, float LiftCoefficient, float GustAmplitude, float GustTimeFrequency, float GustSpaceFrequency, float DirectionSwayAmplitude, float DirectionSwayFrequency, float MaxDeltaVelocityPerStep, int ContactCooldownFrames)
		{
			this.WindFieldRTScale = WindFieldRTScale;
			this.WindDirection = WindDirection;
			this.BaseWindStrength = BaseWindStrength;
			this.Rho = Rho;
			this.DragCoefficient = DragCoefficient;
			this.LiftCoefficient = LiftCoefficient;
			this.GustAmplitude = GustAmplitude;
			this.GustTimeFrequency = GustTimeFrequency;
			this.GustSpaceFrequency = GustSpaceFrequency;
			this.DirectionSwayAmplitude = DirectionSwayAmplitude;
			this.DirectionSwayFrequency = DirectionSwayFrequency;
			this.MaxDeltaVelocityPerStep = MaxDeltaVelocityPerStep;
			this.ContactCooldownFrames = ContactCooldownFrames;
		}

		// Token: 0x06015CDA RID: 89306 RVA: 0x002005C4 File Offset: 0x001FE7C4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroClothWilsonResponse.StaticStruct();
		}

		// Token: 0x06015CDB RID: 89307 RVA: 0x002005D0 File Offset: 0x001FE7D0
		[NullableContext(2)]
		public FKuroClothWilsonResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015CDC RID: 89308 RVA: 0x002005DA File Offset: 0x001FE7DA
		public FKuroClothWilsonResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015CDD RID: 89309 RVA: 0x002005E5 File Offset: 0x001FE7E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroClothWilsonResponse(Pointer, false, true);
		}

		// Token: 0x06015CDE RID: 89310 RVA: 0x002005EF File Offset: 0x001FE7EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroClothWilsonResponse(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE44 RID: 48708
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroClothWilsonResponse";

		// Token: 0x0400BE45 RID: 48709
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE46 RID: 48710
		internal static int __PropertyOffset_WindFieldRTScale;

		// Token: 0x0400BE47 RID: 48711
		internal static int __PropertyOffset_WindDirection;

		// Token: 0x0400BE48 RID: 48712
		internal static int __PropertyOffset_BaseWindStrength;

		// Token: 0x0400BE49 RID: 48713
		internal static int __PropertyOffset_Rho;

		// Token: 0x0400BE4A RID: 48714
		internal static int __PropertyOffset_DragCoefficient;

		// Token: 0x0400BE4B RID: 48715
		internal static int __PropertyOffset_LiftCoefficient;

		// Token: 0x0400BE4C RID: 48716
		internal static int __PropertyOffset_GustAmplitude;

		// Token: 0x0400BE4D RID: 48717
		internal static int __PropertyOffset_GustTimeFrequency;

		// Token: 0x0400BE4E RID: 48718
		internal static int __PropertyOffset_GustSpaceFrequency;

		// Token: 0x0400BE4F RID: 48719
		internal static int __PropertyOffset_DirectionSwayAmplitude;

		// Token: 0x0400BE50 RID: 48720
		internal static int __PropertyOffset_DirectionSwayFrequency;

		// Token: 0x0400BE51 RID: 48721
		internal static int __PropertyOffset_MaxDeltaVelocityPerStep;

		// Token: 0x0400BE52 RID: 48722
		internal static int __PropertyOffset_ContactCooldownFrames;
	}
}
