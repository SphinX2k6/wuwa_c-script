using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002DA RID: 730
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BtSaveLoadRecordItem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FBtSaveLoadRecordItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004EC7 RID: 20167 RVA: 0x0006E0F9 File Offset: 0x0006C2F9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBtSaveLoadRecordItem._ScriptStructPtr != 0) ? FBtSaveLoadRecordItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAI.BtSaveLoadRecordItem", ref FBtSaveLoadRecordItem._ScriptStructPtr);
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x0006E11D File Offset: 0x0006C31D
		// (set) Token: 0x06004EC9 RID: 20169 RVA: 0x0006E12D File Offset: 0x0006C32D
		public unsafe int RunBehaviorNodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBtSaveLoadRecordItem.__PropertyOffset_RunBehaviorNodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBtSaveLoadRecordItem.__PropertyOffset_RunBehaviorNodeId) = value;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06004ECA RID: 20170 RVA: 0x0006E140 File Offset: 0x0006C340
		// (set) Token: 0x06004ECB RID: 20171 RVA: 0x0006E183 File Offset: 0x0006C383
		public TMap<int, int> SavedNodeMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._SavedNodeMap) == null)
				{
					result = (this._SavedNodeMap = new TMap<int, int>(base.NativePtr + (IntPtr)FBtSaveLoadRecordItem.__PropertyOffset_SavedNodeMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SavedNodeMap.CopyAssign(value);
			}
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x0006E191 File Offset: 0x0006C391
		public FBtSaveLoadRecordItem()
		{
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x0006E199 File Offset: 0x0006C399
		protected override IntPtr GetUStructPtr()
		{
			return FBtSaveLoadRecordItem.StaticStruct();
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x0006E1A5 File Offset: 0x0006C3A5
		[NullableContext(2)]
		public FBtSaveLoadRecordItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x0006E1AF File Offset: 0x0006C3AF
		public FBtSaveLoadRecordItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x0006E1BA File Offset: 0x0006C3BA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBtSaveLoadRecordItem(Pointer, false, true);
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x0006E1C4 File Offset: 0x0006C3C4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBtSaveLoadRecordItem(Pointer, MemoryOwner);
		}

		// Token: 0x04001F82 RID: 8066
		public const string __ObjectPath = "/Script/KuroAI.BtSaveLoadRecordItem";

		// Token: 0x04001F83 RID: 8067
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F84 RID: 8068
		internal static int __PropertyOffset_RunBehaviorNodeId;

		// Token: 0x04001F85 RID: 8069
		internal static int __PropertyOffset_SavedNodeMap;

		// Token: 0x04001F86 RID: 8070
		[Nullable(2)]
		private TMap<int, int> _SavedNodeMap;
	}
}
