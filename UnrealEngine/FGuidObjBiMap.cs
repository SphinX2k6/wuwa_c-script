using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002015 RID: 8213
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.GuidObjBiMap")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FGuidObjBiMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EF40 RID: 126784 RVA: 0x002E081A File Offset: 0x002DEA1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGuidObjBiMap._ScriptStructPtr != 0) ? FGuidObjBiMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.GuidObjBiMap", ref FGuidObjBiMap._ScriptStructPtr);
		}

		// Token: 0x17007B3C RID: 31548
		// (get) Token: 0x0601EF41 RID: 126785 RVA: 0x002E0840 File Offset: 0x002DEA40
		// (set) Token: 0x0601EF42 RID: 126786 RVA: 0x002E0883 File Offset: 0x002DEA83
		public TMap<FGuid, UObject> AllGuidToObjMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, UObject> result;
				if ((result = this._AllGuidToObjMap) == null)
				{
					result = (this._AllGuidToObjMap = new TMap<FGuid, UObject>(base.NativePtr + (IntPtr)FGuidObjBiMap.__PropertyOffset_AllGuidToObjMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllGuidToObjMap.CopyAssign(value);
			}
		}

		// Token: 0x17007B3D RID: 31549
		// (get) Token: 0x0601EF43 RID: 126787 RVA: 0x002E0894 File Offset: 0x002DEA94
		// (set) Token: 0x0601EF44 RID: 126788 RVA: 0x002E08D7 File Offset: 0x002DEAD7
		public TMap<UObject, FGuid> AllObjToGuidMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, FGuid> result;
				if ((result = this._AllObjToGuidMap) == null)
				{
					result = (this._AllObjToGuidMap = new TMap<UObject, FGuid>(base.NativePtr + (IntPtr)FGuidObjBiMap.__PropertyOffset_AllObjToGuidMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllObjToGuidMap.CopyAssign(value);
			}
		}

		// Token: 0x0601EF45 RID: 126789 RVA: 0x002E08E5 File Offset: 0x002DEAE5
		public FGuidObjBiMap()
		{
		}

		// Token: 0x0601EF46 RID: 126790 RVA: 0x002E08ED File Offset: 0x002DEAED
		public FGuidObjBiMap(TMap<FGuid, UObject> AllGuidToObjMap, TMap<UObject, FGuid> AllObjToGuidMap)
		{
			this.AllGuidToObjMap = AllGuidToObjMap;
			this.AllObjToGuidMap = AllObjToGuidMap;
		}

		// Token: 0x0601EF47 RID: 126791 RVA: 0x002E0903 File Offset: 0x002DEB03
		protected override IntPtr GetUStructPtr()
		{
			return FGuidObjBiMap.StaticStruct();
		}

		// Token: 0x0601EF48 RID: 126792 RVA: 0x002E090F File Offset: 0x002DEB0F
		[NullableContext(2)]
		public FGuidObjBiMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EF49 RID: 126793 RVA: 0x002E0919 File Offset: 0x002DEB19
		public FGuidObjBiMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EF4A RID: 126794 RVA: 0x002E0924 File Offset: 0x002DEB24
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGuidObjBiMap(Pointer, false, true);
		}

		// Token: 0x0601EF4B RID: 126795 RVA: 0x002E092E File Offset: 0x002DEB2E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGuidObjBiMap(Pointer, MemoryOwner);
		}

		// Token: 0x04010D44 RID: 68932
		public const string __ObjectPath = "/Script/LGUI.GuidObjBiMap";

		// Token: 0x04010D45 RID: 68933
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D46 RID: 68934
		internal static int __PropertyOffset_AllGuidToObjMap;

		// Token: 0x04010D47 RID: 68935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, UObject> _AllGuidToObjMap;

		// Token: 0x04010D48 RID: 68936
		internal static int __PropertyOffset_AllObjToGuidMap;

		// Token: 0x04010D49 RID: 68937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, FGuid> _AllObjToGuidMap;
	}
}
