using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001809 RID: 6153
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.BatchKey")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBatchKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016C58 RID: 93272 RVA: 0x00213B5F File Offset: 0x00211D5F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBatchKey._ScriptStructPtr != 0) ? FBatchKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicMeshBatch.BatchKey", ref FBatchKey._ScriptStructPtr);
		}

		// Token: 0x17005C02 RID: 23554
		// (get) Token: 0x06016C59 RID: 93273 RVA: 0x00213B83 File Offset: 0x00211D83
		// (set) Token: 0x06016C5A RID: 93274 RVA: 0x00213B97 File Offset: 0x00211D97
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKey.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKey.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17005C03 RID: 23555
		// (get) Token: 0x06016C5B RID: 93275 RVA: 0x00213BAC File Offset: 0x00211DAC
		// (set) Token: 0x06016C5C RID: 93276 RVA: 0x00213BC0 File Offset: 0x00211DC0
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKey.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBatchKey.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x06016C5D RID: 93277 RVA: 0x00213BD5 File Offset: 0x00211DD5
		public FBatchKey()
		{
		}

		// Token: 0x06016C5E RID: 93278 RVA: 0x00213BDD File Offset: 0x00211DDD
		[NullableContext(1)]
		public FBatchKey(UStaticMesh Mesh, UMaterialInterface Material)
		{
			this.Mesh = Mesh;
			this.Material = Material;
		}

		// Token: 0x06016C5F RID: 93279 RVA: 0x00213BF3 File Offset: 0x00211DF3
		protected override IntPtr GetUStructPtr()
		{
			return FBatchKey.StaticStruct();
		}

		// Token: 0x06016C60 RID: 93280 RVA: 0x00213BFF File Offset: 0x00211DFF
		public FBatchKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016C61 RID: 93281 RVA: 0x00213C09 File Offset: 0x00211E09
		public FBatchKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016C62 RID: 93282 RVA: 0x00213C14 File Offset: 0x00211E14
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBatchKey(Pointer, false, true);
		}

		// Token: 0x06016C63 RID: 93283 RVA: 0x00213C1E File Offset: 0x00211E1E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBatchKey(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5B4 RID: 50612
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDynamicMeshBatch.BatchKey";

		// Token: 0x0400C5B5 RID: 50613
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C5B6 RID: 50614
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400C5B7 RID: 50615
		internal static int __PropertyOffset_Material;
	}
}
