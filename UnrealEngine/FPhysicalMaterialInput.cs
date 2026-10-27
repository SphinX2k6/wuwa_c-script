using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FA3 RID: 8099
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.PhysicalMaterialInput")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPhysicalMaterialInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EBBD RID: 125885 RVA: 0x002DB17F File Offset: 0x002D937F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhysicalMaterialInput._ScriptStructPtr != 0) ? FPhysicalMaterialInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.PhysicalMaterialInput", ref FPhysicalMaterialInput._ScriptStructPtr);
		}

		// Token: 0x17007A6F RID: 31343
		// (get) Token: 0x0601EBBE RID: 125886 RVA: 0x002DB1A3 File Offset: 0x002D93A3
		// (set) Token: 0x0601EBBF RID: 125887 RVA: 0x002DB1B7 File Offset: 0x002D93B7
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysicalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + FPhysicalMaterialInput.__PropertyOffset_PhysicalMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPhysicalMaterialInput.__PropertyOffset_PhysicalMaterial, value);
			}
		}

		// Token: 0x17007A70 RID: 31344
		// (get) Token: 0x0601EBC0 RID: 125888 RVA: 0x002DB1CC File Offset: 0x002D93CC
		// (set) Token: 0x0601EBC1 RID: 125889 RVA: 0x002DB20F File Offset: 0x002D940F
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)FPhysicalMaterialInput.__PropertyOffset_Input, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)FPhysicalMaterialInput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EBC2 RID: 125890 RVA: 0x002DB230 File Offset: 0x002D9430
		public FPhysicalMaterialInput()
		{
		}

		// Token: 0x0601EBC3 RID: 125891 RVA: 0x002DB238 File Offset: 0x002D9438
		public FPhysicalMaterialInput(UPhysicalMaterial PhysicalMaterial, FExpressionInput Input)
		{
			this.PhysicalMaterial = PhysicalMaterial;
			this.Input = Input;
		}

		// Token: 0x0601EBC4 RID: 125892 RVA: 0x002DB24E File Offset: 0x002D944E
		protected override IntPtr GetUStructPtr()
		{
			return FPhysicalMaterialInput.StaticStruct();
		}

		// Token: 0x0601EBC5 RID: 125893 RVA: 0x002DB25A File Offset: 0x002D945A
		[NullableContext(2)]
		public FPhysicalMaterialInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EBC6 RID: 125894 RVA: 0x002DB264 File Offset: 0x002D9464
		public FPhysicalMaterialInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EBC7 RID: 125895 RVA: 0x002DB26F File Offset: 0x002D946F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhysicalMaterialInput(Pointer, false, true);
		}

		// Token: 0x0601EBC8 RID: 125896 RVA: 0x002DB279 File Offset: 0x002D9479
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhysicalMaterialInput(Pointer, MemoryOwner);
		}

		// Token: 0x040109E7 RID: 68071
		public const string __ObjectPath = "/Script/Landscape.PhysicalMaterialInput";

		// Token: 0x040109E8 RID: 68072
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040109E9 RID: 68073
		internal static int __PropertyOffset_PhysicalMaterial;

		// Token: 0x040109EA RID: 68074
		internal static int __PropertyOffset_Input;

		// Token: 0x040109EB RID: 68075
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
