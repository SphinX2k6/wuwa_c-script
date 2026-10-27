using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001445 RID: 5189
	[UnrealObjectPath("/Script/GLTFExporter.GLTFExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UGLTFExporter : UExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012F78 RID: 77688 RVA: 0x001BE2A2 File Offset: 0x001BC4A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFExporter._ClassPtr;
		}

		// Token: 0x06012F79 RID: 77689 RVA: 0x001BE2B0 File Offset: 0x001BC4B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ExportToGLTF(UObject Object, [Nullable(1)] string FilePath, UGLTFExportOptions Options, [Nullable(new byte[]
		{
			2,
			1
		})] in TSet<AActor> SelectedActors, ref FGLTFExportMessages OutMessages)
		{
			UGLTFExporter.__ExportToGLTF_FunctionParams* ptr = stackalloc UGLTFExporter.__ExportToGLTF_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(UGLTFExporter.__ExportToGLTF_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGLTFExporter.__ExportToGLTF_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->FilePath), FilePath);
			ptr->Options = ((Options != null) ? Options.NativePtr : IntPtr.Zero);
			TSet<AActor> tset = SelectedActors;
			if (tset != null)
			{
				tset.MoveTo(&ptr->SelectedActors);
			}
			if (OutMessages != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGLTFExportMessages.StaticStruct(), &ptr->OutMessages, OutMessages.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UGLTFExporter._ClassDefaultObjectPtr, UGLTFExporter.__ExportToGLTF_NativeFunctionPtr, (void*)ptr, 0);
			TSet<AActor> tset2 = SelectedActors;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->SelectedActors);
			}
			if (OutMessages != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGLTFExportMessages.StaticStruct(), OutMessages.NativePtr, &ptr->OutMessages, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UGLTFExporter.__ExportToGLTF_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06012F7A RID: 77690 RVA: 0x001BE3B6 File Offset: 0x001BC5B6
		static UGLTFExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFExporter");
		}

		// Token: 0x06012F7B RID: 77691 RVA: 0x001BE3C4 File Offset: 0x001BC5C4
		protected UGLTFExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012F7C RID: 77692 RVA: 0x001BE3EC File Offset: 0x001BC5EC
		protected UGLTFExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A249 RID: 41545
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFExporter";

		// Token: 0x0400A24A RID: 41546
		private static IntPtr _ClassPtr;

		// Token: 0x0400A24B RID: 41547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A24C RID: 41548
		private static IntPtr __ExportToGLTF_NativeFunctionPtr;

		// Token: 0x02002E94 RID: 11924
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __ExportToGLTF_FunctionParams
		{
			// Token: 0x04016965 RID: 92517
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04016966 RID: 92518
			[FieldOffset(8)]
			public FString FilePath;

			// Token: 0x04016967 RID: 92519
			[FieldOffset(24)]
			public IntPtr Options;

			// Token: 0x04016968 RID: 92520
			[FieldOffset(32)]
			public byte SelectedActors;

			// Token: 0x04016969 RID: 92521
			[FieldOffset(112)]
			public byte OutMessages;

			// Token: 0x0401696A RID: 92522
			[FieldOffset(160)]
			public bool __Result;
		}
	}
}
