using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200258E RID: 9614
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceVectorField")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UNiagaraDataInterfaceVectorField : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023AD6 RID: 146134 RVA: 0x0034C129 File Offset: 0x0034A329
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceVectorField._ClassPtr;
		}

		// Token: 0x06023AD7 RID: 146135 RVA: 0x0034C138 File Offset: 0x0034A338
		public UNiagaraDataInterfaceVectorField() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVectorField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023AD8 RID: 146136 RVA: 0x0034C160 File Offset: 0x0034A360
		[NullableContext(1)]
		public UNiagaraDataInterfaceVectorField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVectorField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088F8 RID: 35064
		// (get) Token: 0x06023AD9 RID: 146137 RVA: 0x0034C193 File Offset: 0x0034A393
		// (set) Token: 0x06023ADA RID: 146138 RVA: 0x0034C1A7 File Offset: 0x0034A3A7
		public unsafe UVectorField Field
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorField>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceVectorField.__PropertyOffset_Field);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceVectorField.__PropertyOffset_Field, value);
			}
		}

		// Token: 0x170088F9 RID: 35065
		// (get) Token: 0x06023ADB RID: 146139 RVA: 0x0034C1BC File Offset: 0x0034A3BC
		// (set) Token: 0x06023ADC RID: 146140 RVA: 0x0034C1D0 File Offset: 0x0034A3D0
		public unsafe UVectorField LowQualityField
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorField>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceVectorField.__PropertyOffset_LowQualityField);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceVectorField.__PropertyOffset_LowQualityField, value);
			}
		}

		// Token: 0x170088FA RID: 35066
		// (get) Token: 0x06023ADD RID: 146141 RVA: 0x0034C1E5 File Offset: 0x0034A3E5
		// (set) Token: 0x06023ADE RID: 146142 RVA: 0x0034C1F5 File Offset: 0x0034A3F5
		public unsafe bool bTileX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorField.__PropertyOffset_bTileX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorField.__PropertyOffset_bTileX) = (value ? 1 : 0);
			}
		}

		// Token: 0x170088FB RID: 35067
		// (get) Token: 0x06023ADF RID: 146143 RVA: 0x0034C206 File Offset: 0x0034A406
		// (set) Token: 0x06023AE0 RID: 146144 RVA: 0x0034C216 File Offset: 0x0034A416
		public unsafe bool bTileY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorField.__PropertyOffset_bTileY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorField.__PropertyOffset_bTileY) = (value ? 1 : 0);
			}
		}

		// Token: 0x170088FC RID: 35068
		// (get) Token: 0x06023AE1 RID: 146145 RVA: 0x0034C227 File Offset: 0x0034A427
		// (set) Token: 0x06023AE2 RID: 146146 RVA: 0x0034C237 File Offset: 0x0034A437
		public unsafe bool bTileZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorField.__PropertyOffset_bTileZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorField.__PropertyOffset_bTileZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023AE3 RID: 146147 RVA: 0x0034C248 File Offset: 0x0034A448
		static UNiagaraDataInterfaceVectorField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceVectorField");
		}

		// Token: 0x06023AE4 RID: 146148 RVA: 0x0034C256 File Offset: 0x0034A456
		protected UNiagaraDataInterfaceVectorField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013220 RID: 78368
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceVectorField";

		// Token: 0x04013221 RID: 78369
		private static IntPtr _ClassPtr;

		// Token: 0x04013222 RID: 78370
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013223 RID: 78371
		internal static int __PropertyOffset_Field;

		// Token: 0x04013224 RID: 78372
		internal static int __PropertyOffset_LowQualityField;

		// Token: 0x04013225 RID: 78373
		internal static int __PropertyOffset_bTileX;

		// Token: 0x04013226 RID: 78374
		internal static int __PropertyOffset_bTileY;

		// Token: 0x04013227 RID: 78375
		internal static int __PropertyOffset_bTileZ;
	}
}
