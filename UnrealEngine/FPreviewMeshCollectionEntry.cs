using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001036 RID: 4150
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PreviewMeshCollectionEntry")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FPreviewMeshCollectionEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E96E RID: 59758 RVA: 0x0015AC26 File Offset: 0x00158E26
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPreviewMeshCollectionEntry._ScriptStructPtr != 0) ? FPreviewMeshCollectionEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PreviewMeshCollectionEntry", ref FPreviewMeshCollectionEntry._ScriptStructPtr);
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600E96F RID: 59759 RVA: 0x0015AC4A File Offset: 0x00158E4A
		// (set) Token: 0x0600E970 RID: 59760 RVA: 0x0015AC69 File Offset: 0x00158E69
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)FPreviewMeshCollectionEntry.__PropertyOffset_SkeletalMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FPreviewMeshCollectionEntry.__PropertyOffset_SkeletalMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0600E971 RID: 59761 RVA: 0x0015AC8E File Offset: 0x00158E8E
		public FPreviewMeshCollectionEntry()
		{
		}

		// Token: 0x0600E972 RID: 59762 RVA: 0x0015AC96 File Offset: 0x00158E96
		public FPreviewMeshCollectionEntry(TSoftObjectPtr<USkeletalMesh> SkeletalMesh)
		{
			this.SkeletalMesh = SkeletalMesh;
		}

		// Token: 0x0600E973 RID: 59763 RVA: 0x0015ACA5 File Offset: 0x00158EA5
		protected override IntPtr GetUStructPtr()
		{
			return FPreviewMeshCollectionEntry.StaticStruct();
		}

		// Token: 0x0600E974 RID: 59764 RVA: 0x0015ACB1 File Offset: 0x00158EB1
		[NullableContext(2)]
		public FPreviewMeshCollectionEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E975 RID: 59765 RVA: 0x0015ACBB File Offset: 0x00158EBB
		public FPreviewMeshCollectionEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x0015ACC6 File Offset: 0x00158EC6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPreviewMeshCollectionEntry(Pointer, false, true);
		}

		// Token: 0x0600E977 RID: 59767 RVA: 0x0015ACD0 File Offset: 0x00158ED0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPreviewMeshCollectionEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04007EB7 RID: 32439
		public const string __ObjectPath = "/Script/Engine.PreviewMeshCollectionEntry";

		// Token: 0x04007EB8 RID: 32440
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007EB9 RID: 32441
		internal static int __PropertyOffset_SkeletalMesh;
	}
}
