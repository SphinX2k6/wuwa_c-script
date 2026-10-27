using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200048B RID: 1163
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Convex")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FClothCollisionPrim_Convex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E84 RID: 16004 RVA: 0x0005E0D7 File Offset: 0x0005C2D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothCollisionPrim_Convex._ScriptStructPtr != 0) ? FClothCollisionPrim_Convex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Convex", ref FClothCollisionPrim_Convex._ScriptStructPtr);
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x0005E0FC File Offset: 0x0005C2FC
		// (set) Token: 0x06003E86 RID: 16006 RVA: 0x0005E13F File Offset: 0x0005C33F
		public TArray<FPlane> Planes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPlane> result;
				if ((result = this._Planes) == null)
				{
					result = (this._Planes = new TArray<FPlane>(base.NativePtr + (IntPtr)FClothCollisionPrim_Convex.__PropertyOffset_Planes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Planes.CopyAssign(value);
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x0005E150 File Offset: 0x0005C350
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x0005E193 File Offset: 0x0005C393
		public TArray<FVector> SurfacePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._SurfacePoints) == null)
				{
					result = (this._SurfacePoints = new TArray<FVector>(base.NativePtr + (IntPtr)FClothCollisionPrim_Convex.__PropertyOffset_SurfacePoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SurfacePoints.CopyAssign(value);
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x0005E1A1 File Offset: 0x0005C3A1
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x0005E1B1 File Offset: 0x0005C3B1
		public unsafe int BoneIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothCollisionPrim_Convex.__PropertyOffset_BoneIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothCollisionPrim_Convex.__PropertyOffset_BoneIndex) = value;
			}
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x0005E1C2 File Offset: 0x0005C3C2
		public FClothCollisionPrim_Convex()
		{
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x0005E1CA File Offset: 0x0005C3CA
		public FClothCollisionPrim_Convex(TArray<FPlane> Planes, TArray<FVector> SurfacePoints, int BoneIndex)
		{
			this.Planes = Planes;
			this.SurfacePoints = SurfacePoints;
			this.BoneIndex = BoneIndex;
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x0005E1E7 File Offset: 0x0005C3E7
		protected override IntPtr GetUStructPtr()
		{
			return FClothCollisionPrim_Convex.StaticStruct();
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x0005E1F3 File Offset: 0x0005C3F3
		[NullableContext(2)]
		public FClothCollisionPrim_Convex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x0005E1FD File Offset: 0x0005C3FD
		public FClothCollisionPrim_Convex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x0005E208 File Offset: 0x0005C408
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothCollisionPrim_Convex(Pointer, false, true);
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x0005E212 File Offset: 0x0005C412
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothCollisionPrim_Convex(Pointer, MemoryOwner);
		}

		// Token: 0x04001D7B RID: 7547
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Convex";

		// Token: 0x04001D7C RID: 7548
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D7D RID: 7549
		internal static int __PropertyOffset_Planes;

		// Token: 0x04001D7E RID: 7550
		[Nullable(2)]
		private TArray<FPlane> _Planes;

		// Token: 0x04001D7F RID: 7551
		internal static int __PropertyOffset_SurfacePoints;

		// Token: 0x04001D80 RID: 7552
		[Nullable(2)]
		private TArray<FVector> _SurfacePoints;

		// Token: 0x04001D81 RID: 7553
		internal static int __PropertyOffset_BoneIndex;
	}
}
