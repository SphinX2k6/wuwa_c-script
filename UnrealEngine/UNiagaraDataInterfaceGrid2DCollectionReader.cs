using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002577 RID: 9591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceGrid2DCollectionReader")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UNiagaraDataInterfaceGrid2DCollectionReader : UNiagaraDataInterfaceGrid2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239B8 RID: 145848 RVA: 0x0034A349 File Offset: 0x00348549
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceGrid2DCollectionReader._ClassPtr;
		}

		// Token: 0x060239B9 RID: 145849 RVA: 0x0034A358 File Offset: 0x00348558
		public UNiagaraDataInterfaceGrid2DCollectionReader() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid2DCollectionReader.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239BA RID: 145850 RVA: 0x0034A380 File Offset: 0x00348580
		public UNiagaraDataInterfaceGrid2DCollectionReader(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid2DCollectionReader.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088A7 RID: 34983
		// (get) Token: 0x060239BB RID: 145851 RVA: 0x0034A3B3 File Offset: 0x003485B3
		// (set) Token: 0x060239BC RID: 145852 RVA: 0x0034A3C7 File Offset: 0x003485C7
		public unsafe string EmitterName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraDataInterfaceGrid2DCollectionReader.__PropertyOffset_EmitterName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraDataInterfaceGrid2DCollectionReader.__PropertyOffset_EmitterName)), value);
			}
		}

		// Token: 0x170088A8 RID: 34984
		// (get) Token: 0x060239BD RID: 145853 RVA: 0x0034A3DC File Offset: 0x003485DC
		// (set) Token: 0x060239BE RID: 145854 RVA: 0x0034A3F0 File Offset: 0x003485F0
		public unsafe string DIName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraDataInterfaceGrid2DCollectionReader.__PropertyOffset_DIName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraDataInterfaceGrid2DCollectionReader.__PropertyOffset_DIName)), value);
			}
		}

		// Token: 0x060239BF RID: 145855 RVA: 0x0034A405 File Offset: 0x00348605
		static UNiagaraDataInterfaceGrid2DCollectionReader()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceGrid2DCollectionReader");
		}

		// Token: 0x060239C0 RID: 145856 RVA: 0x0034A413 File Offset: 0x00348613
		protected UNiagaraDataInterfaceGrid2DCollectionReader(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401316A RID: 78186
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceGrid2DCollectionReader";

		// Token: 0x0401316B RID: 78187
		private static IntPtr _ClassPtr;

		// Token: 0x0401316C RID: 78188
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401316D RID: 78189
		internal static int __PropertyOffset_EmitterName;

		// Token: 0x0401316E RID: 78190
		internal static int __PropertyOffset_DIName;
	}
}
