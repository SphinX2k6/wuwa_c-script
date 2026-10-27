using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010E3 RID: 4323
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SerializedTriMeshCollisionData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSerializedTriMeshCollisionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F7D9 RID: 63449 RVA: 0x0016EC22 File Offset: 0x0016CE22
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSerializedTriMeshCollisionData._ScriptStructPtr != 0) ? FSerializedTriMeshCollisionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SerializedTriMeshCollisionData", ref FSerializedTriMeshCollisionData._ScriptStructPtr);
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0600F7DA RID: 63450 RVA: 0x0016EC48 File Offset: 0x0016CE48
		// (set) Token: 0x0600F7DB RID: 63451 RVA: 0x0016EC8B File Offset: 0x0016CE8B
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)FSerializedTriMeshCollisionData.__PropertyOffset_Vertices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0600F7DC RID: 63452 RVA: 0x0016EC9C File Offset: 0x0016CE9C
		// (set) Token: 0x0600F7DD RID: 63453 RVA: 0x0016ECDF File Offset: 0x0016CEDF
		public TArray<FIntVector> Indices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntVector> result;
				if ((result = this._Indices) == null)
				{
					result = (this._Indices = new TArray<FIntVector>(base.NativePtr + (IntPtr)FSerializedTriMeshCollisionData.__PropertyOffset_Indices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Indices.CopyAssign(value);
			}
		}

		// Token: 0x0600F7DE RID: 63454 RVA: 0x0016ECED File Offset: 0x0016CEED
		public FSerializedTriMeshCollisionData()
		{
		}

		// Token: 0x0600F7DF RID: 63455 RVA: 0x0016ECF5 File Offset: 0x0016CEF5
		public FSerializedTriMeshCollisionData(TArray<FVector> Vertices, TArray<FIntVector> Indices)
		{
			this.Vertices = Vertices;
			this.Indices = Indices;
		}

		// Token: 0x0600F7E0 RID: 63456 RVA: 0x0016ED0B File Offset: 0x0016CF0B
		protected override IntPtr GetUStructPtr()
		{
			return FSerializedTriMeshCollisionData.StaticStruct();
		}

		// Token: 0x0600F7E1 RID: 63457 RVA: 0x0016ED17 File Offset: 0x0016CF17
		[NullableContext(2)]
		public FSerializedTriMeshCollisionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F7E2 RID: 63458 RVA: 0x0016ED21 File Offset: 0x0016CF21
		public FSerializedTriMeshCollisionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F7E3 RID: 63459 RVA: 0x0016ED2C File Offset: 0x0016CF2C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSerializedTriMeshCollisionData(Pointer, false, true);
		}

		// Token: 0x0600F7E4 RID: 63460 RVA: 0x0016ED36 File Offset: 0x0016CF36
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSerializedTriMeshCollisionData(Pointer, MemoryOwner);
		}

		// Token: 0x040085EB RID: 34283
		public const string __ObjectPath = "/Script/Engine.SerializedTriMeshCollisionData";

		// Token: 0x040085EC RID: 34284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040085ED RID: 34285
		internal static int __PropertyOffset_Vertices;

		// Token: 0x040085EE RID: 34286
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x040085EF RID: 34287
		internal static int __PropertyOffset_Indices;

		// Token: 0x040085F0 RID: 34288
		[Nullable(2)]
		private TArray<FIntVector> _Indices;
	}
}
