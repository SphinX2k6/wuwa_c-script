using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002587 RID: 9607
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceSpline")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UNiagaraDataInterfaceSpline : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A7A RID: 146042 RVA: 0x0034B6DD File Offset: 0x003498DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceSpline._ClassPtr;
		}

		// Token: 0x06023A7B RID: 146043 RVA: 0x0034B6EC File Offset: 0x003498EC
		public UNiagaraDataInterfaceSpline() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceSpline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A7C RID: 146044 RVA: 0x0034B714 File Offset: 0x00349914
		[NullableContext(1)]
		public UNiagaraDataInterfaceSpline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088DD RID: 35037
		// (get) Token: 0x06023A7D RID: 146045 RVA: 0x0034B747 File Offset: 0x00349947
		// (set) Token: 0x06023A7E RID: 146046 RVA: 0x0034B75B File Offset: 0x0034995B
		[Nullable(2)]
		public unsafe AActor Source
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceSpline.__PropertyOffset_Source);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceSpline.__PropertyOffset_Source, value);
			}
		}

		// Token: 0x170088DE RID: 35038
		// (get) Token: 0x06023A7F RID: 146047 RVA: 0x0034B770 File Offset: 0x00349970
		// (set) Token: 0x06023A80 RID: 146048 RVA: 0x0034B780 File Offset: 0x00349980
		public unsafe bool bUseLUT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSpline.__PropertyOffset_bUseLUT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSpline.__PropertyOffset_bUseLUT) = (value ? 1 : 0);
			}
		}

		// Token: 0x170088DF RID: 35039
		// (get) Token: 0x06023A81 RID: 146049 RVA: 0x0034B791 File Offset: 0x00349991
		// (set) Token: 0x06023A82 RID: 146050 RVA: 0x0034B7A1 File Offset: 0x003499A1
		public unsafe int NumLUTSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSpline.__PropertyOffset_NumLUTSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSpline.__PropertyOffset_NumLUTSteps) = value;
			}
		}

		// Token: 0x06023A83 RID: 146051 RVA: 0x0034B7B2 File Offset: 0x003499B2
		static UNiagaraDataInterfaceSpline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceSpline");
		}

		// Token: 0x06023A84 RID: 146052 RVA: 0x0034B7C0 File Offset: 0x003499C0
		protected UNiagaraDataInterfaceSpline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131E3 RID: 78307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceSpline";

		// Token: 0x040131E4 RID: 78308
		private static IntPtr _ClassPtr;

		// Token: 0x040131E5 RID: 78309
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131E6 RID: 78310
		internal static int __PropertyOffset_Source;

		// Token: 0x040131E7 RID: 78311
		internal static int __PropertyOffset_bUseLUT;

		// Token: 0x040131E8 RID: 78312
		internal static int __PropertyOffset_NumLUTSteps;
	}
}
