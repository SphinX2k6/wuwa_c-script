using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200142C RID: 5164
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActorSelectedRigidBody")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGeometryCollectionDebugDrawActorSelectedRigidBody : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012E5F RID: 77407 RVA: 0x001BC7D0 File Offset: 0x001BA9D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCollectionDebugDrawActorSelectedRigidBody._ScriptStructPtr != 0) ? FGeometryCollectionDebugDrawActorSelectedRigidBody._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActorSelectedRigidBody", ref FGeometryCollectionDebugDrawActorSelectedRigidBody._ScriptStructPtr);
		}

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x06012E60 RID: 77408 RVA: 0x001BC7F4 File Offset: 0x001BA9F4
		// (set) Token: 0x06012E61 RID: 77409 RVA: 0x001BC804 File Offset: 0x001BAA04
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionDebugDrawActorSelectedRigidBody.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionDebugDrawActorSelectedRigidBody.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x06012E62 RID: 77410 RVA: 0x001BC815 File Offset: 0x001BAA15
		// (set) Token: 0x06012E63 RID: 77411 RVA: 0x001BC829 File Offset: 0x001BAA29
		public unsafe AChaosSolverActor Solver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AChaosSolverActor>(base.NativePtr / (IntPtr)sizeof(void*) + FGeometryCollectionDebugDrawActorSelectedRigidBody.__PropertyOffset_Solver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGeometryCollectionDebugDrawActorSelectedRigidBody.__PropertyOffset_Solver, value);
			}
		}

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x06012E64 RID: 77412 RVA: 0x001BC83E File Offset: 0x001BAA3E
		// (set) Token: 0x06012E65 RID: 77413 RVA: 0x001BC852 File Offset: 0x001BAA52
		public unsafe AGeometryCollectionActor GeometryCollection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGeometryCollectionActor>(base.NativePtr / (IntPtr)sizeof(void*) + FGeometryCollectionDebugDrawActorSelectedRigidBody.__PropertyOffset_GeometryCollection);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGeometryCollectionDebugDrawActorSelectedRigidBody.__PropertyOffset_GeometryCollection, value);
			}
		}

		// Token: 0x06012E66 RID: 77414 RVA: 0x001BC867 File Offset: 0x001BAA67
		public FGeometryCollectionDebugDrawActorSelectedRigidBody()
		{
		}

		// Token: 0x06012E67 RID: 77415 RVA: 0x001BC86F File Offset: 0x001BAA6F
		[NullableContext(1)]
		public FGeometryCollectionDebugDrawActorSelectedRigidBody(int Id, AChaosSolverActor Solver, AGeometryCollectionActor GeometryCollection)
		{
			this.Id = Id;
			this.Solver = Solver;
			this.GeometryCollection = GeometryCollection;
		}

		// Token: 0x06012E68 RID: 77416 RVA: 0x001BC88C File Offset: 0x001BAA8C
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryCollectionDebugDrawActorSelectedRigidBody.StaticStruct();
		}

		// Token: 0x06012E69 RID: 77417 RVA: 0x001BC898 File Offset: 0x001BAA98
		public FGeometryCollectionDebugDrawActorSelectedRigidBody(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012E6A RID: 77418 RVA: 0x001BC8A2 File Offset: 0x001BAAA2
		public FGeometryCollectionDebugDrawActorSelectedRigidBody(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012E6B RID: 77419 RVA: 0x001BC8AD File Offset: 0x001BAAAD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryCollectionDebugDrawActorSelectedRigidBody(Pointer, false, true);
		}

		// Token: 0x06012E6C RID: 77420 RVA: 0x001BC8B7 File Offset: 0x001BAAB7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryCollectionDebugDrawActorSelectedRigidBody(Pointer, MemoryOwner);
		}

		// Token: 0x0400A195 RID: 41365
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActorSelectedRigidBody";

		// Token: 0x0400A196 RID: 41366
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A197 RID: 41367
		internal static int __PropertyOffset_Id;

		// Token: 0x0400A198 RID: 41368
		internal static int __PropertyOffset_Solver;

		// Token: 0x0400A199 RID: 41369
		internal static int __PropertyOffset_GeometryCollection;
	}
}
