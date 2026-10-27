using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002589 RID: 9609
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceStaticMesh")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UNiagaraDataInterfaceStaticMesh : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A9B RID: 146075 RVA: 0x0034B9E6 File Offset: 0x00349BE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceStaticMesh._ClassPtr;
		}

		// Token: 0x06023A9C RID: 146076 RVA: 0x0034B9F4 File Offset: 0x00349BF4
		public UNiagaraDataInterfaceStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A9D RID: 146077 RVA: 0x0034BA1C File Offset: 0x00349C1C
		[NullableContext(1)]
		public UNiagaraDataInterfaceStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088E7 RID: 35047
		// (get) Token: 0x06023A9E RID: 146078 RVA: 0x0034BA4F File Offset: 0x00349C4F
		// (set) Token: 0x06023A9F RID: 146079 RVA: 0x0034BA5F File Offset: 0x00349C5F
		public unsafe ENDIStaticMesh_SourceMode SourceMode
		{
			get
			{
				return (ENDIStaticMesh_SourceMode)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceStaticMesh.__PropertyOffset_SourceMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceStaticMesh.__PropertyOffset_SourceMode) = (byte)value;
			}
		}

		// Token: 0x170088E8 RID: 35048
		// (get) Token: 0x06023AA0 RID: 146080 RVA: 0x0034BA70 File Offset: 0x00349C70
		// (set) Token: 0x06023AA1 RID: 146081 RVA: 0x0034BA84 File Offset: 0x00349C84
		public unsafe UStaticMesh DefaultMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceStaticMesh.__PropertyOffset_DefaultMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceStaticMesh.__PropertyOffset_DefaultMesh, value);
			}
		}

		// Token: 0x170088E9 RID: 35049
		// (get) Token: 0x06023AA2 RID: 146082 RVA: 0x0034BA99 File Offset: 0x00349C99
		// (set) Token: 0x06023AA3 RID: 146083 RVA: 0x0034BAAD File Offset: 0x00349CAD
		public unsafe AActor Source
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceStaticMesh.__PropertyOffset_Source);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceStaticMesh.__PropertyOffset_Source, value);
			}
		}

		// Token: 0x170088EA RID: 35050
		// (get) Token: 0x06023AA4 RID: 146084 RVA: 0x0034BAC2 File Offset: 0x00349CC2
		// (set) Token: 0x06023AA5 RID: 146085 RVA: 0x0034BAD6 File Offset: 0x00349CD6
		public unsafe UStaticMeshComponent SourceComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceStaticMesh.__PropertyOffset_SourceComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceStaticMesh.__PropertyOffset_SourceComponent, value);
			}
		}

		// Token: 0x170088EB RID: 35051
		// (get) Token: 0x06023AA6 RID: 146086 RVA: 0x0034BAEC File Offset: 0x00349CEC
		// (set) Token: 0x06023AA7 RID: 146087 RVA: 0x0034BB25 File Offset: 0x00349D25
		[Nullable(1)]
		public FNDIStaticMeshSectionFilter SectionFilter
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNDIStaticMeshSectionFilter result;
				if ((result = this._SectionFilter) == null)
				{
					result = (this._SectionFilter = new FNDIStaticMeshSectionFilter(base.NativePtr + (IntPtr)UNiagaraDataInterfaceStaticMesh.__PropertyOffset_SectionFilter, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNDIStaticMeshSectionFilter.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceStaticMesh.__PropertyOffset_SectionFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088EC RID: 35052
		// (get) Token: 0x06023AA8 RID: 146088 RVA: 0x0034BB46 File Offset: 0x00349D46
		// (set) Token: 0x06023AA9 RID: 146089 RVA: 0x0034BB56 File Offset: 0x00349D56
		public unsafe bool bUsePhysicsBodyVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceStaticMesh.__PropertyOffset_bUsePhysicsBodyVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceStaticMesh.__PropertyOffset_bUsePhysicsBodyVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170088ED RID: 35053
		// (get) Token: 0x06023AAA RID: 146090 RVA: 0x0034BB68 File Offset: 0x00349D68
		// (set) Token: 0x06023AAB RID: 146091 RVA: 0x0034BBA1 File Offset: 0x00349DA1
		[Nullable(1)]
		public TArray<FName> FilteredSockets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FilteredSockets) == null)
				{
					result = (this._FilteredSockets = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceStaticMesh.__PropertyOffset_FilteredSockets, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FilteredSockets.CopyAssign(value);
			}
		}

		// Token: 0x06023AAC RID: 146092 RVA: 0x0034BBAF File Offset: 0x00349DAF
		static UNiagaraDataInterfaceStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceStaticMesh");
		}

		// Token: 0x06023AAD RID: 146093 RVA: 0x0034BBBD File Offset: 0x00349DBD
		protected UNiagaraDataInterfaceStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131F5 RID: 78325
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceStaticMesh";

		// Token: 0x040131F6 RID: 78326
		private static IntPtr _ClassPtr;

		// Token: 0x040131F7 RID: 78327
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131F8 RID: 78328
		internal static int __PropertyOffset_SourceMode;

		// Token: 0x040131F9 RID: 78329
		internal static int __PropertyOffset_DefaultMesh;

		// Token: 0x040131FA RID: 78330
		internal static int __PropertyOffset_Source;

		// Token: 0x040131FB RID: 78331
		internal static int __PropertyOffset_SourceComponent;

		// Token: 0x040131FC RID: 78332
		internal static int __PropertyOffset_SectionFilter;

		// Token: 0x040131FD RID: 78333
		private FNDIStaticMeshSectionFilter _SectionFilter;

		// Token: 0x040131FE RID: 78334
		internal static int __PropertyOffset_bUsePhysicsBodyVelocity;

		// Token: 0x040131FF RID: 78335
		internal static int __PropertyOffset_FilteredSockets;

		// Token: 0x04013200 RID: 78336
		private TArray<FName> _FilteredSockets;
	}
}
