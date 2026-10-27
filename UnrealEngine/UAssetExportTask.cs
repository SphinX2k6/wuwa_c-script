using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000852 RID: 2130
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AssetExportTask")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAssetExportTask : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060072E1 RID: 29409 RVA: 0x000A49EB File Offset: 0x000A2BEB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetExportTask._ClassPtr;
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x000A49F8 File Offset: 0x000A2BF8
		public UAssetExportTask() : this(BuiltinUtils.AllocNativeUObject(UAssetExportTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x000A4A20 File Offset: 0x000A2C20
		public UAssetExportTask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetExportTask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x060072E4 RID: 29412 RVA: 0x000A4A53 File Offset: 0x000A2C53
		// (set) Token: 0x060072E5 RID: 29413 RVA: 0x000A4A67 File Offset: 0x000A2C67
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UAssetExportTask.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAssetExportTask.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x060072E6 RID: 29414 RVA: 0x000A4A7C File Offset: 0x000A2C7C
		// (set) Token: 0x060072E7 RID: 29415 RVA: 0x000A4A90 File Offset: 0x000A2C90
		[Nullable(2)]
		public unsafe UExporter Exporter
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UExporter>(base.NativePtr / (IntPtr)sizeof(void*) + UAssetExportTask.__PropertyOffset_Exporter);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAssetExportTask.__PropertyOffset_Exporter, value);
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x000A4AA5 File Offset: 0x000A2CA5
		// (set) Token: 0x060072E9 RID: 29417 RVA: 0x000A4AB9 File Offset: 0x000A2CB9
		public unsafe string Filename
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAssetExportTask.__PropertyOffset_Filename)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAssetExportTask.__PropertyOffset_Filename)), value);
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x000A4ACE File Offset: 0x000A2CCE
		// (set) Token: 0x060072EB RID: 29419 RVA: 0x000A4ADE File Offset: 0x000A2CDE
		public unsafe bool bSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bSelected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bSelected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060072EC RID: 29420 RVA: 0x000A4AEF File Offset: 0x000A2CEF
		// (set) Token: 0x060072ED RID: 29421 RVA: 0x000A4AFF File Offset: 0x000A2CFF
		public unsafe bool bReplaceIdentical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bReplaceIdentical) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bReplaceIdentical) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060072EE RID: 29422 RVA: 0x000A4B10 File Offset: 0x000A2D10
		// (set) Token: 0x060072EF RID: 29423 RVA: 0x000A4B20 File Offset: 0x000A2D20
		public unsafe bool bPrompt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bPrompt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bPrompt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x060072F0 RID: 29424 RVA: 0x000A4B31 File Offset: 0x000A2D31
		// (set) Token: 0x060072F1 RID: 29425 RVA: 0x000A4B41 File Offset: 0x000A2D41
		public unsafe bool bAutomated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bAutomated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bAutomated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x060072F2 RID: 29426 RVA: 0x000A4B52 File Offset: 0x000A2D52
		// (set) Token: 0x060072F3 RID: 29427 RVA: 0x000A4B62 File Offset: 0x000A2D62
		public unsafe bool bUseFileArchive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bUseFileArchive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bUseFileArchive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x060072F4 RID: 29428 RVA: 0x000A4B73 File Offset: 0x000A2D73
		// (set) Token: 0x060072F5 RID: 29429 RVA: 0x000A4B83 File Offset: 0x000A2D83
		public unsafe bool bWriteEmptyFiles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bWriteEmptyFiles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_bWriteEmptyFiles) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x060072F6 RID: 29430 RVA: 0x000A4B94 File Offset: 0x000A2D94
		// (set) Token: 0x060072F7 RID: 29431 RVA: 0x000A4BCD File Offset: 0x000A2DCD
		public TArray<UObject> IgnoreObjectList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._IgnoreObjectList) == null)
				{
					result = (this._IgnoreObjectList = new TArray<UObject>(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_IgnoreObjectList, this));
				}
				return result;
			}
			set
			{
				this.IgnoreObjectList.CopyAssign(value);
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x060072F8 RID: 29432 RVA: 0x000A4BDB File Offset: 0x000A2DDB
		// (set) Token: 0x060072F9 RID: 29433 RVA: 0x000A4BEF File Offset: 0x000A2DEF
		[Nullable(2)]
		public unsafe UObject Options
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UAssetExportTask.__PropertyOffset_Options);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAssetExportTask.__PropertyOffset_Options, value);
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x000A4C04 File Offset: 0x000A2E04
		// (set) Token: 0x060072FB RID: 29435 RVA: 0x000A4C3D File Offset: 0x000A2E3D
		public TArray<string> Errors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Errors) == null)
				{
					result = (this._Errors = new TArray<string>(base.NativePtr + (IntPtr)UAssetExportTask.__PropertyOffset_Errors, this));
				}
				return result;
			}
			set
			{
				this.Errors.CopyAssign(value);
			}
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x000A4C4B File Offset: 0x000A2E4B
		static UAssetExportTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AssetExportTask");
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x000A4C59 File Offset: 0x000A2E59
		protected UAssetExportTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003735 RID: 14133
		public new const string __ObjectPath = "/Script/Engine.AssetExportTask";

		// Token: 0x04003736 RID: 14134
		private static IntPtr _ClassPtr;

		// Token: 0x04003737 RID: 14135
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003738 RID: 14136
		internal static int __PropertyOffset_Object;

		// Token: 0x04003739 RID: 14137
		internal static int __PropertyOffset_Exporter;

		// Token: 0x0400373A RID: 14138
		internal static int __PropertyOffset_Filename;

		// Token: 0x0400373B RID: 14139
		internal static int __PropertyOffset_bSelected;

		// Token: 0x0400373C RID: 14140
		internal static int __PropertyOffset_bReplaceIdentical;

		// Token: 0x0400373D RID: 14141
		internal static int __PropertyOffset_bPrompt;

		// Token: 0x0400373E RID: 14142
		internal static int __PropertyOffset_bAutomated;

		// Token: 0x0400373F RID: 14143
		internal static int __PropertyOffset_bUseFileArchive;

		// Token: 0x04003740 RID: 14144
		internal static int __PropertyOffset_bWriteEmptyFiles;

		// Token: 0x04003741 RID: 14145
		internal static int __PropertyOffset_IgnoreObjectList;

		// Token: 0x04003742 RID: 14146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _IgnoreObjectList;

		// Token: 0x04003743 RID: 14147
		internal static int __PropertyOffset_Options;

		// Token: 0x04003744 RID: 14148
		internal static int __PropertyOffset_Errors;

		// Token: 0x04003745 RID: 14149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Errors;
	}
}
