using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200103F RID: 4159
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrimitiveMaterialRef")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPrimitiveMaterialRef : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EC6E RID: 60526 RVA: 0x0015EBEC File Offset: 0x0015CDEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimitiveMaterialRef._ScriptStructPtr != 0) ? FPrimitiveMaterialRef._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrimitiveMaterialRef", ref FPrimitiveMaterialRef._ScriptStructPtr);
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0600EC6F RID: 60527 RVA: 0x0015EC10 File Offset: 0x0015CE10
		// (set) Token: 0x0600EC70 RID: 60528 RVA: 0x0015EC24 File Offset: 0x0015CE24
		public unsafe UPrimitiveComponent Primitive
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FPrimitiveMaterialRef.__PropertyOffset_Primitive);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPrimitiveMaterialRef.__PropertyOffset_Primitive, value);
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x0600EC71 RID: 60529 RVA: 0x0015EC39 File Offset: 0x0015CE39
		// (set) Token: 0x0600EC72 RID: 60530 RVA: 0x0015EC4D File Offset: 0x0015CE4D
		public unsafe UDecalComponent Decal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FPrimitiveMaterialRef.__PropertyOffset_Decal);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPrimitiveMaterialRef.__PropertyOffset_Decal, value);
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0600EC73 RID: 60531 RVA: 0x0015EC62 File Offset: 0x0015CE62
		// (set) Token: 0x0600EC74 RID: 60532 RVA: 0x0015EC72 File Offset: 0x0015CE72
		public unsafe int ElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimitiveMaterialRef.__PropertyOffset_ElementIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimitiveMaterialRef.__PropertyOffset_ElementIndex) = value;
			}
		}

		// Token: 0x0600EC75 RID: 60533 RVA: 0x0015EC83 File Offset: 0x0015CE83
		public FPrimitiveMaterialRef()
		{
		}

		// Token: 0x0600EC76 RID: 60534 RVA: 0x0015EC8B File Offset: 0x0015CE8B
		[NullableContext(1)]
		public FPrimitiveMaterialRef(UPrimitiveComponent Primitive, UDecalComponent Decal, int ElementIndex)
		{
			this.Primitive = Primitive;
			this.Decal = Decal;
			this.ElementIndex = ElementIndex;
		}

		// Token: 0x0600EC77 RID: 60535 RVA: 0x0015ECA8 File Offset: 0x0015CEA8
		protected override IntPtr GetUStructPtr()
		{
			return FPrimitiveMaterialRef.StaticStruct();
		}

		// Token: 0x0600EC78 RID: 60536 RVA: 0x0015ECB4 File Offset: 0x0015CEB4
		public FPrimitiveMaterialRef(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x0015ECBE File Offset: 0x0015CEBE
		public FPrimitiveMaterialRef(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EC7A RID: 60538 RVA: 0x0015ECC9 File Offset: 0x0015CEC9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimitiveMaterialRef(Pointer, false, true);
		}

		// Token: 0x0600EC7B RID: 60539 RVA: 0x0015ECD3 File Offset: 0x0015CED3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimitiveMaterialRef(Pointer, MemoryOwner);
		}

		// Token: 0x04008000 RID: 32768
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PrimitiveMaterialRef";

		// Token: 0x04008001 RID: 32769
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008002 RID: 32770
		internal static int __PropertyOffset_Primitive;

		// Token: 0x04008003 RID: 32771
		internal static int __PropertyOffset_Decal;

		// Token: 0x04008004 RID: 32772
		internal static int __PropertyOffset_ElementIndex;
	}
}
