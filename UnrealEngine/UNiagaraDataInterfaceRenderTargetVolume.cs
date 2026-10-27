using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002583 RID: 9603
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceRenderTargetVolume")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UNiagaraDataInterfaceRenderTargetVolume : UNiagaraDataInterfaceRWBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A41 RID: 145985 RVA: 0x0034B0C2 File Offset: 0x003492C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceRenderTargetVolume._ClassPtr;
		}

		// Token: 0x06023A42 RID: 145986 RVA: 0x0034B0D0 File Offset: 0x003492D0
		public UNiagaraDataInterfaceRenderTargetVolume() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceRenderTargetVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A43 RID: 145987 RVA: 0x0034B0F8 File Offset: 0x003492F8
		public UNiagaraDataInterfaceRenderTargetVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceRenderTargetVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088CA RID: 35018
		// (get) Token: 0x06023A44 RID: 145988 RVA: 0x0034B12B File Offset: 0x0034932B
		// (set) Token: 0x06023A45 RID: 145989 RVA: 0x0034B13F File Offset: 0x0034933F
		public unsafe FIntVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170088CB RID: 35019
		// (get) Token: 0x06023A46 RID: 145990 RVA: 0x0034B154 File Offset: 0x00349354
		// (set) Token: 0x06023A47 RID: 145991 RVA: 0x0034B168 File Offset: 0x00349368
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextureRenderTargetFormat> OverrideRenderTargetFormat
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_OverrideRenderTargetFormat);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_OverrideRenderTargetFormat) = value;
			}
		}

		// Token: 0x170088CC RID: 35020
		// (get) Token: 0x06023A48 RID: 145992 RVA: 0x0034B17D File Offset: 0x0034937D
		// (set) Token: 0x06023A49 RID: 145993 RVA: 0x0034B196 File Offset: 0x00349396
		public unsafe bool bOverrideFormat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_bOverrideFormat) & UNiagaraDataInterfaceRenderTargetVolume.__PropertyMask_bOverrideFormat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_bOverrideFormat) = ((*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_bOverrideFormat) & ~UNiagaraDataInterfaceRenderTargetVolume.__PropertyMask_bOverrideFormat) | (value ? UNiagaraDataInterfaceRenderTargetVolume.__PropertyMask_bOverrideFormat : 0));
			}
		}

		// Token: 0x170088CD RID: 35021
		// (get) Token: 0x06023A4A RID: 145994 RVA: 0x0034B1C8 File Offset: 0x003493C8
		// (set) Token: 0x06023A4B RID: 145995 RVA: 0x0034B201 File Offset: 0x00349401
		public FNiagaraUserParameterBinding RenderTargetUserParameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._RenderTargetUserParameter) == null)
				{
					result = (this._RenderTargetUserParameter = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_RenderTargetUserParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_RenderTargetUserParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088CE RID: 35022
		// (get) Token: 0x06023A4C RID: 145996 RVA: 0x0034B224 File Offset: 0x00349424
		// (set) Token: 0x06023A4D RID: 145997 RVA: 0x0034B25D File Offset: 0x0034945D
		public TMap<ulong, UTextureRenderTargetVolume> ManagedRenderTargets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ulong, UTextureRenderTargetVolume> result;
				if ((result = this._ManagedRenderTargets) == null)
				{
					result = (this._ManagedRenderTargets = new TMap<ulong, UTextureRenderTargetVolume>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTargetVolume.__PropertyOffset_ManagedRenderTargets, this));
				}
				return result;
			}
			set
			{
				this.ManagedRenderTargets.CopyAssign(value);
			}
		}

		// Token: 0x06023A4E RID: 145998 RVA: 0x0034B26B File Offset: 0x0034946B
		static UNiagaraDataInterfaceRenderTargetVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceRenderTargetVolume");
		}

		// Token: 0x06023A4F RID: 145999 RVA: 0x0034B279 File Offset: 0x00349479
		protected UNiagaraDataInterfaceRenderTargetVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131BA RID: 78266
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceRenderTargetVolume";

		// Token: 0x040131BB RID: 78267
		private static IntPtr _ClassPtr;

		// Token: 0x040131BC RID: 78268
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131BD RID: 78269
		internal static int __PropertyOffset_Size;

		// Token: 0x040131BE RID: 78270
		internal static int __PropertyOffset_OverrideRenderTargetFormat;

		// Token: 0x040131BF RID: 78271
		internal static int __PropertyOffset_bOverrideFormat;

		// Token: 0x040131C0 RID: 78272
		internal static byte __PropertyMask_bOverrideFormat;

		// Token: 0x040131C1 RID: 78273
		internal static int __PropertyOffset_RenderTargetUserParameter;

		// Token: 0x040131C2 RID: 78274
		[Nullable(2)]
		private FNiagaraUserParameterBinding _RenderTargetUserParameter;

		// Token: 0x040131C3 RID: 78275
		internal static int __PropertyOffset_ManagedRenderTargets;

		// Token: 0x040131C4 RID: 78276
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ulong, UTextureRenderTargetVolume> _ManagedRenderTargets;
	}
}
