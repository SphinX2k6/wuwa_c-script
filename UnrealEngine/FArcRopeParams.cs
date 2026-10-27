using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C71 RID: 7281
	[UnrealObjectPath("/Script/KuroRopeEffect.ArcRopeParams")]
	[UnrealStructLayout(92, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 92)]
	public class FArcRopeParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C3E1 RID: 115681 RVA: 0x0029A295 File Offset: 0x00298495
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FArcRopeParams._ScriptStructPtr != 0) ? FArcRopeParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRopeEffect.ArcRopeParams", ref FArcRopeParams._ScriptStructPtr);
		}

		// Token: 0x17007220 RID: 29216
		// (get) Token: 0x0601C3E2 RID: 115682 RVA: 0x0029A2B9 File Offset: 0x002984B9
		// (set) Token: 0x0601C3E3 RID: 115683 RVA: 0x0029A2C9 File Offset: 0x002984C9
		public unsafe bool bContinuousDrive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bContinuousDrive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bContinuousDrive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007221 RID: 29217
		// (get) Token: 0x0601C3E4 RID: 115684 RVA: 0x0029A2DA File Offset: 0x002984DA
		// (set) Token: 0x0601C3E5 RID: 115685 RVA: 0x0029A2EA File Offset: 0x002984EA
		public unsafe bool bResampleUniform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bResampleUniform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bResampleUniform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007222 RID: 29218
		// (get) Token: 0x0601C3E6 RID: 115686 RVA: 0x0029A2FB File Offset: 0x002984FB
		// (set) Token: 0x0601C3E7 RID: 115687 RVA: 0x0029A30B File Offset: 0x0029850B
		public unsafe int ResampleSegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_ResampleSegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_ResampleSegmentCount) = value;
			}
		}

		// Token: 0x17007223 RID: 29219
		// (get) Token: 0x0601C3E8 RID: 115688 RVA: 0x0029A31C File Offset: 0x0029851C
		// (set) Token: 0x0601C3E9 RID: 115689 RVA: 0x0029A32C File Offset: 0x0029852C
		public unsafe bool bReinitOnReplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bReinitOnReplay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bReinitOnReplay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007224 RID: 29220
		// (get) Token: 0x0601C3EA RID: 115690 RVA: 0x0029A33D File Offset: 0x0029853D
		// (set) Token: 0x0601C3EB RID: 115691 RVA: 0x0029A34D File Offset: 0x0029854D
		public unsafe float ReinitGapThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_ReinitGapThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_ReinitGapThreshold) = value;
			}
		}

		// Token: 0x17007225 RID: 29221
		// (get) Token: 0x0601C3EC RID: 115692 RVA: 0x0029A35E File Offset: 0x0029855E
		// (set) Token: 0x0601C3ED RID: 115693 RVA: 0x0029A36E File Offset: 0x0029856E
		public unsafe bool bSimpleWhipMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bSimpleWhipMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bSimpleWhipMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007226 RID: 29222
		// (get) Token: 0x0601C3EE RID: 115694 RVA: 0x0029A37F File Offset: 0x0029857F
		// (set) Token: 0x0601C3EF RID: 115695 RVA: 0x0029A38F File Offset: 0x0029858F
		public unsafe bool bEnablePhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bEnablePhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bEnablePhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007227 RID: 29223
		// (get) Token: 0x0601C3F0 RID: 115696 RVA: 0x0029A3A0 File Offset: 0x002985A0
		// (set) Token: 0x0601C3F1 RID: 115697 RVA: 0x0029A3B0 File Offset: 0x002985B0
		public unsafe float WhipStraightenStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipStraightenStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipStraightenStiffness) = value;
			}
		}

		// Token: 0x17007228 RID: 29224
		// (get) Token: 0x0601C3F2 RID: 115698 RVA: 0x0029A3C1 File Offset: 0x002985C1
		// (set) Token: 0x0601C3F3 RID: 115699 RVA: 0x0029A3D1 File Offset: 0x002985D1
		public unsafe float WhipSwing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSwing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSwing) = value;
			}
		}

		// Token: 0x17007229 RID: 29225
		// (get) Token: 0x0601C3F4 RID: 115700 RVA: 0x0029A3E2 File Offset: 0x002985E2
		// (set) Token: 0x0601C3F5 RID: 115701 RVA: 0x0029A3F2 File Offset: 0x002985F2
		public unsafe float WhipSmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSmoothing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSmoothing) = value;
			}
		}

		// Token: 0x1700722A RID: 29226
		// (get) Token: 0x0601C3F6 RID: 115702 RVA: 0x0029A403 File Offset: 0x00298603
		// (set) Token: 0x0601C3F7 RID: 115703 RVA: 0x0029A413 File Offset: 0x00298613
		public unsafe int WhipSmoothingIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSmoothingIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSmoothingIterations) = value;
			}
		}

		// Token: 0x1700722B RID: 29227
		// (get) Token: 0x0601C3F8 RID: 115704 RVA: 0x0029A424 File Offset: 0x00298624
		// (set) Token: 0x0601C3F9 RID: 115705 RVA: 0x0029A434 File Offset: 0x00298634
		public unsafe float WhipSag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipSag) = value;
			}
		}

		// Token: 0x1700722C RID: 29228
		// (get) Token: 0x0601C3FA RID: 115706 RVA: 0x0029A445 File Offset: 0x00298645
		// (set) Token: 0x0601C3FB RID: 115707 RVA: 0x0029A455 File Offset: 0x00298655
		public unsafe float WhipStartDirInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipStartDirInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipStartDirInfluence) = value;
			}
		}

		// Token: 0x1700722D RID: 29229
		// (get) Token: 0x0601C3FC RID: 115708 RVA: 0x0029A466 File Offset: 0x00298666
		// (set) Token: 0x0601C3FD RID: 115709 RVA: 0x0029A476 File Offset: 0x00298676
		public unsafe float WhipEndDirInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipEndDirInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_WhipEndDirInfluence) = value;
			}
		}

		// Token: 0x1700722E RID: 29230
		// (get) Token: 0x0601C3FE RID: 115710 RVA: 0x0029A487 File Offset: 0x00298687
		// (set) Token: 0x0601C3FF RID: 115711 RVA: 0x0029A497 File Offset: 0x00298697
		public unsafe bool bPinStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bPinStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bPinStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700722F RID: 29231
		// (get) Token: 0x0601C400 RID: 115712 RVA: 0x0029A4A8 File Offset: 0x002986A8
		// (set) Token: 0x0601C401 RID: 115713 RVA: 0x0029A4B8 File Offset: 0x002986B8
		public unsafe bool bPinEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bPinEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_bPinEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007230 RID: 29232
		// (get) Token: 0x0601C402 RID: 115714 RVA: 0x0029A4C9 File Offset: 0x002986C9
		// (set) Token: 0x0601C403 RID: 115715 RVA: 0x0029A4DD File Offset: 0x002986DD
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17007231 RID: 29233
		// (get) Token: 0x0601C404 RID: 115716 RVA: 0x0029A4F2 File Offset: 0x002986F2
		// (set) Token: 0x0601C405 RID: 115717 RVA: 0x0029A502 File Offset: 0x00298702
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17007232 RID: 29234
		// (get) Token: 0x0601C406 RID: 115718 RVA: 0x0029A513 File Offset: 0x00298713
		// (set) Token: 0x0601C407 RID: 115719 RVA: 0x0029A523 File Offset: 0x00298723
		public unsafe int ConstraintIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_ConstraintIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_ConstraintIterations) = value;
			}
		}

		// Token: 0x17007233 RID: 29235
		// (get) Token: 0x0601C408 RID: 115720 RVA: 0x0029A534 File Offset: 0x00298734
		// (set) Token: 0x0601C409 RID: 115721 RVA: 0x0029A544 File Offset: 0x00298744
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x17007234 RID: 29236
		// (get) Token: 0x0601C40A RID: 115722 RVA: 0x0029A555 File Offset: 0x00298755
		// (set) Token: 0x0601C40B RID: 115723 RVA: 0x0029A565 File Offset: 0x00298765
		public unsafe float BendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_BendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_BendStiffness) = value;
			}
		}

		// Token: 0x17007235 RID: 29237
		// (get) Token: 0x0601C40C RID: 115724 RVA: 0x0029A576 File Offset: 0x00298776
		// (set) Token: 0x0601C40D RID: 115725 RVA: 0x0029A586 File Offset: 0x00298786
		public unsafe float MaxTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_MaxTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_MaxTimeStep) = value;
			}
		}

		// Token: 0x17007236 RID: 29238
		// (get) Token: 0x0601C40E RID: 115726 RVA: 0x0029A597 File Offset: 0x00298797
		// (set) Token: 0x0601C40F RID: 115727 RVA: 0x0029A5A7 File Offset: 0x002987A7
		public unsafe float TensionPropagation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_TensionPropagation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_TensionPropagation) = value;
			}
		}

		// Token: 0x17007237 RID: 29239
		// (get) Token: 0x0601C410 RID: 115728 RVA: 0x0029A5B8 File Offset: 0x002987B8
		// (set) Token: 0x0601C411 RID: 115729 RVA: 0x0029A5C8 File Offset: 0x002987C8
		public unsafe float TensionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_TensionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParams.__PropertyOffset_TensionStrength) = value;
			}
		}

		// Token: 0x0601C412 RID: 115730 RVA: 0x0029A5D9 File Offset: 0x002987D9
		public FArcRopeParams()
		{
		}

		// Token: 0x0601C413 RID: 115731 RVA: 0x0029A5E4 File Offset: 0x002987E4
		public FArcRopeParams(bool bContinuousDrive, bool bResampleUniform, int ResampleSegmentCount, bool bReinitOnReplay, float ReinitGapThreshold, bool bSimpleWhipMode, bool bEnablePhysics, float WhipStraightenStiffness, float WhipSwing, float WhipSmoothing, int WhipSmoothingIterations, float WhipSag, float WhipStartDirInfluence, float WhipEndDirInfluence, bool bPinStart, bool bPinEnd, FVector Gravity, float Damping, int ConstraintIterations, float Stiffness, float BendStiffness, float MaxTimeStep, float TensionPropagation, float TensionStrength)
		{
			this.bContinuousDrive = bContinuousDrive;
			this.bResampleUniform = bResampleUniform;
			this.ResampleSegmentCount = ResampleSegmentCount;
			this.bReinitOnReplay = bReinitOnReplay;
			this.ReinitGapThreshold = ReinitGapThreshold;
			this.bSimpleWhipMode = bSimpleWhipMode;
			this.bEnablePhysics = bEnablePhysics;
			this.WhipStraightenStiffness = WhipStraightenStiffness;
			this.WhipSwing = WhipSwing;
			this.WhipSmoothing = WhipSmoothing;
			this.WhipSmoothingIterations = WhipSmoothingIterations;
			this.WhipSag = WhipSag;
			this.WhipStartDirInfluence = WhipStartDirInfluence;
			this.WhipEndDirInfluence = WhipEndDirInfluence;
			this.bPinStart = bPinStart;
			this.bPinEnd = bPinEnd;
			this.Gravity = Gravity;
			this.Damping = Damping;
			this.ConstraintIterations = ConstraintIterations;
			this.Stiffness = Stiffness;
			this.BendStiffness = BendStiffness;
			this.MaxTimeStep = MaxTimeStep;
			this.TensionPropagation = TensionPropagation;
			this.TensionStrength = TensionStrength;
		}

		// Token: 0x0601C414 RID: 115732 RVA: 0x0029A6B4 File Offset: 0x002988B4
		protected override IntPtr GetUStructPtr()
		{
			return FArcRopeParams.StaticStruct();
		}

		// Token: 0x0601C415 RID: 115733 RVA: 0x0029A6C0 File Offset: 0x002988C0
		[NullableContext(2)]
		public FArcRopeParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C416 RID: 115734 RVA: 0x0029A6CA File Offset: 0x002988CA
		public FArcRopeParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C417 RID: 115735 RVA: 0x0029A6D5 File Offset: 0x002988D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FArcRopeParams(Pointer, false, true);
		}

		// Token: 0x0601C418 RID: 115736 RVA: 0x0029A6DF File Offset: 0x002988DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FArcRopeParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400F2FD RID: 62205
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRopeEffect.ArcRopeParams";

		// Token: 0x0400F2FE RID: 62206
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F2FF RID: 62207
		internal static int __PropertyOffset_bContinuousDrive;

		// Token: 0x0400F300 RID: 62208
		internal static int __PropertyOffset_bResampleUniform;

		// Token: 0x0400F301 RID: 62209
		internal static int __PropertyOffset_ResampleSegmentCount;

		// Token: 0x0400F302 RID: 62210
		internal static int __PropertyOffset_bReinitOnReplay;

		// Token: 0x0400F303 RID: 62211
		internal static int __PropertyOffset_ReinitGapThreshold;

		// Token: 0x0400F304 RID: 62212
		internal static int __PropertyOffset_bSimpleWhipMode;

		// Token: 0x0400F305 RID: 62213
		internal static int __PropertyOffset_bEnablePhysics;

		// Token: 0x0400F306 RID: 62214
		internal static int __PropertyOffset_WhipStraightenStiffness;

		// Token: 0x0400F307 RID: 62215
		internal static int __PropertyOffset_WhipSwing;

		// Token: 0x0400F308 RID: 62216
		internal static int __PropertyOffset_WhipSmoothing;

		// Token: 0x0400F309 RID: 62217
		internal static int __PropertyOffset_WhipSmoothingIterations;

		// Token: 0x0400F30A RID: 62218
		internal static int __PropertyOffset_WhipSag;

		// Token: 0x0400F30B RID: 62219
		internal static int __PropertyOffset_WhipStartDirInfluence;

		// Token: 0x0400F30C RID: 62220
		internal static int __PropertyOffset_WhipEndDirInfluence;

		// Token: 0x0400F30D RID: 62221
		internal static int __PropertyOffset_bPinStart;

		// Token: 0x0400F30E RID: 62222
		internal static int __PropertyOffset_bPinEnd;

		// Token: 0x0400F30F RID: 62223
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400F310 RID: 62224
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400F311 RID: 62225
		internal static int __PropertyOffset_ConstraintIterations;

		// Token: 0x0400F312 RID: 62226
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400F313 RID: 62227
		internal static int __PropertyOffset_BendStiffness;

		// Token: 0x0400F314 RID: 62228
		internal static int __PropertyOffset_MaxTimeStep;

		// Token: 0x0400F315 RID: 62229
		internal static int __PropertyOffset_TensionPropagation;

		// Token: 0x0400F316 RID: 62230
		internal static int __PropertyOffset_TensionStrength;
	}
}
