using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A31 RID: 6705
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudStreamingConfig")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroPointCloudStreamingConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018CF9 RID: 101625 RVA: 0x0024A976 File Offset: 0x00248B76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPointCloudStreamingConfig._ClassPtr;
		}

		// Token: 0x06018CFA RID: 101626 RVA: 0x0024A984 File Offset: 0x00248B84
		public UKuroPointCloudStreamingConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudStreamingConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018CFB RID: 101627 RVA: 0x0024A9AC File Offset: 0x00248BAC
		public UKuroPointCloudStreamingConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudStreamingConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006254 RID: 25172
		// (get) Token: 0x06018CFC RID: 101628 RVA: 0x0024A9E0 File Offset: 0x00248BE0
		// (set) Token: 0x06018CFD RID: 101629 RVA: 0x0024AA19 File Offset: 0x00248C19
		public TArray<FKuroPointCloudStreamingCell> StreamingCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPointCloudStreamingCell> result;
				if ((result = this._StreamingCells) == null)
				{
					result = (this._StreamingCells = new TArray<FKuroPointCloudStreamingCell>(base.NativePtr + (IntPtr)UKuroPointCloudStreamingConfig.__PropertyOffset_StreamingCells, this));
				}
				return result;
			}
			set
			{
				this.StreamingCells.CopyAssign(value);
			}
		}

		// Token: 0x17006255 RID: 25173
		// (get) Token: 0x06018CFE RID: 101630 RVA: 0x0024AA27 File Offset: 0x00248C27
		// (set) Token: 0x06018CFF RID: 101631 RVA: 0x0024AA37 File Offset: 0x00248C37
		public unsafe float CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudStreamingConfig.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudStreamingConfig.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x06018D00 RID: 101632 RVA: 0x0024AA48 File Offset: 0x00248C48
		[NullableContext(2)]
		public void SetInstanceData(int CellX, int CellY, FName CollectionName, UKuroPointCloudInstance PointCloudInstance)
		{
			UKuroPointCloudStreamingConfig.__SetInstanceData_Internal(base.NativePtr, CellX, CellY, CollectionName, (PointCloudInstance != null) ? PointCloudInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018D01 RID: 101633 RVA: 0x0024AA6A File Offset: 0x00248C6A
		public void ClearEmptyInstances()
		{
			UKuroPointCloudStreamingConfig.__ClearEmptyInstances_Internal(base.NativePtr);
		}

		// Token: 0x06018D02 RID: 101634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInstanceData_Internal(IntPtr @this, int CellX, int CellY, FName CollectionName, IntPtr PointCloudInstance);

		// Token: 0x06018D03 RID: 101635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearEmptyInstances_Internal(IntPtr @this);

		// Token: 0x06018D04 RID: 101636 RVA: 0x0024AA77 File Offset: 0x00248C77
		static UKuroPointCloudStreamingConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudStreamingConfig");
		}

		// Token: 0x06018D05 RID: 101637 RVA: 0x0024AA85 File Offset: 0x00248C85
		protected UKuroPointCloudStreamingConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D69A RID: 54938
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudStreamingConfig";

		// Token: 0x0400D69B RID: 54939
		private static IntPtr _ClassPtr;

		// Token: 0x0400D69C RID: 54940
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D69D RID: 54941
		internal static int __PropertyOffset_StreamingCells;

		// Token: 0x0400D69E RID: 54942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPointCloudStreamingCell> _StreamingCells;

		// Token: 0x0400D69F RID: 54943
		internal static int __PropertyOffset_CellSize;
	}
}
