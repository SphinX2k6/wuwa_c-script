using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A92 RID: 6802
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FloatingBillboardCloudParameters")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FFloatingBillboardCloudParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019172 RID: 102770 RVA: 0x00250C69 File Offset: 0x0024EE69
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatingBillboardCloudParameters._ScriptStructPtr != 0) ? FFloatingBillboardCloudParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.FloatingBillboardCloudParameters", ref FFloatingBillboardCloudParameters._ScriptStructPtr);
		}

		// Token: 0x170063AD RID: 25517
		// (get) Token: 0x06019173 RID: 102771 RVA: 0x00250C8D File Offset: 0x0024EE8D
		// (set) Token: 0x06019174 RID: 102772 RVA: 0x00250CA1 File Offset: 0x0024EEA1
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FFloatingBillboardCloudParameters.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFloatingBillboardCloudParameters.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x170063AE RID: 25518
		// (get) Token: 0x06019175 RID: 102773 RVA: 0x00250CB6 File Offset: 0x0024EEB6
		// (set) Token: 0x06019176 RID: 102774 RVA: 0x00250CCA File Offset: 0x0024EECA
		public unsafe FVector CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFloatingBillboardCloudParameters.__PropertyOffset_CloudAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFloatingBillboardCloudParameters.__PropertyOffset_CloudAngle) = value;
			}
		}

		// Token: 0x170063AF RID: 25519
		// (get) Token: 0x06019177 RID: 102775 RVA: 0x00250CDF File Offset: 0x0024EEDF
		// (set) Token: 0x06019178 RID: 102776 RVA: 0x00250CF3 File Offset: 0x0024EEF3
		public unsafe UMaterialInstance OverrideMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FFloatingBillboardCloudParameters.__PropertyOffset_OverrideMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFloatingBillboardCloudParameters.__PropertyOffset_OverrideMaterial, value);
			}
		}

		// Token: 0x06019179 RID: 102777 RVA: 0x00250D08 File Offset: 0x0024EF08
		public FFloatingBillboardCloudParameters()
		{
		}

		// Token: 0x0601917A RID: 102778 RVA: 0x00250D10 File Offset: 0x0024EF10
		[NullableContext(1)]
		public FFloatingBillboardCloudParameters(UStaticMesh Mesh, FVector CloudAngle, UMaterialInstance OverrideMaterial)
		{
			this.Mesh = Mesh;
			this.CloudAngle = CloudAngle;
			this.OverrideMaterial = OverrideMaterial;
		}

		// Token: 0x0601917B RID: 102779 RVA: 0x00250D2D File Offset: 0x0024EF2D
		protected override IntPtr GetUStructPtr()
		{
			return FFloatingBillboardCloudParameters.StaticStruct();
		}

		// Token: 0x0601917C RID: 102780 RVA: 0x00250D39 File Offset: 0x0024EF39
		public FFloatingBillboardCloudParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601917D RID: 102781 RVA: 0x00250D43 File Offset: 0x0024EF43
		public FFloatingBillboardCloudParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601917E RID: 102782 RVA: 0x00250D4E File Offset: 0x0024EF4E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFloatingBillboardCloudParameters(Pointer, false, true);
		}

		// Token: 0x0601917F RID: 102783 RVA: 0x00250D58 File Offset: 0x0024EF58
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFloatingBillboardCloudParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400DACA RID: 56010
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FloatingBillboardCloudParameters";

		// Token: 0x0400DACB RID: 56011
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DACC RID: 56012
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400DACD RID: 56013
		internal static int __PropertyOffset_CloudAngle;

		// Token: 0x0400DACE RID: 56014
		internal static int __PropertyOffset_OverrideMaterial;
	}
}
