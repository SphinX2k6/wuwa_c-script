using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EA9 RID: 3753
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshSectionInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMeshSectionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CB20 RID: 52000 RVA: 0x00128106 File Offset: 0x00126306
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshSectionInfo._ScriptStructPtr != 0) ? FMeshSectionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshSectionInfo", ref FMeshSectionInfo._ScriptStructPtr);
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x0012812A File Offset: 0x0012632A
		// (set) Token: 0x0600CB22 RID: 52002 RVA: 0x0012813A File Offset: 0x0012633A
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0600CB23 RID: 52003 RVA: 0x0012814B File Offset: 0x0012634B
		// (set) Token: 0x0600CB24 RID: 52004 RVA: 0x0012815B File Offset: 0x0012635B
		public unsafe bool bEnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bEnableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bEnableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0600CB25 RID: 52005 RVA: 0x0012816C File Offset: 0x0012636C
		// (set) Token: 0x0600CB26 RID: 52006 RVA: 0x0012817C File Offset: 0x0012637C
		public unsafe bool bCastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bCastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bCastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x0012818D File Offset: 0x0012638D
		// (set) Token: 0x0600CB28 RID: 52008 RVA: 0x0012819D File Offset: 0x0012639D
		public unsafe bool bVisibleInRayTracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bVisibleInRayTracing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bVisibleInRayTracing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x001281AE File Offset: 0x001263AE
		// (set) Token: 0x0600CB2A RID: 52010 RVA: 0x001281BE File Offset: 0x001263BE
		public unsafe bool bAffectDistanceFieldLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bAffectDistanceFieldLighting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bAffectDistanceFieldLighting) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600CB2B RID: 52011 RVA: 0x001281CF File Offset: 0x001263CF
		// (set) Token: 0x0600CB2C RID: 52012 RVA: 0x001281DF File Offset: 0x001263DF
		public unsafe bool bForceOpaque
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bForceOpaque) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_bForceOpaque) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x0600CB2D RID: 52013 RVA: 0x001281F0 File Offset: 0x001263F0
		// (set) Token: 0x0600CB2E RID: 52014 RVA: 0x00128233 File Offset: 0x00126433
		public FOpacityMicromap OpacityMicromap
		{
			get
			{
				base.FastCheckIsValid();
				FOpacityMicromap result;
				if ((result = this._OpacityMicromap) == null)
				{
					result = (this._OpacityMicromap = new FOpacityMicromap(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_OpacityMicromap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpacityMicromap.StaticStruct(), base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_OpacityMicromap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x0600CB2F RID: 52015 RVA: 0x00128254 File Offset: 0x00126454
		// (set) Token: 0x0600CB30 RID: 52016 RVA: 0x00128297 File Offset: 0x00126497
		public TArray<int> ExtraMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ExtraMaterialMap) == null)
				{
					result = (this._ExtraMaterialMap = new TArray<int>(base.NativePtr + (IntPtr)FMeshSectionInfo.__PropertyOffset_ExtraMaterialMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExtraMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x001282A5 File Offset: 0x001264A5
		public FMeshSectionInfo()
		{
		}

		// Token: 0x0600CB32 RID: 52018 RVA: 0x001282B0 File Offset: 0x001264B0
		public FMeshSectionInfo(int MaterialIndex, bool bEnableCollision, bool bCastShadow, bool bVisibleInRayTracing, bool bAffectDistanceFieldLighting, bool bForceOpaque, FOpacityMicromap OpacityMicromap, TArray<int> ExtraMaterialMap)
		{
			this.MaterialIndex = MaterialIndex;
			this.bEnableCollision = bEnableCollision;
			this.bCastShadow = bCastShadow;
			this.bVisibleInRayTracing = bVisibleInRayTracing;
			this.bAffectDistanceFieldLighting = bAffectDistanceFieldLighting;
			this.bForceOpaque = bForceOpaque;
			this.OpacityMicromap = OpacityMicromap;
			this.ExtraMaterialMap = ExtraMaterialMap;
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x00128300 File Offset: 0x00126500
		protected override IntPtr GetUStructPtr()
		{
			return FMeshSectionInfo.StaticStruct();
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x0012830C File Offset: 0x0012650C
		[NullableContext(2)]
		public FMeshSectionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x00128316 File Offset: 0x00126516
		public FMeshSectionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x00128321 File Offset: 0x00126521
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshSectionInfo(Pointer, false, true);
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x0012832B File Offset: 0x0012652B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshSectionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006D75 RID: 28021
		public const string __ObjectPath = "/Script/Engine.MeshSectionInfo";

		// Token: 0x04006D76 RID: 28022
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006D77 RID: 28023
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x04006D78 RID: 28024
		internal static int __PropertyOffset_bEnableCollision;

		// Token: 0x04006D79 RID: 28025
		internal static int __PropertyOffset_bCastShadow;

		// Token: 0x04006D7A RID: 28026
		internal static int __PropertyOffset_bVisibleInRayTracing;

		// Token: 0x04006D7B RID: 28027
		internal static int __PropertyOffset_bAffectDistanceFieldLighting;

		// Token: 0x04006D7C RID: 28028
		internal static int __PropertyOffset_bForceOpaque;

		// Token: 0x04006D7D RID: 28029
		internal static int __PropertyOffset_OpacityMicromap;

		// Token: 0x04006D7E RID: 28030
		[Nullable(2)]
		private FOpacityMicromap _OpacityMicromap;

		// Token: 0x04006D7F RID: 28031
		internal static int __PropertyOffset_ExtraMaterialMap;

		// Token: 0x04006D80 RID: 28032
		[Nullable(2)]
		private TArray<int> _ExtraMaterialMap;
	}
}
