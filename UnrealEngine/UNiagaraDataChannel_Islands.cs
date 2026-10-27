using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002558 RID: 9560
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannel_Islands")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UNiagaraDataChannel_Islands : UNiagaraDataChannel, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602384C RID: 145484 RVA: 0x00348012 File Offset: 0x00346212
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannel_Islands._ClassPtr;
		}

		// Token: 0x0602384D RID: 145485 RVA: 0x00348020 File Offset: 0x00346220
		public UNiagaraDataChannel_Islands() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Islands.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602384E RID: 145486 RVA: 0x00348048 File Offset: 0x00346248
		public UNiagaraDataChannel_Islands(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Islands.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008851 RID: 34897
		// (get) Token: 0x0602384F RID: 145487 RVA: 0x0034807B File Offset: 0x0034627B
		// (set) Token: 0x06023850 RID: 145488 RVA: 0x0034808B File Offset: 0x0034628B
		public unsafe ENiagraDataChannel_IslandMode Mode
		{
			get
			{
				return (ENiagraDataChannel_IslandMode)(*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17008852 RID: 34898
		// (get) Token: 0x06023851 RID: 145489 RVA: 0x0034809C File Offset: 0x0034629C
		// (set) Token: 0x06023852 RID: 145490 RVA: 0x003480B0 File Offset: 0x003462B0
		public unsafe FVector InitialExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_InitialExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_InitialExtents) = value;
			}
		}

		// Token: 0x17008853 RID: 34899
		// (get) Token: 0x06023853 RID: 145491 RVA: 0x003480C5 File Offset: 0x003462C5
		// (set) Token: 0x06023854 RID: 145492 RVA: 0x003480D9 File Offset: 0x003462D9
		public unsafe FVector MaxExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_MaxExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_MaxExtents) = value;
			}
		}

		// Token: 0x17008854 RID: 34900
		// (get) Token: 0x06023855 RID: 145493 RVA: 0x003480EE File Offset: 0x003462EE
		// (set) Token: 0x06023856 RID: 145494 RVA: 0x00348102 File Offset: 0x00346302
		public unsafe FVector PerElementExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_PerElementExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_PerElementExtents) = value;
			}
		}

		// Token: 0x17008855 RID: 34901
		// (get) Token: 0x06023857 RID: 145495 RVA: 0x00348118 File Offset: 0x00346318
		// (set) Token: 0x06023858 RID: 145496 RVA: 0x00348151 File Offset: 0x00346351
		public TArray<TSoftObjectPtr<UNiagaraSystem>> Systems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UNiagaraSystem>> result;
				if ((result = this._Systems) == null)
				{
					result = (this._Systems = new TArray<TSoftObjectPtr<UNiagaraSystem>>(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_Systems, this));
				}
				return result;
			}
			set
			{
				this.Systems.CopyAssign(value);
			}
		}

		// Token: 0x17008856 RID: 34902
		// (get) Token: 0x06023859 RID: 145497 RVA: 0x0034815F File Offset: 0x0034635F
		// (set) Token: 0x0602385A RID: 145498 RVA: 0x0034816F File Offset: 0x0034636F
		public unsafe int IslandPoolSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_IslandPoolSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_IslandPoolSize) = value;
			}
		}

		// Token: 0x17008857 RID: 34903
		// (get) Token: 0x0602385B RID: 145499 RVA: 0x00348180 File Offset: 0x00346380
		// (set) Token: 0x0602385C RID: 145500 RVA: 0x003481B9 File Offset: 0x003463B9
		public FNDCIslandDebugDrawSettings DebugDrawSettings
		{
			get
			{
				base.FastCheckIsValid();
				FNDCIslandDebugDrawSettings result;
				if ((result = this._DebugDrawSettings) == null)
				{
					result = (this._DebugDrawSettings = new FNDCIslandDebugDrawSettings(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_DebugDrawSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNDCIslandDebugDrawSettings.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_DebugDrawSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008858 RID: 34904
		// (get) Token: 0x0602385D RID: 145501 RVA: 0x003481DC File Offset: 0x003463DC
		// (set) Token: 0x0602385E RID: 145502 RVA: 0x00348215 File Offset: 0x00346415
		public TArray<UNiagaraSystem> SystemsInternal
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSystem> result;
				if ((result = this._SystemsInternal) == null)
				{
					result = (this._SystemsInternal = new TArray<UNiagaraSystem>(base.NativePtr + (IntPtr)UNiagaraDataChannel_Islands.__PropertyOffset_SystemsInternal, this));
				}
				return result;
			}
			set
			{
				this.SystemsInternal.CopyAssign(value);
			}
		}

		// Token: 0x0602385F RID: 145503 RVA: 0x00348223 File Offset: 0x00346423
		static UNiagaraDataChannel_Islands()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannel_Islands");
		}

		// Token: 0x06023860 RID: 145504 RVA: 0x00348231 File Offset: 0x00346431
		protected UNiagaraDataChannel_Islands(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013099 RID: 77977
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannel_Islands";

		// Token: 0x0401309A RID: 77978
		private static IntPtr _ClassPtr;

		// Token: 0x0401309B RID: 77979
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401309C RID: 77980
		internal static int __PropertyOffset_Mode;

		// Token: 0x0401309D RID: 77981
		internal static int __PropertyOffset_InitialExtents;

		// Token: 0x0401309E RID: 77982
		internal static int __PropertyOffset_MaxExtents;

		// Token: 0x0401309F RID: 77983
		internal static int __PropertyOffset_PerElementExtents;

		// Token: 0x040130A0 RID: 77984
		internal static int __PropertyOffset_Systems;

		// Token: 0x040130A1 RID: 77985
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UNiagaraSystem>> _Systems;

		// Token: 0x040130A2 RID: 77986
		internal static int __PropertyOffset_IslandPoolSize;

		// Token: 0x040130A3 RID: 77987
		internal static int __PropertyOffset_DebugDrawSettings;

		// Token: 0x040130A4 RID: 77988
		[Nullable(2)]
		private FNDCIslandDebugDrawSettings _DebugDrawSettings;

		// Token: 0x040130A5 RID: 77989
		internal static int __PropertyOffset_SystemsInternal;

		// Token: 0x040130A6 RID: 77990
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _SystemsInternal;
	}
}
