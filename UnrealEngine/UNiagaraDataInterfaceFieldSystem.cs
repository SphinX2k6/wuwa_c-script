using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000447 RID: 1095
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ChaosNiagara.NiagaraDataInterfaceFieldSystem")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UNiagaraDataInterfaceFieldSystem : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003B26 RID: 15142 RVA: 0x000593DE File Offset: 0x000575DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceFieldSystem._ClassPtr;
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x000593EC File Offset: 0x000575EC
		public UNiagaraDataInterfaceFieldSystem() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceFieldSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00059414 File Offset: 0x00057614
		[NullableContext(1)]
		public UNiagaraDataInterfaceFieldSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceFieldSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06003B29 RID: 15145 RVA: 0x00059447 File Offset: 0x00057647
		// (set) Token: 0x06003B2A RID: 15146 RVA: 0x0005945B File Offset: 0x0005765B
		public unsafe UBlueprint BlueprintSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlueprint>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceFieldSystem.__PropertyOffset_BlueprintSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceFieldSystem.__PropertyOffset_BlueprintSource, value);
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x00059470 File Offset: 0x00057670
		// (set) Token: 0x06003B2C RID: 15148 RVA: 0x00059484 File Offset: 0x00057684
		public unsafe AActor SourceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceFieldSystem.__PropertyOffset_SourceActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceFieldSystem.__PropertyOffset_SourceActor, value);
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x00059499 File Offset: 0x00057699
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x000594AD File Offset: 0x000576AD
		public unsafe FIntVector FieldDimensions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceFieldSystem.__PropertyOffset_FieldDimensions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceFieldSystem.__PropertyOffset_FieldDimensions) = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x000594C2 File Offset: 0x000576C2
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x000594D6 File Offset: 0x000576D6
		public unsafe FVector MinBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceFieldSystem.__PropertyOffset_MinBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceFieldSystem.__PropertyOffset_MinBounds) = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x000594EB File Offset: 0x000576EB
		// (set) Token: 0x06003B32 RID: 15154 RVA: 0x000594FF File Offset: 0x000576FF
		public unsafe FVector MaxBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceFieldSystem.__PropertyOffset_MaxBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceFieldSystem.__PropertyOffset_MaxBounds) = value;
			}
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x00059514 File Offset: 0x00057714
		static UNiagaraDataInterfaceFieldSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosNiagara.NiagaraDataInterfaceFieldSystem");
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00059522 File Offset: 0x00057722
		protected UNiagaraDataInterfaceFieldSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B39 RID: 6969
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosNiagara.NiagaraDataInterfaceFieldSystem";

		// Token: 0x04001B3A RID: 6970
		private static IntPtr _ClassPtr;

		// Token: 0x04001B3B RID: 6971
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B3C RID: 6972
		internal static int __PropertyOffset_BlueprintSource;

		// Token: 0x04001B3D RID: 6973
		internal static int __PropertyOffset_SourceActor;

		// Token: 0x04001B3E RID: 6974
		internal static int __PropertyOffset_FieldDimensions;

		// Token: 0x04001B3F RID: 6975
		internal static int __PropertyOffset_MinBounds;

		// Token: 0x04001B40 RID: 6976
		internal static int __PropertyOffset_MaxBounds;
	}
}
