using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001032 RID: 4146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PreviewAssetAttachContainer")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPreviewAssetAttachContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E94B RID: 59723 RVA: 0x0015A959 File Offset: 0x00158B59
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPreviewAssetAttachContainer._ScriptStructPtr != 0) ? FPreviewAssetAttachContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PreviewAssetAttachContainer", ref FPreviewAssetAttachContainer._ScriptStructPtr);
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600E94C RID: 59724 RVA: 0x0015A980 File Offset: 0x00158B80
		// (set) Token: 0x0600E94D RID: 59725 RVA: 0x0015A9C3 File Offset: 0x00158BC3
		public TArray<FPreviewAttachedObjectPair> AttachedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPreviewAttachedObjectPair> result;
				if ((result = this._AttachedObjects) == null)
				{
					result = (this._AttachedObjects = new TArray<FPreviewAttachedObjectPair>(base.NativePtr + (IntPtr)FPreviewAssetAttachContainer.__PropertyOffset_AttachedObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttachedObjects.CopyAssign(value);
			}
		}

		// Token: 0x0600E94E RID: 59726 RVA: 0x0015A9D1 File Offset: 0x00158BD1
		public FPreviewAssetAttachContainer()
		{
		}

		// Token: 0x0600E94F RID: 59727 RVA: 0x0015A9D9 File Offset: 0x00158BD9
		public FPreviewAssetAttachContainer(TArray<FPreviewAttachedObjectPair> AttachedObjects)
		{
			this.AttachedObjects = AttachedObjects;
		}

		// Token: 0x0600E950 RID: 59728 RVA: 0x0015A9E8 File Offset: 0x00158BE8
		protected override IntPtr GetUStructPtr()
		{
			return FPreviewAssetAttachContainer.StaticStruct();
		}

		// Token: 0x0600E951 RID: 59729 RVA: 0x0015A9F4 File Offset: 0x00158BF4
		[NullableContext(2)]
		public FPreviewAssetAttachContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E952 RID: 59730 RVA: 0x0015A9FE File Offset: 0x00158BFE
		public FPreviewAssetAttachContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E953 RID: 59731 RVA: 0x0015AA09 File Offset: 0x00158C09
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPreviewAssetAttachContainer(Pointer, false, true);
		}

		// Token: 0x0600E954 RID: 59732 RVA: 0x0015AA13 File Offset: 0x00158C13
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPreviewAssetAttachContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04007EA6 RID: 32422
		public const string __ObjectPath = "/Script/Engine.PreviewAssetAttachContainer";

		// Token: 0x04007EA7 RID: 32423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007EA8 RID: 32424
		internal static int __PropertyOffset_AttachedObjects;

		// Token: 0x04007EA9 RID: 32425
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPreviewAttachedObjectPair> _AttachedObjects;
	}
}
