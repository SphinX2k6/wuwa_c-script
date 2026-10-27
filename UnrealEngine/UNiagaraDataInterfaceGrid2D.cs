using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002575 RID: 9589
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceGrid2D")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public abstract class UNiagaraDataInterfaceGrid2D : UNiagaraDataInterfaceRWBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023993 RID: 145811 RVA: 0x00349FB6 File Offset: 0x003481B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceGrid2D._ClassPtr;
		}

		// Token: 0x1700889D RID: 34973
		// (get) Token: 0x06023994 RID: 145812 RVA: 0x00349FC2 File Offset: 0x003481C2
		// (set) Token: 0x06023995 RID: 145813 RVA: 0x00349FD2 File Offset: 0x003481D2
		public unsafe int NumCellsX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumCellsX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumCellsX) = value;
			}
		}

		// Token: 0x1700889E RID: 34974
		// (get) Token: 0x06023996 RID: 145814 RVA: 0x00349FE3 File Offset: 0x003481E3
		// (set) Token: 0x06023997 RID: 145815 RVA: 0x00349FF3 File Offset: 0x003481F3
		public unsafe int NumCellsY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumCellsY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumCellsY) = value;
			}
		}

		// Token: 0x1700889F RID: 34975
		// (get) Token: 0x06023998 RID: 145816 RVA: 0x0034A004 File Offset: 0x00348204
		// (set) Token: 0x06023999 RID: 145817 RVA: 0x0034A014 File Offset: 0x00348214
		public unsafe int NumCellsMaxAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumCellsMaxAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumCellsMaxAxis) = value;
			}
		}

		// Token: 0x170088A0 RID: 34976
		// (get) Token: 0x0602399A RID: 145818 RVA: 0x0034A025 File Offset: 0x00348225
		// (set) Token: 0x0602399B RID: 145819 RVA: 0x0034A035 File Offset: 0x00348235
		public unsafe int NumAttributes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumAttributes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_NumAttributes) = value;
			}
		}

		// Token: 0x170088A1 RID: 34977
		// (get) Token: 0x0602399C RID: 145820 RVA: 0x0034A046 File Offset: 0x00348246
		// (set) Token: 0x0602399D RID: 145821 RVA: 0x0034A056 File Offset: 0x00348256
		public unsafe bool SetGridFromMaxAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_SetGridFromMaxAxis) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_SetGridFromMaxAxis) = (value ? 1 : 0);
			}
		}

		// Token: 0x170088A2 RID: 34978
		// (get) Token: 0x0602399E RID: 145822 RVA: 0x0034A067 File Offset: 0x00348267
		// (set) Token: 0x0602399F RID: 145823 RVA: 0x0034A07B File Offset: 0x0034827B
		public unsafe FVector2D WorldBBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_WorldBBoxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2D.__PropertyOffset_WorldBBoxSize) = value;
			}
		}

		// Token: 0x060239A0 RID: 145824 RVA: 0x0034A090 File Offset: 0x00348290
		static UNiagaraDataInterfaceGrid2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceGrid2D");
		}

		// Token: 0x060239A1 RID: 145825 RVA: 0x0034A0A0 File Offset: 0x003482A0
		protected UNiagaraDataInterfaceGrid2D() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239A2 RID: 145826 RVA: 0x0034A0C8 File Offset: 0x003482C8
		protected UNiagaraDataInterfaceGrid2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013157 RID: 78167
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceGrid2D";

		// Token: 0x04013158 RID: 78168
		private static IntPtr _ClassPtr;

		// Token: 0x04013159 RID: 78169
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401315A RID: 78170
		internal static int __PropertyOffset_NumCellsX;

		// Token: 0x0401315B RID: 78171
		internal static int __PropertyOffset_NumCellsY;

		// Token: 0x0401315C RID: 78172
		internal static int __PropertyOffset_NumCellsMaxAxis;

		// Token: 0x0401315D RID: 78173
		internal static int __PropertyOffset_NumAttributes;

		// Token: 0x0401315E RID: 78174
		internal static int __PropertyOffset_SetGridFromMaxAxis;

		// Token: 0x0401315F RID: 78175
		internal static int __PropertyOffset_WorldBBoxSize;
	}
}
