using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002579 RID: 9593
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UNiagaraDataInterfaceGrid3DCollection : UNiagaraDataInterfaceGrid3D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239CF RID: 145871 RVA: 0x0034A51D File Offset: 0x0034871D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceGrid3DCollection._ClassPtr;
		}

		// Token: 0x060239D0 RID: 145872 RVA: 0x0034A52C File Offset: 0x0034872C
		public UNiagaraDataInterfaceGrid3DCollection() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid3DCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239D1 RID: 145873 RVA: 0x0034A554 File Offset: 0x00348754
		public UNiagaraDataInterfaceGrid3DCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGrid3DCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088AE RID: 34990
		// (get) Token: 0x060239D2 RID: 145874 RVA: 0x0034A587 File Offset: 0x00348787
		// (set) Token: 0x060239D3 RID: 145875 RVA: 0x0034A597 File Offset: 0x00348797
		public unsafe int NumAttributes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3DCollection.__PropertyOffset_NumAttributes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3DCollection.__PropertyOffset_NumAttributes) = value;
			}
		}

		// Token: 0x170088AF RID: 34991
		// (get) Token: 0x060239D4 RID: 145876 RVA: 0x0034A5A8 File Offset: 0x003487A8
		// (set) Token: 0x060239D5 RID: 145877 RVA: 0x0034A5E1 File Offset: 0x003487E1
		public FNiagaraUserParameterBinding RenderTargetUserParameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._RenderTargetUserParameter) == null)
				{
					result = (this._RenderTargetUserParameter = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3DCollection.__PropertyOffset_RenderTargetUserParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3DCollection.__PropertyOffset_RenderTargetUserParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088B0 RID: 34992
		// (get) Token: 0x060239D6 RID: 145878 RVA: 0x0034A602 File Offset: 0x00348802
		// (set) Token: 0x060239D7 RID: 145879 RVA: 0x0034A612 File Offset: 0x00348812
		public unsafe ENiagaraGpuBufferFormat BufferFormat
		{
			get
			{
				return (ENiagaraGpuBufferFormat)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3DCollection.__PropertyOffset_BufferFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceGrid3DCollection.__PropertyOffset_BufferFormat) = (byte)value;
			}
		}

		// Token: 0x060239D8 RID: 145880 RVA: 0x0034A624 File Offset: 0x00348824
		[NullableContext(2)]
		public unsafe void GetTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY, ref int SizeZ)
		{
			fixed (int* ptr = &SizeX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &SizeY)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &SizeZ)
					{
						void* ptr6 = (void*)ptr5;
						UNiagaraDataInterfaceGrid3DCollection.__GetTextureSize_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, ref SizeX, ref SizeY, ref SizeZ);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060239D9 RID: 145881 RVA: 0x0034A670 File Offset: 0x00348870
		[NullableContext(2)]
		public unsafe void GetRawTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY, ref int SizeZ)
		{
			fixed (int* ptr = &SizeX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &SizeY)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &SizeZ)
					{
						void* ptr6 = (void*)ptr5;
						UNiagaraDataInterfaceGrid3DCollection.__GetRawTextureSize_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, ref SizeX, ref SizeY, ref SizeZ);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060239DA RID: 145882 RVA: 0x0034A6BB File Offset: 0x003488BB
		[NullableContext(2)]
		public bool FillVolumeTexture(UNiagaraComponent Component, UVolumeTexture dest, int AttributeIndex)
		{
			return UNiagaraDataInterfaceGrid3DCollection.__FillVolumeTexture_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, (dest != null) ? dest.NativePtr : IntPtr.Zero, AttributeIndex);
		}

		// Token: 0x060239DB RID: 145883 RVA: 0x0034A6EC File Offset: 0x003488EC
		[NullableContext(2)]
		public unsafe bool FillRawVolumeTexture(UNiagaraComponent Component, UVolumeTexture Dest, ref int TilesX, ref int TilesY, ref int TileZ)
		{
			fixed (int* ptr = &TilesX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &TilesY)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &TileZ)
					{
						void* ptr6 = (void*)ptr5;
						return UNiagaraDataInterfaceGrid3DCollection.__FillRawVolumeTexture_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, (Dest != null) ? Dest.NativePtr : IntPtr.Zero, ref TilesX, ref TilesY, ref TileZ);
					}
				}
			}
		}

		// Token: 0x060239DC RID: 145884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTextureSize_Internal(IntPtr @this, IntPtr Component, ref int SizeX, ref int SizeY, ref int SizeZ);

		// Token: 0x060239DD RID: 145885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRawTextureSize_Internal(IntPtr @this, IntPtr Component, ref int SizeX, ref int SizeY, ref int SizeZ);

		// Token: 0x060239DE RID: 145886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FillVolumeTexture_Internal(IntPtr @this, IntPtr Component, IntPtr dest, int AttributeIndex);

		// Token: 0x060239DF RID: 145887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FillRawVolumeTexture_Internal(IntPtr @this, IntPtr Component, IntPtr Dest, ref int TilesX, ref int TilesY, ref int TileZ);

		// Token: 0x060239E0 RID: 145888 RVA: 0x0034A73E File Offset: 0x0034893E
		static UNiagaraDataInterfaceGrid3DCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceGrid3DCollection");
		}

		// Token: 0x060239E1 RID: 145889 RVA: 0x0034A74C File Offset: 0x0034894C
		protected UNiagaraDataInterfaceGrid3DCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013177 RID: 78199
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceGrid3DCollection";

		// Token: 0x04013178 RID: 78200
		private static IntPtr _ClassPtr;

		// Token: 0x04013179 RID: 78201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401317A RID: 78202
		internal static int __PropertyOffset_NumAttributes;

		// Token: 0x0401317B RID: 78203
		internal static int __PropertyOffset_RenderTargetUserParameter;

		// Token: 0x0401317C RID: 78204
		[Nullable(2)]
		private FNiagaraUserParameterBinding _RenderTargetUserParameter;

		// Token: 0x0401317D RID: 78205
		internal static int __PropertyOffset_BufferFormat;
	}
}
