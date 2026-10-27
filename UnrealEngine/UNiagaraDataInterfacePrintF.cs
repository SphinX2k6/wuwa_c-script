using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002580 RID: 9600
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfacePrintF")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfacePrintF : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A12 RID: 145938 RVA: 0x0034ABF5 File Offset: 0x00348DF5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfacePrintF._ClassPtr;
		}

		// Token: 0x06023A13 RID: 145939 RVA: 0x0034AC04 File Offset: 0x00348E04
		public UNiagaraDataInterfacePrintF() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfacePrintF.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A14 RID: 145940 RVA: 0x0034AC2C File Offset: 0x00348E2C
		[NullableContext(1)]
		public UNiagaraDataInterfacePrintF(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfacePrintF.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088BA RID: 35002
		// (get) Token: 0x06023A15 RID: 145941 RVA: 0x0034AC5F File Offset: 0x00348E5F
		// (set) Token: 0x06023A16 RID: 145942 RVA: 0x0034AC6F File Offset: 0x00348E6F
		public unsafe int ParticleIndexToDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_ParticleIndexToDisplay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_ParticleIndexToDisplay) = value;
			}
		}

		// Token: 0x170088BB RID: 35003
		// (get) Token: 0x06023A17 RID: 145943 RVA: 0x0034AC80 File Offset: 0x00348E80
		// (set) Token: 0x06023A18 RID: 145944 RVA: 0x0034AC90 File Offset: 0x00348E90
		public unsafe bool bDisplayAll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_bDisplayAll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_bDisplayAll) = (value ? 1 : 0);
			}
		}

		// Token: 0x170088BC RID: 35004
		// (get) Token: 0x06023A19 RID: 145945 RVA: 0x0034ACA1 File Offset: 0x00348EA1
		// (set) Token: 0x06023A1A RID: 145946 RVA: 0x0034ACB1 File Offset: 0x00348EB1
		public unsafe int MaxParticlesToDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_MaxParticlesToDisplay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_MaxParticlesToDisplay) = value;
			}
		}

		// Token: 0x170088BD RID: 35005
		// (get) Token: 0x06023A1B RID: 145947 RVA: 0x0034ACC2 File Offset: 0x00348EC2
		// (set) Token: 0x06023A1C RID: 145948 RVA: 0x0034ACD2 File Offset: 0x00348ED2
		public unsafe int DebugLineKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_DebugLineKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_DebugLineKey) = value;
			}
		}

		// Token: 0x170088BE RID: 35006
		// (get) Token: 0x06023A1D RID: 145949 RVA: 0x0034ACE3 File Offset: 0x00348EE3
		// (set) Token: 0x06023A1E RID: 145950 RVA: 0x0034ACF7 File Offset: 0x00348EF7
		public unsafe FLinearColor DisplayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_DisplayColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_DisplayColor) = value;
			}
		}

		// Token: 0x170088BF RID: 35007
		// (get) Token: 0x06023A1F RID: 145951 RVA: 0x0034AD0C File Offset: 0x00348F0C
		// (set) Token: 0x06023A20 RID: 145952 RVA: 0x0034AD1C File Offset: 0x00348F1C
		public unsafe float DisplayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_DisplayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfacePrintF.__PropertyOffset_DisplayTime) = value;
			}
		}

		// Token: 0x06023A21 RID: 145953 RVA: 0x0034AD2D File Offset: 0x00348F2D
		static UNiagaraDataInterfacePrintF()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfacePrintF");
		}

		// Token: 0x06023A22 RID: 145954 RVA: 0x0034AD3B File Offset: 0x00348F3B
		protected UNiagaraDataInterfacePrintF(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401319B RID: 78235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfacePrintF";

		// Token: 0x0401319C RID: 78236
		private static IntPtr _ClassPtr;

		// Token: 0x0401319D RID: 78237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401319E RID: 78238
		internal static int __PropertyOffset_ParticleIndexToDisplay;

		// Token: 0x0401319F RID: 78239
		internal static int __PropertyOffset_bDisplayAll;

		// Token: 0x040131A0 RID: 78240
		internal static int __PropertyOffset_MaxParticlesToDisplay;

		// Token: 0x040131A1 RID: 78241
		internal static int __PropertyOffset_DebugLineKey;

		// Token: 0x040131A2 RID: 78242
		internal static int __PropertyOffset_DisplayColor;

		// Token: 0x040131A3 RID: 78243
		internal static int __PropertyOffset_DisplayTime;
	}
}
