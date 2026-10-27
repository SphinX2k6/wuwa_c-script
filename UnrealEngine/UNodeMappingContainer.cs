using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EF1 RID: 3825
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NodeMappingContainer")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UNodeMappingContainer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CF7A RID: 53114 RVA: 0x0012EA46 File Offset: 0x0012CC46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNodeMappingContainer._ClassPtr;
		}

		// Token: 0x0600CF7B RID: 53115 RVA: 0x0012EA54 File Offset: 0x0012CC54
		public UNodeMappingContainer() : this(BuiltinUtils.AllocNativeUObject(UNodeMappingContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x0012EA7C File Offset: 0x0012CC7C
		public UNodeMappingContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNodeMappingContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x0600CF7D RID: 53117 RVA: 0x0012EAB0 File Offset: 0x0012CCB0
		// (set) Token: 0x0600CF7E RID: 53118 RVA: 0x0012EAE9 File Offset: 0x0012CCE9
		public TMap<FName, FNodeItem> SourceItems
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FNodeItem> result;
				if ((result = this._SourceItems) == null)
				{
					result = (this._SourceItems = new TMap<FName, FNodeItem>(base.NativePtr + (IntPtr)UNodeMappingContainer.__PropertyOffset_SourceItems, this));
				}
				return result;
			}
			set
			{
				this.SourceItems.CopyAssign(value);
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0600CF7F RID: 53119 RVA: 0x0012EAF8 File Offset: 0x0012CCF8
		// (set) Token: 0x0600CF80 RID: 53120 RVA: 0x0012EB31 File Offset: 0x0012CD31
		public TMap<FName, FNodeItem> TargetItems
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FNodeItem> result;
				if ((result = this._TargetItems) == null)
				{
					result = (this._TargetItems = new TMap<FName, FNodeItem>(base.NativePtr + (IntPtr)UNodeMappingContainer.__PropertyOffset_TargetItems, this));
				}
				return result;
			}
			set
			{
				this.TargetItems.CopyAssign(value);
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0600CF81 RID: 53121 RVA: 0x0012EB40 File Offset: 0x0012CD40
		// (set) Token: 0x0600CF82 RID: 53122 RVA: 0x0012EB79 File Offset: 0x0012CD79
		public TMap<FName, FName> SourceToTarget
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._SourceToTarget) == null)
				{
					result = (this._SourceToTarget = new TMap<FName, FName>(base.NativePtr + (IntPtr)UNodeMappingContainer.__PropertyOffset_SourceToTarget, this));
				}
				return result;
			}
			set
			{
				this.SourceToTarget.CopyAssign(value);
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0600CF83 RID: 53123 RVA: 0x0012EB87 File Offset: 0x0012CD87
		// (set) Token: 0x0600CF84 RID: 53124 RVA: 0x0012EB9C File Offset: 0x0012CD9C
		public TSoftObjectPtr<UObject> SourceAsset
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)UNodeMappingContainer.__PropertyOffset_SourceAsset, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UNodeMappingContainer.__PropertyOffset_SourceAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0600CF85 RID: 53125 RVA: 0x0012EBC1 File Offset: 0x0012CDC1
		// (set) Token: 0x0600CF86 RID: 53126 RVA: 0x0012EBD6 File Offset: 0x0012CDD6
		public TSoftObjectPtr<UObject> TargetAsset
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)UNodeMappingContainer.__PropertyOffset_TargetAsset, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UNodeMappingContainer.__PropertyOffset_TargetAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0600CF87 RID: 53127 RVA: 0x0012EBFB File Offset: 0x0012CDFB
		static UNodeMappingContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NodeMappingContainer");
		}

		// Token: 0x0600CF88 RID: 53128 RVA: 0x0012EC09 File Offset: 0x0012CE09
		protected UNodeMappingContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006FDD RID: 28637
		public new const string __ObjectPath = "/Script/Engine.NodeMappingContainer";

		// Token: 0x04006FDE RID: 28638
		private static IntPtr _ClassPtr;

		// Token: 0x04006FDF RID: 28639
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006FE0 RID: 28640
		internal static int __PropertyOffset_SourceItems;

		// Token: 0x04006FE1 RID: 28641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FNodeItem> _SourceItems;

		// Token: 0x04006FE2 RID: 28642
		internal static int __PropertyOffset_TargetItems;

		// Token: 0x04006FE3 RID: 28643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FNodeItem> _TargetItems;

		// Token: 0x04006FE4 RID: 28644
		internal static int __PropertyOffset_SourceToTarget;

		// Token: 0x04006FE5 RID: 28645
		[Nullable(2)]
		private TMap<FName, FName> _SourceToTarget;

		// Token: 0x04006FE6 RID: 28646
		internal static int __PropertyOffset_SourceAsset;

		// Token: 0x04006FE7 RID: 28647
		internal static int __PropertyOffset_TargetAsset;
	}
}
