using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200048C RID: 1164
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Sphere")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FClothCollisionPrim_Sphere : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E92 RID: 16018 RVA: 0x0005E21B File Offset: 0x0005C41B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothCollisionPrim_Sphere._ScriptStructPtr != 0) ? FClothCollisionPrim_Sphere._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Sphere", ref FClothCollisionPrim_Sphere._ScriptStructPtr);
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x0005E23F File Offset: 0x0005C43F
		// (set) Token: 0x06003E94 RID: 16020 RVA: 0x0005E24F File Offset: 0x0005C44F
		public unsafe int BoneIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Sphere.__PropertyOffset_BoneIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Sphere.__PropertyOffset_BoneIndex) = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x0005E260 File Offset: 0x0005C460
		// (set) Token: 0x06003E96 RID: 16022 RVA: 0x0005E270 File Offset: 0x0005C470
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Sphere.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Sphere.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06003E97 RID: 16023 RVA: 0x0005E281 File Offset: 0x0005C481
		// (set) Token: 0x06003E98 RID: 16024 RVA: 0x0005E295 File Offset: 0x0005C495
		public unsafe FVector LocalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Sphere.__PropertyOffset_LocalPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Sphere.__PropertyOffset_LocalPosition) = value;
			}
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x0005E2AA File Offset: 0x0005C4AA
		public FClothCollisionPrim_Sphere()
		{
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x0005E2B2 File Offset: 0x0005C4B2
		public FClothCollisionPrim_Sphere(int BoneIndex, float Radius, FVector LocalPosition)
		{
			this.BoneIndex = BoneIndex;
			this.Radius = Radius;
			this.LocalPosition = LocalPosition;
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x0005E2CF File Offset: 0x0005C4CF
		protected override IntPtr GetUStructPtr()
		{
			return FClothCollisionPrim_Sphere.StaticStruct();
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x0005E2DB File Offset: 0x0005C4DB
		[NullableContext(2)]
		public FClothCollisionPrim_Sphere(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x0005E2E5 File Offset: 0x0005C4E5
		public FClothCollisionPrim_Sphere(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x0005E2F0 File Offset: 0x0005C4F0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothCollisionPrim_Sphere(Pointer, false, true);
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x0005E2FA File Offset: 0x0005C4FA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothCollisionPrim_Sphere(Pointer, MemoryOwner);
		}

		// Token: 0x04001D82 RID: 7554
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Sphere";

		// Token: 0x04001D83 RID: 7555
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D84 RID: 7556
		internal static int __PropertyOffset_BoneIndex;

		// Token: 0x04001D85 RID: 7557
		internal static int __PropertyOffset_Radius;

		// Token: 0x04001D86 RID: 7558
		internal static int __PropertyOffset_LocalPosition;
	}
}
