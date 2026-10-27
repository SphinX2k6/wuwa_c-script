using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000496 RID: 1174
	[UnrealObjectPath("/Script/ClothingSystemRuntimeNv.ClothConstraintSetupNv")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FClothConstraintSetupNv : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003F40 RID: 16192 RVA: 0x0005F08D File Offset: 0x0005D28D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothConstraintSetupNv._ScriptStructPtr != 0) ? FClothConstraintSetupNv._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeNv.ClothConstraintSetupNv", ref FClothConstraintSetupNv._ScriptStructPtr);
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06003F41 RID: 16193 RVA: 0x0005F0B1 File Offset: 0x0005D2B1
		// (set) Token: 0x06003F42 RID: 16194 RVA: 0x0005F0C1 File Offset: 0x0005D2C1
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003F43 RID: 16195 RVA: 0x0005F0D2 File Offset: 0x0005D2D2
		// (set) Token: 0x06003F44 RID: 16196 RVA: 0x0005F0E2 File Offset: 0x0005D2E2
		public unsafe float StiffnessMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_StiffnessMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_StiffnessMultiplier) = value;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003F45 RID: 16197 RVA: 0x0005F0F3 File Offset: 0x0005D2F3
		// (set) Token: 0x06003F46 RID: 16198 RVA: 0x0005F103 File Offset: 0x0005D303
		public unsafe float StretchLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_StretchLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_StretchLimit) = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003F47 RID: 16199 RVA: 0x0005F114 File Offset: 0x0005D314
		// (set) Token: 0x06003F48 RID: 16200 RVA: 0x0005F124 File Offset: 0x0005D324
		public unsafe float CompressionLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_CompressionLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConstraintSetupNv.__PropertyOffset_CompressionLimit) = value;
			}
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0005F135 File Offset: 0x0005D335
		public FClothConstraintSetupNv()
		{
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x0005F13D File Offset: 0x0005D33D
		public FClothConstraintSetupNv(float Stiffness, float StiffnessMultiplier, float StretchLimit, float CompressionLimit)
		{
			this.Stiffness = Stiffness;
			this.StiffnessMultiplier = StiffnessMultiplier;
			this.StretchLimit = StretchLimit;
			this.CompressionLimit = CompressionLimit;
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x0005F162 File Offset: 0x0005D362
		protected override IntPtr GetUStructPtr()
		{
			return FClothConstraintSetupNv.StaticStruct();
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x0005F16E File Offset: 0x0005D36E
		[NullableContext(2)]
		public FClothConstraintSetupNv(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x0005F178 File Offset: 0x0005D378
		public FClothConstraintSetupNv(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x0005F183 File Offset: 0x0005D383
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothConstraintSetupNv(Pointer, false, true);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0005F18D File Offset: 0x0005D38D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothConstraintSetupNv(Pointer, MemoryOwner);
		}

		// Token: 0x04001DDF RID: 7647
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeNv.ClothConstraintSetupNv";

		// Token: 0x04001DE0 RID: 7648
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001DE1 RID: 7649
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x04001DE2 RID: 7650
		internal static int __PropertyOffset_StiffnessMultiplier;

		// Token: 0x04001DE3 RID: 7651
		internal static int __PropertyOffset_StretchLimit;

		// Token: 0x04001DE4 RID: 7652
		internal static int __PropertyOffset_CompressionLimit;
	}
}
