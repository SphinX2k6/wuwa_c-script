using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BFE RID: 7166
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MountainParameters")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMountainParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BA8B RID: 113291 RVA: 0x0028B588 File Offset: 0x00289788
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMountainParameters._ScriptStructPtr != 0) ? FMountainParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MountainParameters", ref FMountainParameters._ScriptStructPtr);
		}

		// Token: 0x17006F91 RID: 28561
		// (get) Token: 0x0601BA8C RID: 113292 RVA: 0x0028B5AC File Offset: 0x002897AC
		// (set) Token: 0x0601BA8D RID: 113293 RVA: 0x0028B5C0 File Offset: 0x002897C0
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FMountainParameters.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMountainParameters.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17006F92 RID: 28562
		// (get) Token: 0x0601BA8E RID: 113294 RVA: 0x0028B5D5 File Offset: 0x002897D5
		// (set) Token: 0x0601BA8F RID: 113295 RVA: 0x0028B5E9 File Offset: 0x002897E9
		public unsafe UMaterialInstance OverrideMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FMountainParameters.__PropertyOffset_OverrideMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMountainParameters.__PropertyOffset_OverrideMaterial, value);
			}
		}

		// Token: 0x0601BA90 RID: 113296 RVA: 0x0028B5FE File Offset: 0x002897FE
		public FMountainParameters()
		{
		}

		// Token: 0x0601BA91 RID: 113297 RVA: 0x0028B606 File Offset: 0x00289806
		[NullableContext(1)]
		public FMountainParameters(UStaticMesh Mesh, UMaterialInstance OverrideMaterial)
		{
			this.Mesh = Mesh;
			this.OverrideMaterial = OverrideMaterial;
		}

		// Token: 0x0601BA92 RID: 113298 RVA: 0x0028B61C File Offset: 0x0028981C
		protected override IntPtr GetUStructPtr()
		{
			return FMountainParameters.StaticStruct();
		}

		// Token: 0x0601BA93 RID: 113299 RVA: 0x0028B628 File Offset: 0x00289828
		public FMountainParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BA94 RID: 113300 RVA: 0x0028B632 File Offset: 0x00289832
		public FMountainParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BA95 RID: 113301 RVA: 0x0028B63D File Offset: 0x0028983D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMountainParameters(Pointer, false, true);
		}

		// Token: 0x0601BA96 RID: 113302 RVA: 0x0028B647 File Offset: 0x00289847
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMountainParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE03 RID: 60931
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MountainParameters";

		// Token: 0x0400EE04 RID: 60932
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE05 RID: 60933
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400EE06 RID: 60934
		internal static int __PropertyOffset_OverrideMaterial;
	}
}
