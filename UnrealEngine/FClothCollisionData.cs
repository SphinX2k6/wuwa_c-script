using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000489 RID: 1161
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothCollisionData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FClothCollisionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E64 RID: 15972 RVA: 0x0005DDE4 File Offset: 0x0005BFE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothCollisionData._ScriptStructPtr != 0) ? FClothCollisionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeInterface.ClothCollisionData", ref FClothCollisionData._ScriptStructPtr);
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06003E65 RID: 15973 RVA: 0x0005DE08 File Offset: 0x0005C008
		// (set) Token: 0x06003E66 RID: 15974 RVA: 0x0005DE4B File Offset: 0x0005C04B
		public TArray<FClothCollisionPrim_Sphere> Spheres
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClothCollisionPrim_Sphere> result;
				if ((result = this._Spheres) == null)
				{
					result = (this._Spheres = new TArray<FClothCollisionPrim_Sphere>(base.NativePtr + (IntPtr)FClothCollisionData.__PropertyOffset_Spheres, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Spheres.CopyAssign(value);
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06003E67 RID: 15975 RVA: 0x0005DE5C File Offset: 0x0005C05C
		// (set) Token: 0x06003E68 RID: 15976 RVA: 0x0005DE9F File Offset: 0x0005C09F
		public TArray<FClothCollisionPrim_SphereConnection> SphereConnections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClothCollisionPrim_SphereConnection> result;
				if ((result = this._SphereConnections) == null)
				{
					result = (this._SphereConnections = new TArray<FClothCollisionPrim_SphereConnection>(base.NativePtr + (IntPtr)FClothCollisionData.__PropertyOffset_SphereConnections, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphereConnections.CopyAssign(value);
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x0005DEB0 File Offset: 0x0005C0B0
		// (set) Token: 0x06003E6A RID: 15978 RVA: 0x0005DEF3 File Offset: 0x0005C0F3
		public TArray<FClothCollisionPrim_Convex> Convexes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClothCollisionPrim_Convex> result;
				if ((result = this._Convexes) == null)
				{
					result = (this._Convexes = new TArray<FClothCollisionPrim_Convex>(base.NativePtr + (IntPtr)FClothCollisionData.__PropertyOffset_Convexes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Convexes.CopyAssign(value);
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x0005DF04 File Offset: 0x0005C104
		// (set) Token: 0x06003E6C RID: 15980 RVA: 0x0005DF47 File Offset: 0x0005C147
		public TArray<FClothCollisionPrim_Box> Boxes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClothCollisionPrim_Box> result;
				if ((result = this._Boxes) == null)
				{
					result = (this._Boxes = new TArray<FClothCollisionPrim_Box>(base.NativePtr + (IntPtr)FClothCollisionData.__PropertyOffset_Boxes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Boxes.CopyAssign(value);
			}
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x0005DF55 File Offset: 0x0005C155
		public FClothCollisionData()
		{
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0005DF5D File Offset: 0x0005C15D
		public FClothCollisionData(TArray<FClothCollisionPrim_Sphere> Spheres, TArray<FClothCollisionPrim_SphereConnection> SphereConnections, TArray<FClothCollisionPrim_Convex> Convexes, TArray<FClothCollisionPrim_Box> Boxes)
		{
			this.Spheres = Spheres;
			this.SphereConnections = SphereConnections;
			this.Convexes = Convexes;
			this.Boxes = Boxes;
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x0005DF82 File Offset: 0x0005C182
		protected override IntPtr GetUStructPtr()
		{
			return FClothCollisionData.StaticStruct();
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x0005DF8E File Offset: 0x0005C18E
		[NullableContext(2)]
		public FClothCollisionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x0005DF98 File Offset: 0x0005C198
		public FClothCollisionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x0005DFA3 File Offset: 0x0005C1A3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothCollisionData(Pointer, false, true);
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0005DFAD File Offset: 0x0005C1AD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothCollisionData(Pointer, MemoryOwner);
		}

		// Token: 0x04001D6B RID: 7531
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothCollisionData";

		// Token: 0x04001D6C RID: 7532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D6D RID: 7533
		internal static int __PropertyOffset_Spheres;

		// Token: 0x04001D6E RID: 7534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClothCollisionPrim_Sphere> _Spheres;

		// Token: 0x04001D6F RID: 7535
		internal static int __PropertyOffset_SphereConnections;

		// Token: 0x04001D70 RID: 7536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClothCollisionPrim_SphereConnection> _SphereConnections;

		// Token: 0x04001D71 RID: 7537
		internal static int __PropertyOffset_Convexes;

		// Token: 0x04001D72 RID: 7538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClothCollisionPrim_Convex> _Convexes;

		// Token: 0x04001D73 RID: 7539
		internal static int __PropertyOffset_Boxes;

		// Token: 0x04001D74 RID: 7540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClothCollisionPrim_Box> _Boxes;
	}
}
