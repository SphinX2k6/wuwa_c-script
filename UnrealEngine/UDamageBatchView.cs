using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A5 RID: 933
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageBatchView")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UDamageBatchView : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005C42 RID: 23618 RVA: 0x0008204A File Offset: 0x0008024A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDamageBatchView._ClassPtr;
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00082058 File Offset: 0x00080258
		public UDamageBatchView() : this(BuiltinUtils.AllocNativeUObject(UDamageBatchView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00082080 File Offset: 0x00080280
		public UDamageBatchView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDamageBatchView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x000820B3 File Offset: 0x000802B3
		// (set) Token: 0x06005C46 RID: 23622 RVA: 0x000820C7 File Offset: 0x000802C7
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

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06005C47 RID: 23623 RVA: 0x000820DC File Offset: 0x000802DC
		// (set) Token: 0x06005C48 RID: 23624 RVA: 0x00082115 File Offset: 0x00080315
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

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06005C49 RID: 23625 RVA: 0x00082124 File Offset: 0x00080324
		// (set) Token: 0x06005C4A RID: 23626 RVA: 0x0008215D File Offset: 0x0008035D
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

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06005C4B RID: 23627 RVA: 0x0008216B File Offset: 0x0008036B
		// (set) Token: 0x06005C4C RID: 23628 RVA: 0x0008217F File Offset: 0x0008037F
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

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x00082194 File Offset: 0x00080394
		// (set) Token: 0x06005C4E RID: 23630 RVA: 0x000821A8 File Offset: 0x000803A8
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

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x000821C0 File Offset: 0x000803C0
		// (set) Token: 0x06005C50 RID: 23632 RVA: 0x000821F9 File Offset: 0x000803F9
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

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x00082208 File Offset: 0x00080408
		// (set) Token: 0x06005C52 RID: 23634 RVA: 0x00082241 File Offset: 0x00080441
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

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x0008224F File Offset: 0x0008044F
		// (set) Token: 0x06005C54 RID: 23636 RVA: 0x00082263 File Offset: 0x00080463
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

		// Token: 0x06005C55 RID: 23637 RVA: 0x00082278 File Offset: 0x00080478
		public void OnPendingTextGeometryReady()
		{
			UDamageBatchView.__OnPendingTextGeometryReady_Internal(base.NativePtr);
		}

		// Token: 0x06005C56 RID: 23638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPendingTextGeometryReady_Internal(IntPtr @this);

		// Token: 0x06005C57 RID: 23639 RVA: 0x00082285 File Offset: 0x00080485
		static UDamageBatchView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.DamageBatchView");
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x00082293 File Offset: 0x00080493
		protected UDamageBatchView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400266E RID: 9838
		public new const string __ObjectPath = "/Script/KuroGameplayUI.DamageBatchView";

		// Token: 0x0400266F RID: 9839
		private static IntPtr _ClassPtr;

		// Token: 0x04002670 RID: 9840
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002671 RID: 9841
		internal static int __PropertyOffset_RootActor;

		// Token: 0x04002672 RID: 9842
		internal static int __PropertyOffset_TextList;

		// Token: 0x04002673 RID: 9843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIText> _TextList;

		// Token: 0x04002674 RID: 9844
		internal static int __PropertyOffset_TextUvModifierList;

		// Token: 0x04002675 RID: 9845
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUITextAdditionalUVModifier> _TextUvModifierList;

		// Token: 0x04002676 RID: 9846
		internal static int __PropertyOffset_DynamicBatch;

		// Token: 0x04002677 RID: 9847
		internal static int __PropertyOffset_AnchorItem;

		// Token: 0x04002678 RID: 9848
		internal static int __PropertyOffset_UnusedSimpleDamageViewInfoList;

		// Token: 0x04002679 RID: 9849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimpleDamageViewInfo> _UnusedSimpleDamageViewInfoList;

		// Token: 0x0400267A RID: 9850
		internal static int __PropertyOffset_SimpleDamageViewInfoList;

		// Token: 0x0400267B RID: 9851
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimpleDamageViewInfo> _SimpleDamageViewInfoList;

		// Token: 0x0400267C RID: 9852
		internal static int __PropertyOffset_PendingBakeViewInfo;
	}
}
