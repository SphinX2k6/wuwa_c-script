using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200187C RID: 6268
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageBatchView")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UDamageBatchView : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601713D RID: 94525 RVA: 0x0021A26F File Offset: 0x0021846F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDamageBatchView._ClassPtr;
		}

		// Token: 0x0601713E RID: 94526 RVA: 0x0021A27C File Offset: 0x0021847C
		public UDamageBatchView() : this(BuiltinUtils.AllocNativeUObject(UDamageBatchView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601713F RID: 94527 RVA: 0x0021A2A4 File Offset: 0x002184A4
		public UDamageBatchView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDamageBatchView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CCC RID: 23756
		// (get) Token: 0x06017140 RID: 94528 RVA: 0x0021A2D7 File Offset: 0x002184D7
		// (set) Token: 0x06017141 RID: 94529 RVA: 0x0021A2EB File Offset: 0x002184EB
		[Nullable(2)]
		public unsafe AUIBaseActor RootActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_RootActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_RootActor, value);
			}
		}

		// Token: 0x17005CCD RID: 23757
		// (get) Token: 0x06017142 RID: 94530 RVA: 0x0021A300 File Offset: 0x00218500
		// (set) Token: 0x06017143 RID: 94531 RVA: 0x0021A339 File Offset: 0x00218539
		public TArray<UUIText> TextList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUIText> result;
				if ((result = this._TextList) == null)
				{
					result = (this._TextList = new TArray<UUIText>(base.NativePtr + (IntPtr)UDamageBatchView.__PropertyOffset_TextList, this));
				}
				return result;
			}
			set
			{
				this.TextList.CopyAssign(value);
			}
		}

		// Token: 0x17005CCE RID: 23758
		// (get) Token: 0x06017144 RID: 94532 RVA: 0x0021A348 File Offset: 0x00218548
		// (set) Token: 0x06017145 RID: 94533 RVA: 0x0021A381 File Offset: 0x00218581
		public TArray<UUITextAdditionalUVModifier> TextUvModifierList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUITextAdditionalUVModifier> result;
				if ((result = this._TextUvModifierList) == null)
				{
					result = (this._TextUvModifierList = new TArray<UUITextAdditionalUVModifier>(base.NativePtr + (IntPtr)UDamageBatchView.__PropertyOffset_TextUvModifierList, this));
				}
				return result;
			}
			set
			{
				this.TextUvModifierList.CopyAssign(value);
			}
		}

		// Token: 0x17005CCF RID: 23759
		// (get) Token: 0x06017146 RID: 94534 RVA: 0x0021A38F File Offset: 0x0021858F
		// (set) Token: 0x06017147 RID: 94535 RVA: 0x0021A3A3 File Offset: 0x002185A3
		[Nullable(2)]
		public unsafe UUIDynamicBatchMesh DynamicBatch
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDynamicBatchMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_DynamicBatch);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_DynamicBatch, value);
			}
		}

		// Token: 0x17005CD0 RID: 23760
		// (get) Token: 0x06017148 RID: 94536 RVA: 0x0021A3B8 File Offset: 0x002185B8
		// (set) Token: 0x06017149 RID: 94537 RVA: 0x0021A3CC File Offset: 0x002185CC
		[Nullable(2)]
		public unsafe UUIItem AnchorItem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_AnchorItem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_AnchorItem, value);
			}
		}

		// Token: 0x17005CD1 RID: 23761
		// (get) Token: 0x0601714A RID: 94538 RVA: 0x0021A3E4 File Offset: 0x002185E4
		// (set) Token: 0x0601714B RID: 94539 RVA: 0x0021A41D File Offset: 0x0021861D
		public TArray<USimpleDamageView> UnusedSimpleDamageViewList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimpleDamageView> result;
				if ((result = this._UnusedSimpleDamageViewList) == null)
				{
					result = (this._UnusedSimpleDamageViewList = new TArray<USimpleDamageView>(base.NativePtr + (IntPtr)UDamageBatchView.__PropertyOffset_UnusedSimpleDamageViewList, this));
				}
				return result;
			}
			set
			{
				this.UnusedSimpleDamageViewList.CopyAssign(value);
			}
		}

		// Token: 0x17005CD2 RID: 23762
		// (get) Token: 0x0601714C RID: 94540 RVA: 0x0021A42C File Offset: 0x0021862C
		// (set) Token: 0x0601714D RID: 94541 RVA: 0x0021A465 File Offset: 0x00218665
		public TArray<USimpleDamageViewInfo> UnusedSimpleDamageViewInfoList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimpleDamageViewInfo> result;
				if ((result = this._UnusedSimpleDamageViewInfoList) == null)
				{
					result = (this._UnusedSimpleDamageViewInfoList = new TArray<USimpleDamageViewInfo>(base.NativePtr + (IntPtr)UDamageBatchView.__PropertyOffset_UnusedSimpleDamageViewInfoList, this));
				}
				return result;
			}
			set
			{
				this.UnusedSimpleDamageViewInfoList.CopyAssign(value);
			}
		}

		// Token: 0x17005CD3 RID: 23763
		// (get) Token: 0x0601714E RID: 94542 RVA: 0x0021A474 File Offset: 0x00218674
		// (set) Token: 0x0601714F RID: 94543 RVA: 0x0021A4AD File Offset: 0x002186AD
		public TArray<USimpleDamageViewInfo> SimpleDamageViewInfoList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimpleDamageViewInfo> result;
				if ((result = this._SimpleDamageViewInfoList) == null)
				{
					result = (this._SimpleDamageViewInfoList = new TArray<USimpleDamageViewInfo>(base.NativePtr + (IntPtr)UDamageBatchView.__PropertyOffset_SimpleDamageViewInfoList, this));
				}
				return result;
			}
			set
			{
				this.SimpleDamageViewInfoList.CopyAssign(value);
			}
		}

		// Token: 0x17005CD4 RID: 23764
		// (get) Token: 0x06017150 RID: 94544 RVA: 0x0021A4BB File Offset: 0x002186BB
		// (set) Token: 0x06017151 RID: 94545 RVA: 0x0021A4CF File Offset: 0x002186CF
		[Nullable(2)]
		public unsafe USimpleDamageViewInfo PendingBakeViewInfo
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USimpleDamageViewInfo>(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_PendingBakeViewInfo);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDamageBatchView.__PropertyOffset_PendingBakeViewInfo, value);
			}
		}

		// Token: 0x06017152 RID: 94546 RVA: 0x0021A4E4 File Offset: 0x002186E4
		public void OnPendingTextGeometryReady()
		{
			UDamageBatchView.__OnPendingTextGeometryReady_Internal(base.NativePtr);
		}

		// Token: 0x06017153 RID: 94547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPendingTextGeometryReady_Internal(IntPtr @this);

		// Token: 0x06017154 RID: 94548 RVA: 0x0021A4F1 File Offset: 0x002186F1
		static UDamageBatchView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.DamageBatchView");
		}

		// Token: 0x06017155 RID: 94549 RVA: 0x0021A4FF File Offset: 0x002186FF
		protected UDamageBatchView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C858 RID: 51288
		public new const string __ObjectPath = "/Script/KuroGameplayUI.DamageBatchView";

		// Token: 0x0400C859 RID: 51289
		private static IntPtr _ClassPtr;

		// Token: 0x0400C85A RID: 51290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C85B RID: 51291
		internal static int __PropertyOffset_RootActor;

		// Token: 0x0400C85C RID: 51292
		internal static int __PropertyOffset_TextList;

		// Token: 0x0400C85D RID: 51293
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIText> _TextList;

		// Token: 0x0400C85E RID: 51294
		internal static int __PropertyOffset_TextUvModifierList;

		// Token: 0x0400C85F RID: 51295
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUITextAdditionalUVModifier> _TextUvModifierList;

		// Token: 0x0400C860 RID: 51296
		internal static int __PropertyOffset_DynamicBatch;

		// Token: 0x0400C861 RID: 51297
		internal static int __PropertyOffset_AnchorItem;

		// Token: 0x0400C862 RID: 51298
		internal static int __PropertyOffset_UnusedSimpleDamageViewList;

		// Token: 0x0400C863 RID: 51299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimpleDamageView> _UnusedSimpleDamageViewList;

		// Token: 0x0400C864 RID: 51300
		internal static int __PropertyOffset_UnusedSimpleDamageViewInfoList;

		// Token: 0x0400C865 RID: 51301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimpleDamageViewInfo> _UnusedSimpleDamageViewInfoList;

		// Token: 0x0400C866 RID: 51302
		internal static int __PropertyOffset_SimpleDamageViewInfoList;

		// Token: 0x0400C867 RID: 51303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimpleDamageViewInfo> _SimpleDamageViewInfoList;

		// Token: 0x0400C868 RID: 51304
		internal static int __PropertyOffset_PendingBakeViewInfo;
	}
}
