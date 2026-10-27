using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200167B RID: 5755
	[UnrealObjectPath("/Script/KuroAnim.PhyClothConfig")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FPhyClothConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E04 RID: 85508 RVA: 0x001EB104 File Offset: 0x001E9304
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhyClothConfig._ScriptStructPtr != 0) ? FPhyClothConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.PhyClothConfig", ref FPhyClothConfig._ScriptStructPtr);
		}

		// Token: 0x170052AE RID: 21166
		// (get) Token: 0x06014E05 RID: 85509 RVA: 0x001EB128 File Offset: 0x001E9328
		// (set) Token: 0x06014E06 RID: 85510 RVA: 0x001EB138 File Offset: 0x001E9338
		public unsafe float SpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_SpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_SpringStiffness) = value;
			}
		}

		// Token: 0x170052AF RID: 21167
		// (get) Token: 0x06014E07 RID: 85511 RVA: 0x001EB149 File Offset: 0x001E9349
		// (set) Token: 0x06014E08 RID: 85512 RVA: 0x001EB159 File Offset: 0x001E9359
		public unsafe float AngleSpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_AngleSpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_AngleSpringStiffness) = value;
			}
		}

		// Token: 0x170052B0 RID: 21168
		// (get) Token: 0x06014E09 RID: 85513 RVA: 0x001EB16A File Offset: 0x001E936A
		// (set) Token: 0x06014E0A RID: 85514 RVA: 0x001EB17A File Offset: 0x001E937A
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x170052B1 RID: 21169
		// (get) Token: 0x06014E0B RID: 85515 RVA: 0x001EB18B File Offset: 0x001E938B
		// (set) Token: 0x06014E0C RID: 85516 RVA: 0x001EB19F File Offset: 0x001E939F
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x170052B2 RID: 21170
		// (get) Token: 0x06014E0D RID: 85517 RVA: 0x001EB1B4 File Offset: 0x001E93B4
		// (set) Token: 0x06014E0E RID: 85518 RVA: 0x001EB1C4 File Offset: 0x001E93C4
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x170052B3 RID: 21171
		// (get) Token: 0x06014E0F RID: 85519 RVA: 0x001EB1D5 File Offset: 0x001E93D5
		// (set) Token: 0x06014E10 RID: 85520 RVA: 0x001EB1E5 File Offset: 0x001E93E5
		public unsafe float LimitScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_LimitScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_LimitScale) = value;
			}
		}

		// Token: 0x170052B4 RID: 21172
		// (get) Token: 0x06014E11 RID: 85521 RVA: 0x001EB1F6 File Offset: 0x001E93F6
		// (set) Token: 0x06014E12 RID: 85522 RVA: 0x001EB206 File Offset: 0x001E9406
		public unsafe float LimitDegree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_LimitDegree);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_LimitDegree) = value;
			}
		}

		// Token: 0x170052B5 RID: 21173
		// (get) Token: 0x06014E13 RID: 85523 RVA: 0x001EB217 File Offset: 0x001E9417
		// (set) Token: 0x06014E14 RID: 85524 RVA: 0x001EB227 File Offset: 0x001E9427
		public unsafe float StrengthRateForSideLink
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_StrengthRateForSideLink);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_StrengthRateForSideLink) = value;
			}
		}

		// Token: 0x170052B6 RID: 21174
		// (get) Token: 0x06014E15 RID: 85525 RVA: 0x001EB238 File Offset: 0x001E9438
		// (set) Token: 0x06014E16 RID: 85526 RVA: 0x001EB248 File Offset: 0x001E9448
		public unsafe float StrengthRateForInverseLink
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_StrengthRateForInverseLink);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothConfig.__PropertyOffset_StrengthRateForInverseLink) = value;
			}
		}

		// Token: 0x06014E17 RID: 85527 RVA: 0x001EB259 File Offset: 0x001E9459
		public FPhyClothConfig()
		{
		}

		// Token: 0x06014E18 RID: 85528 RVA: 0x001EB264 File Offset: 0x001E9464
		public FPhyClothConfig(float SpringStiffness, float AngleSpringStiffness, float Damping, FVector Gravity, float Mass, float LimitScale, float LimitDegree, float StrengthRateForSideLink, float StrengthRateForInverseLink)
		{
			this.SpringStiffness = SpringStiffness;
			this.AngleSpringStiffness = AngleSpringStiffness;
			this.Damping = Damping;
			this.Gravity = Gravity;
			this.Mass = Mass;
			this.LimitScale = LimitScale;
			this.LimitDegree = LimitDegree;
			this.StrengthRateForSideLink = StrengthRateForSideLink;
			this.StrengthRateForInverseLink = StrengthRateForInverseLink;
		}

		// Token: 0x06014E19 RID: 85529 RVA: 0x001EB2BC File Offset: 0x001E94BC
		protected override IntPtr GetUStructPtr()
		{
			return FPhyClothConfig.StaticStruct();
		}

		// Token: 0x06014E1A RID: 85530 RVA: 0x001EB2C8 File Offset: 0x001E94C8
		[NullableContext(2)]
		public FPhyClothConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E1B RID: 85531 RVA: 0x001EB2D2 File Offset: 0x001E94D2
		public FPhyClothConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E1C RID: 85532 RVA: 0x001EB2DD File Offset: 0x001E94DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhyClothConfig(Pointer, false, true);
		}

		// Token: 0x06014E1D RID: 85533 RVA: 0x001EB2E7 File Offset: 0x001E94E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhyClothConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B601 RID: 46593
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.PhyClothConfig";

		// Token: 0x0400B602 RID: 46594
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B603 RID: 46595
		internal static int __PropertyOffset_SpringStiffness;

		// Token: 0x0400B604 RID: 46596
		internal static int __PropertyOffset_AngleSpringStiffness;

		// Token: 0x0400B605 RID: 46597
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400B606 RID: 46598
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400B607 RID: 46599
		internal static int __PropertyOffset_Mass;

		// Token: 0x0400B608 RID: 46600
		internal static int __PropertyOffset_LimitScale;

		// Token: 0x0400B609 RID: 46601
		internal static int __PropertyOffset_LimitDegree;

		// Token: 0x0400B60A RID: 46602
		internal static int __PropertyOffset_StrengthRateForSideLink;

		// Token: 0x0400B60B RID: 46603
		internal static int __PropertyOffset_StrengthRateForInverseLink;
	}
}
