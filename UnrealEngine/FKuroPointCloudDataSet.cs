using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A2A RID: 6698
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudDataSet")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroPointCloudDataSet : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018C9C RID: 101532 RVA: 0x0024A19A File Offset: 0x0024839A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointCloudDataSet._ScriptStructPtr != 0) ? FKuroPointCloudDataSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointCloudDataSet", ref FKuroPointCloudDataSet._ScriptStructPtr);
		}

		// Token: 0x17006246 RID: 25158
		// (get) Token: 0x06018C9D RID: 101533 RVA: 0x0024A1C0 File Offset: 0x002483C0
		// (set) Token: 0x06018C9E RID: 101534 RVA: 0x0024A203 File Offset: 0x00248403
		public TArray<FKPCWDynamicCustomPointInfo> CustomPointInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKPCWDynamicCustomPointInfo> result;
				if ((result = this._CustomPointInfos) == null)
				{
					result = (this._CustomPointInfos = new TArray<FKPCWDynamicCustomPointInfo>(base.NativePtr + (IntPtr)FKuroPointCloudDataSet.__PropertyOffset_CustomPointInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomPointInfos.CopyAssign(value);
			}
		}

		// Token: 0x06018C9F RID: 101535 RVA: 0x0024A211 File Offset: 0x00248411
		public FKuroPointCloudDataSet()
		{
		}

		// Token: 0x06018CA0 RID: 101536 RVA: 0x0024A219 File Offset: 0x00248419
		public FKuroPointCloudDataSet(TArray<FKPCWDynamicCustomPointInfo> CustomPointInfos)
		{
			this.CustomPointInfos = CustomPointInfos;
		}

		// Token: 0x06018CA1 RID: 101537 RVA: 0x0024A228 File Offset: 0x00248428
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointCloudDataSet.StaticStruct();
		}

		// Token: 0x06018CA2 RID: 101538 RVA: 0x0024A234 File Offset: 0x00248434
		[NullableContext(2)]
		public FKuroPointCloudDataSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018CA3 RID: 101539 RVA: 0x0024A23E File Offset: 0x0024843E
		public FKuroPointCloudDataSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018CA4 RID: 101540 RVA: 0x0024A249 File Offset: 0x00248449
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointCloudDataSet(Pointer, false, true);
		}

		// Token: 0x06018CA5 RID: 101541 RVA: 0x0024A253 File Offset: 0x00248453
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointCloudDataSet(Pointer, MemoryOwner);
		}

		// Token: 0x0400D675 RID: 54901
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudDataSet";

		// Token: 0x0400D676 RID: 54902
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D677 RID: 54903
		internal static int __PropertyOffset_CustomPointInfos;

		// Token: 0x0400D678 RID: 54904
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKPCWDynamicCustomPointInfo> _CustomPointInfos;
	}
}
