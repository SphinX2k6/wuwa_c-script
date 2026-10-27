using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002581 RID: 9601
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceRenderTarget2D")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UNiagaraDataInterfaceRenderTarget2D : UNiagaraDataInterfaceRWBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A23 RID: 145955 RVA: 0x0034AD44 File Offset: 0x00348F44
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceRenderTarget2D._ClassPtr;
		}

		// Token: 0x06023A24 RID: 145956 RVA: 0x0034AD50 File Offset: 0x00348F50
		public UNiagaraDataInterfaceRenderTarget2D() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceRenderTarget2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A25 RID: 145957 RVA: 0x0034AD78 File Offset: 0x00348F78
		public UNiagaraDataInterfaceRenderTarget2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceRenderTarget2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088C0 RID: 35008
		// (get) Token: 0x06023A26 RID: 145958 RVA: 0x0034ADAB File Offset: 0x00348FAB
		// (set) Token: 0x06023A27 RID: 145959 RVA: 0x0034ADBF File Offset: 0x00348FBF
		public unsafe FIntPoint Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170088C1 RID: 35009
		// (get) Token: 0x06023A28 RID: 145960 RVA: 0x0034ADD4 File Offset: 0x00348FD4
		// (set) Token: 0x06023A29 RID: 145961 RVA: 0x0034ADE8 File Offset: 0x00348FE8
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextureRenderTargetFormat> OverrideRenderTargetFormat
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_OverrideRenderTargetFormat);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_OverrideRenderTargetFormat) = value;
			}
		}

		// Token: 0x170088C2 RID: 35010
		// (get) Token: 0x06023A2A RID: 145962 RVA: 0x0034ADFD File Offset: 0x00348FFD
		// (set) Token: 0x06023A2B RID: 145963 RVA: 0x0034AE16 File Offset: 0x00349016
		public unsafe bool bOverrideFormat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_bOverrideFormat) & UNiagaraDataInterfaceRenderTarget2D.__PropertyMask_bOverrideFormat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_bOverrideFormat) = ((*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_bOverrideFormat) & ~UNiagaraDataInterfaceRenderTarget2D.__PropertyMask_bOverrideFormat) | (value ? UNiagaraDataInterfaceRenderTarget2D.__PropertyMask_bOverrideFormat : 0));
			}
		}

		// Token: 0x170088C3 RID: 35011
		// (get) Token: 0x06023A2C RID: 145964 RVA: 0x0034AE48 File Offset: 0x00349048
		// (set) Token: 0x06023A2D RID: 145965 RVA: 0x0034AE81 File Offset: 0x00349081
		public FNiagaraUserParameterBinding RenderTargetUserParameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._RenderTargetUserParameter) == null)
				{
					result = (this._RenderTargetUserParameter = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_RenderTargetUserParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_RenderTargetUserParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088C4 RID: 35012
		// (get) Token: 0x06023A2E RID: 145966 RVA: 0x0034AEA4 File Offset: 0x003490A4
		// (set) Token: 0x06023A2F RID: 145967 RVA: 0x0034AEDD File Offset: 0x003490DD
		public TMap<ulong, UTextureRenderTarget2D> ManagedRenderTargets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ulong, UTextureRenderTarget2D> result;
				if ((result = this._ManagedRenderTargets) == null)
				{
					result = (this._ManagedRenderTargets = new TMap<ulong, UTextureRenderTarget2D>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2D.__PropertyOffset_ManagedRenderTargets, this));
				}
				return result;
			}
			set
			{
				this.ManagedRenderTargets.CopyAssign(value);
			}
		}

		// Token: 0x06023A30 RID: 145968 RVA: 0x0034AEEB File Offset: 0x003490EB
		static UNiagaraDataInterfaceRenderTarget2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceRenderTarget2D");
		}

		// Token: 0x06023A31 RID: 145969 RVA: 0x0034AEF9 File Offset: 0x003490F9
		protected UNiagaraDataInterfaceRenderTarget2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131A4 RID: 78244
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceRenderTarget2D";

		// Token: 0x040131A5 RID: 78245
		private static IntPtr _ClassPtr;

		// Token: 0x040131A6 RID: 78246
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131A7 RID: 78247
		internal static int __PropertyOffset_Size;

		// Token: 0x040131A8 RID: 78248
		internal static int __PropertyOffset_OverrideRenderTargetFormat;

		// Token: 0x040131A9 RID: 78249
		internal static int __PropertyOffset_bOverrideFormat;

		// Token: 0x040131AA RID: 78250
		internal static byte __PropertyMask_bOverrideFormat;

		// Token: 0x040131AB RID: 78251
		internal static int __PropertyOffset_RenderTargetUserParameter;

		// Token: 0x040131AC RID: 78252
		[Nullable(2)]
		private FNiagaraUserParameterBinding _RenderTargetUserParameter;

		// Token: 0x040131AD RID: 78253
		internal static int __PropertyOffset_ManagedRenderTargets;

		// Token: 0x040131AE RID: 78254
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ulong, UTextureRenderTarget2D> _ManagedRenderTargets;
	}
}
