using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002651 RID: 9809
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.ComponentSerializeData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FComponentSerializeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024744 RID: 149316 RVA: 0x0035F640 File Offset: 0x0035D840
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentSerializeData._ScriptStructPtr != 0) ? FComponentSerializeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PrefabSystem.ComponentSerializeData", ref FComponentSerializeData._ScriptStructPtr);
		}

		// Token: 0x17008C85 RID: 35973
		// (get) Token: 0x06024745 RID: 149317 RVA: 0x0035F664 File Offset: 0x0035D864
		// (set) Token: 0x06024746 RID: 149318 RVA: 0x0035F674 File Offset: 0x0035D874
		public unsafe int OuterFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_OuterFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_OuterFileID) = value;
			}
		}

		// Token: 0x17008C86 RID: 35974
		// (get) Token: 0x06024747 RID: 149319 RVA: 0x0035F685 File Offset: 0x0035D885
		// (set) Token: 0x06024748 RID: 149320 RVA: 0x0035F695 File Offset: 0x0035D895
		public unsafe int ParentComponentFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_ParentComponentFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_ParentComponentFileID) = value;
			}
		}

		// Token: 0x17008C87 RID: 35975
		// (get) Token: 0x06024749 RID: 149321 RVA: 0x0035F6A6 File Offset: 0x0035D8A6
		// (set) Token: 0x0602474A RID: 149322 RVA: 0x0035F6B6 File Offset: 0x0035D8B6
		public unsafe int HierarchyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_HierarchyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_HierarchyIndex) = value;
			}
		}

		// Token: 0x17008C88 RID: 35976
		// (get) Token: 0x0602474B RID: 149323 RVA: 0x0035F6C7 File Offset: 0x0035D8C7
		// (set) Token: 0x0602474C RID: 149324 RVA: 0x0035F6DB File Offset: 0x0035D8DB
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008C89 RID: 35977
		// (get) Token: 0x0602474D RID: 149325 RVA: 0x0035F6F0 File Offset: 0x0035D8F0
		// (set) Token: 0x0602474E RID: 149326 RVA: 0x0035F733 File Offset: 0x0035D933
		public TArray<byte> PropertyData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._PropertyData) == null)
				{
					result = (this._PropertyData = new TArray<byte>(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_PropertyData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyData.CopyAssign(value);
			}
		}

		// Token: 0x17008C8A RID: 35978
		// (get) Token: 0x0602474F RID: 149327 RVA: 0x0035F741 File Offset: 0x0035D941
		// (set) Token: 0x06024750 RID: 149328 RVA: 0x0035F751 File Offset: 0x0035D951
		public unsafe int FileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_FileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_FileID) = value;
			}
		}

		// Token: 0x17008C8B RID: 35979
		// (get) Token: 0x06024751 RID: 149329 RVA: 0x0035F762 File Offset: 0x0035D962
		// (set) Token: 0x06024752 RID: 149330 RVA: 0x0035F772 File Offset: 0x0035D972
		public unsafe uint ObjectFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_ObjectFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_ObjectFlags) = (int)value;
			}
		}

		// Token: 0x17008C8C RID: 35980
		// (get) Token: 0x06024753 RID: 149331 RVA: 0x0035F783 File Offset: 0x0035D983
		// (set) Token: 0x06024754 RID: 149332 RVA: 0x0035F793 File Offset: 0x0035D993
		public unsafe int ClassIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_ClassIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSerializeData.__PropertyOffset_ClassIndex) = value;
			}
		}

		// Token: 0x06024755 RID: 149333 RVA: 0x0035F7A4 File Offset: 0x0035D9A4
		public FComponentSerializeData()
		{
		}

		// Token: 0x06024756 RID: 149334 RVA: 0x0035F7AC File Offset: 0x0035D9AC
		public FComponentSerializeData(int OuterFileID, int ParentComponentFileID, int HierarchyIndex, FName Name, TArray<byte> PropertyData, int FileID, uint ObjectFlags, int ClassIndex)
		{
			this.OuterFileID = OuterFileID;
			this.ParentComponentFileID = ParentComponentFileID;
			this.HierarchyIndex = HierarchyIndex;
			this.Name = Name;
			this.PropertyData = PropertyData;
			this.FileID = FileID;
			this.ObjectFlags = ObjectFlags;
			this.ClassIndex = ClassIndex;
		}

		// Token: 0x06024757 RID: 149335 RVA: 0x0035F7FC File Offset: 0x0035D9FC
		protected override IntPtr GetUStructPtr()
		{
			return FComponentSerializeData.StaticStruct();
		}

		// Token: 0x06024758 RID: 149336 RVA: 0x0035F808 File Offset: 0x0035DA08
		[NullableContext(2)]
		public FComponentSerializeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024759 RID: 149337 RVA: 0x0035F812 File Offset: 0x0035DA12
		public FComponentSerializeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602475A RID: 149338 RVA: 0x0035F81D File Offset: 0x0035DA1D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentSerializeData(Pointer, false, true);
		}

		// Token: 0x0602475B RID: 149339 RVA: 0x0035F827 File Offset: 0x0035DA27
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentSerializeData(Pointer, MemoryOwner);
		}

		// Token: 0x04013959 RID: 80217
		public const string __ObjectPath = "/Script/PrefabSystem.ComponentSerializeData";

		// Token: 0x0401395A RID: 80218
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401395B RID: 80219
		internal static int __PropertyOffset_OuterFileID;

		// Token: 0x0401395C RID: 80220
		internal static int __PropertyOffset_ParentComponentFileID;

		// Token: 0x0401395D RID: 80221
		internal static int __PropertyOffset_HierarchyIndex;

		// Token: 0x0401395E RID: 80222
		internal static int __PropertyOffset_Name;

		// Token: 0x0401395F RID: 80223
		internal static int __PropertyOffset_PropertyData;

		// Token: 0x04013960 RID: 80224
		[Nullable(2)]
		private TArray<byte> _PropertyData;

		// Token: 0x04013961 RID: 80225
		internal static int __PropertyOffset_FileID;

		// Token: 0x04013962 RID: 80226
		internal static int __PropertyOffset_ObjectFlags;

		// Token: 0x04013963 RID: 80227
		internal static int __PropertyOffset_ClassIndex;
	}
}
