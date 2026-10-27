using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200249B RID: 9371
	[UnrealObjectPath("/Script/NavigationSystem.NavLinkCustomInstanceData")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FNavLinkCustomInstanceData : FActorComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023175 RID: 143733 RVA: 0x0033E522 File Offset: 0x0033C722
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavLinkCustomInstanceData._ScriptStructPtr != 0) ? FNavLinkCustomInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavLinkCustomInstanceData", ref FNavLinkCustomInstanceData._ScriptStructPtr);
		}

		// Token: 0x170086DB RID: 34523
		// (get) Token: 0x06023176 RID: 143734 RVA: 0x0033E546 File Offset: 0x0033C746
		// (set) Token: 0x06023177 RID: 143735 RVA: 0x0033E556 File Offset: 0x0033C756
		public unsafe uint NavLinkUserId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavLinkCustomInstanceData.__PropertyOffset_NavLinkUserId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavLinkCustomInstanceData.__PropertyOffset_NavLinkUserId) = (int)value;
			}
		}

		// Token: 0x06023178 RID: 143736 RVA: 0x0033E567 File Offset: 0x0033C767
		public FNavLinkCustomInstanceData()
		{
		}

		// Token: 0x06023179 RID: 143737 RVA: 0x0033E570 File Offset: 0x0033C770
		[NullableContext(1)]
		public FNavLinkCustomInstanceData(uint NavLinkUserId, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.NavLinkUserId = NavLinkUserId;
			base.SourceComponentTemplate = SourceComponentTemplate;
			base.SourceComponentCreationMethod = SourceComponentCreationMethod;
			base.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			base.SavedProperties = SavedProperties;
			base.UniqueTransientPackage = UniqueTransientPackage;
			base.DuplicatedObjects = DuplicatedObjects;
			base.ReferencedObjects = ReferencedObjects;
			base.ReferencedNames = ReferencedNames;
		}

		// Token: 0x0602317A RID: 143738 RVA: 0x0033E5C8 File Offset: 0x0033C7C8
		protected override IntPtr GetUStructPtr()
		{
			return FNavLinkCustomInstanceData.StaticStruct();
		}

		// Token: 0x0602317B RID: 143739 RVA: 0x0033E5D4 File Offset: 0x0033C7D4
		[NullableContext(2)]
		public FNavLinkCustomInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602317C RID: 143740 RVA: 0x0033E5DE File Offset: 0x0033C7DE
		public FNavLinkCustomInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602317D RID: 143741 RVA: 0x0033E5E9 File Offset: 0x0033C7E9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavLinkCustomInstanceData(Pointer, false, true);
		}

		// Token: 0x0602317E RID: 143742 RVA: 0x0033E5F3 File Offset: 0x0033C7F3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavLinkCustomInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04012BBC RID: 76732
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavLinkCustomInstanceData";

		// Token: 0x04012BBD RID: 76733
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012BBE RID: 76734
		internal static int __PropertyOffset_NavLinkUserId;
	}
}
