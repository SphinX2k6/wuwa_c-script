using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200048A RID: 1162
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Box")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FClothCollisionPrim_Box : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E74 RID: 15988 RVA: 0x0005DFB6 File Offset: 0x0005C1B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothCollisionPrim_Box._ScriptStructPtr != 0) ? FClothCollisionPrim_Box._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Box", ref FClothCollisionPrim_Box._ScriptStructPtr);
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x0005DFDA File Offset: 0x0005C1DA
		// (set) Token: 0x06003E76 RID: 15990 RVA: 0x0005DFEE File Offset: 0x0005C1EE
		public unsafe FVector LocalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_LocalPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_LocalPosition) = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06003E77 RID: 15991 RVA: 0x0005E003 File Offset: 0x0005C203
		// (set) Token: 0x06003E78 RID: 15992 RVA: 0x0005E017 File Offset: 0x0005C217
		public unsafe FQuat LocalRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_LocalRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_LocalRotation) = value;
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06003E79 RID: 15993 RVA: 0x0005E02C File Offset: 0x0005C22C
		// (set) Token: 0x06003E7A RID: 15994 RVA: 0x0005E040 File Offset: 0x0005C240
		public unsafe FVector HalfExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_HalfExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_HalfExtents) = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06003E7B RID: 15995 RVA: 0x0005E055 File Offset: 0x0005C255
		// (set) Token: 0x06003E7C RID: 15996 RVA: 0x0005E065 File Offset: 0x0005C265
		public unsafe int BoneIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_BoneIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Box.__PropertyOffset_BoneIndex) = value;
			}
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x0005E076 File Offset: 0x0005C276
		public FClothCollisionPrim_Box()
		{
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x0005E07E File Offset: 0x0005C27E
		public FClothCollisionPrim_Box(FVector LocalPosition, FQuat LocalRotation, FVector HalfExtents, int BoneIndex)
		{
			this.LocalPosition = LocalPosition;
			this.LocalRotation = LocalRotation;
			this.HalfExtents = HalfExtents;
			this.BoneIndex = BoneIndex;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x0005E0A3 File Offset: 0x0005C2A3
		protected override IntPtr GetUStructPtr()
		{
			return FClothCollisionPrim_Box.StaticStruct();
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x0005E0AF File Offset: 0x0005C2AF
		[NullableContext(2)]
		public FClothCollisionPrim_Box(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x0005E0B9 File Offset: 0x0005C2B9
		public FClothCollisionPrim_Box(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x0005E0C4 File Offset: 0x0005C2C4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothCollisionPrim_Box(Pointer, false, true);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x0005E0CE File Offset: 0x0005C2CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothCollisionPrim_Box(Pointer, MemoryOwner);
		}

		// Token: 0x04001D75 RID: 7541
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Box";

		// Token: 0x04001D76 RID: 7542
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D77 RID: 7543
		internal static int __PropertyOffset_LocalPosition;

		// Token: 0x04001D78 RID: 7544
		internal static int __PropertyOffset_LocalRotation;

		// Token: 0x04001D79 RID: 7545
		internal static int __PropertyOffset_HalfExtents;

		// Token: 0x04001D7A RID: 7546
		internal static int __PropertyOffset_BoneIndex;
	}
}
