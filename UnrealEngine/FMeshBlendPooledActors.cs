using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022C2 RID: 8898
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendPooledActors")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FMeshBlendPooledActors : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021CBF RID: 138431 RVA: 0x0031F59D File Offset: 0x0031D79D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendPooledActors._ScriptStructPtr != 0) ? FMeshBlendPooledActors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendPooledActors", ref FMeshBlendPooledActors._ScriptStructPtr);
		}

		// Token: 0x1700830F RID: 33551
		// (get) Token: 0x06021CC0 RID: 138432 RVA: 0x0031F5C4 File Offset: 0x0031D7C4
		// (set) Token: 0x06021CC1 RID: 138433 RVA: 0x0031F607 File Offset: 0x0031D807
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TWeakObjectPtr<UMeshComponent>, int> BoundMeshComponents
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
				TMap<TWeakObjectPtr<UMeshComponent>, int> result;
				if ((result = this._BoundMeshComponents) == null)
				{
					result = (this._BoundMeshComponents = new TMap<TWeakObjectPtr<UMeshComponent>, int>(base.NativePtr + (IntPtr)FMeshBlendPooledActors.__PropertyOffset_BoundMeshComponents, base.MemoryOwner ?? this));
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
				this.BoundMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x06021CC2 RID: 138434 RVA: 0x0031F615 File Offset: 0x0031D815
		public FMeshBlendPooledActors()
		{
		}

		// Token: 0x06021CC3 RID: 138435 RVA: 0x0031F61D File Offset: 0x0031D81D
		public FMeshBlendPooledActors([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TWeakObjectPtr<UMeshComponent>, int> BoundMeshComponents)
		{
			this.BoundMeshComponents = BoundMeshComponents;
		}

		// Token: 0x06021CC4 RID: 138436 RVA: 0x0031F62C File Offset: 0x0031D82C
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBlendPooledActors.StaticStruct();
		}

		// Token: 0x06021CC5 RID: 138437 RVA: 0x0031F638 File Offset: 0x0031D838
		[NullableContext(2)]
		public FMeshBlendPooledActors(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021CC6 RID: 138438 RVA: 0x0031F642 File Offset: 0x0031D842
		public FMeshBlendPooledActors(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CC7 RID: 138439 RVA: 0x0031F64D File Offset: 0x0031D84D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBlendPooledActors(Pointer, false, true);
		}

		// Token: 0x06021CC8 RID: 138440 RVA: 0x0031F657 File Offset: 0x0031D857
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBlendPooledActors(Pointer, MemoryOwner);
		}

		// Token: 0x04012081 RID: 73857
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendPooledActors";

		// Token: 0x04012082 RID: 73858
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012083 RID: 73859
		internal static int __PropertyOffset_BoundMeshComponents;

		// Token: 0x04012084 RID: 73860
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<UMeshComponent>, int> _BoundMeshComponents;
	}
}
