using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BFD RID: 7165
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MaterialStackElement")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMaterialStackElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BA81 RID: 113281 RVA: 0x0028B4F0 File Offset: 0x002896F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialStackElement._ScriptStructPtr != 0) ? FMaterialStackElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MaterialStackElement", ref FMaterialStackElement._ScriptStructPtr);
		}

		// Token: 0x17006F90 RID: 28560
		// (get) Token: 0x0601BA82 RID: 113282 RVA: 0x0028B514 File Offset: 0x00289714
		// (set) Token: 0x0601BA83 RID: 113283 RVA: 0x0028B528 File Offset: 0x00289728
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialStackElement.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialStackElement.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0601BA84 RID: 113284 RVA: 0x0028B53D File Offset: 0x0028973D
		public FMaterialStackElement()
		{
		}

		// Token: 0x0601BA85 RID: 113285 RVA: 0x0028B545 File Offset: 0x00289745
		[NullableContext(1)]
		public FMaterialStackElement(UMaterialInterface Material)
		{
			this.Material = Material;
		}

		// Token: 0x0601BA86 RID: 113286 RVA: 0x0028B554 File Offset: 0x00289754
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialStackElement.StaticStruct();
		}

		// Token: 0x0601BA87 RID: 113287 RVA: 0x0028B560 File Offset: 0x00289760
		[NullableContext(2)]
		public FMaterialStackElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BA88 RID: 113288 RVA: 0x0028B56A File Offset: 0x0028976A
		public FMaterialStackElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BA89 RID: 113289 RVA: 0x0028B575 File Offset: 0x00289775
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialStackElement(Pointer, false, true);
		}

		// Token: 0x0601BA8A RID: 113290 RVA: 0x0028B57F File Offset: 0x0028977F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialStackElement(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE00 RID: 60928
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MaterialStackElement";

		// Token: 0x0400EE01 RID: 60929
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE02 RID: 60930
		internal static int __PropertyOffset_Material;
	}
}
