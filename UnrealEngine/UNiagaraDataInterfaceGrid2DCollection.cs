using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002576 RID: 9590
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UNiagaraDataInterfaceGrid2DCollection : UNiagaraDataInterfaceGrid2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239A3 RID: 145827 RVA: 0x0034A0D1 File Offset: 0x003482D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceGrid2DCollection._ClassPtr;
		}

		// Token: 0x060239A4 RID: 145828 RVA: 0x0034A0E0 File Offset: 0x003482E0
		public UNiagaraDataInterfaceGrid2DCollection() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid2DCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239A5 RID: 145829 RVA: 0x0034A108 File Offset: 0x00348308
		public UNiagaraDataInterfaceGrid2DCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid2DCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088A3 RID: 34979
		// (get) Token: 0x060239A6 RID: 145830 RVA: 0x0034A13C File Offset: 0x0034833C
		// (set) Token: 0x060239A7 RID: 145831 RVA: 0x0034A175 File Offset: 0x00348375
		public FNiagaraUserParameterBinding RenderTargetUserParameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._RenderTargetUserParameter) == null)
				{
					result = (this._RenderTargetUserParameter = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_RenderTargetUserParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_RenderTargetUserParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088A4 RID: 34980
		// (get) Token: 0x060239A8 RID: 145832 RVA: 0x0034A196 File Offset: 0x00348396
		// (set) Token: 0x060239A9 RID: 145833 RVA: 0x0034A1A6 File Offset: 0x003483A6
		public unsafe ENiagaraGpuBufferFormat OverrideBufferFormat
		{
			get
			{
				return (ENiagaraGpuBufferFormat)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_OverrideBufferFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_OverrideBufferFormat) = (byte)value;
			}
		}

		// Token: 0x170088A5 RID: 34981
		// (get) Token: 0x060239AA RID: 145834 RVA: 0x0034A1B7 File Offset: 0x003483B7
		// (set) Token: 0x060239AB RID: 145835 RVA: 0x0034A1D0 File Offset: 0x003483D0
		public unsafe bool bOverrideFormat
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_bOverrideFormat) & UNiagaraDataInterfaceGrid2DCollection.__PropertyMask_bOverrideFormat) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_bOverrideFormat) = ((*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_bOverrideFormat) & ~UNiagaraDataInterfaceGrid2DCollection.__PropertyMask_bOverrideFormat) | (value ? UNiagaraDataInterfaceGrid2DCollection.__PropertyMask_bOverrideFormat : 0));
			}
		}

		// Token: 0x170088A6 RID: 34982
		// (get) Token: 0x060239AC RID: 145836 RVA: 0x0034A200 File Offset: 0x00348400
		// (set) Token: 0x060239AD RID: 145837 RVA: 0x0034A239 File Offset: 0x00348439
		public TMap<ulong, UTextureRenderTarget2DArray> ManagedRenderTargets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ulong, UTextureRenderTarget2DArray> result;
				if ((result = this._ManagedRenderTargets) == null)
				{
					result = (this._ManagedRenderTargets = new TMap<ulong, UTextureRenderTarget2DArray>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid2DCollection.__PropertyOffset_ManagedRenderTargets, this));
				}
				return result;
			}
			set
			{
				this.ManagedRenderTargets.CopyAssign(value);
			}
		}

		// Token: 0x060239AE RID: 145838 RVA: 0x0034A248 File Offset: 0x00348448
		[NullableContext(2)]
		public unsafe void GetTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY)
		{
			fixed (int* ptr = &SizeX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &SizeY)
				{
					void* ptr4 = (void*)ptr3;
					UNiagaraDataInterfaceGrid2DCollection.__GetTextureSize_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, ref SizeX, ref SizeY);
					ptr = null;
				}
			}
		}

		// Token: 0x060239AF RID: 145839 RVA: 0x0034A284 File Offset: 0x00348484
		[NullableContext(2)]
		public unsafe void GetRawTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY)
		{
			fixed (int* ptr = &SizeX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &SizeY)
				{
					void* ptr4 = (void*)ptr3;
					UNiagaraDataInterfaceGrid2DCollection.__GetRawTextureSize_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, ref SizeX, ref SizeY);
					ptr = null;
				}
			}
		}

		// Token: 0x060239B0 RID: 145840 RVA: 0x0034A2BE File Offset: 0x003484BE
		[NullableContext(2)]
		public bool FillTexture2D(UNiagaraComponent Component, UTextureRenderTarget2D dest, int AttributeIndex)
		{
			return UNiagaraDataInterfaceGrid2DCollection.__FillTexture2D_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, (dest != null) ? dest.NativePtr : IntPtr.Zero, AttributeIndex);
		}

		// Token: 0x060239B1 RID: 145841 RVA: 0x0034A2EC File Offset: 0x003484EC
		[NullableContext(2)]
		public unsafe bool FillRawTexture2D(UNiagaraComponent Component, UTextureRenderTarget2D Dest, ref int TilesX, ref int TilesY)
		{
			fixed (int* ptr = &TilesX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &TilesY)
				{
					void* ptr4 = (void*)ptr3;
					return UNiagaraDataInterfaceGrid2DCollection.__FillRawTexture2D_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, (Dest != null) ? Dest.NativePtr : IntPtr.Zero, ref TilesX, ref TilesY);
				}
			}
		}

		// Token: 0x060239B2 RID: 145842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTextureSize_Internal(IntPtr @this, IntPtr Component, ref int SizeX, ref int SizeY);

		// Token: 0x060239B3 RID: 145843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRawTextureSize_Internal(IntPtr @this, IntPtr Component, ref int SizeX, ref int SizeY);

		// Token: 0x060239B4 RID: 145844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FillTexture2D_Internal(IntPtr @this, IntPtr Component, IntPtr dest, int AttributeIndex);

		// Token: 0x060239B5 RID: 145845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FillRawTexture2D_Internal(IntPtr @this, IntPtr Component, IntPtr Dest, ref int TilesX, ref int TilesY);

		// Token: 0x060239B6 RID: 145846 RVA: 0x0034A332 File Offset: 0x00348532
		static UNiagaraDataInterfaceGrid2DCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceGrid2DCollection");
		}

		// Token: 0x060239B7 RID: 145847 RVA: 0x0034A340 File Offset: 0x00348540
		protected UNiagaraDataInterfaceGrid2DCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013160 RID: 78176
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceGrid2DCollection";

		// Token: 0x04013161 RID: 78177
		private static IntPtr _ClassPtr;

		// Token: 0x04013162 RID: 78178
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013163 RID: 78179
		internal static int __PropertyOffset_RenderTargetUserParameter;

		// Token: 0x04013164 RID: 78180
		[Nullable(2)]
		private FNiagaraUserParameterBinding _RenderTargetUserParameter;

		// Token: 0x04013165 RID: 78181
		internal static int __PropertyOffset_OverrideBufferFormat;

		// Token: 0x04013166 RID: 78182
		internal static int __PropertyOffset_bOverrideFormat;

		// Token: 0x04013167 RID: 78183
		internal static byte __PropertyMask_bOverrideFormat;

		// Token: 0x04013168 RID: 78184
		internal static int __PropertyOffset_ManagedRenderTargets;

		// Token: 0x04013169 RID: 78185
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ulong, UTextureRenderTarget2DArray> _ManagedRenderTargets;
	}
}
