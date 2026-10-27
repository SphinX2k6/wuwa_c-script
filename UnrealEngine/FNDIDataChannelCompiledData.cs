using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002539 RID: 9529
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NDIDataChannelCompiledData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNDIDataChannelCompiledData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060235F2 RID: 144882 RVA: 0x00344F6A File Offset: 0x0034316A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDIDataChannelCompiledData._ScriptStructPtr != 0) ? FNDIDataChannelCompiledData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDIDataChannelCompiledData", ref FNDIDataChannelCompiledData._ScriptStructPtr);
		}

		// Token: 0x170087F7 RID: 34807
		// (get) Token: 0x060235F3 RID: 144883 RVA: 0x00344F90 File Offset: 0x00343190
		// (set) Token: 0x060235F4 RID: 144884 RVA: 0x00344FD3 File Offset: 0x003431D3
		public TArray<FNDIDataChannelFunctionInfo> FunctionInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNDIDataChannelFunctionInfo> result;
				if ((result = this._FunctionInfo) == null)
				{
					result = (this._FunctionInfo = new TArray<FNDIDataChannelFunctionInfo>(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_FunctionInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FunctionInfo.CopyAssign(value);
			}
		}

		// Token: 0x170087F8 RID: 34808
		// (get) Token: 0x060235F5 RID: 144885 RVA: 0x00344FE1 File Offset: 0x003431E1
		// (set) Token: 0x060235F6 RID: 144886 RVA: 0x00344FF1 File Offset: 0x003431F1
		public unsafe uint TotalParams
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_TotalParams);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_TotalParams) = (int)value;
			}
		}

		// Token: 0x170087F9 RID: 34809
		// (get) Token: 0x060235F7 RID: 144887 RVA: 0x00345002 File Offset: 0x00343202
		// (set) Token: 0x060235F8 RID: 144888 RVA: 0x00345012 File Offset: 0x00343212
		public unsafe bool bUsedByCPU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_bUsedByCPU) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_bUsedByCPU) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087FA RID: 34810
		// (get) Token: 0x060235F9 RID: 144889 RVA: 0x00345023 File Offset: 0x00343223
		// (set) Token: 0x060235FA RID: 144890 RVA: 0x00345033 File Offset: 0x00343233
		public unsafe bool bUsedByGPU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_bUsedByGPU) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_bUsedByGPU) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087FB RID: 34811
		// (get) Token: 0x060235FB RID: 144891 RVA: 0x00345044 File Offset: 0x00343244
		// (set) Token: 0x060235FC RID: 144892 RVA: 0x00345054 File Offset: 0x00343254
		public unsafe bool bNeedsSpawnDataTable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_bNeedsSpawnDataTable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNDIDataChannelCompiledData.__PropertyOffset_bNeedsSpawnDataTable) = (value ? 1 : 0);
			}
		}

		// Token: 0x060235FD RID: 144893 RVA: 0x00345065 File Offset: 0x00343265
		public FNDIDataChannelCompiledData()
		{
		}

		// Token: 0x060235FE RID: 144894 RVA: 0x0034506D File Offset: 0x0034326D
		public FNDIDataChannelCompiledData(TArray<FNDIDataChannelFunctionInfo> FunctionInfo, uint TotalParams, bool bUsedByCPU, bool bUsedByGPU, bool bNeedsSpawnDataTable)
		{
			this.FunctionInfo = FunctionInfo;
			this.TotalParams = TotalParams;
			this.bUsedByCPU = bUsedByCPU;
			this.bUsedByGPU = bUsedByGPU;
			this.bNeedsSpawnDataTable = bNeedsSpawnDataTable;
		}

		// Token: 0x060235FF RID: 144895 RVA: 0x0034509A File Offset: 0x0034329A
		protected override IntPtr GetUStructPtr()
		{
			return FNDIDataChannelCompiledData.StaticStruct();
		}

		// Token: 0x06023600 RID: 144896 RVA: 0x003450A6 File Offset: 0x003432A6
		[NullableContext(2)]
		public FNDIDataChannelCompiledData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023601 RID: 144897 RVA: 0x003450B0 File Offset: 0x003432B0
		public FNDIDataChannelCompiledData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023602 RID: 144898 RVA: 0x003450BB File Offset: 0x003432BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDIDataChannelCompiledData(Pointer, false, true);
		}

		// Token: 0x06023603 RID: 144899 RVA: 0x003450C5 File Offset: 0x003432C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDIDataChannelCompiledData(Pointer, MemoryOwner);
		}

		// Token: 0x04012FC5 RID: 77765
		public const string __ObjectPath = "/Script/Niagara.NDIDataChannelCompiledData";

		// Token: 0x04012FC6 RID: 77766
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FC7 RID: 77767
		internal static int __PropertyOffset_FunctionInfo;

		// Token: 0x04012FC8 RID: 77768
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNDIDataChannelFunctionInfo> _FunctionInfo;

		// Token: 0x04012FC9 RID: 77769
		internal static int __PropertyOffset_TotalParams;

		// Token: 0x04012FCA RID: 77770
		internal static int __PropertyOffset_bUsedByCPU;

		// Token: 0x04012FCB RID: 77771
		internal static int __PropertyOffset_bUsedByGPU;

		// Token: 0x04012FCC RID: 77772
		internal static int __PropertyOffset_bNeedsSpawnDataTable;
	}
}
