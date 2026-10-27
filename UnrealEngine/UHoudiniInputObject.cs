using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D6 RID: 5334
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputObject")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UHoudiniInputObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013526 RID: 79142 RVA: 0x001C6928 File Offset: 0x001C4B28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputObject._ClassPtr;
		}

		// Token: 0x06013527 RID: 79143 RVA: 0x001C6934 File Offset: 0x001C4B34
		public UHoudiniInputObject() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013528 RID: 79144 RVA: 0x001C695C File Offset: 0x001C4B5C
		public UHoudiniInputObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x06013529 RID: 79145 RVA: 0x001C698F File Offset: 0x001C4B8F
		// (set) Token: 0x0601352A RID: 79146 RVA: 0x001C69A4 File Offset: 0x001C4BA4
		public TSoftObjectPtr<UObject> InputObject
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_InputObject, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_InputObject, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x0601352B RID: 79147 RVA: 0x001C69C9 File Offset: 0x001C4BC9
		// (set) Token: 0x0601352C RID: 79148 RVA: 0x001C69DD File Offset: 0x001C4BDD
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x0601352D RID: 79149 RVA: 0x001C69F2 File Offset: 0x001C4BF2
		// (set) Token: 0x0601352E RID: 79150 RVA: 0x001C6A02 File Offset: 0x001C4C02
		public unsafe EHoudiniInputObjectType Type
		{
			get
			{
				return (EHoudiniInputObjectType)(*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x0601352F RID: 79151 RVA: 0x001C6A13 File Offset: 0x001C4C13
		// (set) Token: 0x06013530 RID: 79152 RVA: 0x001C6A23 File Offset: 0x001C4C23
		public unsafe int InputNodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_InputNodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_InputNodeId) = value;
			}
		}

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x06013531 RID: 79153 RVA: 0x001C6A34 File Offset: 0x001C4C34
		// (set) Token: 0x06013532 RID: 79154 RVA: 0x001C6A44 File Offset: 0x001C4C44
		public unsafe int InputObjectNodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_InputObjectNodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_InputObjectNodeId) = value;
			}
		}

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x06013533 RID: 79155 RVA: 0x001C6A55 File Offset: 0x001C4C55
		// (set) Token: 0x06013534 RID: 79156 RVA: 0x001C6A69 File Offset: 0x001C4C69
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x06013535 RID: 79157 RVA: 0x001C6A7E File Offset: 0x001C4C7E
		// (set) Token: 0x06013536 RID: 79158 RVA: 0x001C6A8E File Offset: 0x001C4C8E
		public unsafe bool bHasChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bHasChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bHasChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B55 RID: 19285
		// (get) Token: 0x06013537 RID: 79159 RVA: 0x001C6A9F File Offset: 0x001C4C9F
		// (set) Token: 0x06013538 RID: 79160 RVA: 0x001C6AAF File Offset: 0x001C4CAF
		public unsafe bool bNeedsToTriggerUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bNeedsToTriggerUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bNeedsToTriggerUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B56 RID: 19286
		// (get) Token: 0x06013539 RID: 79161 RVA: 0x001C6AC0 File Offset: 0x001C4CC0
		// (set) Token: 0x0601353A RID: 79162 RVA: 0x001C6AD0 File Offset: 0x001C4CD0
		public unsafe bool bTransformChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bTransformChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bTransformChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B57 RID: 19287
		// (get) Token: 0x0601353B RID: 79163 RVA: 0x001C6AE1 File Offset: 0x001C4CE1
		// (set) Token: 0x0601353C RID: 79164 RVA: 0x001C6AF1 File Offset: 0x001C4CF1
		public unsafe bool bImportAsReference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReference) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReference) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B58 RID: 19288
		// (get) Token: 0x0601353D RID: 79165 RVA: 0x001C6B02 File Offset: 0x001C4D02
		// (set) Token: 0x0601353E RID: 79166 RVA: 0x001C6B12 File Offset: 0x001C4D12
		public unsafe bool bImportAsReferenceRotScaleEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReferenceRotScaleEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReferenceRotScaleEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B59 RID: 19289
		// (get) Token: 0x0601353F RID: 79167 RVA: 0x001C6B23 File Offset: 0x001C4D23
		// (set) Token: 0x06013540 RID: 79168 RVA: 0x001C6B33 File Offset: 0x001C4D33
		public unsafe bool bImportAsReferenceBboxEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReferenceBboxEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReferenceBboxEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B5A RID: 19290
		// (get) Token: 0x06013541 RID: 79169 RVA: 0x001C6B44 File Offset: 0x001C4D44
		// (set) Token: 0x06013542 RID: 79170 RVA: 0x001C6B54 File Offset: 0x001C4D54
		public unsafe bool bImportAsReferenceMaterialEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReferenceMaterialEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bImportAsReferenceMaterialEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B5B RID: 19291
		// (get) Token: 0x06013543 RID: 79171 RVA: 0x001C6B68 File Offset: 0x001C4D68
		// (set) Token: 0x06013544 RID: 79172 RVA: 0x001C6BA1 File Offset: 0x001C4DA1
		public TArray<string> MaterialReferences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MaterialReferences) == null)
				{
					result = (this._MaterialReferences = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_MaterialReferences, this));
				}
				return result;
			}
			set
			{
				this.MaterialReferences.CopyAssign(value);
			}
		}

		// Token: 0x17004B5C RID: 19292
		// (get) Token: 0x06013545 RID: 79173 RVA: 0x001C6BAF File Offset: 0x001C4DAF
		// (set) Token: 0x06013546 RID: 79174 RVA: 0x001C6BBF File Offset: 0x001C4DBF
		public unsafe bool bCanDeleteHoudiniNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bCanDeleteHoudiniNodes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputObject.__PropertyOffset_bCanDeleteHoudiniNodes) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013547 RID: 79175 RVA: 0x001C6BD0 File Offset: 0x001C4DD0
		static UHoudiniInputObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputObject");
		}

		// Token: 0x06013548 RID: 79176 RVA: 0x001C6BDE File Offset: 0x001C4DDE
		protected UHoudiniInputObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6FE RID: 42750
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputObject";

		// Token: 0x0400A6FF RID: 42751
		private static IntPtr _ClassPtr;

		// Token: 0x0400A700 RID: 42752
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A701 RID: 42753
		internal static int __PropertyOffset_InputObject;

		// Token: 0x0400A702 RID: 42754
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400A703 RID: 42755
		internal static int __PropertyOffset_Type;

		// Token: 0x0400A704 RID: 42756
		internal static int __PropertyOffset_InputNodeId;

		// Token: 0x0400A705 RID: 42757
		internal static int __PropertyOffset_InputObjectNodeId;

		// Token: 0x0400A706 RID: 42758
		internal static int __PropertyOffset_Guid;

		// Token: 0x0400A707 RID: 42759
		internal static int __PropertyOffset_bHasChanged;

		// Token: 0x0400A708 RID: 42760
		internal static int __PropertyOffset_bNeedsToTriggerUpdate;

		// Token: 0x0400A709 RID: 42761
		internal static int __PropertyOffset_bTransformChanged;

		// Token: 0x0400A70A RID: 42762
		internal static int __PropertyOffset_bImportAsReference;

		// Token: 0x0400A70B RID: 42763
		internal static int __PropertyOffset_bImportAsReferenceRotScaleEnabled;

		// Token: 0x0400A70C RID: 42764
		internal static int __PropertyOffset_bImportAsReferenceBboxEnabled;

		// Token: 0x0400A70D RID: 42765
		internal static int __PropertyOffset_bImportAsReferenceMaterialEnabled;

		// Token: 0x0400A70E RID: 42766
		internal static int __PropertyOffset_MaterialReferences;

		// Token: 0x0400A70F RID: 42767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MaterialReferences;

		// Token: 0x0400A710 RID: 42768
		internal static int __PropertyOffset_bCanDeleteHoudiniNodes;
	}
}
