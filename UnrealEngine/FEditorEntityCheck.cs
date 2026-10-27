using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000A55 RID: 2645
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EditorEntityCheck")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FEditorEntityCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008FA5 RID: 36773 RVA: 0x000CD97C File Offset: 0x000CBB7C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditorEntityCheck._ScriptStructPtr != 0) ? FEditorEntityCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EditorEntityCheck", ref FEditorEntityCheck._ScriptStructPtr);
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06008FA6 RID: 36774 RVA: 0x000CD9A0 File Offset: 0x000CBBA0
		// (set) Token: 0x06008FA7 RID: 36775 RVA: 0x000CD9B4 File Offset: 0x000CBBB4
		public unsafe string DefaultDatalayer
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_DefaultDatalayer)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_DefaultDatalayer)), value);
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x000CD9C9 File Offset: 0x000CBBC9
		// (set) Token: 0x06008FA9 RID: 36777 RVA: 0x000CD9DD File Offset: 0x000CBBDD
		public unsafe string TargetRuntimeGrid
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_TargetRuntimeGrid)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_TargetRuntimeGrid)), value);
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06008FAA RID: 36778 RVA: 0x000CD9F2 File Offset: 0x000CBBF2
		// (set) Token: 0x06008FAB RID: 36779 RVA: 0x000CDA06 File Offset: 0x000CBC06
		public unsafe string SpetialFolderRex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_SpetialFolderRex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_SpetialFolderRex)), value);
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06008FAC RID: 36780 RVA: 0x000CDA1B File Offset: 0x000CBC1B
		// (set) Token: 0x06008FAD RID: 36781 RVA: 0x000CDA2F File Offset: 0x000CBC2F
		public unsafe string SpetialFolderDataLayer
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_SpetialFolderDataLayer)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEditorEntityCheck.__PropertyOffset_SpetialFolderDataLayer)), value);
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06008FAE RID: 36782 RVA: 0x000CDA44 File Offset: 0x000CBC44
		// (set) Token: 0x06008FAF RID: 36783 RVA: 0x000CDA87 File Offset: 0x000CBC87
		public TArray<string> ExcludeFolderRexs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExcludeFolderRexs) == null)
				{
					result = (this._ExcludeFolderRexs = new TArray<string>(base.NativePtr + (IntPtr)FEditorEntityCheck.__PropertyOffset_ExcludeFolderRexs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExcludeFolderRexs.CopyAssign(value);
			}
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x000CDA95 File Offset: 0x000CBC95
		public FEditorEntityCheck()
		{
		}

		// Token: 0x06008FB1 RID: 36785 RVA: 0x000CDA9D File Offset: 0x000CBC9D
		public FEditorEntityCheck(string DefaultDatalayer, string TargetRuntimeGrid, string SpetialFolderRex, string SpetialFolderDataLayer, TArray<string> ExcludeFolderRexs)
		{
			this.DefaultDatalayer = DefaultDatalayer;
			this.TargetRuntimeGrid = TargetRuntimeGrid;
			this.SpetialFolderRex = SpetialFolderRex;
			this.SpetialFolderDataLayer = SpetialFolderDataLayer;
			this.ExcludeFolderRexs = ExcludeFolderRexs;
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x000CDACA File Offset: 0x000CBCCA
		protected override IntPtr GetUStructPtr()
		{
			return FEditorEntityCheck.StaticStruct();
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x000CDAD6 File Offset: 0x000CBCD6
		[NullableContext(2)]
		public FEditorEntityCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x000CDAE0 File Offset: 0x000CBCE0
		public FEditorEntityCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x000CDAEB File Offset: 0x000CBCEB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditorEntityCheck(Pointer, false, true);
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x000CDAF5 File Offset: 0x000CBCF5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditorEntityCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04004701 RID: 18177
		public const string __ObjectPath = "/Script/Engine.EditorEntityCheck";

		// Token: 0x04004702 RID: 18178
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004703 RID: 18179
		internal static int __PropertyOffset_DefaultDatalayer;

		// Token: 0x04004704 RID: 18180
		internal static int __PropertyOffset_TargetRuntimeGrid;

		// Token: 0x04004705 RID: 18181
		internal static int __PropertyOffset_SpetialFolderRex;

		// Token: 0x04004706 RID: 18182
		internal static int __PropertyOffset_SpetialFolderDataLayer;

		// Token: 0x04004707 RID: 18183
		internal static int __PropertyOffset_ExcludeFolderRexs;

		// Token: 0x04004708 RID: 18184
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludeFolderRexs;
	}
}
