using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200180B RID: 6155
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.BatchSystem")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1448)]
	public class ABatchSystem : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016C72 RID: 93298 RVA: 0x00213D4A File Offset: 0x00211F4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABatchSystem._ClassPtr;
		}

		// Token: 0x06016C73 RID: 93299 RVA: 0x00213D58 File Offset: 0x00211F58
		public ABatchSystem() : this(BuiltinUtils.AllocNativeUObject(ABatchSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016C74 RID: 93300 RVA: 0x00213D80 File Offset: 0x00211F80
		public ABatchSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABatchSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C07 RID: 23559
		// (get) Token: 0x06016C75 RID: 93301 RVA: 0x00213DB3 File Offset: 0x00211FB3
		// (set) Token: 0x06016C76 RID: 93302 RVA: 0x00213DC3 File Offset: 0x00211FC3
		public unsafe float CullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABatchSystem.__PropertyOffset_CullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABatchSystem.__PropertyOffset_CullDistance) = value;
			}
		}

		// Token: 0x17005C08 RID: 23560
		// (get) Token: 0x06016C77 RID: 93303 RVA: 0x00213DD4 File Offset: 0x00211FD4
		// (set) Token: 0x06016C78 RID: 93304 RVA: 0x00213E0D File Offset: 0x0021200D
		public TMap<FBatchKey, UInstancedStaticMeshComponent> BatchComponents
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FBatchKey, UInstancedStaticMeshComponent> result;
				if ((result = this._BatchComponents) == null)
				{
					result = (this._BatchComponents = new TMap<FBatchKey, UInstancedStaticMeshComponent>(base.NativePtr + (IntPtr)ABatchSystem.__PropertyOffset_BatchComponents, this));
				}
				return result;
			}
			set
			{
				this.BatchComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005C09 RID: 23561
		// (get) Token: 0x06016C79 RID: 93305 RVA: 0x00213E1C File Offset: 0x0021201C
		// (set) Token: 0x06016C7A RID: 93306 RVA: 0x00213E55 File Offset: 0x00212055
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TWeakObjectPtr<USceneComponent>, FDynamicInstanceData> DynamicInstances
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<USceneComponent>, FDynamicInstanceData> result;
				if ((result = this._DynamicInstances) == null)
				{
					result = (this._DynamicInstances = new TMap<TWeakObjectPtr<USceneComponent>, FDynamicInstanceData>(base.NativePtr + (IntPtr)ABatchSystem.__PropertyOffset_DynamicInstances, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.DynamicInstances.CopyAssign(value);
			}
		}

		// Token: 0x06016C7B RID: 93307 RVA: 0x00213E63 File Offset: 0x00212063
		[NullableContext(2)]
		public void SetActorDynamicUpdate(USceneComponent Component, bool bDynamic)
		{
			ABatchSystem.__SetActorDynamicUpdate_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, bDynamic);
		}

		// Token: 0x06016C7C RID: 93308 RVA: 0x00213E81 File Offset: 0x00212081
		public void ProcessBatch()
		{
			ABatchSystem.__ProcessBatch_Internal(base.NativePtr);
		}

		// Token: 0x06016C7D RID: 93309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorDynamicUpdate_Internal(IntPtr @this, IntPtr Component, bool bDynamic);

		// Token: 0x06016C7E RID: 93310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ProcessBatch_Internal(IntPtr @this);

		// Token: 0x06016C7F RID: 93311 RVA: 0x00213E8E File Offset: 0x0021208E
		static ABatchSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicMeshBatch.BatchSystem");
		}

		// Token: 0x06016C80 RID: 93312 RVA: 0x00213E9C File Offset: 0x0021209C
		protected ABatchSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C5BE RID: 50622
		public new const string __ObjectPath = "/Script/KuroDynamicMeshBatch.BatchSystem";

		// Token: 0x0400C5BF RID: 50623
		private static IntPtr _ClassPtr;

		// Token: 0x0400C5C0 RID: 50624
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C5C1 RID: 50625
		internal static int __PropertyOffset_CullDistance;

		// Token: 0x0400C5C2 RID: 50626
		internal static int __PropertyOffset_BatchComponents;

		// Token: 0x0400C5C3 RID: 50627
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FBatchKey, UInstancedStaticMeshComponent> _BatchComponents;

		// Token: 0x0400C5C4 RID: 50628
		internal static int __PropertyOffset_DynamicInstances;

		// Token: 0x0400C5C5 RID: 50629
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TWeakObjectPtr<USceneComponent>, FDynamicInstanceData> _DynamicInstances;
	}
}
