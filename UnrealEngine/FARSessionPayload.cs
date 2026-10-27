using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C3 RID: 963
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARSessionPayload")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FARSessionPayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060035F4 RID: 13812 RVA: 0x00052089 File Offset: 0x00050289
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARSessionPayload._ScriptStructPtr != 0) ? FARSessionPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARSessionPayload", ref FARSessionPayload._ScriptStructPtr);
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x000520AD File Offset: 0x000502AD
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x000520BD File Offset: 0x000502BD
		public unsafe int ConfigFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARSessionPayload.__PropertyOffset_ConfigFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARSessionPayload.__PropertyOffset_ConfigFlags) = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x000520CE File Offset: 0x000502CE
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x000520E2 File Offset: 0x000502E2
		public unsafe UMaterialInterface DefaultMeshMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FARSessionPayload.__PropertyOffset_DefaultMeshMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FARSessionPayload.__PropertyOffset_DefaultMeshMaterial, value);
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x000520F7 File Offset: 0x000502F7
		// (set) Token: 0x060035FA RID: 13818 RVA: 0x0005210B File Offset: 0x0005030B
		public unsafe UMaterialInterface DefaultWireframeMeshMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FARSessionPayload.__PropertyOffset_DefaultWireframeMeshMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FARSessionPayload.__PropertyOffset_DefaultWireframeMeshMaterial, value);
			}
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00052120 File Offset: 0x00050320
		public FARSessionPayload()
		{
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x00052128 File Offset: 0x00050328
		[NullableContext(1)]
		public FARSessionPayload(int ConfigFlags, UMaterialInterface DefaultMeshMaterial, UMaterialInterface DefaultWireframeMeshMaterial)
		{
			this.ConfigFlags = ConfigFlags;
			this.DefaultMeshMaterial = DefaultMeshMaterial;
			this.DefaultWireframeMeshMaterial = DefaultWireframeMeshMaterial;
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00052145 File Offset: 0x00050345
		protected override IntPtr GetUStructPtr()
		{
			return FARSessionPayload.StaticStruct();
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00052151 File Offset: 0x00050351
		public FARSessionPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x0005215B File Offset: 0x0005035B
		public FARSessionPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00052166 File Offset: 0x00050366
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARSessionPayload(Pointer, false, true);
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00052170 File Offset: 0x00050370
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARSessionPayload(Pointer, MemoryOwner);
		}

		// Token: 0x04001757 RID: 5975
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARSessionPayload";

		// Token: 0x04001758 RID: 5976
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001759 RID: 5977
		internal static int __PropertyOffset_ConfigFlags;

		// Token: 0x0400175A RID: 5978
		internal static int __PropertyOffset_DefaultMeshMaterial;

		// Token: 0x0400175B RID: 5979
		internal static int __PropertyOffset_DefaultWireframeMeshMaterial;
	}
}
