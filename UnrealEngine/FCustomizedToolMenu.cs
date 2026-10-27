using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002842 RID: 10306
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.CustomizedToolMenu")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 496)]
	public class FCustomizedToolMenu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060264C3 RID: 156867 RVA: 0x003A2CA1 File Offset: 0x003A0EA1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomizedToolMenu._ScriptStructPtr != 0) ? FCustomizedToolMenu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.CustomizedToolMenu", ref FCustomizedToolMenu._ScriptStructPtr);
		}

		// Token: 0x170093E0 RID: 37856
		// (get) Token: 0x060264C4 RID: 156868 RVA: 0x003A2CC5 File Offset: 0x003A0EC5
		// (set) Token: 0x060264C5 RID: 156869 RVA: 0x003A2CD9 File Offset: 0x003A0ED9
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomizedToolMenu.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomizedToolMenu.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170093E1 RID: 37857
		// (get) Token: 0x060264C6 RID: 156870 RVA: 0x003A2CF0 File Offset: 0x003A0EF0
		// (set) Token: 0x060264C7 RID: 156871 RVA: 0x003A2D33 File Offset: 0x003A0F33
		public TMap<FName, FCustomizedToolMenuEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCustomizedToolMenuEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TMap<FName, FCustomizedToolMenuEntry>(base.NativePtr + (IntPtr)FCustomizedToolMenu.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x170093E2 RID: 37858
		// (get) Token: 0x060264C8 RID: 156872 RVA: 0x003A2D44 File Offset: 0x003A0F44
		// (set) Token: 0x060264C9 RID: 156873 RVA: 0x003A2D87 File Offset: 0x003A0F87
		public TMap<FName, FCustomizedToolMenuSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCustomizedToolMenuSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TMap<FName, FCustomizedToolMenuSection>(base.NativePtr + (IntPtr)FCustomizedToolMenu.__PropertyOffset_Sections, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x170093E3 RID: 37859
		// (get) Token: 0x060264CA RID: 156874 RVA: 0x003A2D98 File Offset: 0x003A0F98
		// (set) Token: 0x060264CB RID: 156875 RVA: 0x003A2DDB File Offset: 0x003A0FDB
		public TMap<FName, FCustomizedToolMenuNameArray> EntryOrder
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCustomizedToolMenuNameArray> result;
				if ((result = this._EntryOrder) == null)
				{
					result = (this._EntryOrder = new TMap<FName, FCustomizedToolMenuNameArray>(base.NativePtr + (IntPtr)FCustomizedToolMenu.__PropertyOffset_EntryOrder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EntryOrder.CopyAssign(value);
			}
		}

		// Token: 0x170093E4 RID: 37860
		// (get) Token: 0x060264CC RID: 156876 RVA: 0x003A2DEC File Offset: 0x003A0FEC
		// (set) Token: 0x060264CD RID: 156877 RVA: 0x003A2E2F File Offset: 0x003A102F
		public TArray<FName> SectionOrder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SectionOrder) == null)
				{
					result = (this._SectionOrder = new TArray<FName>(base.NativePtr + (IntPtr)FCustomizedToolMenu.__PropertyOffset_SectionOrder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SectionOrder.CopyAssign(value);
			}
		}

		// Token: 0x060264CE RID: 156878 RVA: 0x003A2E3D File Offset: 0x003A103D
		public FCustomizedToolMenu()
		{
		}

		// Token: 0x060264CF RID: 156879 RVA: 0x003A2E45 File Offset: 0x003A1045
		public FCustomizedToolMenu(FName Name, TMap<FName, FCustomizedToolMenuEntry> Entries, TMap<FName, FCustomizedToolMenuSection> Sections, TMap<FName, FCustomizedToolMenuNameArray> EntryOrder, TArray<FName> SectionOrder)
		{
			this.Name = Name;
			this.Entries = Entries;
			this.Sections = Sections;
			this.EntryOrder = EntryOrder;
			this.SectionOrder = SectionOrder;
		}

		// Token: 0x060264D0 RID: 156880 RVA: 0x003A2E72 File Offset: 0x003A1072
		protected override IntPtr GetUStructPtr()
		{
			return FCustomizedToolMenu.StaticStruct();
		}

		// Token: 0x060264D1 RID: 156881 RVA: 0x003A2E7E File Offset: 0x003A107E
		[NullableContext(2)]
		public FCustomizedToolMenu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060264D2 RID: 156882 RVA: 0x003A2E88 File Offset: 0x003A1088
		public FCustomizedToolMenu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060264D3 RID: 156883 RVA: 0x003A2E93 File Offset: 0x003A1093
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomizedToolMenu(Pointer, false, true);
		}

		// Token: 0x060264D4 RID: 156884 RVA: 0x003A2E9D File Offset: 0x003A109D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomizedToolMenu(Pointer, MemoryOwner);
		}

		// Token: 0x04014F87 RID: 85895
		public const string __ObjectPath = "/Script/Slate.CustomizedToolMenu";

		// Token: 0x04014F88 RID: 85896
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F89 RID: 85897
		internal static int __PropertyOffset_Name;

		// Token: 0x04014F8A RID: 85898
		internal static int __PropertyOffset_Entries;

		// Token: 0x04014F8B RID: 85899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCustomizedToolMenuEntry> _Entries;

		// Token: 0x04014F8C RID: 85900
		internal static int __PropertyOffset_Sections;

		// Token: 0x04014F8D RID: 85901
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCustomizedToolMenuSection> _Sections;

		// Token: 0x04014F8E RID: 85902
		internal static int __PropertyOffset_EntryOrder;

		// Token: 0x04014F8F RID: 85903
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCustomizedToolMenuNameArray> _EntryOrder;

		// Token: 0x04014F90 RID: 85904
		internal static int __PropertyOffset_SectionOrder;

		// Token: 0x04014F91 RID: 85905
		[Nullable(2)]
		private TArray<FName> _SectionOrder;
	}
}
