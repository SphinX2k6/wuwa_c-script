using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200257C RID: 9596
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceNeighborGrid3D")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UNiagaraDataInterfaceNeighborGrid3D : UNiagaraDataInterfaceGrid3D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239F8 RID: 145912 RVA: 0x0034A951 File Offset: 0x00348B51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceNeighborGrid3D._ClassPtr;
		}

		// Token: 0x060239F9 RID: 145913 RVA: 0x0034A960 File Offset: 0x00348B60
		public UNiagaraDataInterfaceNeighborGrid3D() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceNeighborGrid3D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239FA RID: 145914 RVA: 0x0034A988 File Offset: 0x00348B88
		[NullableContext(1)]
		public UNiagaraDataInterfaceNeighborGrid3D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceNeighborGrid3D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088B7 RID: 34999
		// (get) Token: 0x060239FB RID: 145915 RVA: 0x0034A9BB File Offset: 0x00348BBB
		// (set) Token: 0x060239FC RID: 145916 RVA: 0x0034A9CB File Offset: 0x00348BCB
		public unsafe uint MaxNeighborsPerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceNeighborGrid3D.__PropertyOffset_MaxNeighborsPerCell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceNeighborGrid3D.__PropertyOffset_MaxNeighborsPerCell) = (int)value;
			}
		}

		// Token: 0x060239FD RID: 145917 RVA: 0x0034A9DC File Offset: 0x00348BDC
		static UNiagaraDataInterfaceNeighborGrid3D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceNeighborGrid3D");
		}

		// Token: 0x060239FE RID: 145918 RVA: 0x0034A9EA File Offset: 0x00348BEA
		protected UNiagaraDataInterfaceNeighborGrid3D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401318B RID: 78219
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceNeighborGrid3D";

		// Token: 0x0401318C RID: 78220
		private static IntPtr _ClassPtr;

		// Token: 0x0401318D RID: 78221
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401318E RID: 78222
		internal static int __PropertyOffset_MaxNeighborsPerCell;
	}
}
