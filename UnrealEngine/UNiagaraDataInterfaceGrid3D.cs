using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002578 RID: 9592
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceGrid3D")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public abstract class UNiagaraDataInterfaceGrid3D : UNiagaraDataInterfaceRWBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239C1 RID: 145857 RVA: 0x0034A41C File Offset: 0x0034861C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceGrid3D._ClassPtr;
		}

		// Token: 0x170088A9 RID: 34985
		// (get) Token: 0x060239C2 RID: 145858 RVA: 0x0034A428 File Offset: 0x00348628
		// (set) Token: 0x060239C3 RID: 145859 RVA: 0x0034A43C File Offset: 0x0034863C
		public unsafe FIntVector NumCells
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_NumCells);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_NumCells) = value;
			}
		}

		// Token: 0x170088AA RID: 34986
		// (get) Token: 0x060239C4 RID: 145860 RVA: 0x0034A451 File Offset: 0x00348651
		// (set) Token: 0x060239C5 RID: 145861 RVA: 0x0034A461 File Offset: 0x00348661
		public unsafe float CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x170088AB RID: 34987
		// (get) Token: 0x060239C6 RID: 145862 RVA: 0x0034A472 File Offset: 0x00348672
		// (set) Token: 0x060239C7 RID: 145863 RVA: 0x0034A482 File Offset: 0x00348682
		public unsafe int NumCellsMaxAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_NumCellsMaxAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_NumCellsMaxAxis) = value;
			}
		}

		// Token: 0x170088AC RID: 34988
		// (get) Token: 0x060239C8 RID: 145864 RVA: 0x0034A493 File Offset: 0x00348693
		// (set) Token: 0x060239C9 RID: 145865 RVA: 0x0034A4A3 File Offset: 0x003486A3
		public unsafe ESetResolutionMethod SetResolutionMethod
		{
			get
			{
				return (ESetResolutionMethod)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_SetResolutionMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_SetResolutionMethod) = (int)value;
			}
		}

		// Token: 0x170088AD RID: 34989
		// (get) Token: 0x060239CA RID: 145866 RVA: 0x0034A4B4 File Offset: 0x003486B4
		// (set) Token: 0x060239CB RID: 145867 RVA: 0x0034A4C8 File Offset: 0x003486C8
		public unsafe FVector WorldBBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_WorldBBoxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3D.__PropertyOffset_WorldBBoxSize) = value;
			}
		}

		// Token: 0x060239CC RID: 145868 RVA: 0x0034A4DD File Offset: 0x003486DD
		static UNiagaraDataInterfaceGrid3D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceGrid3D");
		}

		// Token: 0x060239CD RID: 145869 RVA: 0x0034A4EC File Offset: 0x003486EC
		protected UNiagaraDataInterfaceGrid3D() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid3D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239CE RID: 145870 RVA: 0x0034A514 File Offset: 0x00348714
		protected UNiagaraDataInterfaceGrid3D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401316F RID: 78191
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceGrid3D";

		// Token: 0x04013170 RID: 78192
		private static IntPtr _ClassPtr;

		// Token: 0x04013171 RID: 78193
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013172 RID: 78194
		internal static int __PropertyOffset_NumCells;

		// Token: 0x04013173 RID: 78195
		internal static int __PropertyOffset_CellSize;

		// Token: 0x04013174 RID: 78196
		internal static int __PropertyOffset_NumCellsMaxAxis;

		// Token: 0x04013175 RID: 78197
		internal static int __PropertyOffset_SetResolutionMethod;

		// Token: 0x04013176 RID: 78198
		internal static int __PropertyOffset_WorldBBoxSize;
	}
}
