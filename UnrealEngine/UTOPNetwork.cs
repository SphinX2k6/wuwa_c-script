using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200150A RID: 5386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.TOPNetwork")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UTOPNetwork : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601397F RID: 80255 RVA: 0x001CC72C File Offset: 0x001CA92C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTOPNetwork._ClassPtr;
		}

		// Token: 0x06013980 RID: 80256 RVA: 0x001CC738 File Offset: 0x001CA938
		public UTOPNetwork() : this(BuiltinUtils.AllocNativeUObject(UTOPNetwork.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013981 RID: 80257 RVA: 0x001CC760 File Offset: 0x001CA960
		public UTOPNetwork(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTOPNetwork.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x06013982 RID: 80258 RVA: 0x001CC793 File Offset: 0x001CA993
		// (set) Token: 0x06013983 RID: 80259 RVA: 0x001CC7A3 File Offset: 0x001CA9A3
		public unsafe int NodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_NodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_NodeId) = value;
			}
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x06013984 RID: 80260 RVA: 0x001CC7B4 File Offset: 0x001CA9B4
		// (set) Token: 0x06013985 RID: 80261 RVA: 0x001CC7C8 File Offset: 0x001CA9C8
		public unsafe string NodeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNetwork.__PropertyOffset_NodeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNetwork.__PropertyOffset_NodeName)), value);
			}
		}

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x06013986 RID: 80262 RVA: 0x001CC7DD File Offset: 0x001CA9DD
		// (set) Token: 0x06013987 RID: 80263 RVA: 0x001CC7F1 File Offset: 0x001CA9F1
		public unsafe string NodePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNetwork.__PropertyOffset_NodePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNetwork.__PropertyOffset_NodePath)), value);
			}
		}

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x06013988 RID: 80264 RVA: 0x001CC808 File Offset: 0x001CAA08
		// (set) Token: 0x06013989 RID: 80265 RVA: 0x001CC841 File Offset: 0x001CAA41
		public TArray<UTOPNode> AllTOPNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTOPNode> result;
				if ((result = this._AllTOPNodes) == null)
				{
					result = (this._AllTOPNodes = new TArray<UTOPNode>(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_AllTOPNodes, this));
				}
				return result;
			}
			set
			{
				this.AllTOPNodes.CopyAssign(value);
			}
		}

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x0601398A RID: 80266 RVA: 0x001CC84F File Offset: 0x001CAA4F
		// (set) Token: 0x0601398B RID: 80267 RVA: 0x001CC85F File Offset: 0x001CAA5F
		public unsafe int SelectedTOPIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_SelectedTOPIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_SelectedTOPIndex) = value;
			}
		}

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x0601398C RID: 80268 RVA: 0x001CC870 File Offset: 0x001CAA70
		// (set) Token: 0x0601398D RID: 80269 RVA: 0x001CC884 File Offset: 0x001CAA84
		public unsafe string ParentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNetwork.__PropertyOffset_ParentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNetwork.__PropertyOffset_ParentName)), value);
			}
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x0601398E RID: 80270 RVA: 0x001CC899 File Offset: 0x001CAA99
		// (set) Token: 0x0601398F RID: 80271 RVA: 0x001CC8A9 File Offset: 0x001CAAA9
		public unsafe bool bShowResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_bShowResults) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_bShowResults) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x06013990 RID: 80272 RVA: 0x001CC8BA File Offset: 0x001CAABA
		// (set) Token: 0x06013991 RID: 80273 RVA: 0x001CC8CA File Offset: 0x001CAACA
		public unsafe bool bAutoLoadResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_bAutoLoadResults) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNetwork.__PropertyOffset_bAutoLoadResults) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013992 RID: 80274 RVA: 0x001CC8DB File Offset: 0x001CAADB
		static UTOPNetwork()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.TOPNetwork");
		}

		// Token: 0x06013993 RID: 80275 RVA: 0x001CC8E9 File Offset: 0x001CAAE9
		protected UTOPNetwork(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A952 RID: 43346
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.TOPNetwork";

		// Token: 0x0400A953 RID: 43347
		private static IntPtr _ClassPtr;

		// Token: 0x0400A954 RID: 43348
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A955 RID: 43349
		internal static int __PropertyOffset_NodeId;

		// Token: 0x0400A956 RID: 43350
		internal static int __PropertyOffset_NodeName;

		// Token: 0x0400A957 RID: 43351
		internal static int __PropertyOffset_NodePath;

		// Token: 0x0400A958 RID: 43352
		internal static int __PropertyOffset_AllTOPNodes;

		// Token: 0x0400A959 RID: 43353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTOPNode> _AllTOPNodes;

		// Token: 0x0400A95A RID: 43354
		internal static int __PropertyOffset_SelectedTOPIndex;

		// Token: 0x0400A95B RID: 43355
		internal static int __PropertyOffset_ParentName;

		// Token: 0x0400A95C RID: 43356
		internal static int __PropertyOffset_bShowResults;

		// Token: 0x0400A95D RID: 43357
		internal static int __PropertyOffset_bAutoLoadResults;
	}
}
