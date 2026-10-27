using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EC7 RID: 3783
	[UnrealObjectPath("/Script/Engine.NamedEmitterMaterial")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNamedEmitterMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CCC8 RID: 52424 RVA: 0x0012A534 File Offset: 0x00128734
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedEmitterMaterial._ScriptStructPtr != 0) ? FNamedEmitterMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NamedEmitterMaterial", ref FNamedEmitterMaterial._ScriptStructPtr);
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0600CCC9 RID: 52425 RVA: 0x0012A558 File Offset: 0x00128758
		// (set) Token: 0x0600CCCA RID: 52426 RVA: 0x0012A56C File Offset: 0x0012876C
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedEmitterMaterial.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedEmitterMaterial.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0600CCCB RID: 52427 RVA: 0x0012A581 File Offset: 0x00128781
		// (set) Token: 0x0600CCCC RID: 52428 RVA: 0x0012A595 File Offset: 0x00128795
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FNamedEmitterMaterial.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNamedEmitterMaterial.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0600CCCD RID: 52429 RVA: 0x0012A5AA File Offset: 0x001287AA
		public FNamedEmitterMaterial()
		{
		}

		// Token: 0x0600CCCE RID: 52430 RVA: 0x0012A5B2 File Offset: 0x001287B2
		[NullableContext(1)]
		public FNamedEmitterMaterial(FName Name, UMaterialInterface Material)
		{
			this.Name = Name;
			this.Material = Material;
		}

		// Token: 0x0600CCCF RID: 52431 RVA: 0x0012A5C8 File Offset: 0x001287C8
		protected override IntPtr GetUStructPtr()
		{
			return FNamedEmitterMaterial.StaticStruct();
		}

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x0012A5D4 File Offset: 0x001287D4
		[NullableContext(2)]
		public FNamedEmitterMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCD1 RID: 52433 RVA: 0x0012A5DE File Offset: 0x001287DE
		public FNamedEmitterMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CCD2 RID: 52434 RVA: 0x0012A5E9 File Offset: 0x001287E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedEmitterMaterial(Pointer, false, true);
		}

		// Token: 0x0600CCD3 RID: 52435 RVA: 0x0012A5F3 File Offset: 0x001287F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedEmitterMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x04006E3E RID: 28222
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NamedEmitterMaterial";

		// Token: 0x04006E3F RID: 28223
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E40 RID: 28224
		internal static int __PropertyOffset_Name;

		// Token: 0x04006E41 RID: 28225
		internal static int __PropertyOffset_Material;
	}
}
