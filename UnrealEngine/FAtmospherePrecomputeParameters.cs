using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000863 RID: 2147
	[UnrealObjectPath("/Script/Engine.AtmospherePrecomputeParameters")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FAtmospherePrecomputeParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060073AD RID: 29613 RVA: 0x000A6120 File Offset: 0x000A4320
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAtmospherePrecomputeParameters._ScriptStructPtr != 0) ? FAtmospherePrecomputeParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AtmospherePrecomputeParameters", ref FAtmospherePrecomputeParameters._ScriptStructPtr);
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x060073AE RID: 29614 RVA: 0x000A6144 File Offset: 0x000A4344
		// (set) Token: 0x060073AF RID: 29615 RVA: 0x000A6154 File Offset: 0x000A4354
		public unsafe float DensityHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_DensityHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_DensityHeight) = value;
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x060073B0 RID: 29616 RVA: 0x000A6165 File Offset: 0x000A4365
		// (set) Token: 0x060073B1 RID: 29617 RVA: 0x000A6175 File Offset: 0x000A4375
		public unsafe float DecayHeight_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_DecayHeight_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_DecayHeight_DEPRECATED) = value;
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x060073B2 RID: 29618 RVA: 0x000A6186 File Offset: 0x000A4386
		// (set) Token: 0x060073B3 RID: 29619 RVA: 0x000A6196 File Offset: 0x000A4396
		public unsafe int MaxScatteringOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_MaxScatteringOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_MaxScatteringOrder) = value;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x060073B4 RID: 29620 RVA: 0x000A61A7 File Offset: 0x000A43A7
		// (set) Token: 0x060073B5 RID: 29621 RVA: 0x000A61B7 File Offset: 0x000A43B7
		public unsafe int TransmittanceTexWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_TransmittanceTexWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_TransmittanceTexWidth) = value;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x060073B6 RID: 29622 RVA: 0x000A61C8 File Offset: 0x000A43C8
		// (set) Token: 0x060073B7 RID: 29623 RVA: 0x000A61D8 File Offset: 0x000A43D8
		public unsafe int TransmittanceTexHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_TransmittanceTexHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_TransmittanceTexHeight) = value;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x060073B8 RID: 29624 RVA: 0x000A61E9 File Offset: 0x000A43E9
		// (set) Token: 0x060073B9 RID: 29625 RVA: 0x000A61F9 File Offset: 0x000A43F9
		public unsafe int IrradianceTexWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_IrradianceTexWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_IrradianceTexWidth) = value;
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x060073BA RID: 29626 RVA: 0x000A620A File Offset: 0x000A440A
		// (set) Token: 0x060073BB RID: 29627 RVA: 0x000A621A File Offset: 0x000A441A
		public unsafe int IrradianceTexHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_IrradianceTexHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_IrradianceTexHeight) = value;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x060073BC RID: 29628 RVA: 0x000A622B File Offset: 0x000A442B
		// (set) Token: 0x060073BD RID: 29629 RVA: 0x000A623B File Offset: 0x000A443B
		public unsafe int InscatterAltitudeSampleNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterAltitudeSampleNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterAltitudeSampleNum) = value;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x060073BE RID: 29630 RVA: 0x000A624C File Offset: 0x000A444C
		// (set) Token: 0x060073BF RID: 29631 RVA: 0x000A625C File Offset: 0x000A445C
		public unsafe int InscatterMuNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterMuNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterMuNum) = value;
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x060073C0 RID: 29632 RVA: 0x000A626D File Offset: 0x000A446D
		// (set) Token: 0x060073C1 RID: 29633 RVA: 0x000A627D File Offset: 0x000A447D
		public unsafe int InscatterMuSNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterMuSNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterMuSNum) = value;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x060073C2 RID: 29634 RVA: 0x000A628E File Offset: 0x000A448E
		// (set) Token: 0x060073C3 RID: 29635 RVA: 0x000A629E File Offset: 0x000A449E
		public unsafe int InscatterNuNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterNuNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAtmospherePrecomputeParameters.__PropertyOffset_InscatterNuNum) = value;
			}
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x000A62AF File Offset: 0x000A44AF
		public FAtmospherePrecomputeParameters()
		{
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x000A62B8 File Offset: 0x000A44B8
		public FAtmospherePrecomputeParameters(float DensityHeight, float DecayHeight_DEPRECATED, int MaxScatteringOrder, int TransmittanceTexWidth, int TransmittanceTexHeight, int IrradianceTexWidth, int IrradianceTexHeight, int InscatterAltitudeSampleNum, int InscatterMuNum, int InscatterMuSNum, int InscatterNuNum)
		{
			this.DensityHeight = DensityHeight;
			this.DecayHeight_DEPRECATED = DecayHeight_DEPRECATED;
			this.MaxScatteringOrder = MaxScatteringOrder;
			this.TransmittanceTexWidth = TransmittanceTexWidth;
			this.TransmittanceTexHeight = TransmittanceTexHeight;
			this.IrradianceTexWidth = IrradianceTexWidth;
			this.IrradianceTexHeight = IrradianceTexHeight;
			this.InscatterAltitudeSampleNum = InscatterAltitudeSampleNum;
			this.InscatterMuNum = InscatterMuNum;
			this.InscatterMuSNum = InscatterMuSNum;
			this.InscatterNuNum = InscatterNuNum;
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x000A6320 File Offset: 0x000A4520
		protected override IntPtr GetUStructPtr()
		{
			return FAtmospherePrecomputeParameters.StaticStruct();
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x000A632C File Offset: 0x000A452C
		[NullableContext(2)]
		public FAtmospherePrecomputeParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x000A6336 File Offset: 0x000A4536
		public FAtmospherePrecomputeParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x000A6341 File Offset: 0x000A4541
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAtmospherePrecomputeParameters(Pointer, false, true);
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x000A634B File Offset: 0x000A454B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAtmospherePrecomputeParameters(Pointer, MemoryOwner);
		}

		// Token: 0x040037AE RID: 14254
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AtmospherePrecomputeParameters";

		// Token: 0x040037AF RID: 14255
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040037B0 RID: 14256
		internal static int __PropertyOffset_DensityHeight;

		// Token: 0x040037B1 RID: 14257
		internal static int __PropertyOffset_DecayHeight_DEPRECATED;

		// Token: 0x040037B2 RID: 14258
		internal static int __PropertyOffset_MaxScatteringOrder;

		// Token: 0x040037B3 RID: 14259
		internal static int __PropertyOffset_TransmittanceTexWidth;

		// Token: 0x040037B4 RID: 14260
		internal static int __PropertyOffset_TransmittanceTexHeight;

		// Token: 0x040037B5 RID: 14261
		internal static int __PropertyOffset_IrradianceTexWidth;

		// Token: 0x040037B6 RID: 14262
		internal static int __PropertyOffset_IrradianceTexHeight;

		// Token: 0x040037B7 RID: 14263
		internal static int __PropertyOffset_InscatterAltitudeSampleNum;

		// Token: 0x040037B8 RID: 14264
		internal static int __PropertyOffset_InscatterMuNum;

		// Token: 0x040037B9 RID: 14265
		internal static int __PropertyOffset_InscatterMuSNum;

		// Token: 0x040037BA RID: 14266
		internal static int __PropertyOffset_InscatterNuNum;
	}
}
