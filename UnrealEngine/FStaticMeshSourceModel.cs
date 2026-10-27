using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001198 RID: 4504
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMeshSourceModel")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FStaticMeshSourceModel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601097D RID: 67965 RVA: 0x00185DC7 File Offset: 0x00183FC7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMeshSourceModel._ScriptStructPtr != 0) ? FStaticMeshSourceModel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMeshSourceModel", ref FStaticMeshSourceModel._ScriptStructPtr);
		}

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x0601097E RID: 67966 RVA: 0x00185DEC File Offset: 0x00183FEC
		// (set) Token: 0x0601097F RID: 67967 RVA: 0x00185E2F File Offset: 0x0018402F
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

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x06010980 RID: 67968 RVA: 0x00185E50 File Offset: 0x00184050
		// (set) Token: 0x06010981 RID: 67969 RVA: 0x00185E93 File Offset: 0x00184093
		public FMeshReductionSettings ReductionSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMeshReductionSettings result;
				if ((result = this._ReductionSettings) == null)
				{
					result = (this._ReductionSettings = new FMeshReductionSettings(base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_ReductionSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshReductionSettings.StaticStruct(), base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_ReductionSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x06010982 RID: 67970 RVA: 0x00185EB4 File Offset: 0x001840B4
		// (set) Token: 0x06010983 RID: 67971 RVA: 0x00185EC4 File Offset: 0x001840C4
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

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x06010984 RID: 67972 RVA: 0x00185ED8 File Offset: 0x001840D8
		// (set) Token: 0x06010985 RID: 67973 RVA: 0x00185F1B File Offset: 0x0018411B
		public FPerPlatformFloat ScreenSize
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._ScreenSize) == null)
				{
					result = (this._ScreenSize = new FPerPlatformFloat(base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_ScreenSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_ScreenSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x06010986 RID: 67974 RVA: 0x00185F3C File Offset: 0x0018413C
		// (set) Token: 0x06010987 RID: 67975 RVA: 0x00185F7F File Offset: 0x0018417F
		public FPerPlatformFloat KuroLODDistance
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._KuroLODDistance) == null)
				{
					result = (this._KuroLODDistance = new FPerPlatformFloat(base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_KuroLODDistance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)FStaticMeshSourceModel.__PropertyOffset_KuroLODDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x06010988 RID: 67976 RVA: 0x00185FA0 File Offset: 0x001841A0
		// (set) Token: 0x06010989 RID: 67977 RVA: 0x00185FB4 File Offset: 0x001841B4
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

		// Token: 0x0601098A RID: 67978 RVA: 0x00185FC9 File Offset: 0x001841C9
		public FStaticMeshSourceModel()
		{
		}

		// Token: 0x0601098B RID: 67979 RVA: 0x00185FD1 File Offset: 0x001841D1
		public FStaticMeshSourceModel(FMeshBuildSettings BuildSettings, FMeshReductionSettings ReductionSettings, float LODDistance_DEPRECATED, FPerPlatformFloat ScreenSize, FPerPlatformFloat KuroLODDistance, string SourceImportFilename, bool bImportWithBaseMesh)
		{
			this.BuildSettings = BuildSettings;
			this.ReductionSettings = ReductionSettings;
			this.LODDistance_DEPRECATED = LODDistance_DEPRECATED;
			this.ScreenSize = ScreenSize;
			this.KuroLODDistance = KuroLODDistance;
			this.SourceImportFilename = SourceImportFilename;
		}

		// Token: 0x0601098C RID: 67980 RVA: 0x00186006 File Offset: 0x00184206
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMeshSourceModel.StaticStruct();
		}

		// Token: 0x0601098D RID: 67981 RVA: 0x00186012 File Offset: 0x00184212
		[NullableContext(2)]
		public FStaticMeshSourceModel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601098E RID: 67982 RVA: 0x0018601C File Offset: 0x0018421C
		public FStaticMeshSourceModel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601098F RID: 67983 RVA: 0x00186027 File Offset: 0x00184227
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMeshSourceModel(Pointer, false, true);
		}

		// Token: 0x06010990 RID: 67984 RVA: 0x00186031 File Offset: 0x00184231
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMeshSourceModel(Pointer, MemoryOwner);
		}

		// Token: 0x04008E03 RID: 36355
		public const string __ObjectPath = "/Script/Engine.StaticMeshSourceModel";

		// Token: 0x04008E04 RID: 36356
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008E05 RID: 36357
		internal static int __PropertyOffset_BuildSettings;

		// Token: 0x04008E06 RID: 36358
		[Nullable(2)]
		private FMeshBuildSettings _BuildSettings;

		// Token: 0x04008E07 RID: 36359
		internal static int __PropertyOffset_ReductionSettings;

		// Token: 0x04008E08 RID: 36360
		[Nullable(2)]
		private FMeshReductionSettings _ReductionSettings;

		// Token: 0x04008E09 RID: 36361
		internal static int __PropertyOffset_LODDistance_DEPRECATED;

		// Token: 0x04008E0A RID: 36362
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x04008E0B RID: 36363
		[Nullable(2)]
		private FPerPlatformFloat _ScreenSize;

		// Token: 0x04008E0C RID: 36364
		internal static int __PropertyOffset_KuroLODDistance;

		// Token: 0x04008E0D RID: 36365
		[Nullable(2)]
		private FPerPlatformFloat _KuroLODDistance;

		// Token: 0x04008E0E RID: 36366
		internal static int __PropertyOffset_SourceImportFilename;
	}
}
