using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000931 RID: 2353
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ChildActorComponentInstanceData")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FChildActorComponentInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060084FC RID: 34044 RVA: 0x000BDA70 File Offset: 0x000BBC70
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChildActorComponentInstanceData._ScriptStructPtr != 0) ? FChildActorComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ChildActorComponentInstanceData", ref FChildActorComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x060084FD RID: 34045 RVA: 0x000BDA94 File Offset: 0x000BBC94
		// (set) Token: 0x060084FE RID: 34046 RVA: 0x000BDAA8 File Offset: 0x000BBCA8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> ChildActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FChildActorComponentInstanceData.__PropertyOffset_ChildActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FChildActorComponentInstanceData.__PropertyOffset_ChildActorClass) = value;
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x060084FF RID: 34047 RVA: 0x000BDABD File Offset: 0x000BBCBD
		// (set) Token: 0x06008500 RID: 34048 RVA: 0x000BDAD1 File Offset: 0x000BBCD1
		public unsafe FName ChildActorName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChildActorComponentInstanceData.__PropertyOffset_ChildActorName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChildActorComponentInstanceData.__PropertyOffset_ChildActorName) = value;
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06008501 RID: 34049 RVA: 0x000BDAE8 File Offset: 0x000BBCE8
		// (set) Token: 0x06008502 RID: 34050 RVA: 0x000BDB2B File Offset: 0x000BBD2B
		public TArray<FChildActorAttachedActorInfo> AttachedActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FChildActorAttachedActorInfo> result;
				if ((result = this._AttachedActors) == null)
				{
					result = (this._AttachedActors = new TArray<FChildActorAttachedActorInfo>(base.NativePtr + (IntPtr)FChildActorComponentInstanceData.__PropertyOffset_AttachedActors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttachedActors.CopyAssign(value);
			}
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x000BDB39 File Offset: 0x000BBD39
		public FChildActorComponentInstanceData()
		{
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x000BDB44 File Offset: 0x000BBD44
		public FChildActorComponentInstanceData([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ChildActorClass, FName ChildActorName, TArray<FChildActorAttachedActorInfo> AttachedActors, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.ChildActorClass = ChildActorClass;
			this.ChildActorName = ChildActorName;
			this.AttachedActors = AttachedActors;
			base.AttachedInstanceComponents = AttachedInstanceComponents;
			base.SourceComponentTemplate = SourceComponentTemplate;
			base.SourceComponentCreationMethod = SourceComponentCreationMethod;
			base.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			base.SavedProperties = SavedProperties;
			base.UniqueTransientPackage = UniqueTransientPackage;
			base.DuplicatedObjects = DuplicatedObjects;
			base.ReferencedObjects = ReferencedObjects;
			base.ReferencedNames = ReferencedNames;
		}

		// Token: 0x06008505 RID: 34053 RVA: 0x000BDBB4 File Offset: 0x000BBDB4
		protected override IntPtr GetUStructPtr()
		{
			return FChildActorComponentInstanceData.StaticStruct();
		}

		// Token: 0x06008506 RID: 34054 RVA: 0x000BDBC0 File Offset: 0x000BBDC0
		[NullableContext(2)]
		public FChildActorComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008507 RID: 34055 RVA: 0x000BDBCA File Offset: 0x000BBDCA
		public FChildActorComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008508 RID: 34056 RVA: 0x000BDBD5 File Offset: 0x000BBDD5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChildActorComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x06008509 RID: 34057 RVA: 0x000BDBDF File Offset: 0x000BBDDF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChildActorComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04003F49 RID: 16201
		public new const string __ObjectPath = "/Script/Engine.ChildActorComponentInstanceData";

		// Token: 0x04003F4A RID: 16202
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003F4B RID: 16203
		internal static int __PropertyOffset_ChildActorClass;

		// Token: 0x04003F4C RID: 16204
		internal static int __PropertyOffset_ChildActorName;

		// Token: 0x04003F4D RID: 16205
		internal static int __PropertyOffset_AttachedActors;

		// Token: 0x04003F4E RID: 16206
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FChildActorAttachedActorInfo> _AttachedActors;
	}
}
