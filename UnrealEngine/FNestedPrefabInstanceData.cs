using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002653 RID: 9811
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.NestedPrefabInstanceData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNestedPrefabInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024768 RID: 149352 RVA: 0x0035F91B File Offset: 0x0035DB1B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNestedPrefabInstanceData._ScriptStructPtr != 0) ? FNestedPrefabInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PrefabSystem.NestedPrefabInstanceData", ref FNestedPrefabInstanceData._ScriptStructPtr);
		}

		// Token: 0x17008C8F RID: 35983
		// (get) Token: 0x06024769 RID: 149353 RVA: 0x0035F93F File Offset: 0x0035DB3F
		// (set) Token: 0x0602476A RID: 149354 RVA: 0x0035F94F File Offset: 0x0035DB4F
		public unsafe int PrefabInstanceFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_PrefabInstanceFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_PrefabInstanceFileID) = value;
			}
		}

		// Token: 0x17008C90 RID: 35984
		// (get) Token: 0x0602476B RID: 149355 RVA: 0x0035F960 File Offset: 0x0035DB60
		// (set) Token: 0x0602476C RID: 149356 RVA: 0x0035F974 File Offset: 0x0035DB74
		public unsafe FGuid SourcePrefabGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_SourcePrefabGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_SourcePrefabGuid) = value;
			}
		}

		// Token: 0x17008C91 RID: 35985
		// (get) Token: 0x0602476D RID: 149357 RVA: 0x0035F989 File Offset: 0x0035DB89
		// (set) Token: 0x0602476E RID: 149358 RVA: 0x0035F999 File Offset: 0x0035DB99
		public unsafe int ParentFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_ParentFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_ParentFileID) = value;
			}
		}

		// Token: 0x17008C92 RID: 35986
		// (get) Token: 0x0602476F RID: 149359 RVA: 0x0035F9AA File Offset: 0x0035DBAA
		// (set) Token: 0x06024770 RID: 149360 RVA: 0x0035F9BA File Offset: 0x0035DBBA
		public unsafe int HierarchyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_HierarchyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_HierarchyIndex) = value;
			}
		}

		// Token: 0x17008C93 RID: 35987
		// (get) Token: 0x06024771 RID: 149361 RVA: 0x0035F9CC File Offset: 0x0035DBCC
		// (set) Token: 0x06024772 RID: 149362 RVA: 0x0035FA0F File Offset: 0x0035DC0F
		public FSoftObjectPath SourcePrefabPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._SourcePrefabPath) == null)
				{
					result = (this._SourcePrefabPath = new FSoftObjectPath(base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_SourcePrefabPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FNestedPrefabInstanceData.__PropertyOffset_SourcePrefabPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008C94 RID: 35988
		// (get) Token: 0x06024773 RID: 149363 RVA: 0x0035FA30 File Offset: 0x0035DC30
		// (set) Token: 0x06024774 RID: 149364 RVA: 0x0035FA44 File Offset: 0x0035DC44
		[Nullable(2)]
		public unsafe UObject SourcePrefabAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FNestedPrefabInstanceData.__PropertyOffset_SourcePrefabAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNestedPrefabInstanceData.__PropertyOffset_SourcePrefabAsset, value);
			}
		}

		// Token: 0x06024775 RID: 149365 RVA: 0x0035FA59 File Offset: 0x0035DC59
		public FNestedPrefabInstanceData()
		{
		}

		// Token: 0x06024776 RID: 149366 RVA: 0x0035FA61 File Offset: 0x0035DC61
		public FNestedPrefabInstanceData(int PrefabInstanceFileID, FGuid SourcePrefabGuid, int ParentFileID, int HierarchyIndex, FSoftObjectPath SourcePrefabPath, UObject SourcePrefabAsset)
		{
			this.PrefabInstanceFileID = PrefabInstanceFileID;
			this.SourcePrefabGuid = SourcePrefabGuid;
			this.ParentFileID = ParentFileID;
			this.HierarchyIndex = HierarchyIndex;
			this.SourcePrefabPath = SourcePrefabPath;
			this.SourcePrefabAsset = SourcePrefabAsset;
		}

		// Token: 0x06024777 RID: 149367 RVA: 0x0035FA96 File Offset: 0x0035DC96
		protected override IntPtr GetUStructPtr()
		{
			return FNestedPrefabInstanceData.StaticStruct();
		}

		// Token: 0x06024778 RID: 149368 RVA: 0x0035FAA2 File Offset: 0x0035DCA2
		[NullableContext(2)]
		public FNestedPrefabInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024779 RID: 149369 RVA: 0x0035FAAC File Offset: 0x0035DCAC
		public FNestedPrefabInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602477A RID: 149370 RVA: 0x0035FAB7 File Offset: 0x0035DCB7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNestedPrefabInstanceData(Pointer, false, true);
		}

		// Token: 0x0602477B RID: 149371 RVA: 0x0035FAC1 File Offset: 0x0035DCC1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNestedPrefabInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04013969 RID: 80233
		public const string __ObjectPath = "/Script/PrefabSystem.NestedPrefabInstanceData";

		// Token: 0x0401396A RID: 80234
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401396B RID: 80235
		internal static int __PropertyOffset_PrefabInstanceFileID;

		// Token: 0x0401396C RID: 80236
		internal static int __PropertyOffset_SourcePrefabGuid;

		// Token: 0x0401396D RID: 80237
		internal static int __PropertyOffset_ParentFileID;

		// Token: 0x0401396E RID: 80238
		internal static int __PropertyOffset_HierarchyIndex;

		// Token: 0x0401396F RID: 80239
		internal static int __PropertyOffset_SourcePrefabPath;

		// Token: 0x04013970 RID: 80240
		[Nullable(2)]
		private FSoftObjectPath _SourcePrefabPath;

		// Token: 0x04013971 RID: 80241
		internal static int __PropertyOffset_SourcePrefabAsset;
	}
}
