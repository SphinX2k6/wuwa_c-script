using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200129C RID: 4764
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/FastGeoStreaming.FastGeoStreamingCell")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UFastGeoStreamingCell : UWorldPartitionRuntimeAssetStreamingCell, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011799 RID: 71577 RVA: 0x0019A73A File Offset: 0x0019893A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFastGeoStreamingCell._ClassPtr;
		}

		// Token: 0x0601179A RID: 71578 RVA: 0x0019A748 File Offset: 0x00198948
		public UFastGeoStreamingCell() : this(BuiltinUtils.AllocNativeUObject(UFastGeoStreamingCell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601179B RID: 71579 RVA: 0x0019A770 File Offset: 0x00198970
		public UFastGeoStreamingCell(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFastGeoStreamingCell.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x0601179C RID: 71580 RVA: 0x0019A7A3 File Offset: 0x001989A3
		// (set) Token: 0x0601179D RID: 71581 RVA: 0x0019A7B8 File Offset: 0x001989B8
		public TSoftObjectPtr<UFastGeoContainer> FastGeoContainerPtr
		{
			get
			{
				return new TSoftObjectPtr<UFastGeoContainer>(base.NativePtr + (IntPtr)UFastGeoStreamingCell.__PropertyOffset_FastGeoContainerPtr, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UFastGeoStreamingCell.__PropertyOffset_FastGeoContainerPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x0601179E RID: 71582 RVA: 0x0019A7DD File Offset: 0x001989DD
		// (set) Token: 0x0601179F RID: 71583 RVA: 0x0019A7F2 File Offset: 0x001989F2
		public TSoftObjectPtr<UFastGeoContainer> InstancedContainer
		{
			get
			{
				return new TSoftObjectPtr<UFastGeoContainer>(base.NativePtr + (IntPtr)UFastGeoStreamingCell.__PropertyOffset_InstancedContainer, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UFastGeoStreamingCell.__PropertyOffset_InstancedContainer, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060117A0 RID: 71584 RVA: 0x0019A817 File Offset: 0x00198A17
		static UFastGeoStreamingCell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FastGeoStreaming.FastGeoStreamingCell");
		}

		// Token: 0x060117A1 RID: 71585 RVA: 0x0019A825 File Offset: 0x00198A25
		protected UFastGeoStreamingCell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095AA RID: 38314
		public new const string __ObjectPath = "/Script/FastGeoStreaming.FastGeoStreamingCell";

		// Token: 0x040095AB RID: 38315
		private static IntPtr _ClassPtr;

		// Token: 0x040095AC RID: 38316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040095AD RID: 38317
		internal static int __PropertyOffset_FastGeoContainerPtr;

		// Token: 0x040095AE RID: 38318
		internal static int __PropertyOffset_InstancedContainer;
	}
}
