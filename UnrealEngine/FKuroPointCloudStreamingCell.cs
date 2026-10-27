using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A30 RID: 6704
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudStreamingCell")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroPointCloudStreamingCell : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018CEB RID: 101611 RVA: 0x0024A866 File Offset: 0x00248A66
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointCloudStreamingCell._ScriptStructPtr != 0) ? FKuroPointCloudStreamingCell._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointCloudStreamingCell", ref FKuroPointCloudStreamingCell._ScriptStructPtr);
		}

		// Token: 0x17006251 RID: 25169
		// (get) Token: 0x06018CEC RID: 101612 RVA: 0x0024A88A File Offset: 0x00248A8A
		// (set) Token: 0x06018CED RID: 101613 RVA: 0x0024A89A File Offset: 0x00248A9A
		public unsafe int CellX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointCloudStreamingCell.__PropertyOffset_CellX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointCloudStreamingCell.__PropertyOffset_CellX) = value;
			}
		}

		// Token: 0x17006252 RID: 25170
		// (get) Token: 0x06018CEE RID: 101614 RVA: 0x0024A8AB File Offset: 0x00248AAB
		// (set) Token: 0x06018CEF RID: 101615 RVA: 0x0024A8BB File Offset: 0x00248ABB
		public unsafe int CellY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointCloudStreamingCell.__PropertyOffset_CellY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointCloudStreamingCell.__PropertyOffset_CellY) = value;
			}
		}

		// Token: 0x17006253 RID: 25171
		// (get) Token: 0x06018CF0 RID: 101616 RVA: 0x0024A8CC File Offset: 0x00248ACC
		// (set) Token: 0x06018CF1 RID: 101617 RVA: 0x0024A90F File Offset: 0x00248B0F
		public TArray<FKuroPointCloudCollectionInstance> InstanceData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPointCloudCollectionInstance> result;
				if ((result = this._InstanceData) == null)
				{
					result = (this._InstanceData = new TArray<FKuroPointCloudCollectionInstance>(base.NativePtr + (IntPtr)FKuroPointCloudStreamingCell.__PropertyOffset_InstanceData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InstanceData.CopyAssign(value);
			}
		}

		// Token: 0x06018CF2 RID: 101618 RVA: 0x0024A91D File Offset: 0x00248B1D
		public FKuroPointCloudStreamingCell()
		{
		}

		// Token: 0x06018CF3 RID: 101619 RVA: 0x0024A925 File Offset: 0x00248B25
		public FKuroPointCloudStreamingCell(int CellX, int CellY, TArray<FKuroPointCloudCollectionInstance> InstanceData)
		{
			this.CellX = CellX;
			this.CellY = CellY;
			this.InstanceData = InstanceData;
		}

		// Token: 0x06018CF4 RID: 101620 RVA: 0x0024A942 File Offset: 0x00248B42
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointCloudStreamingCell.StaticStruct();
		}

		// Token: 0x06018CF5 RID: 101621 RVA: 0x0024A94E File Offset: 0x00248B4E
		[NullableContext(2)]
		public FKuroPointCloudStreamingCell(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018CF6 RID: 101622 RVA: 0x0024A958 File Offset: 0x00248B58
		public FKuroPointCloudStreamingCell(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018CF7 RID: 101623 RVA: 0x0024A963 File Offset: 0x00248B63
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointCloudStreamingCell(Pointer, false, true);
		}

		// Token: 0x06018CF8 RID: 101624 RVA: 0x0024A96D File Offset: 0x00248B6D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointCloudStreamingCell(Pointer, MemoryOwner);
		}

		// Token: 0x0400D694 RID: 54932
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudStreamingCell";

		// Token: 0x0400D695 RID: 54933
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D696 RID: 54934
		internal static int __PropertyOffset_CellX;

		// Token: 0x0400D697 RID: 54935
		internal static int __PropertyOffset_CellY;

		// Token: 0x0400D698 RID: 54936
		internal static int __PropertyOffset_InstanceData;

		// Token: 0x0400D699 RID: 54937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPointCloudCollectionInstance> _InstanceData;
	}
}
