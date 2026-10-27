using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022C3 RID: 8899
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendPrimitiveDataIndexHelper")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMeshBlendPrimitiveDataIndexHelper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021CC9 RID: 138441 RVA: 0x0031F660 File Offset: 0x0031D860
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendPrimitiveDataIndexHelper._ScriptStructPtr != 0) ? FMeshBlendPrimitiveDataIndexHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendPrimitiveDataIndexHelper", ref FMeshBlendPrimitiveDataIndexHelper._ScriptStructPtr);
		}

		// Token: 0x17008310 RID: 33552
		// (get) Token: 0x06021CCA RID: 138442 RVA: 0x0031F684 File Offset: 0x0031D884
		// (set) Token: 0x06021CCB RID: 138443 RVA: 0x0031F6C7 File Offset: 0x0031D8C7
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TWeakObjectPtr<UStaticMesh>, FMeshBlendPrimitiveDataIndexHelperData> CachedMeshIndexes
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
				TMap<TWeakObjectPtr<UStaticMesh>, FMeshBlendPrimitiveDataIndexHelperData> result;
				if ((result = this._CachedMeshIndexes) == null)
				{
					result = (this._CachedMeshIndexes = new TMap<TWeakObjectPtr<UStaticMesh>, FMeshBlendPrimitiveDataIndexHelperData>(base.NativePtr + (IntPtr)FMeshBlendPrimitiveDataIndexHelper.__PropertyOffset_CachedMeshIndexes, base.MemoryOwner ?? this));
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
				this.CachedMeshIndexes.CopyAssign(value);
			}
		}

		// Token: 0x17008311 RID: 33553
		// (get) Token: 0x06021CCC RID: 138444 RVA: 0x0031F6D8 File Offset: 0x0031D8D8
		// (set) Token: 0x06021CCD RID: 138445 RVA: 0x0031F71B File Offset: 0x0031D91B
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TWeakObjectPtr<UMaterialInterface>, int> CachedMaterialIndexes
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<UMaterialInterface>, int> result;
				if ((result = this._CachedMaterialIndexes) == null)
				{
					result = (this._CachedMaterialIndexes = new TMap<TWeakObjectPtr<UMaterialInterface>, int>(base.NativePtr + (IntPtr)FMeshBlendPrimitiveDataIndexHelper.__PropertyOffset_CachedMaterialIndexes, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.CachedMaterialIndexes.CopyAssign(value);
			}
		}

		// Token: 0x06021CCE RID: 138446 RVA: 0x0031F729 File Offset: 0x0031D929
		public FMeshBlendPrimitiveDataIndexHelper()
		{
		}

		// Token: 0x06021CCF RID: 138447 RVA: 0x0031F731 File Offset: 0x0031D931
		public FMeshBlendPrimitiveDataIndexHelper([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TWeakObjectPtr<UStaticMesh>, FMeshBlendPrimitiveDataIndexHelperData> CachedMeshIndexes, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TWeakObjectPtr<UMaterialInterface>, int> CachedMaterialIndexes)
		{
			this.CachedMeshIndexes = CachedMeshIndexes;
			this.CachedMaterialIndexes = CachedMaterialIndexes;
		}

		// Token: 0x06021CD0 RID: 138448 RVA: 0x0031F747 File Offset: 0x0031D947
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBlendPrimitiveDataIndexHelper.StaticStruct();
		}

		// Token: 0x06021CD1 RID: 138449 RVA: 0x0031F753 File Offset: 0x0031D953
		[NullableContext(2)]
		public FMeshBlendPrimitiveDataIndexHelper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021CD2 RID: 138450 RVA: 0x0031F75D File Offset: 0x0031D95D
		public FMeshBlendPrimitiveDataIndexHelper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CD3 RID: 138451 RVA: 0x0031F768 File Offset: 0x0031D968
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBlendPrimitiveDataIndexHelper(Pointer, false, true);
		}

		// Token: 0x06021CD4 RID: 138452 RVA: 0x0031F772 File Offset: 0x0031D972
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBlendPrimitiveDataIndexHelper(Pointer, MemoryOwner);
		}

		// Token: 0x04012085 RID: 73861
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendPrimitiveDataIndexHelper";

		// Token: 0x04012086 RID: 73862
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012087 RID: 73863
		internal static int __PropertyOffset_CachedMeshIndexes;

		// Token: 0x04012088 RID: 73864
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TWeakObjectPtr<UStaticMesh>, FMeshBlendPrimitiveDataIndexHelperData> _CachedMeshIndexes;

		// Token: 0x04012089 RID: 73865
		internal static int __PropertyOffset_CachedMaterialIndexes;

		// Token: 0x0401208A RID: 73866
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<UMaterialInterface>, int> _CachedMaterialIndexes;
	}
}
