using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002650 RID: 9808
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.ActorSerializeData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FActorSerializeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024728 RID: 149288 RVA: 0x0035F3CF File Offset: 0x0035D5CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorSerializeData._ScriptStructPtr != 0) ? FActorSerializeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PrefabSystem.ActorSerializeData", ref FActorSerializeData._ScriptStructPtr);
		}

		// Token: 0x17008C7B RID: 35963
		// (get) Token: 0x06024729 RID: 149289 RVA: 0x0035F3F3 File Offset: 0x0035D5F3
		// (set) Token: 0x0602472A RID: 149290 RVA: 0x0035F403 File Offset: 0x0035D603
		public unsafe int ParentActorFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_ParentActorFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_ParentActorFileID) = value;
			}
		}

		// Token: 0x17008C7C RID: 35964
		// (get) Token: 0x0602472B RID: 149291 RVA: 0x0035F414 File Offset: 0x0035D614
		// (set) Token: 0x0602472C RID: 149292 RVA: 0x0035F424 File Offset: 0x0035D624
		public unsafe int RootComponentFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_RootComponentFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_RootComponentFileID) = value;
			}
		}

		// Token: 0x17008C7D RID: 35965
		// (get) Token: 0x0602472D RID: 149293 RVA: 0x0035F438 File Offset: 0x0035D638
		// (set) Token: 0x0602472E RID: 149294 RVA: 0x0035F47B File Offset: 0x0035D67B
		public TArray<byte> ActorPropertyData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ActorPropertyData) == null)
				{
					result = (this._ActorPropertyData = new TArray<byte>(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_ActorPropertyData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActorPropertyData.CopyAssign(value);
			}
		}

		// Token: 0x17008C7E RID: 35966
		// (get) Token: 0x0602472F RID: 149295 RVA: 0x0035F489 File Offset: 0x0035D689
		// (set) Token: 0x06024730 RID: 149296 RVA: 0x0035F499 File Offset: 0x0035D699
		public unsafe int RootClassIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_RootClassIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_RootClassIndex) = value;
			}
		}

		// Token: 0x17008C7F RID: 35967
		// (get) Token: 0x06024731 RID: 149297 RVA: 0x0035F4AC File Offset: 0x0035D6AC
		// (set) Token: 0x06024732 RID: 149298 RVA: 0x0035F4EF File Offset: 0x0035D6EF
		public TArray<byte> RootComponentPropertyData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._RootComponentPropertyData) == null)
				{
					result = (this._RootComponentPropertyData = new TArray<byte>(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_RootComponentPropertyData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RootComponentPropertyData.CopyAssign(value);
			}
		}

		// Token: 0x17008C80 RID: 35968
		// (get) Token: 0x06024733 RID: 149299 RVA: 0x0035F4FD File Offset: 0x0035D6FD
		// (set) Token: 0x06024734 RID: 149300 RVA: 0x0035F50D File Offset: 0x0035D70D
		public unsafe int HierarchyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_HierarchyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_HierarchyIndex) = value;
			}
		}

		// Token: 0x17008C81 RID: 35969
		// (get) Token: 0x06024735 RID: 149301 RVA: 0x0035F51E File Offset: 0x0035D71E
		// (set) Token: 0x06024736 RID: 149302 RVA: 0x0035F52E File Offset: 0x0035D72E
		public unsafe bool IsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_IsActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_IsActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C82 RID: 35970
		// (get) Token: 0x06024737 RID: 149303 RVA: 0x0035F53F File Offset: 0x0035D73F
		// (set) Token: 0x06024738 RID: 149304 RVA: 0x0035F54F File Offset: 0x0035D74F
		public unsafe int FileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_FileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_FileID) = value;
			}
		}

		// Token: 0x17008C83 RID: 35971
		// (get) Token: 0x06024739 RID: 149305 RVA: 0x0035F560 File Offset: 0x0035D760
		// (set) Token: 0x0602473A RID: 149306 RVA: 0x0035F570 File Offset: 0x0035D770
		public unsafe uint ObjectFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_ObjectFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_ObjectFlags) = (int)value;
			}
		}

		// Token: 0x17008C84 RID: 35972
		// (get) Token: 0x0602473B RID: 149307 RVA: 0x0035F581 File Offset: 0x0035D781
		// (set) Token: 0x0602473C RID: 149308 RVA: 0x0035F591 File Offset: 0x0035D791
		public unsafe int ClassIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_ClassIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSerializeData.__PropertyOffset_ClassIndex) = value;
			}
		}

		// Token: 0x0602473D RID: 149309 RVA: 0x0035F5A2 File Offset: 0x0035D7A2
		public FActorSerializeData()
		{
		}

		// Token: 0x0602473E RID: 149310 RVA: 0x0035F5AC File Offset: 0x0035D7AC
		public FActorSerializeData(int ParentActorFileID, int RootComponentFileID, TArray<byte> ActorPropertyData, int RootClassIndex, TArray<byte> RootComponentPropertyData, int HierarchyIndex, bool IsActive, ushort DisplayNameIndex, int FileID, uint ObjectFlags, int ClassIndex)
		{
			this.ParentActorFileID = ParentActorFileID;
			this.RootComponentFileID = RootComponentFileID;
			this.ActorPropertyData = ActorPropertyData;
			this.RootClassIndex = RootClassIndex;
			this.RootComponentPropertyData = RootComponentPropertyData;
			this.HierarchyIndex = HierarchyIndex;
			this.IsActive = IsActive;
			this.FileID = FileID;
			this.ObjectFlags = ObjectFlags;
			this.ClassIndex = ClassIndex;
		}

		// Token: 0x0602473F RID: 149311 RVA: 0x0035F60C File Offset: 0x0035D80C
		protected override IntPtr GetUStructPtr()
		{
			return FActorSerializeData.StaticStruct();
		}

		// Token: 0x06024740 RID: 149312 RVA: 0x0035F618 File Offset: 0x0035D818
		[NullableContext(2)]
		public FActorSerializeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024741 RID: 149313 RVA: 0x0035F622 File Offset: 0x0035D822
		public FActorSerializeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024742 RID: 149314 RVA: 0x0035F62D File Offset: 0x0035D82D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorSerializeData(Pointer, false, true);
		}

		// Token: 0x06024743 RID: 149315 RVA: 0x0035F637 File Offset: 0x0035D837
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorSerializeData(Pointer, MemoryOwner);
		}

		// Token: 0x0401394B RID: 80203
		public const string __ObjectPath = "/Script/PrefabSystem.ActorSerializeData";

		// Token: 0x0401394C RID: 80204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401394D RID: 80205
		internal static int __PropertyOffset_ParentActorFileID;

		// Token: 0x0401394E RID: 80206
		internal static int __PropertyOffset_RootComponentFileID;

		// Token: 0x0401394F RID: 80207
		internal static int __PropertyOffset_ActorPropertyData;

		// Token: 0x04013950 RID: 80208
		[Nullable(2)]
		private TArray<byte> _ActorPropertyData;

		// Token: 0x04013951 RID: 80209
		internal static int __PropertyOffset_RootClassIndex;

		// Token: 0x04013952 RID: 80210
		internal static int __PropertyOffset_RootComponentPropertyData;

		// Token: 0x04013953 RID: 80211
		[Nullable(2)]
		private TArray<byte> _RootComponentPropertyData;

		// Token: 0x04013954 RID: 80212
		internal static int __PropertyOffset_HierarchyIndex;

		// Token: 0x04013955 RID: 80213
		internal static int __PropertyOffset_IsActive;

		// Token: 0x04013956 RID: 80214
		internal static int __PropertyOffset_FileID;

		// Token: 0x04013957 RID: 80215
		internal static int __PropertyOffset_ObjectFlags;

		// Token: 0x04013958 RID: 80216
		internal static int __PropertyOffset_ClassIndex;
	}
}
