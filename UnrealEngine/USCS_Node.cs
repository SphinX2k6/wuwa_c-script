using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010DF RID: 4319
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SCS_Node")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class USCS_Node : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F7A5 RID: 63397 RVA: 0x0016E776 File Offset: 0x0016C976
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USCS_Node._ClassPtr;
		}

		// Token: 0x0600F7A6 RID: 63398 RVA: 0x0016E784 File Offset: 0x0016C984
		public USCS_Node() : this(BuiltinUtils.AllocNativeUObject(USCS_Node.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F7A7 RID: 63399 RVA: 0x0016E7AC File Offset: 0x0016C9AC
		public USCS_Node(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USCS_Node.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0600F7A8 RID: 63400 RVA: 0x0016E7DF File Offset: 0x0016C9DF
		// (set) Token: 0x0600F7A9 RID: 63401 RVA: 0x0016E7F3 File Offset: 0x0016C9F3
		public unsafe UClassStackOnlyPtr ComponentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_ComponentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_ComponentClass) = value;
			}
		}

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x0600F7AA RID: 63402 RVA: 0x0016E808 File Offset: 0x0016CA08
		// (set) Token: 0x0600F7AB RID: 63403 RVA: 0x0016E81C File Offset: 0x0016CA1C
		[Nullable(2)]
		public unsafe UActorComponent ComponentTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USCS_Node.__PropertyOffset_ComponentTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USCS_Node.__PropertyOffset_ComponentTemplate, value);
			}
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0600F7AC RID: 63404 RVA: 0x0016E834 File Offset: 0x0016CA34
		// (set) Token: 0x0600F7AD RID: 63405 RVA: 0x0016E86D File Offset: 0x0016CA6D
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData
		{
			get
			{
				base.FastCheckIsValid();
				FBlueprintCookedComponentInstancingData result;
				if ((result = this._CookedComponentInstancingData) == null)
				{
					result = (this._CookedComponentInstancingData = new FBlueprintCookedComponentInstancingData(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_CookedComponentInstancingData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlueprintCookedComponentInstancingData.StaticStruct(), base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_CookedComponentInstancingData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0600F7AE RID: 63406 RVA: 0x0016E88E File Offset: 0x0016CA8E
		// (set) Token: 0x0600F7AF RID: 63407 RVA: 0x0016E8A2 File Offset: 0x0016CAA2
		public unsafe FName AttachToName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_AttachToName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_AttachToName) = value;
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0600F7B0 RID: 63408 RVA: 0x0016E8B7 File Offset: 0x0016CAB7
		// (set) Token: 0x0600F7B1 RID: 63409 RVA: 0x0016E8CB File Offset: 0x0016CACB
		public unsafe FName ParentComponentOrVariableName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_ParentComponentOrVariableName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_ParentComponentOrVariableName) = value;
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0600F7B2 RID: 63410 RVA: 0x0016E8E0 File Offset: 0x0016CAE0
		// (set) Token: 0x0600F7B3 RID: 63411 RVA: 0x0016E8F4 File Offset: 0x0016CAF4
		public unsafe FName ParentComponentOwnerClassName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_ParentComponentOwnerClassName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_ParentComponentOwnerClassName) = value;
			}
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0600F7B4 RID: 63412 RVA: 0x0016E909 File Offset: 0x0016CB09
		// (set) Token: 0x0600F7B5 RID: 63413 RVA: 0x0016E919 File Offset: 0x0016CB19
		public unsafe bool bIsParentComponentNative
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_bIsParentComponentNative) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_bIsParentComponentNative) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0600F7B6 RID: 63414 RVA: 0x0016E92C File Offset: 0x0016CB2C
		// (set) Token: 0x0600F7B7 RID: 63415 RVA: 0x0016E965 File Offset: 0x0016CB65
		public TArray<USCS_Node> ChildNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USCS_Node> result;
				if ((result = this._ChildNodes) == null)
				{
					result = (this._ChildNodes = new TArray<USCS_Node>(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_ChildNodes, this));
				}
				return result;
			}
			set
			{
				this.ChildNodes.CopyAssign(value);
			}
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0600F7B8 RID: 63416 RVA: 0x0016E974 File Offset: 0x0016CB74
		// (set) Token: 0x0600F7B9 RID: 63417 RVA: 0x0016E9AD File Offset: 0x0016CBAD
		public TArray<FBPVariableMetaDataEntry> MetaDataArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBPVariableMetaDataEntry> result;
				if ((result = this._MetaDataArray) == null)
				{
					result = (this._MetaDataArray = new TArray<FBPVariableMetaDataEntry>(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_MetaDataArray, this));
				}
				return result;
			}
			set
			{
				this.MetaDataArray.CopyAssign(value);
			}
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0600F7BA RID: 63418 RVA: 0x0016E9BB File Offset: 0x0016CBBB
		// (set) Token: 0x0600F7BB RID: 63419 RVA: 0x0016E9CF File Offset: 0x0016CBCF
		public unsafe FGuid VariableGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_VariableGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_VariableGuid) = value;
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0600F7BC RID: 63420 RVA: 0x0016E9E4 File Offset: 0x0016CBE4
		// (set) Token: 0x0600F7BD RID: 63421 RVA: 0x0016E9F8 File Offset: 0x0016CBF8
		public unsafe FName InternalVariableName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_InternalVariableName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USCS_Node.__PropertyOffset_InternalVariableName) = value;
			}
		}

		// Token: 0x0600F7BE RID: 63422 RVA: 0x0016EA0D File Offset: 0x0016CC0D
		static USCS_Node()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SCS_Node");
		}

		// Token: 0x0600F7BF RID: 63423 RVA: 0x0016EA1B File Offset: 0x0016CC1B
		protected USCS_Node(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040085CF RID: 34255
		public new const string __ObjectPath = "/Script/Engine.SCS_Node";

		// Token: 0x040085D0 RID: 34256
		private static IntPtr _ClassPtr;

		// Token: 0x040085D1 RID: 34257
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040085D2 RID: 34258
		internal static int __PropertyOffset_ComponentClass;

		// Token: 0x040085D3 RID: 34259
		internal static int __PropertyOffset_ComponentTemplate;

		// Token: 0x040085D4 RID: 34260
		internal static int __PropertyOffset_CookedComponentInstancingData;

		// Token: 0x040085D5 RID: 34261
		[Nullable(2)]
		private FBlueprintCookedComponentInstancingData _CookedComponentInstancingData;

		// Token: 0x040085D6 RID: 34262
		internal static int __PropertyOffset_AttachToName;

		// Token: 0x040085D7 RID: 34263
		internal static int __PropertyOffset_ParentComponentOrVariableName;

		// Token: 0x040085D8 RID: 34264
		internal static int __PropertyOffset_ParentComponentOwnerClassName;

		// Token: 0x040085D9 RID: 34265
		internal static int __PropertyOffset_bIsParentComponentNative;

		// Token: 0x040085DA RID: 34266
		internal static int __PropertyOffset_ChildNodes;

		// Token: 0x040085DB RID: 34267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USCS_Node> _ChildNodes;

		// Token: 0x040085DC RID: 34268
		internal static int __PropertyOffset_MetaDataArray;

		// Token: 0x040085DD RID: 34269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBPVariableMetaDataEntry> _MetaDataArray;

		// Token: 0x040085DE RID: 34270
		internal static int __PropertyOffset_VariableGuid;

		// Token: 0x040085DF RID: 34271
		internal static int __PropertyOffset_InternalVariableName;
	}
}
