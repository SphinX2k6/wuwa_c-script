using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014FE RID: 5374
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniPDGAssetLink")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UHoudiniPDGAssetLink : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601379B RID: 79771 RVA: 0x001CA222 File Offset: 0x001C8422
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniPDGAssetLink._ClassPtr;
		}

		// Token: 0x0601379C RID: 79772 RVA: 0x001CA230 File Offset: 0x001C8430
		public UHoudiniPDGAssetLink() : this(BuiltinUtils.AllocNativeUObject(UHoudiniPDGAssetLink.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601379D RID: 79773 RVA: 0x001CA258 File Offset: 0x001C8458
		public UHoudiniPDGAssetLink(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniPDGAssetLink.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x0601379E RID: 79774 RVA: 0x001CA28B File Offset: 0x001C848B
		// (set) Token: 0x0601379F RID: 79775 RVA: 0x001CA29F File Offset: 0x001C849F
		public unsafe string AssetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_AssetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_AssetName)), value);
			}
		}

		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x060137A0 RID: 79776 RVA: 0x001CA2B4 File Offset: 0x001C84B4
		// (set) Token: 0x060137A1 RID: 79777 RVA: 0x001CA2C8 File Offset: 0x001C84C8
		public unsafe string AssetNodePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_AssetNodePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_AssetNodePath)), value);
			}
		}

		// Token: 0x17004C1F RID: 19487
		// (get) Token: 0x060137A2 RID: 79778 RVA: 0x001CA2DD File Offset: 0x001C84DD
		// (set) Token: 0x060137A3 RID: 79779 RVA: 0x001CA2ED File Offset: 0x001C84ED
		public unsafe int AssetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_AssetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_AssetID) = value;
			}
		}

		// Token: 0x17004C20 RID: 19488
		// (get) Token: 0x060137A4 RID: 79780 RVA: 0x001CA300 File Offset: 0x001C8500
		// (set) Token: 0x060137A5 RID: 79781 RVA: 0x001CA339 File Offset: 0x001C8539
		public TArray<UTOPNetwork> AllTOPNetworks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTOPNetwork> result;
				if ((result = this._AllTOPNetworks) == null)
				{
					result = (this._AllTOPNetworks = new TArray<UTOPNetwork>(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_AllTOPNetworks, this));
				}
				return result;
			}
			set
			{
				this.AllTOPNetworks.CopyAssign(value);
			}
		}

		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x060137A6 RID: 79782 RVA: 0x001CA347 File Offset: 0x001C8547
		// (set) Token: 0x060137A7 RID: 79783 RVA: 0x001CA357 File Offset: 0x001C8557
		public unsafe int SelectedTOPNetworkIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_SelectedTOPNetworkIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_SelectedTOPNetworkIndex) = value;
			}
		}

		// Token: 0x17004C22 RID: 19490
		// (get) Token: 0x060137A8 RID: 79784 RVA: 0x001CA368 File Offset: 0x001C8568
		// (set) Token: 0x060137A9 RID: 79785 RVA: 0x001CA378 File Offset: 0x001C8578
		public unsafe EPDGLinkState LinkState
		{
			get
			{
				return (EPDGLinkState)(*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_LinkState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_LinkState) = (byte)value;
			}
		}

		// Token: 0x17004C23 RID: 19491
		// (get) Token: 0x060137AA RID: 79786 RVA: 0x001CA389 File Offset: 0x001C8589
		// (set) Token: 0x060137AB RID: 79787 RVA: 0x001CA399 File Offset: 0x001C8599
		public unsafe bool bAutoCook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bAutoCook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bAutoCook) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C24 RID: 19492
		// (get) Token: 0x060137AC RID: 79788 RVA: 0x001CA3AA File Offset: 0x001C85AA
		// (set) Token: 0x060137AD RID: 79789 RVA: 0x001CA3BA File Offset: 0x001C85BA
		public unsafe bool bUseTOPNodeFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bUseTOPNodeFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bUseTOPNodeFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C25 RID: 19493
		// (get) Token: 0x060137AE RID: 79790 RVA: 0x001CA3CB File Offset: 0x001C85CB
		// (set) Token: 0x060137AF RID: 79791 RVA: 0x001CA3DB File Offset: 0x001C85DB
		public unsafe bool bUseTOPOutputFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bUseTOPOutputFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bUseTOPOutputFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C26 RID: 19494
		// (get) Token: 0x060137B0 RID: 79792 RVA: 0x001CA3EC File Offset: 0x001C85EC
		// (set) Token: 0x060137B1 RID: 79793 RVA: 0x001CA400 File Offset: 0x001C8600
		public unsafe string TOPNodeFilter
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_TOPNodeFilter)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_TOPNodeFilter)), value);
			}
		}

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x060137B2 RID: 79794 RVA: 0x001CA415 File Offset: 0x001C8615
		// (set) Token: 0x060137B3 RID: 79795 RVA: 0x001CA429 File Offset: 0x001C8629
		public unsafe string TOPOutputFilter
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_TOPOutputFilter)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_TOPOutputFilter)), value);
			}
		}

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x060137B4 RID: 79796 RVA: 0x001CA43E File Offset: 0x001C863E
		// (set) Token: 0x060137B5 RID: 79797 RVA: 0x001CA44E File Offset: 0x001C864E
		public unsafe int NumWorkItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_NumWorkItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_NumWorkItems) = value;
			}
		}

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x060137B6 RID: 79798 RVA: 0x001CA460 File Offset: 0x001C8660
		// (set) Token: 0x060137B7 RID: 79799 RVA: 0x001CA499 File Offset: 0x001C8699
		public FAggregatedWorkItemTally WorkItemTally
		{
			get
			{
				base.FastCheckIsValid();
				FAggregatedWorkItemTally result;
				if ((result = this._WorkItemTally) == null)
				{
					result = (this._WorkItemTally = new FAggregatedWorkItemTally(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_WorkItemTally, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAggregatedWorkItemTally.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_WorkItemTally, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x060137B8 RID: 79800 RVA: 0x001CA4BA File Offset: 0x001C86BA
		// (set) Token: 0x060137B9 RID: 79801 RVA: 0x001CA4CE File Offset: 0x001C86CE
		public unsafe string OutputCachePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_OutputCachePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_OutputCachePath)), value);
			}
		}

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x060137BA RID: 79802 RVA: 0x001CA4E3 File Offset: 0x001C86E3
		// (set) Token: 0x060137BB RID: 79803 RVA: 0x001CA4F3 File Offset: 0x001C86F3
		public unsafe bool bNeedsUIRefresh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bNeedsUIRefresh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_bNeedsUIRefresh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x060137BC RID: 79804 RVA: 0x001CA504 File Offset: 0x001C8704
		// (set) Token: 0x060137BD RID: 79805 RVA: 0x001CA518 File Offset: 0x001C8718
		[Nullable(2)]
		public unsafe AActor OutputParentActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniPDGAssetLink.__PropertyOffset_OutputParentActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniPDGAssetLink.__PropertyOffset_OutputParentActor, value);
			}
		}

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x060137BE RID: 79806 RVA: 0x001CA530 File Offset: 0x001C8730
		// (set) Token: 0x060137BF RID: 79807 RVA: 0x001CA569 File Offset: 0x001C8769
		public FDirectoryPath BakeFolder
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._BakeFolder) == null)
				{
					result = (this._BakeFolder = new FDirectoryPath(base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_BakeFolder, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniPDGAssetLink.__PropertyOffset_BakeFolder, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060137C0 RID: 79808 RVA: 0x001CA58A File Offset: 0x001C878A
		static UHoudiniPDGAssetLink()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniPDGAssetLink");
		}

		// Token: 0x060137C1 RID: 79809 RVA: 0x001CA598 File Offset: 0x001C8798
		protected UHoudiniPDGAssetLink(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A874 RID: 43124
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniPDGAssetLink";

		// Token: 0x0400A875 RID: 43125
		private static IntPtr _ClassPtr;

		// Token: 0x0400A876 RID: 43126
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A877 RID: 43127
		internal static int __PropertyOffset_AssetName;

		// Token: 0x0400A878 RID: 43128
		internal static int __PropertyOffset_AssetNodePath;

		// Token: 0x0400A879 RID: 43129
		internal static int __PropertyOffset_AssetID;

		// Token: 0x0400A87A RID: 43130
		internal static int __PropertyOffset_AllTOPNetworks;

		// Token: 0x0400A87B RID: 43131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTOPNetwork> _AllTOPNetworks;

		// Token: 0x0400A87C RID: 43132
		internal static int __PropertyOffset_SelectedTOPNetworkIndex;

		// Token: 0x0400A87D RID: 43133
		internal static int __PropertyOffset_LinkState;

		// Token: 0x0400A87E RID: 43134
		internal static int __PropertyOffset_bAutoCook;

		// Token: 0x0400A87F RID: 43135
		internal static int __PropertyOffset_bUseTOPNodeFilter;

		// Token: 0x0400A880 RID: 43136
		internal static int __PropertyOffset_bUseTOPOutputFilter;

		// Token: 0x0400A881 RID: 43137
		internal static int __PropertyOffset_TOPNodeFilter;

		// Token: 0x0400A882 RID: 43138
		internal static int __PropertyOffset_TOPOutputFilter;

		// Token: 0x0400A883 RID: 43139
		internal static int __PropertyOffset_NumWorkItems;

		// Token: 0x0400A884 RID: 43140
		internal static int __PropertyOffset_WorkItemTally;

		// Token: 0x0400A885 RID: 43141
		[Nullable(2)]
		private FAggregatedWorkItemTally _WorkItemTally;

		// Token: 0x0400A886 RID: 43142
		internal static int __PropertyOffset_OutputCachePath;

		// Token: 0x0400A887 RID: 43143
		internal static int __PropertyOffset_bNeedsUIRefresh;

		// Token: 0x0400A888 RID: 43144
		internal static int __PropertyOffset_OutputParentActor;

		// Token: 0x0400A889 RID: 43145
		internal static int __PropertyOffset_BakeFolder;

		// Token: 0x0400A88A RID: 43146
		[Nullable(2)]
		private FDirectoryPath _BakeFolder;
	}
}
