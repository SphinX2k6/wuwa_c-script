using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002559 RID: 9561
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannel_Placement")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UNiagaraDataChannel_Placement : UNiagaraDataChannel, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023861 RID: 145505 RVA: 0x0034823A File Offset: 0x0034643A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannel_Placement._ClassPtr;
		}

		// Token: 0x06023862 RID: 145506 RVA: 0x00348248 File Offset: 0x00346448
		public UNiagaraDataChannel_Placement() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Placement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023863 RID: 145507 RVA: 0x00348270 File Offset: 0x00346470
		public UNiagaraDataChannel_Placement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Placement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008859 RID: 34905
		// (get) Token: 0x06023864 RID: 145508 RVA: 0x003482A3 File Offset: 0x003464A3
		// (set) Token: 0x06023865 RID: 145509 RVA: 0x003482B3 File Offset: 0x003464B3
		public unsafe ENiagraDataChannel_PlacementMode Mode
		{
			get
			{
				return (ENiagraDataChannel_PlacementMode)(*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x1700885A RID: 34906
		// (get) Token: 0x06023866 RID: 145510 RVA: 0x003482C4 File Offset: 0x003464C4
		// (set) Token: 0x06023867 RID: 145511 RVA: 0x003482D8 File Offset: 0x003464D8
		public unsafe FVector InitialExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_InitialExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_InitialExtents) = value;
			}
		}

		// Token: 0x1700885B RID: 34907
		// (get) Token: 0x06023868 RID: 145512 RVA: 0x003482ED File Offset: 0x003464ED
		// (set) Token: 0x06023869 RID: 145513 RVA: 0x00348301 File Offset: 0x00346501
		public unsafe FVector PerElementExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_PerElementExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_PerElementExtents) = value;
			}
		}

		// Token: 0x1700885C RID: 34908
		// (get) Token: 0x0602386A RID: 145514 RVA: 0x00348316 File Offset: 0x00346516
		// (set) Token: 0x0602386B RID: 145515 RVA: 0x0034832B File Offset: 0x0034652B
		public TSoftObjectPtr<UNiagaraSystem> System
		{
			get
			{
				return new TSoftObjectPtr<UNiagaraSystem>(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_System, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_System, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700885D RID: 34909
		// (get) Token: 0x0602386C RID: 145516 RVA: 0x00348350 File Offset: 0x00346550
		// (set) Token: 0x0602386D RID: 145517 RVA: 0x00348389 File Offset: 0x00346589
		public FNDCPlacementDebugDrawSettings DebugDrawSettings
		{
			get
			{
				base.FastCheckIsValid();
				FNDCPlacementDebugDrawSettings result;
				if ((result = this._DebugDrawSettings) == null)
				{
					result = (this._DebugDrawSettings = new FNDCPlacementDebugDrawSettings(base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_DebugDrawSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNDCPlacementDebugDrawSettings.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataChannel_Placement.__PropertyOffset_DebugDrawSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700885E RID: 34910
		// (get) Token: 0x0602386E RID: 145518 RVA: 0x003483AA File Offset: 0x003465AA
		// (set) Token: 0x0602386F RID: 145519 RVA: 0x003483BE File Offset: 0x003465BE
		[Nullable(2)]
		public unsafe UNiagaraSystem SystemsInternal
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannel_Placement.__PropertyOffset_SystemsInternal);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannel_Placement.__PropertyOffset_SystemsInternal, value);
			}
		}

		// Token: 0x06023870 RID: 145520 RVA: 0x003483D3 File Offset: 0x003465D3
		static UNiagaraDataChannel_Placement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannel_Placement");
		}

		// Token: 0x06023871 RID: 145521 RVA: 0x003483E1 File Offset: 0x003465E1
		protected UNiagaraDataChannel_Placement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130A7 RID: 77991
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannel_Placement";

		// Token: 0x040130A8 RID: 77992
		private static IntPtr _ClassPtr;

		// Token: 0x040130A9 RID: 77993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130AA RID: 77994
		internal static int __PropertyOffset_Mode;

		// Token: 0x040130AB RID: 77995
		internal static int __PropertyOffset_InitialExtents;

		// Token: 0x040130AC RID: 77996
		internal static int __PropertyOffset_PerElementExtents;

		// Token: 0x040130AD RID: 77997
		internal static int __PropertyOffset_System;

		// Token: 0x040130AE RID: 77998
		internal static int __PropertyOffset_DebugDrawSettings;

		// Token: 0x040130AF RID: 77999
		[Nullable(2)]
		private FNDCPlacementDebugDrawSettings _DebugDrawSettings;

		// Token: 0x040130B0 RID: 78000
		internal static int __PropertyOffset_SystemsInternal;
	}
}
