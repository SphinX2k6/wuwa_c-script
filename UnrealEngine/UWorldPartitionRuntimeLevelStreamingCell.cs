using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200127D RID: 4733
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeLevelStreamingCell")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UWorldPartitionRuntimeLevelStreamingCell : UWorldPartitionRuntimeCell, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011578 RID: 71032 RVA: 0x00197416 File Offset: 0x00195616
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeLevelStreamingCell._ClassPtr;
		}

		// Token: 0x06011579 RID: 71033 RVA: 0x00197424 File Offset: 0x00195624
		public UWorldPartitionRuntimeLevelStreamingCell() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeLevelStreamingCell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601157A RID: 71034 RVA: 0x0019744C File Offset: 0x0019564C
		public UWorldPartitionRuntimeLevelStreamingCell(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeLevelStreamingCell.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004392 RID: 17298
		// (get) Token: 0x0601157B RID: 71035 RVA: 0x00197480 File Offset: 0x00195680
		// (set) Token: 0x0601157C RID: 71036 RVA: 0x001974B9 File Offset: 0x001956B9
		public FWorldPartitionRuntimeCellStreamingData StreamingData
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionRuntimeCellStreamingData result;
				if ((result = this._StreamingData) == null)
				{
					result = (this._StreamingData = new FWorldPartitionRuntimeCellStreamingData(base.NativePtr + (IntPtr)UWorldPartitionRuntimeLevelStreamingCell.__PropertyOffset_StreamingData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionRuntimeCellStreamingData.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionRuntimeLevelStreamingCell.__PropertyOffset_StreamingData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004393 RID: 17299
		// (get) Token: 0x0601157D RID: 71037 RVA: 0x001974DC File Offset: 0x001956DC
		// (set) Token: 0x0601157E RID: 71038 RVA: 0x00197515 File Offset: 0x00195715
		public FWorldPartitionRuntimeCellStreamingData NoTransformerStreamingData
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionRuntimeCellStreamingData result;
				if ((result = this._NoTransformerStreamingData) == null)
				{
					result = (this._NoTransformerStreamingData = new FWorldPartitionRuntimeCellStreamingData(base.NativePtr + (IntPtr)UWorldPartitionRuntimeLevelStreamingCell.__PropertyOffset_NoTransformerStreamingData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionRuntimeCellStreamingData.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionRuntimeLevelStreamingCell.__PropertyOffset_NoTransformerStreamingData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601157F RID: 71039 RVA: 0x00197536 File Offset: 0x00195736
		public void OnLevelUnloaded()
		{
			UWorldPartitionRuntimeLevelStreamingCell.__OnLevelUnloaded_Internal(base.NativePtr);
		}

		// Token: 0x06011580 RID: 71040 RVA: 0x00197543 File Offset: 0x00195743
		public void OnLevelShown()
		{
			UWorldPartitionRuntimeLevelStreamingCell.__OnLevelShown_Internal(base.NativePtr);
		}

		// Token: 0x06011581 RID: 71041 RVA: 0x00197550 File Offset: 0x00195750
		public void OnLevelHidden()
		{
			UWorldPartitionRuntimeLevelStreamingCell.__OnLevelHidden_Internal(base.NativePtr);
		}

		// Token: 0x06011582 RID: 71042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelUnloaded_Internal(IntPtr @this);

		// Token: 0x06011583 RID: 71043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelShown_Internal(IntPtr @this);

		// Token: 0x06011584 RID: 71044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelHidden_Internal(IntPtr @this);

		// Token: 0x06011585 RID: 71045 RVA: 0x0019755D File Offset: 0x0019575D
		static UWorldPartitionRuntimeLevelStreamingCell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeLevelStreamingCell");
		}

		// Token: 0x06011586 RID: 71046 RVA: 0x0019756B File Offset: 0x0019576B
		protected UWorldPartitionRuntimeLevelStreamingCell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009478 RID: 38008
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeLevelStreamingCell";

		// Token: 0x04009479 RID: 38009
		private static IntPtr _ClassPtr;

		// Token: 0x0400947A RID: 38010
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400947B RID: 38011
		internal static int __PropertyOffset_StreamingData;

		// Token: 0x0400947C RID: 38012
		[Nullable(2)]
		private FWorldPartitionRuntimeCellStreamingData _StreamingData;

		// Token: 0x0400947D RID: 38013
		internal static int __PropertyOffset_NoTransformerStreamingData;

		// Token: 0x0400947E RID: 38014
		[Nullable(2)]
		private FWorldPartitionRuntimeCellStreamingData _NoTransformerStreamingData;
	}
}
