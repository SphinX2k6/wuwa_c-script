using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B4 RID: 1972
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorComponentInstanceData")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FActorComponentInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600698C RID: 27020 RVA: 0x00097895 File Offset: 0x00095A95
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorComponentInstanceData._ScriptStructPtr != 0) ? FActorComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorComponentInstanceData", ref FActorComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x0600698D RID: 27021 RVA: 0x000978B9 File Offset: 0x00095AB9
		// (set) Token: 0x0600698E RID: 27022 RVA: 0x000978CD File Offset: 0x00095ACD
		[Nullable(2)]
		public unsafe UObject SourceComponentTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FActorComponentInstanceData.__PropertyOffset_SourceComponentTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActorComponentInstanceData.__PropertyOffset_SourceComponentTemplate, value);
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x0600698F RID: 27023 RVA: 0x000978E2 File Offset: 0x00095AE2
		// (set) Token: 0x06006990 RID: 27024 RVA: 0x000978F2 File Offset: 0x00095AF2
		public unsafe EComponentCreationMethod SourceComponentCreationMethod
		{
			get
			{
				return (EComponentCreationMethod)(*(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_SourceComponentCreationMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_SourceComponentCreationMethod) = (byte)value;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x00097903 File Offset: 0x00095B03
		// (set) Token: 0x06006992 RID: 27026 RVA: 0x00097913 File Offset: 0x00095B13
		public unsafe int SourceComponentTypeSerializedIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_SourceComponentTypeSerializedIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_SourceComponentTypeSerializedIndex) = value;
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06006993 RID: 27027 RVA: 0x00097924 File Offset: 0x00095B24
		// (set) Token: 0x06006994 RID: 27028 RVA: 0x00097967 File Offset: 0x00095B67
		public TArray<byte> SavedProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._SavedProperties) == null)
				{
					result = (this._SavedProperties = new TArray<byte>(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_SavedProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SavedProperties.CopyAssign(value);
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06006995 RID: 27029 RVA: 0x00097978 File Offset: 0x00095B78
		// (set) Token: 0x06006996 RID: 27030 RVA: 0x000979BB File Offset: 0x00095BBB
		public FActorComponentDuplicatedObjectData UniqueTransientPackage
		{
			get
			{
				base.FastCheckIsValid();
				FActorComponentDuplicatedObjectData result;
				if ((result = this._UniqueTransientPackage) == null)
				{
					result = (this._UniqueTransientPackage = new FActorComponentDuplicatedObjectData(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_UniqueTransientPackage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorComponentDuplicatedObjectData.StaticStruct(), base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_UniqueTransientPackage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06006997 RID: 27031 RVA: 0x000979DC File Offset: 0x00095BDC
		// (set) Token: 0x06006998 RID: 27032 RVA: 0x00097A1F File Offset: 0x00095C1F
		public TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorComponentDuplicatedObjectData> result;
				if ((result = this._DuplicatedObjects) == null)
				{
					result = (this._DuplicatedObjects = new TArray<FActorComponentDuplicatedObjectData>(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_DuplicatedObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DuplicatedObjects.CopyAssign(value);
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06006999 RID: 27033 RVA: 0x00097A30 File Offset: 0x00095C30
		// (set) Token: 0x0600699A RID: 27034 RVA: 0x00097A73 File Offset: 0x00095C73
		public TArray<UObject> ReferencedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferencedObjects) == null)
				{
					result = (this._ReferencedObjects = new TArray<UObject>(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_ReferencedObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReferencedObjects.CopyAssign(value);
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600699B RID: 27035 RVA: 0x00097A84 File Offset: 0x00095C84
		// (set) Token: 0x0600699C RID: 27036 RVA: 0x00097AC7 File Offset: 0x00095CC7
		public TArray<FName> ReferencedNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ReferencedNames) == null)
				{
					result = (this._ReferencedNames = new TArray<FName>(base.NativePtr + (IntPtr)FActorComponentInstanceData.__PropertyOffset_ReferencedNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReferencedNames.CopyAssign(value);
			}
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x00097AD5 File Offset: 0x00095CD5
		public FActorComponentInstanceData()
		{
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x00097AE0 File Offset: 0x00095CE0
		public FActorComponentInstanceData(UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.SourceComponentTemplate = SourceComponentTemplate;
			this.SourceComponentCreationMethod = SourceComponentCreationMethod;
			this.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			this.SavedProperties = SavedProperties;
			this.UniqueTransientPackage = UniqueTransientPackage;
			this.DuplicatedObjects = DuplicatedObjects;
			this.ReferencedObjects = ReferencedObjects;
			this.ReferencedNames = ReferencedNames;
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x00097B30 File Offset: 0x00095D30
		protected override IntPtr GetUStructPtr()
		{
			return FActorComponentInstanceData.StaticStruct();
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x00097B3C File Offset: 0x00095D3C
		[NullableContext(2)]
		public FActorComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x00097B46 File Offset: 0x00095D46
		public FActorComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x00097B51 File Offset: 0x00095D51
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x00097B5B File Offset: 0x00095D5B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040032E0 RID: 13024
		public const string __ObjectPath = "/Script/Engine.ActorComponentInstanceData";

		// Token: 0x040032E1 RID: 13025
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040032E2 RID: 13026
		internal static int __PropertyOffset_SourceComponentTemplate;

		// Token: 0x040032E3 RID: 13027
		internal static int __PropertyOffset_SourceComponentCreationMethod;

		// Token: 0x040032E4 RID: 13028
		internal static int __PropertyOffset_SourceComponentTypeSerializedIndex;

		// Token: 0x040032E5 RID: 13029
		internal static int __PropertyOffset_SavedProperties;

		// Token: 0x040032E6 RID: 13030
		[Nullable(2)]
		private TArray<byte> _SavedProperties;

		// Token: 0x040032E7 RID: 13031
		internal static int __PropertyOffset_UniqueTransientPackage;

		// Token: 0x040032E8 RID: 13032
		[Nullable(2)]
		private FActorComponentDuplicatedObjectData _UniqueTransientPackage;

		// Token: 0x040032E9 RID: 13033
		internal static int __PropertyOffset_DuplicatedObjects;

		// Token: 0x040032EA RID: 13034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorComponentDuplicatedObjectData> _DuplicatedObjects;

		// Token: 0x040032EB RID: 13035
		internal static int __PropertyOffset_ReferencedObjects;

		// Token: 0x040032EC RID: 13036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferencedObjects;

		// Token: 0x040032ED RID: 13037
		internal static int __PropertyOffset_ReferencedNames;

		// Token: 0x040032EE RID: 13038
		[Nullable(2)]
		private TArray<FName> _ReferencedNames;
	}
}
