using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002605 RID: 9733
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariableMetaData")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FNiagaraVariableMetaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024324 RID: 148260 RVA: 0x00359439 File Offset: 0x00357639
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariableMetaData._ScriptStructPtr != 0) ? FNiagaraVariableMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariableMetaData", ref FNiagaraVariableMetaData._ScriptStructPtr);
		}

		// Token: 0x17008B61 RID: 35681
		// (get) Token: 0x06024325 RID: 148261 RVA: 0x00359460 File Offset: 0x00357660
		// (set) Token: 0x06024326 RID: 148262 RVA: 0x003594A3 File Offset: 0x003576A3
		public unsafe FText Description
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Description) == null)
				{
					result = (this._Description = new FText(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_Description, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraVariableMetaData.__PropertyOffset_Description)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008B62 RID: 35682
		// (get) Token: 0x06024327 RID: 148263 RVA: 0x003594C0 File Offset: 0x003576C0
		// (set) Token: 0x06024328 RID: 148264 RVA: 0x00359503 File Offset: 0x00357703
		public unsafe FText CategoryName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._CategoryName) == null)
				{
					result = (this._CategoryName = new FText(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_CategoryName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraVariableMetaData.__PropertyOffset_CategoryName)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008B63 RID: 35683
		// (get) Token: 0x06024329 RID: 148265 RVA: 0x0035951E File Offset: 0x0035771E
		// (set) Token: 0x0602432A RID: 148266 RVA: 0x0035952E File Offset: 0x0035772E
		public unsafe bool bAdvancedDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bAdvancedDisplay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bAdvancedDisplay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B64 RID: 35684
		// (get) Token: 0x0602432B RID: 148267 RVA: 0x0035953F File Offset: 0x0035773F
		// (set) Token: 0x0602432C RID: 148268 RVA: 0x0035954F File Offset: 0x0035774F
		public unsafe int EditorSortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_EditorSortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_EditorSortPriority) = value;
			}
		}

		// Token: 0x17008B65 RID: 35685
		// (get) Token: 0x0602432D RID: 148269 RVA: 0x00359560 File Offset: 0x00357760
		// (set) Token: 0x0602432E RID: 148270 RVA: 0x00359570 File Offset: 0x00357770
		public unsafe bool bInlineEditConditionToggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bInlineEditConditionToggle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bInlineEditConditionToggle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B66 RID: 35686
		// (get) Token: 0x0602432F RID: 148271 RVA: 0x00359584 File Offset: 0x00357784
		// (set) Token: 0x06024330 RID: 148272 RVA: 0x003595C7 File Offset: 0x003577C7
		public FNiagaraInputConditionMetadata EditCondition
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraInputConditionMetadata result;
				if ((result = this._EditCondition) == null)
				{
					result = (this._EditCondition = new FNiagaraInputConditionMetadata(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_EditCondition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraInputConditionMetadata.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_EditCondition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B67 RID: 35687
		// (get) Token: 0x06024331 RID: 148273 RVA: 0x003595E8 File Offset: 0x003577E8
		// (set) Token: 0x06024332 RID: 148274 RVA: 0x0035962B File Offset: 0x0035782B
		public FNiagaraInputConditionMetadata VisibleCondition
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraInputConditionMetadata result;
				if ((result = this._VisibleCondition) == null)
				{
					result = (this._VisibleCondition = new FNiagaraInputConditionMetadata(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_VisibleCondition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraInputConditionMetadata.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_VisibleCondition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B68 RID: 35688
		// (get) Token: 0x06024333 RID: 148275 RVA: 0x0035964C File Offset: 0x0035784C
		// (set) Token: 0x06024334 RID: 148276 RVA: 0x0035968F File Offset: 0x0035788F
		public TMap<FName, string> PropertyMetaData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, string> result;
				if ((result = this._PropertyMetaData) == null)
				{
					result = (this._PropertyMetaData = new TMap<FName, string>(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_PropertyMetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyMetaData.CopyAssign(value);
			}
		}

		// Token: 0x17008B69 RID: 35689
		// (get) Token: 0x06024335 RID: 148277 RVA: 0x0035969D File Offset: 0x0035789D
		// (set) Token: 0x06024336 RID: 148278 RVA: 0x003596B1 File Offset: 0x003578B1
		public unsafe FName ParentAttribute
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_ParentAttribute);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_ParentAttribute) = value;
			}
		}

		// Token: 0x17008B6A RID: 35690
		// (get) Token: 0x06024337 RID: 148279 RVA: 0x003596C6 File Offset: 0x003578C6
		// (set) Token: 0x06024338 RID: 148280 RVA: 0x003596DA File Offset: 0x003578DA
		public unsafe FName ScopeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_ScopeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_ScopeName) = value;
			}
		}

		// Token: 0x17008B6B RID: 35691
		// (get) Token: 0x06024339 RID: 148281 RVA: 0x003596EF File Offset: 0x003578EF
		// (set) Token: 0x0602433A RID: 148282 RVA: 0x003596FF File Offset: 0x003578FF
		public unsafe ENiagaraScriptParameterUsage Usage
		{
			get
			{
				return (ENiagaraScriptParameterUsage)(*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_Usage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_Usage) = (int)value;
			}
		}

		// Token: 0x17008B6C RID: 35692
		// (get) Token: 0x0602433B RID: 148283 RVA: 0x00359710 File Offset: 0x00357910
		// (set) Token: 0x0602433C RID: 148284 RVA: 0x00359720 File Offset: 0x00357920
		public unsafe bool bIsStaticSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bIsStaticSwitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bIsStaticSwitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B6D RID: 35693
		// (get) Token: 0x0602433D RID: 148285 RVA: 0x00359731 File Offset: 0x00357931
		// (set) Token: 0x0602433E RID: 148286 RVA: 0x00359741 File Offset: 0x00357941
		public unsafe int StaticSwitchDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_StaticSwitchDefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_StaticSwitchDefaultValue) = value;
			}
		}

		// Token: 0x17008B6E RID: 35694
		// (get) Token: 0x0602433F RID: 148287 RVA: 0x00359752 File Offset: 0x00357952
		// (set) Token: 0x06024340 RID: 148288 RVA: 0x00359762 File Offset: 0x00357962
		public unsafe bool bAddedToNodeGraphDeepCopy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bAddedToNodeGraphDeepCopy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bAddedToNodeGraphDeepCopy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B6F RID: 35695
		// (get) Token: 0x06024341 RID: 148289 RVA: 0x00359773 File Offset: 0x00357973
		// (set) Token: 0x06024342 RID: 148290 RVA: 0x00359783 File Offset: 0x00357983
		public unsafe bool bOutputIsPersistent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bOutputIsPersistent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bOutputIsPersistent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B70 RID: 35696
		// (get) Token: 0x06024343 RID: 148291 RVA: 0x00359794 File Offset: 0x00357994
		// (set) Token: 0x06024344 RID: 148292 RVA: 0x003597A8 File Offset: 0x003579A8
		public unsafe FName CachedNamespacelessVariableName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_CachedNamespacelessVariableName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_CachedNamespacelessVariableName) = value;
			}
		}

		// Token: 0x17008B71 RID: 35697
		// (get) Token: 0x06024345 RID: 148293 RVA: 0x003597BD File Offset: 0x003579BD
		// (set) Token: 0x06024346 RID: 148294 RVA: 0x003597CD File Offset: 0x003579CD
		public unsafe bool bCreatedInSystemEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bCreatedInSystemEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bCreatedInSystemEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B72 RID: 35698
		// (get) Token: 0x06024347 RID: 148295 RVA: 0x003597DE File Offset: 0x003579DE
		// (set) Token: 0x06024348 RID: 148296 RVA: 0x003597EE File Offset: 0x003579EE
		public unsafe bool bUseLegacyNameString
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bUseLegacyNameString) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableMetaData.__PropertyOffset_bUseLegacyNameString) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024349 RID: 148297 RVA: 0x003597FF File Offset: 0x003579FF
		public FNiagaraVariableMetaData()
		{
		}

		// Token: 0x0602434A RID: 148298 RVA: 0x00359808 File Offset: 0x00357A08
		public FNiagaraVariableMetaData(FText Description, FText CategoryName, bool bAdvancedDisplay, int EditorSortPriority, bool bInlineEditConditionToggle, FNiagaraInputConditionMetadata EditCondition, FNiagaraInputConditionMetadata VisibleCondition, TMap<FName, string> PropertyMetaData, FName ParentAttribute, FName ScopeName, ENiagaraScriptParameterUsage Usage, bool bIsStaticSwitch, int StaticSwitchDefaultValue, bool bAddedToNodeGraphDeepCopy, bool bOutputIsPersistent, FName CachedNamespacelessVariableName, bool bCreatedInSystemEditor, bool bUseLegacyNameString)
		{
			this.Description = Description;
			this.CategoryName = CategoryName;
			this.bAdvancedDisplay = bAdvancedDisplay;
			this.EditorSortPriority = EditorSortPriority;
			this.bInlineEditConditionToggle = bInlineEditConditionToggle;
			this.EditCondition = EditCondition;
			this.VisibleCondition = VisibleCondition;
			this.PropertyMetaData = PropertyMetaData;
			this.ParentAttribute = ParentAttribute;
			this.ScopeName = ScopeName;
			this.Usage = Usage;
			this.bIsStaticSwitch = bIsStaticSwitch;
			this.StaticSwitchDefaultValue = StaticSwitchDefaultValue;
			this.bAddedToNodeGraphDeepCopy = bAddedToNodeGraphDeepCopy;
			this.bOutputIsPersistent = bOutputIsPersistent;
			this.CachedNamespacelessVariableName = CachedNamespacelessVariableName;
			this.bCreatedInSystemEditor = bCreatedInSystemEditor;
			this.bUseLegacyNameString = bUseLegacyNameString;
		}

		// Token: 0x0602434B RID: 148299 RVA: 0x003598A8 File Offset: 0x00357AA8
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariableMetaData.StaticStruct();
		}

		// Token: 0x0602434C RID: 148300 RVA: 0x003598B4 File Offset: 0x00357AB4
		[NullableContext(2)]
		public FNiagaraVariableMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602434D RID: 148301 RVA: 0x003598BE File Offset: 0x00357ABE
		public FNiagaraVariableMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602434E RID: 148302 RVA: 0x003598C9 File Offset: 0x00357AC9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariableMetaData(Pointer, false, true);
		}

		// Token: 0x0602434F RID: 148303 RVA: 0x003598D3 File Offset: 0x00357AD3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariableMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x040136B9 RID: 79545
		public const string __ObjectPath = "/Script/Niagara.NiagaraVariableMetaData";

		// Token: 0x040136BA RID: 79546
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136BB RID: 79547
		internal static int __PropertyOffset_Description;

		// Token: 0x040136BC RID: 79548
		[Nullable(2)]
		private FText _Description;

		// Token: 0x040136BD RID: 79549
		internal static int __PropertyOffset_CategoryName;

		// Token: 0x040136BE RID: 79550
		[Nullable(2)]
		private FText _CategoryName;

		// Token: 0x040136BF RID: 79551
		internal static int __PropertyOffset_bAdvancedDisplay;

		// Token: 0x040136C0 RID: 79552
		internal static int __PropertyOffset_EditorSortPriority;

		// Token: 0x040136C1 RID: 79553
		internal static int __PropertyOffset_bInlineEditConditionToggle;

		// Token: 0x040136C2 RID: 79554
		internal static int __PropertyOffset_EditCondition;

		// Token: 0x040136C3 RID: 79555
		[Nullable(2)]
		private FNiagaraInputConditionMetadata _EditCondition;

		// Token: 0x040136C4 RID: 79556
		internal static int __PropertyOffset_VisibleCondition;

		// Token: 0x040136C5 RID: 79557
		[Nullable(2)]
		private FNiagaraInputConditionMetadata _VisibleCondition;

		// Token: 0x040136C6 RID: 79558
		internal static int __PropertyOffset_PropertyMetaData;

		// Token: 0x040136C7 RID: 79559
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, string> _PropertyMetaData;

		// Token: 0x040136C8 RID: 79560
		internal static int __PropertyOffset_ParentAttribute;

		// Token: 0x040136C9 RID: 79561
		internal static int __PropertyOffset_ScopeName;

		// Token: 0x040136CA RID: 79562
		internal static int __PropertyOffset_Usage;

		// Token: 0x040136CB RID: 79563
		internal static int __PropertyOffset_bIsStaticSwitch;

		// Token: 0x040136CC RID: 79564
		internal static int __PropertyOffset_StaticSwitchDefaultValue;

		// Token: 0x040136CD RID: 79565
		internal static int __PropertyOffset_bAddedToNodeGraphDeepCopy;

		// Token: 0x040136CE RID: 79566
		internal static int __PropertyOffset_bOutputIsPersistent;

		// Token: 0x040136CF RID: 79567
		internal static int __PropertyOffset_CachedNamespacelessVariableName;

		// Token: 0x040136D0 RID: 79568
		internal static int __PropertyOffset_bCreatedInSystemEditor;

		// Token: 0x040136D1 RID: 79569
		internal static int __PropertyOffset_bUseLegacyNameString;
	}
}
