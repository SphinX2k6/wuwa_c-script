using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BC8 RID: 3016
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Exporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UExporter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009437 RID: 37943 RVA: 0x000D39FA File Offset: 0x000D1BFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UExporter._ClassPtr;
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x000D3A06 File Offset: 0x000D1C06
		// (set) Token: 0x06009439 RID: 37945 RVA: 0x000D3A1A File Offset: 0x000D1C1A
		public unsafe UClassStackOnlyPtr SupportedClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_SupportedClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_SupportedClass) = value;
			}
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600943A RID: 37946 RVA: 0x000D3A2F File Offset: 0x000D1C2F
		// (set) Token: 0x0600943B RID: 37947 RVA: 0x000D3A43 File Offset: 0x000D1C43
		public unsafe UObject ExportRootScope
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UExporter.__PropertyOffset_ExportRootScope);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UExporter.__PropertyOffset_ExportRootScope, value);
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600943C RID: 37948 RVA: 0x000D3A58 File Offset: 0x000D1C58
		// (set) Token: 0x0600943D RID: 37949 RVA: 0x000D3A91 File Offset: 0x000D1C91
		[Nullable(1)]
		public TArray<string> FormatExtension
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._FormatExtension) == null)
				{
					result = (this._FormatExtension = new TArray<string>(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_FormatExtension, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FormatExtension.CopyAssign(value);
			}
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x0600943E RID: 37950 RVA: 0x000D3AA0 File Offset: 0x000D1CA0
		// (set) Token: 0x0600943F RID: 37951 RVA: 0x000D3AD9 File Offset: 0x000D1CD9
		[Nullable(1)]
		public TArray<string> FormatDescription
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._FormatDescription) == null)
				{
					result = (this._FormatDescription = new TArray<string>(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_FormatDescription, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FormatDescription.CopyAssign(value);
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x000D3AE7 File Offset: 0x000D1CE7
		// (set) Token: 0x06009441 RID: 37953 RVA: 0x000D3AF7 File Offset: 0x000D1CF7
		public unsafe int PreferredFormatIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_PreferredFormatIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_PreferredFormatIndex) = value;
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x000D3B08 File Offset: 0x000D1D08
		// (set) Token: 0x06009443 RID: 37955 RVA: 0x000D3B18 File Offset: 0x000D1D18
		public unsafe int TextIndent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_TextIndent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_TextIndent) = value;
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x06009444 RID: 37956 RVA: 0x000D3B29 File Offset: 0x000D1D29
		// (set) Token: 0x06009445 RID: 37957 RVA: 0x000D3B42 File Offset: 0x000D1D42
		public unsafe bool bText
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_bText) & UExporter.__PropertyMask_bText) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UExporter.__PropertyOffset_bText) = ((*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_bText) & ~UExporter.__PropertyMask_bText) | (value ? UExporter.__PropertyMask_bText : 0));
			}
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x06009446 RID: 37958 RVA: 0x000D3B72 File Offset: 0x000D1D72
		// (set) Token: 0x06009447 RID: 37959 RVA: 0x000D3B8B File Offset: 0x000D1D8B
		public unsafe bool bSelectedOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_bSelectedOnly) & UExporter.__PropertyMask_bSelectedOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UExporter.__PropertyOffset_bSelectedOnly) = ((*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_bSelectedOnly) & ~UExporter.__PropertyMask_bSelectedOnly) | (value ? UExporter.__PropertyMask_bSelectedOnly : 0));
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x06009448 RID: 37960 RVA: 0x000D3BBB File Offset: 0x000D1DBB
		// (set) Token: 0x06009449 RID: 37961 RVA: 0x000D3BD4 File Offset: 0x000D1DD4
		public unsafe bool bForceFileOperations
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_bForceFileOperations) & UExporter.__PropertyMask_bForceFileOperations) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UExporter.__PropertyOffset_bForceFileOperations) = ((*(base.NativePtr + (IntPtr)UExporter.__PropertyOffset_bForceFileOperations) & ~UExporter.__PropertyMask_bForceFileOperations) | (value ? UExporter.__PropertyMask_bForceFileOperations : 0));
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x0600944A RID: 37962 RVA: 0x000D3C04 File Offset: 0x000D1E04
		// (set) Token: 0x0600944B RID: 37963 RVA: 0x000D3C18 File Offset: 0x000D1E18
		public unsafe UAssetExportTask ExportTask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAssetExportTask>(base.NativePtr / (IntPtr)sizeof(void*) + UExporter.__PropertyOffset_ExportTask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UExporter.__PropertyOffset_ExportTask, value);
			}
		}

		// Token: 0x0600944C RID: 37964 RVA: 0x000D3C30 File Offset: 0x000D1E30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool ScriptRunAssetExportTask(UAssetExportTask Task)
		{
			UExporter.__ScriptRunAssetExportTask_FunctionParams* ptr = stackalloc UExporter.__ScriptRunAssetExportTask_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UExporter.__ScriptRunAssetExportTask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UExporter.__ScriptRunAssetExportTask_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Task = ((Task != null) ? Task.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UExporter.__ScriptRunAssetExportTask_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x000D3C8B File Offset: 0x000D1E8B
		public static bool RunAssetExportTasks([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UAssetExportTask> ExportTasks)
		{
			return UExporter.__RunAssetExportTasks_Internal((ExportTasks ?? new TArray<UAssetExportTask>()).NativePtr);
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x000D3CA2 File Offset: 0x000D1EA2
		public static bool RunAssetExportTask(UAssetExportTask Task)
		{
			return UExporter.__RunAssetExportTask_Internal((Task != null) ? Task.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600944F RID: 37967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RunAssetExportTasks_Internal(IntPtr ExportTasks);

		// Token: 0x06009450 RID: 37968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RunAssetExportTask_Internal(IntPtr Task);

		// Token: 0x06009451 RID: 37969 RVA: 0x000D3CB9 File Offset: 0x000D1EB9
		static UExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Exporter");
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x000D3CC8 File Offset: 0x000D1EC8
		protected UExporter() : this(BuiltinUtils.AllocNativeUObject(UExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x000D3CF0 File Offset: 0x000D1EF0
		protected UExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400534E RID: 21326
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Exporter";

		// Token: 0x0400534F RID: 21327
		private static IntPtr _ClassPtr;

		// Token: 0x04005350 RID: 21328
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005351 RID: 21329
		internal static int __PropertyOffset_SupportedClass;

		// Token: 0x04005352 RID: 21330
		internal static int __PropertyOffset_ExportRootScope;

		// Token: 0x04005353 RID: 21331
		internal static int __PropertyOffset_FormatExtension;

		// Token: 0x04005354 RID: 21332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _FormatExtension;

		// Token: 0x04005355 RID: 21333
		internal static int __PropertyOffset_FormatDescription;

		// Token: 0x04005356 RID: 21334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _FormatDescription;

		// Token: 0x04005357 RID: 21335
		internal static int __PropertyOffset_PreferredFormatIndex;

		// Token: 0x04005358 RID: 21336
		internal static int __PropertyOffset_TextIndent;

		// Token: 0x04005359 RID: 21337
		internal static int __PropertyOffset_bText;

		// Token: 0x0400535A RID: 21338
		internal static byte __PropertyMask_bText;

		// Token: 0x0400535B RID: 21339
		internal static int __PropertyOffset_bSelectedOnly;

		// Token: 0x0400535C RID: 21340
		internal static byte __PropertyMask_bSelectedOnly;

		// Token: 0x0400535D RID: 21341
		internal static int __PropertyOffset_bForceFileOperations;

		// Token: 0x0400535E RID: 21342
		internal static byte __PropertyMask_bForceFileOperations;

		// Token: 0x0400535F RID: 21343
		internal static int __PropertyOffset_ExportTask;

		// Token: 0x04005360 RID: 21344
		private static IntPtr __ScriptRunAssetExportTask_NativeFunctionPtr;

		// Token: 0x02002CFB RID: 11515
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ScriptRunAssetExportTask_FunctionParams
		{
			// Token: 0x040166B3 RID: 91827
			[FieldOffset(0)]
			public IntPtr Task;

			// Token: 0x040166B4 RID: 91828
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
