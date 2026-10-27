using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F86 RID: 8070
	[UnrealObjectPath("/Script/Landscape.LandscapeProxyCustomLayerPhysicalMaterial")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLandscapeProxyCustomLayerPhysicalMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EA57 RID: 125527 RVA: 0x002D8EE9 File Offset: 0x002D70E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeProxyCustomLayerPhysicalMaterial._ScriptStructPtr != 0) ? FLandscapeProxyCustomLayerPhysicalMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeProxyCustomLayerPhysicalMaterial", ref FLandscapeProxyCustomLayerPhysicalMaterial._ScriptStructPtr);
		}

		// Token: 0x17007A0D RID: 31245
		// (get) Token: 0x0601EA58 RID: 125528 RVA: 0x002D8F0D File Offset: 0x002D710D
		// (set) Token: 0x0601EA59 RID: 125529 RVA: 0x002D8F21 File Offset: 0x002D7121
		public unsafe FName LayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeProxyCustomLayerPhysicalMaterial.__PropertyOffset_LayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeProxyCustomLayerPhysicalMaterial.__PropertyOffset_LayerName) = value;
			}
		}

		// Token: 0x17007A0E RID: 31246
		// (get) Token: 0x0601EA5A RID: 125530 RVA: 0x002D8F36 File Offset: 0x002D7136
		// (set) Token: 0x0601EA5B RID: 125531 RVA: 0x002D8F4A File Offset: 0x002D714A
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysicalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeProxyCustomLayerPhysicalMaterial.__PropertyOffset_PhysicalMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeProxyCustomLayerPhysicalMaterial.__PropertyOffset_PhysicalMaterial, value);
			}
		}

		// Token: 0x0601EA5C RID: 125532 RVA: 0x002D8F5F File Offset: 0x002D715F
		public FLandscapeProxyCustomLayerPhysicalMaterial()
		{
		}

		// Token: 0x0601EA5D RID: 125533 RVA: 0x002D8F67 File Offset: 0x002D7167
		[NullableContext(1)]
		public FLandscapeProxyCustomLayerPhysicalMaterial(FName LayerName, UPhysicalMaterial PhysicalMaterial)
		{
			this.LayerName = LayerName;
			this.PhysicalMaterial = PhysicalMaterial;
		}

		// Token: 0x0601EA5E RID: 125534 RVA: 0x002D8F7D File Offset: 0x002D717D
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeProxyCustomLayerPhysicalMaterial.StaticStruct();
		}

		// Token: 0x0601EA5F RID: 125535 RVA: 0x002D8F89 File Offset: 0x002D7189
		[NullableContext(2)]
		public FLandscapeProxyCustomLayerPhysicalMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EA60 RID: 125536 RVA: 0x002D8F93 File Offset: 0x002D7193
		public FLandscapeProxyCustomLayerPhysicalMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EA61 RID: 125537 RVA: 0x002D8F9E File Offset: 0x002D719E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeProxyCustomLayerPhysicalMaterial(Pointer, false, true);
		}

		// Token: 0x0601EA62 RID: 125538 RVA: 0x002D8FA8 File Offset: 0x002D71A8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeProxyCustomLayerPhysicalMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x04010915 RID: 67861
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeProxyCustomLayerPhysicalMaterial";

		// Token: 0x04010916 RID: 67862
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010917 RID: 67863
		internal static int __PropertyOffset_LayerName;

		// Token: 0x04010918 RID: 67864
		internal static int __PropertyOffset_PhysicalMaterial;
	}
}
