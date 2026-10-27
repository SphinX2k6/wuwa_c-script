using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002582 RID: 9602
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceRenderTarget2DArray")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UNiagaraDataInterfaceRenderTarget2DArray : UNiagaraDataInterfaceRWBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A32 RID: 145970 RVA: 0x0034AF02 File Offset: 0x00349102
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceRenderTarget2DArray._ClassPtr;
		}

		// Token: 0x06023A33 RID: 145971 RVA: 0x0034AF10 File Offset: 0x00349110
		public UNiagaraDataInterfaceRenderTarget2DArray() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceRenderTarget2DArray.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A34 RID: 145972 RVA: 0x0034AF38 File Offset: 0x00349138
		public UNiagaraDataInterfaceRenderTarget2DArray(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceRenderTarget2DArray.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088C5 RID: 35013
		// (get) Token: 0x06023A35 RID: 145973 RVA: 0x0034AF6B File Offset: 0x0034916B
		// (set) Token: 0x06023A36 RID: 145974 RVA: 0x0034AF7F File Offset: 0x0034917F
		public unsafe FIntVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170088C6 RID: 35014
		// (get) Token: 0x06023A37 RID: 145975 RVA: 0x0034AF94 File Offset: 0x00349194
		// (set) Token: 0x06023A38 RID: 145976 RVA: 0x0034AFA8 File Offset: 0x003491A8
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextureRenderTargetFormat> OverrideRenderTargetFormat
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_OverrideRenderTargetFormat);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_OverrideRenderTargetFormat) = value;
			}
		}

		// Token: 0x170088C7 RID: 35015
		// (get) Token: 0x06023A39 RID: 145977 RVA: 0x0034AFBD File Offset: 0x003491BD
		// (set) Token: 0x06023A3A RID: 145978 RVA: 0x0034AFD6 File Offset: 0x003491D6
		public unsafe bool bOverrideFormat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_bOverrideFormat) & UNiagaraDataInterfaceRenderTarget2DArray.__PropertyMask_bOverrideFormat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_bOverrideFormat) = ((*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_bOverrideFormat) & ~UNiagaraDataInterfaceRenderTarget2DArray.__PropertyMask_bOverrideFormat) | (value ? UNiagaraDataInterfaceRenderTarget2DArray.__PropertyMask_bOverrideFormat : 0));
			}
		}

		// Token: 0x170088C8 RID: 35016
		// (get) Token: 0x06023A3B RID: 145979 RVA: 0x0034B008 File Offset: 0x00349208
		// (set) Token: 0x06023A3C RID: 145980 RVA: 0x0034B041 File Offset: 0x00349241
		public FNiagaraUserParameterBinding RenderTargetUserParameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._RenderTargetUserParameter) == null)
				{
					result = (this._RenderTargetUserParameter = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_RenderTargetUserParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_RenderTargetUserParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088C9 RID: 35017
		// (get) Token: 0x06023A3D RID: 145981 RVA: 0x0034B064 File Offset: 0x00349264
		// (set) Token: 0x06023A3E RID: 145982 RVA: 0x0034B09D File Offset: 0x0034929D
		public TMap<ulong, UTextureRenderTarget2DArray> ManagedRenderTargets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ulong, UTextureRenderTarget2DArray> result;
				if ((result = this._ManagedRenderTargets) == null)
				{
					result = (this._ManagedRenderTargets = new TMap<ulong, UTextureRenderTarget2DArray>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRenderTarget2DArray.__PropertyOffset_ManagedRenderTargets, this));
				}
				return result;
			}
			set
			{
				this.ManagedRenderTargets.CopyAssign(value);
			}
		}

		// Token: 0x06023A3F RID: 145983 RVA: 0x0034B0AB File Offset: 0x003492AB
		static UNiagaraDataInterfaceRenderTarget2DArray()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceRenderTarget2DArray");
		}

		// Token: 0x06023A40 RID: 145984 RVA: 0x0034B0B9 File Offset: 0x003492B9
		protected UNiagaraDataInterfaceRenderTarget2DArray(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131AF RID: 78255
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceRenderTarget2DArray";

		// Token: 0x040131B0 RID: 78256
		private static IntPtr _ClassPtr;

		// Token: 0x040131B1 RID: 78257
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131B2 RID: 78258
		internal static int __PropertyOffset_Size;

		// Token: 0x040131B3 RID: 78259
		internal static int __PropertyOffset_OverrideRenderTargetFormat;

		// Token: 0x040131B4 RID: 78260
		internal static int __PropertyOffset_bOverrideFormat;

		// Token: 0x040131B5 RID: 78261
		internal static byte __PropertyMask_bOverrideFormat;

		// Token: 0x040131B6 RID: 78262
		internal static int __PropertyOffset_RenderTargetUserParameter;

		// Token: 0x040131B7 RID: 78263
		[Nullable(2)]
		private FNiagaraUserParameterBinding _RenderTargetUserParameter;

		// Token: 0x040131B8 RID: 78264
		internal static int __PropertyOffset_ManagedRenderTargets;

		// Token: 0x040131B9 RID: 78265
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ulong, UTextureRenderTarget2DArray> _ManagedRenderTargets;
	}
}
