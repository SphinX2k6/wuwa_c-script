using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000291 RID: 657
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMeshSourceModel")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FStaticMeshSourceModel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060048B3 RID: 18611 RVA: 0x00065E05 File Offset: 0x00064005
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMeshSourceModel._ScriptStructPtr != 0) ? FStaticMeshSourceModel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMeshSourceModel", ref FStaticMeshSourceModel._ScriptStructPtr);
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x00065E2C File Offset: 0x0006402C
		// (set) Token: 0x060048B5 RID: 18613 RVA: 0x00065E6F File Offset: 0x0006406F
		public FMeshBuildSettings BuildSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMeshBuildSettings result;
				if ((result = this._BuildSettings) == null)
				{
					result = (this._BuildSettings = new FMeshBuildSettings(base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_BuildSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshBuildSettings.StaticStruct(), base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_BuildSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x00065E90 File Offset: 0x00064090
		// (set) Token: 0x060048B7 RID: 18615 RVA: 0x00065EA0 File Offset: 0x000640A0
		public unsafe float LODDistance_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_LODDistance_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_LODDistance_DEPRECATED) = value;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x00065EB1 File Offset: 0x000640B1
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x00065EC5 File Offset: 0x000640C5
		public unsafe string SourceImportFilename
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FStaticMeshSourceModel.__PropertyOffset_SourceImportFilename)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FStaticMeshSourceModel.__PropertyOffset_SourceImportFilename)), value);
			}
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00065EDA File Offset: 0x000640DA
		public FStaticMeshSourceModel()
		{
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00065EE2 File Offset: 0x000640E2
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMeshSourceModel.StaticStruct();
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x00065EEE File Offset: 0x000640EE
		[NullableContext(2)]
		public FStaticMeshSourceModel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00065EF8 File Offset: 0x000640F8
		public FStaticMeshSourceModel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00065F03 File Offset: 0x00064103
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMeshSourceModel(Pointer, false, true);
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00065F0D File Offset: 0x0006410D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMeshSourceModel(Pointer, MemoryOwner);
		}

		// Token: 0x04001C30 RID: 7216
		public const string __ObjectPath = "/Script/Engine.StaticMeshSourceModel";

		// Token: 0x04001C31 RID: 7217
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C32 RID: 7218
		internal static int __PropertyOffset_BuildSettings;

		// Token: 0x04001C33 RID: 7219
		[Nullable(2)]
		private FMeshBuildSettings _BuildSettings;

		// Token: 0x04001C34 RID: 7220
		internal static int __PropertyOffset_LODDistance_DEPRECATED;

		// Token: 0x04001C35 RID: 7221
		internal static int __PropertyOffset_SourceImportFilename;
	}
}
