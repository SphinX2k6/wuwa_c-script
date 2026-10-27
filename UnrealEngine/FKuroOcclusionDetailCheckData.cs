using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D00 RID: 3328
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroOcclusionDetailCheckData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroOcclusionDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B132 RID: 45362 RVA: 0x000FB9CA File Offset: 0x000F9BCA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroOcclusionDetailCheckData._ScriptStructPtr != 0) ? FKuroOcclusionDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroOcclusionDetailCheckData", ref FKuroOcclusionDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x0600B133 RID: 45363 RVA: 0x000FB9EE File Offset: 0x000F9BEE
		// (set) Token: 0x0600B134 RID: 45364 RVA: 0x000FBA02 File Offset: 0x000F9C02
		public unsafe string occlusion_mesh_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroOcclusionDetailCheckData.__PropertyOffset_occlusion_mesh_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroOcclusionDetailCheckData.__PropertyOffset_occlusion_mesh_path)), value);
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x0600B135 RID: 45365 RVA: 0x000FBA17 File Offset: 0x000F9C17
		// (set) Token: 0x0600B136 RID: 45366 RVA: 0x000FBA2B File Offset: 0x000F9C2B
		public unsafe string OcclusionModelPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroOcclusionDetailCheckData.__PropertyOffset_OcclusionModelPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroOcclusionDetailCheckData.__PropertyOffset_OcclusionModelPath)), value);
			}
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x000FBA40 File Offset: 0x000F9C40
		public FKuroOcclusionDetailCheckData()
		{
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x000FBA48 File Offset: 0x000F9C48
		public FKuroOcclusionDetailCheckData(string occlusion_mesh_path, string OcclusionModelPath)
		{
			this.occlusion_mesh_path = occlusion_mesh_path;
			this.OcclusionModelPath = OcclusionModelPath;
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x000FBA5E File Offset: 0x000F9C5E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroOcclusionDetailCheckData.StaticStruct();
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x000FBA6A File Offset: 0x000F9C6A
		[NullableContext(2)]
		public FKuroOcclusionDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B13B RID: 45371 RVA: 0x000FBA74 File Offset: 0x000F9C74
		public FKuroOcclusionDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B13C RID: 45372 RVA: 0x000FBA7F File Offset: 0x000F9C7F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroOcclusionDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x000FBA89 File Offset: 0x000F9C89
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroOcclusionDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005CD7 RID: 23767
		public const string __ObjectPath = "/Script/Engine.KuroOcclusionDetailCheckData";

		// Token: 0x04005CD8 RID: 23768
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CD9 RID: 23769
		internal static int __PropertyOffset_occlusion_mesh_path;

		// Token: 0x04005CDA RID: 23770
		internal static int __PropertyOffset_OcclusionModelPath;
	}
}
