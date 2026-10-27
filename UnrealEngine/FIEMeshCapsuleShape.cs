using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200199B RID: 6555
	[UnrealObjectPath("/Script/KuroInteractionEffect.IEMeshCapsuleShape")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FIEMeshCapsuleShape : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060185A5 RID: 99749 RVA: 0x0023E7C6 File Offset: 0x0023C9C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIEMeshCapsuleShape._ScriptStructPtr != 0) ? FIEMeshCapsuleShape._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.IEMeshCapsuleShape", ref FIEMeshCapsuleShape._ScriptStructPtr);
		}

		// Token: 0x1700612A RID: 24874
		// (get) Token: 0x060185A6 RID: 99750 RVA: 0x0023E7EA File Offset: 0x0023C9EA
		// (set) Token: 0x060185A7 RID: 99751 RVA: 0x0023E7FE File Offset: 0x0023C9FE
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x1700612B RID: 24875
		// (get) Token: 0x060185A8 RID: 99752 RVA: 0x0023E813 File Offset: 0x0023CA13
		// (set) Token: 0x060185A9 RID: 99753 RVA: 0x0023E823 File Offset: 0x0023CA23
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700612C RID: 24876
		// (get) Token: 0x060185AA RID: 99754 RVA: 0x0023E834 File Offset: 0x0023CA34
		// (set) Token: 0x060185AB RID: 99755 RVA: 0x0023E844 File Offset: 0x0023CA44
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x1700612D RID: 24877
		// (get) Token: 0x060185AC RID: 99756 RVA: 0x0023E855 File Offset: 0x0023CA55
		// (set) Token: 0x060185AD RID: 99757 RVA: 0x0023E869 File Offset: 0x0023CA69
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshCapsuleShape.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x060185AE RID: 99758 RVA: 0x0023E87E File Offset: 0x0023CA7E
		public FIEMeshCapsuleShape()
		{
		}

		// Token: 0x060185AF RID: 99759 RVA: 0x0023E886 File Offset: 0x0023CA86
		public FIEMeshCapsuleShape(FVector Center, float Radius, float HalfHeight, FRotator Rotation)
		{
			this.Center = Center;
			this.Radius = Radius;
			this.HalfHeight = HalfHeight;
			this.Rotation = Rotation;
		}

		// Token: 0x060185B0 RID: 99760 RVA: 0x0023E8AB File Offset: 0x0023CAAB
		protected override IntPtr GetUStructPtr()
		{
			return FIEMeshCapsuleShape.StaticStruct();
		}

		// Token: 0x060185B1 RID: 99761 RVA: 0x0023E8B7 File Offset: 0x0023CAB7
		[NullableContext(2)]
		public FIEMeshCapsuleShape(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060185B2 RID: 99762 RVA: 0x0023E8C1 File Offset: 0x0023CAC1
		public FIEMeshCapsuleShape(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060185B3 RID: 99763 RVA: 0x0023E8CC File Offset: 0x0023CACC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIEMeshCapsuleShape(Pointer, false, true);
		}

		// Token: 0x060185B4 RID: 99764 RVA: 0x0023E8D6 File Offset: 0x0023CAD6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIEMeshCapsuleShape(Pointer, MemoryOwner);
		}

		// Token: 0x0400D2AE RID: 53934
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroInteractionEffect.IEMeshCapsuleShape";

		// Token: 0x0400D2AF RID: 53935
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D2B0 RID: 53936
		internal static int __PropertyOffset_Center;

		// Token: 0x0400D2B1 RID: 53937
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400D2B2 RID: 53938
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0400D2B3 RID: 53939
		internal static int __PropertyOffset_Rotation;
	}
}
