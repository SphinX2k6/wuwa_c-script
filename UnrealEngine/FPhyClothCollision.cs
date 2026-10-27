using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200167A RID: 5754
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.PhyClothCollision")]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPhyClothCollision : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014DF2 RID: 85490 RVA: 0x001EAF76 File Offset: 0x001E9176
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhyClothCollision._ScriptStructPtr != 0) ? FPhyClothCollision._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.PhyClothCollision", ref FPhyClothCollision._ScriptStructPtr);
		}

		// Token: 0x170052A9 RID: 21161
		// (get) Token: 0x06014DF3 RID: 85491 RVA: 0x001EAF9A File Offset: 0x001E919A
		// (set) Token: 0x06014DF4 RID: 85492 RVA: 0x001EAFAA File Offset: 0x001E91AA
		public unsafe ECollisionType Type
		{
			get
			{
				return (ECollisionType)(*(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x170052AA RID: 21162
		// (get) Token: 0x06014DF5 RID: 85493 RVA: 0x001EAFBC File Offset: 0x001E91BC
		// (set) Token: 0x06014DF6 RID: 85494 RVA: 0x001EAFFF File Offset: 0x001E91FF
		public FBoneReference BindBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BindBone) == null)
				{
					result = (this._BindBone = new FBoneReference(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_BindBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_BindBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052AB RID: 21163
		// (get) Token: 0x06014DF7 RID: 85495 RVA: 0x001EB020 File Offset: 0x001E9220
		// (set) Token: 0x06014DF8 RID: 85496 RVA: 0x001EB034 File Offset: 0x001E9234
		public unsafe FVector CenterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_CenterPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_CenterPos) = value;
			}
		}

		// Token: 0x170052AC RID: 21164
		// (get) Token: 0x06014DF9 RID: 85497 RVA: 0x001EB049 File Offset: 0x001E9249
		// (set) Token: 0x06014DFA RID: 85498 RVA: 0x001EB05D File Offset: 0x001E925D
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170052AD RID: 21165
		// (get) Token: 0x06014DFB RID: 85499 RVA: 0x001EB072 File Offset: 0x001E9272
		// (set) Token: 0x06014DFC RID: 85500 RVA: 0x001EB086 File Offset: 0x001E9286
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothCollision.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x06014DFD RID: 85501 RVA: 0x001EB09B File Offset: 0x001E929B
		public FPhyClothCollision()
		{
		}

		// Token: 0x06014DFE RID: 85502 RVA: 0x001EB0A3 File Offset: 0x001E92A3
		public FPhyClothCollision(ECollisionType Type, FBoneReference BindBone, FVector CenterPos, FRotator Rotation, FVector2D Size)
		{
			this.Type = Type;
			this.BindBone = BindBone;
			this.CenterPos = CenterPos;
			this.Rotation = Rotation;
			this.Size = Size;
		}

		// Token: 0x06014DFF RID: 85503 RVA: 0x001EB0D0 File Offset: 0x001E92D0
		protected override IntPtr GetUStructPtr()
		{
			return FPhyClothCollision.StaticStruct();
		}

		// Token: 0x06014E00 RID: 85504 RVA: 0x001EB0DC File Offset: 0x001E92DC
		[NullableContext(2)]
		public FPhyClothCollision(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E01 RID: 85505 RVA: 0x001EB0E6 File Offset: 0x001E92E6
		public FPhyClothCollision(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E02 RID: 85506 RVA: 0x001EB0F1 File Offset: 0x001E92F1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhyClothCollision(Pointer, false, true);
		}

		// Token: 0x06014E03 RID: 85507 RVA: 0x001EB0FB File Offset: 0x001E92FB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhyClothCollision(Pointer, MemoryOwner);
		}

		// Token: 0x0400B5F9 RID: 46585
		public const string __ObjectPath = "/Script/KuroAnim.PhyClothCollision";

		// Token: 0x0400B5FA RID: 46586
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B5FB RID: 46587
		internal static int __PropertyOffset_Type;

		// Token: 0x0400B5FC RID: 46588
		internal static int __PropertyOffset_BindBone;

		// Token: 0x0400B5FD RID: 46589
		[Nullable(2)]
		private FBoneReference _BindBone;

		// Token: 0x0400B5FE RID: 46590
		internal static int __PropertyOffset_CenterPos;

		// Token: 0x0400B5FF RID: 46591
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400B600 RID: 46592
		internal static int __PropertyOffset_Size;
	}
}
