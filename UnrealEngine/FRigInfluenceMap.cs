using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000527 RID: 1319
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigInfluenceMap")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigInfluenceMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600451B RID: 17691 RVA: 0x00066E78 File Offset: 0x00065078
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigInfluenceMap._ScriptStructPtr != 0) ? FRigInfluenceMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigInfluenceMap", ref FRigInfluenceMap._ScriptStructPtr);
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x00066E9C File Offset: 0x0006509C
		// (set) Token: 0x0600451D RID: 17693 RVA: 0x00066EB0 File Offset: 0x000650B0
		public unsafe FName EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigInfluenceMap.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigInfluenceMap.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600451E RID: 17694 RVA: 0x00066EC8 File Offset: 0x000650C8
		// (set) Token: 0x0600451F RID: 17695 RVA: 0x00066F0B File Offset: 0x0006510B
		public TArray<FRigInfluenceEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigInfluenceEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRigInfluenceEntry>(base.NativePtr + (IntPtr)FRigInfluenceMap.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x00066F1C File Offset: 0x0006511C
		// (set) Token: 0x06004521 RID: 17697 RVA: 0x00066F5F File Offset: 0x0006515F
		public TMap<FRigElementKey, int> KeyToIndex
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FRigElementKey, int> result;
				if ((result = this._KeyToIndex) == null)
				{
					result = (this._KeyToIndex = new TMap<FRigElementKey, int>(base.NativePtr + (IntPtr)FRigInfluenceMap.__PropertyOffset_KeyToIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyToIndex.CopyAssign(value);
			}
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00066F6D File Offset: 0x0006516D
		public FRigInfluenceMap()
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00066F75 File Offset: 0x00065175
		public FRigInfluenceMap(FName EventName, TArray<FRigInfluenceEntry> Entries, TMap<FRigElementKey, int> KeyToIndex)
		{
			this.EventName = EventName;
			this.Entries = Entries;
			this.KeyToIndex = KeyToIndex;
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00066F92 File Offset: 0x00065192
		protected override IntPtr GetUStructPtr()
		{
			return FRigInfluenceMap.StaticStruct();
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00066F9E File Offset: 0x0006519E
		[NullableContext(2)]
		public FRigInfluenceMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00066FA8 File Offset: 0x000651A8
		public FRigInfluenceMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00066FB3 File Offset: 0x000651B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigInfluenceMap(Pointer, false, true);
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00066FBD File Offset: 0x000651BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigInfluenceMap(Pointer, MemoryOwner);
		}

		// Token: 0x040021AA RID: 8618
		public const string __ObjectPath = "/Script/ControlRig.RigInfluenceMap";

		// Token: 0x040021AB RID: 8619
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021AC RID: 8620
		internal static int __PropertyOffset_EventName;

		// Token: 0x040021AD RID: 8621
		internal static int __PropertyOffset_Entries;

		// Token: 0x040021AE RID: 8622
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigInfluenceEntry> _Entries;

		// Token: 0x040021AF RID: 8623
		internal static int __PropertyOffset_KeyToIndex;

		// Token: 0x040021B0 RID: 8624
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FRigElementKey, int> _KeyToIndex;
	}
}
