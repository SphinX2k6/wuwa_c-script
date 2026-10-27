using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A33 RID: 6707
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudWorldCollection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroPointCloudWorldCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018D15 RID: 101653 RVA: 0x0024ABCB File Offset: 0x00248DCB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointCloudWorldCollection._ScriptStructPtr != 0) ? FKuroPointCloudWorldCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointCloudWorldCollection", ref FKuroPointCloudWorldCollection._ScriptStructPtr);
		}

		// Token: 0x1700625A RID: 25178
		// (get) Token: 0x06018D16 RID: 101654 RVA: 0x0024ABF0 File Offset: 0x00248DF0
		// (set) Token: 0x06018D17 RID: 101655 RVA: 0x0024AC33 File Offset: 0x00248E33
		public TArray<UKuroPointCloudWorldComponent> PointCloudWorldComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroPointCloudWorldComponent> result;
				if ((result = this._PointCloudWorldComponents) == null)
				{
					result = (this._PointCloudWorldComponents = new TArray<UKuroPointCloudWorldComponent>(base.NativePtr + (IntPtr)FKuroPointCloudWorldCollection.__PropertyOffset_PointCloudWorldComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PointCloudWorldComponents.CopyAssign(value);
			}
		}

		// Token: 0x06018D18 RID: 101656 RVA: 0x0024AC41 File Offset: 0x00248E41
		public FKuroPointCloudWorldCollection()
		{
		}

		// Token: 0x06018D19 RID: 101657 RVA: 0x0024AC49 File Offset: 0x00248E49
		public FKuroPointCloudWorldCollection(TArray<UKuroPointCloudWorldComponent> PointCloudWorldComponents)
		{
			this.PointCloudWorldComponents = PointCloudWorldComponents;
		}

		// Token: 0x06018D1A RID: 101658 RVA: 0x0024AC58 File Offset: 0x00248E58
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointCloudWorldCollection.StaticStruct();
		}

		// Token: 0x06018D1B RID: 101659 RVA: 0x0024AC64 File Offset: 0x00248E64
		[NullableContext(2)]
		public FKuroPointCloudWorldCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018D1C RID: 101660 RVA: 0x0024AC6E File Offset: 0x00248E6E
		public FKuroPointCloudWorldCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018D1D RID: 101661 RVA: 0x0024AC79 File Offset: 0x00248E79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointCloudWorldCollection(Pointer, false, true);
		}

		// Token: 0x06018D1E RID: 101662 RVA: 0x0024AC83 File Offset: 0x00248E83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointCloudWorldCollection(Pointer, MemoryOwner);
		}

		// Token: 0x0400D6A7 RID: 54951
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudWorldCollection";

		// Token: 0x0400D6A8 RID: 54952
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D6A9 RID: 54953
		internal static int __PropertyOffset_PointCloudWorldComponents;

		// Token: 0x0400D6AA RID: 54954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroPointCloudWorldComponent> _PointCloudWorldComponents;
	}
}
