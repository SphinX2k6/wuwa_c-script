using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001812 RID: 6162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.PropGroup")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FPropGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016CC0 RID: 93376 RVA: 0x00214365 File Offset: 0x00212565
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropGroup._ScriptStructPtr != 0) ? FPropGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicMeshBatch.PropGroup", ref FPropGroup._ScriptStructPtr);
		}

		// Token: 0x17005C10 RID: 23568
		// (get) Token: 0x06016CC1 RID: 93377 RVA: 0x00214389 File Offset: 0x00212589
		// (set) Token: 0x06016CC2 RID: 93378 RVA: 0x0021439D File Offset: 0x0021259D
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FPropGroup.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPropGroup.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17005C11 RID: 23569
		// (get) Token: 0x06016CC3 RID: 93379 RVA: 0x002143B4 File Offset: 0x002125B4
		// (set) Token: 0x06016CC4 RID: 93380 RVA: 0x002143F7 File Offset: 0x002125F7
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FPropGroup.__PropertyOffset_Materials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17005C12 RID: 23570
		// (get) Token: 0x06016CC5 RID: 93381 RVA: 0x00214408 File Offset: 0x00212608
		// (set) Token: 0x06016CC6 RID: 93382 RVA: 0x0021444B File Offset: 0x0021264B
		public TArray<FPropInstanceData> Instances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropInstanceData> result;
				if ((result = this._Instances) == null)
				{
					result = (this._Instances = new TArray<FPropInstanceData>(base.NativePtr + (IntPtr)FPropGroup.__PropertyOffset_Instances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Instances.CopyAssign(value);
			}
		}

		// Token: 0x06016CC7 RID: 93383 RVA: 0x00214459 File Offset: 0x00212659
		public FPropGroup()
		{
		}

		// Token: 0x06016CC8 RID: 93384 RVA: 0x00214461 File Offset: 0x00212661
		public FPropGroup(UStaticMesh StaticMesh, TArray<UMaterialInterface> Materials, TArray<FPropInstanceData> Instances)
		{
			this.StaticMesh = StaticMesh;
			this.Materials = Materials;
			this.Instances = Instances;
		}

		// Token: 0x06016CC9 RID: 93385 RVA: 0x0021447E File Offset: 0x0021267E
		protected override IntPtr GetUStructPtr()
		{
			return FPropGroup.StaticStruct();
		}

		// Token: 0x06016CCA RID: 93386 RVA: 0x0021448A File Offset: 0x0021268A
		[NullableContext(2)]
		public FPropGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016CCB RID: 93387 RVA: 0x00214494 File Offset: 0x00212694
		public FPropGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016CCC RID: 93388 RVA: 0x0021449F File Offset: 0x0021269F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropGroup(Pointer, false, true);
		}

		// Token: 0x06016CCD RID: 93389 RVA: 0x002144A9 File Offset: 0x002126A9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5DE RID: 50654
		public const string __ObjectPath = "/Script/KuroDynamicMeshBatch.PropGroup";

		// Token: 0x0400C5DF RID: 50655
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C5E0 RID: 50656
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400C5E1 RID: 50657
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400C5E2 RID: 50658
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x0400C5E3 RID: 50659
		internal static int __PropertyOffset_Instances;

		// Token: 0x0400C5E4 RID: 50660
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropInstanceData> _Instances;
	}
}
