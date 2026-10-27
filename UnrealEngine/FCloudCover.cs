using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A5B RID: 6747
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CloudCover")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCloudCover : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018F83 RID: 102275 RVA: 0x0024E8BF File Offset: 0x0024CABF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCloudCover._ScriptStructPtr != 0) ? FCloudCover._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CloudCover", ref FCloudCover._ScriptStructPtr);
		}

		// Token: 0x170062F2 RID: 25330
		// (get) Token: 0x06018F84 RID: 102276 RVA: 0x0024E8E3 File Offset: 0x0024CAE3
		// (set) Token: 0x06018F85 RID: 102277 RVA: 0x0024E8F7 File Offset: 0x0024CAF7
		public unsafe UMaterialInterface CoverMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FCloudCover.__PropertyOffset_CoverMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCloudCover.__PropertyOffset_CoverMaterial, value);
			}
		}

		// Token: 0x170062F3 RID: 25331
		// (get) Token: 0x06018F86 RID: 102278 RVA: 0x0024E90C File Offset: 0x0024CB0C
		// (set) Token: 0x06018F87 RID: 102279 RVA: 0x0024E920 File Offset: 0x0024CB20
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FCloudCover.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCloudCover.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x170062F4 RID: 25332
		// (get) Token: 0x06018F88 RID: 102280 RVA: 0x0024E935 File Offset: 0x0024CB35
		// (set) Token: 0x06018F89 RID: 102281 RVA: 0x0024E945 File Offset: 0x0024CB45
		public unsafe float CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudCover.__PropertyOffset_CloudAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudCover.__PropertyOffset_CloudAngle) = value;
			}
		}

		// Token: 0x06018F8A RID: 102282 RVA: 0x0024E956 File Offset: 0x0024CB56
		public FCloudCover()
		{
		}

		// Token: 0x06018F8B RID: 102283 RVA: 0x0024E95E File Offset: 0x0024CB5E
		[NullableContext(1)]
		public FCloudCover(UMaterialInterface CoverMaterial, UStaticMesh Mesh, float CloudAngle)
		{
			this.CoverMaterial = CoverMaterial;
			this.Mesh = Mesh;
			this.CloudAngle = CloudAngle;
		}

		// Token: 0x06018F8C RID: 102284 RVA: 0x0024E97B File Offset: 0x0024CB7B
		protected override IntPtr GetUStructPtr()
		{
			return FCloudCover.StaticStruct();
		}

		// Token: 0x06018F8D RID: 102285 RVA: 0x0024E987 File Offset: 0x0024CB87
		public FCloudCover(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018F8E RID: 102286 RVA: 0x0024E991 File Offset: 0x0024CB91
		public FCloudCover(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018F8F RID: 102287 RVA: 0x0024E99C File Offset: 0x0024CB9C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCloudCover(Pointer, false, true);
		}

		// Token: 0x06018F90 RID: 102288 RVA: 0x0024E9A6 File Offset: 0x0024CBA6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCloudCover(Pointer, MemoryOwner);
		}

		// Token: 0x0400D828 RID: 55336
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CloudCover";

		// Token: 0x0400D829 RID: 55337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D82A RID: 55338
		internal static int __PropertyOffset_CoverMaterial;

		// Token: 0x0400D82B RID: 55339
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400D82C RID: 55340
		internal static int __PropertyOffset_CloudAngle;
	}
}
