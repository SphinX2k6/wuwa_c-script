using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CF2 RID: 3314
	[UnrealObjectPath("/Script/Engine.KuroMaterialFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroMaterialFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AFE2 RID: 45026 RVA: 0x000F96BE File Offset: 0x000F78BE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialFolderCheckConfig._ScriptStructPtr != 0) ? FKuroMaterialFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMaterialFolderCheckConfig", ref FKuroMaterialFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600AFE3 RID: 45027 RVA: 0x000F96E2 File Offset: 0x000F78E2
		// (set) Token: 0x0600AFE4 RID: 45028 RVA: 0x000F96F2 File Offset: 0x000F78F2
		public unsafe int CastRasterShadowsInRaytracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialFolderCheckConfig.__PropertyOffset_CastRasterShadowsInRaytracing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialFolderCheckConfig.__PropertyOffset_CastRasterShadowsInRaytracing) = value;
			}
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x0600AFE5 RID: 45029 RVA: 0x000F9703 File Offset: 0x000F7903
		// (set) Token: 0x0600AFE6 RID: 45030 RVA: 0x000F9713 File Offset: 0x000F7913
		public unsafe int UsedWithInstancedStaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialFolderCheckConfig.__PropertyOffset_UsedWithInstancedStaticMesh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialFolderCheckConfig.__PropertyOffset_UsedWithInstancedStaticMesh) = value;
			}
		}

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x000F9724 File Offset: 0x000F7924
		public FKuroMaterialFolderCheckConfig()
		{
		}

		// Token: 0x0600AFE8 RID: 45032 RVA: 0x000F972C File Offset: 0x000F792C
		[NullableContext(1)]
		public FKuroMaterialFolderCheckConfig(int CastRasterShadowsInRaytracing, int UsedWithInstancedStaticMesh, string Regex, int MatchingPriority)
		{
			this.CastRasterShadowsInRaytracing = CastRasterShadowsInRaytracing;
			this.UsedWithInstancedStaticMesh = UsedWithInstancedStaticMesh;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x000F9751 File Offset: 0x000F7951
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AFEA RID: 45034 RVA: 0x000F975D File Offset: 0x000F795D
		[NullableContext(2)]
		public FKuroMaterialFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AFEB RID: 45035 RVA: 0x000F9767 File Offset: 0x000F7967
		public FKuroMaterialFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x000F9772 File Offset: 0x000F7972
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x000F977C File Offset: 0x000F797C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005C11 RID: 23569
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroMaterialFolderCheckConfig";

		// Token: 0x04005C12 RID: 23570
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C13 RID: 23571
		internal static int __PropertyOffset_CastRasterShadowsInRaytracing;

		// Token: 0x04005C14 RID: 23572
		internal static int __PropertyOffset_UsedWithInstancedStaticMesh;
	}
}
