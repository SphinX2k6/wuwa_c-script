using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200047E RID: 1150
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothConstraintSetup_Legacy")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FClothConstraintSetup_Legacy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003DD2 RID: 15826 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothConstraintSetup_Legacy._ScriptStructPtr != 0) ? FClothConstraintSetup_Legacy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeCommon.ClothConstraintSetup_Legacy", ref FClothConstraintSetup_Legacy._ScriptStructPtr);
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x0005CEEC File Offset: 0x0005B0EC
		// (set) Token: 0x06003DD4 RID: 15828 RVA: 0x0005CEFC File Offset: 0x0005B0FC
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x0005CF0D File Offset: 0x0005B10D
		// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x0005CF1D File Offset: 0x0005B11D
		public unsafe float StiffnessMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_StiffnessMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_StiffnessMultiplier) = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x0005CF2E File Offset: 0x0005B12E
		// (set) Token: 0x06003DD8 RID: 15832 RVA: 0x0005CF3E File Offset: 0x0005B13E
		public unsafe float StretchLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_StretchLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_StretchLimit) = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x0005CF4F File Offset: 0x0005B14F
		// (set) Token: 0x06003DDA RID: 15834 RVA: 0x0005CF5F File Offset: 0x0005B15F
		public unsafe float CompressionLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_CompressionLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetup_Legacy.__PropertyOffset_CompressionLimit) = value;
			}
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x0005CF70 File Offset: 0x0005B170
		public FClothConstraintSetup_Legacy()
		{
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x0005CF78 File Offset: 0x0005B178
		public FClothConstraintSetup_Legacy(float Stiffness, float StiffnessMultiplier, float StretchLimit, float CompressionLimit)
		{
			this.Stiffness = Stiffness;
			this.StiffnessMultiplier = StiffnessMultiplier;
			this.StretchLimit = StretchLimit;
			this.CompressionLimit = CompressionLimit;
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x0005CF9D File Offset: 0x0005B19D
		protected override IntPtr GetUStructPtr()
		{
			return FClothConstraintSetup_Legacy.StaticStruct();
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x0005CFA9 File Offset: 0x0005B1A9
		[NullableContext(2)]
		public FClothConstraintSetup_Legacy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x0005CFB3 File Offset: 0x0005B1B3
		public FClothConstraintSetup_Legacy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x0005CFBE File Offset: 0x0005B1BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothConstraintSetup_Legacy(Pointer, false, true);
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x0005CFC8 File Offset: 0x0005B1C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothConstraintSetup_Legacy(Pointer, MemoryOwner);
		}

		// Token: 0x04001D06 RID: 7430
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothConstraintSetup_Legacy";

		// Token: 0x04001D07 RID: 7431
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D08 RID: 7432
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x04001D09 RID: 7433
		internal static int __PropertyOffset_StiffnessMultiplier;

		// Token: 0x04001D0A RID: 7434
		internal static int __PropertyOffset_StretchLimit;

		// Token: 0x04001D0B RID: 7435
		internal static int __PropertyOffset_CompressionLimit;
	}
}
