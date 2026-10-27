using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015FA RID: 5626
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BtSaveLoadRecordItem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FBtSaveLoadRecordItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014405 RID: 82949 RVA: 0x001DBC68 File Offset: 0x001D9E68
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBtSaveLoadRecordItem._ScriptStructPtr != 0) ? FBtSaveLoadRecordItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAI.BtSaveLoadRecordItem", ref FBtSaveLoadRecordItem._ScriptStructPtr);
		}

		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x06014406 RID: 82950 RVA: 0x001DBC8C File Offset: 0x001D9E8C
		// (set) Token: 0x06014407 RID: 82951 RVA: 0x001DBC9C File Offset: 0x001D9E9C
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

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x06014408 RID: 82952 RVA: 0x001DBCB0 File Offset: 0x001D9EB0
		// (set) Token: 0x06014409 RID: 82953 RVA: 0x001DBCF3 File Offset: 0x001D9EF3
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

		// Token: 0x0601440A RID: 82954 RVA: 0x001DBD01 File Offset: 0x001D9F01
		public FBtSaveLoadRecordItem()
		{
		}

		// Token: 0x0601440B RID: 82955 RVA: 0x001DBD09 File Offset: 0x001D9F09
		public FBtSaveLoadRecordItem(int RunBehaviorNodeId, TMap<int, int> SavedNodeMap)
		{
			this.RunBehaviorNodeId = RunBehaviorNodeId;
			this.SavedNodeMap = SavedNodeMap;
		}

		// Token: 0x0601440C RID: 82956 RVA: 0x001DBD1F File Offset: 0x001D9F1F
		protected override IntPtr GetUStructPtr()
		{
			return FBtSaveLoadRecordItem.StaticStruct();
		}

		// Token: 0x0601440D RID: 82957 RVA: 0x001DBD2B File Offset: 0x001D9F2B
		[NullableContext(2)]
		public FBtSaveLoadRecordItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601440E RID: 82958 RVA: 0x001DBD35 File Offset: 0x001D9F35
		public FBtSaveLoadRecordItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601440F RID: 82959 RVA: 0x001DBD40 File Offset: 0x001D9F40
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBtSaveLoadRecordItem(Pointer, false, true);
		}

		// Token: 0x06014410 RID: 82960 RVA: 0x001DBD4A File Offset: 0x001D9F4A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBtSaveLoadRecordItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400B047 RID: 45127
		public const string __ObjectPath = "/Script/KuroAI.BtSaveLoadRecordItem";

		// Token: 0x0400B048 RID: 45128
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B049 RID: 45129
		internal static int __PropertyOffset_RunBehaviorNodeId;

		// Token: 0x0400B04A RID: 45130
		internal static int __PropertyOffset_SavedNodeMap;

		// Token: 0x0400B04B RID: 45131
		[Nullable(2)]
		private TMap<int, int> _SavedNodeMap;
	}
}
